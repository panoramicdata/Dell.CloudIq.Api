<#
.SYNOPSIS
    Publishes the Dell.CloudIq.Api package to NuGet.org
.DESCRIPTION
    This script performs the following steps:
    1. Checks for clean git working directory
    2. Determines the Nerdbank GitVersioning version
    3. Validates nuget-key.txt exists, has content, and is gitignored
    4. Runs unit tests (unless -SkipTests is specified)
    5. Publishes to NuGet.org
.PARAMETER SkipTests
    Skip running unit tests
.EXAMPLE
    .\Publish.ps1
.EXAMPLE
    .\Publish.ps1 -SkipTests
#>

param(
    [switch]$SkipTests
)

$ErrorActionPreference = 'Stop'

function Write-Step {
    param([string]$Message)
    Write-Host "`n==> $Message" -ForegroundColor Cyan
}

function Exit-WithError {
    param([string]$Message)
    Write-Host "ERROR: $Message" -ForegroundColor Red
    exit 1
}

# Step 1: Check for clean git working directory
Write-Step "Checking git working directory is clean..."

$gitStatus = git status --porcelain
if ($gitStatus) {
    Exit-WithError "Git working directory is not clean. Please commit or stash changes.`n$gitStatus"
}

Write-Host "Git working directory is clean." -ForegroundColor Green

# Step 2: Determine Nerdbank GitVersioning version
Write-Step "Determining Nerdbank GitVersioning version..."

$nbgvOutput = nbgv get-version --format json 2>&1
if ($LASTEXITCODE -ne 0) {
    Exit-WithError "Failed to get version from Nerdbank GitVersioning. Is nbgv installed? Run: dotnet tool install -g nbgv"
}

$versionInfo = $nbgvOutput | ConvertFrom-Json
$version = $versionInfo.NuGetPackageVersion

if (-not $version) {
    Exit-WithError "Could not determine NuGet package version from Nerdbank GitVersioning."
}

Write-Host "Package version: $version" -ForegroundColor Green

# Step 3: Check nuget-key.txt exists, has content, and is gitignored
Write-Step "Validating nuget-key.txt..."

$nugetKeyPath = Join-Path $PSScriptRoot "nuget-key.txt"

if (-not (Test-Path $nugetKeyPath)) {
    Exit-WithError "nuget-key.txt does not exist at: $nugetKeyPath"
}

$nugetKey = (Get-Content $nugetKeyPath -Raw).Trim()

if ([string]::IsNullOrWhiteSpace($nugetKey)) {
    Exit-WithError "nuget-key.txt is empty."
}

$gitIgnoreCheck = git check-ignore "nuget-key.txt" 2>&1
if ($LASTEXITCODE -ne 0) {
    Exit-WithError "nuget-key.txt is not in .gitignore. Add it to prevent accidental commits."
}

Write-Host "nuget-key.txt is valid and gitignored." -ForegroundColor Green

# Step 4: Run unit tests (unless -SkipTests)
if ($SkipTests) {
    Write-Step "Skipping unit tests (-SkipTests specified)..."
} else {
    Write-Step "Running unit tests..."

    dotnet test --configuration Release --no-restore
    if ($LASTEXITCODE -ne 0) {
        Exit-WithError "Unit tests failed."
    }

    Write-Host "All tests passed." -ForegroundColor Green
}

# Step 5: Build and pack
Write-Step "Building and packing..."

dotnet pack Dell.CloudIq.Api\Dell.CloudIq.Api.csproj --configuration Release --no-restore
if ($LASTEXITCODE -ne 0) {
    Exit-WithError "Failed to pack the project."
}

$packagePath = Get-ChildItem -Path "Dell.CloudIq.Api\bin\Release\*.nupkg" | Sort-Object LastWriteTime -Descending | Select-Object -First 1

if (-not $packagePath) {
    Exit-WithError "Could not find NuGet package in Dell.CloudIq.Api\bin\Release\"
}

Write-Host "Package created: $($packagePath.FullName)" -ForegroundColor Green

# Step 6: Publish to NuGet.org
Write-Step "Publishing to NuGet.org..."

dotnet nuget push $packagePath.FullName --api-key $nugetKey --source https://api.nuget.org/v3/index.json --skip-duplicate
if ($LASTEXITCODE -ne 0) {
    Exit-WithError "Failed to publish to NuGet.org."
}

Write-Host "`nSuccessfully published Dell.CloudIq.Api v$version to NuGet.org!" -ForegroundColor Green

exit 0
