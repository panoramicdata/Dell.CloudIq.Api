using Dell.CloudIq.Api.Constants;
using Dell.CloudIq.Api.Validators;

namespace Dell.CloudIq.Api.Test;
/// <summary>Tests for <see cref="CloudIQClientOptionsValidator"/>.</summary>
public class CloudIQClientOptionsValidatorTests
{
	private readonly CloudIQClientOptionsValidator _validator;

	/// <summary>Initializes a new instance of <see cref="CloudIQClientOptionsValidatorTests"/>.</summary>
	public CloudIQClientOptionsValidatorTests()
	{
		_validator = new CloudIQClientOptionsValidator();
	}

	/// <summary>Verifies that no validation error is raised when all options are valid.</summary>
	[Fact]
	public void Validator_Should_Not_HaveError_When_CloudIQClientOptions_AreValid()
	{
		var validClientOptions = new CloudIqClientOptions
		{
			ClientId = "valid-ClientId",
			ClientSecret = "valid-ClientSecret",
			BaseUri = "https://valid-BaseUri.com"
		};

		var result = _validator.Validate(validClientOptions);

		result.Errors.Should().BeEmpty();
	}

	/// <summary>Verifies that a validation error is raised when ClientId is null.</summary>
	[Fact]
	public void Validator_Should_HaveError_When_ClientId_IsNull()
	{
		var invalidClientOptions = new CloudIqClientOptions
		{
			ClientSecret = "valid-ClientSecret",
			BaseUri = "https://valid-BaseUri.com"
		};

		var result = _validator.Validate(invalidClientOptions);
		result.Errors.First().ErrorMessage.Should().BeEquivalentTo(ValidationConstants.ClientIdValidationConstant);
	}

	/// <summary>Verifies that a validation error is raised when ClientSecret is null.</summary>
	[Fact]
	public void Validator_Should_HaveError_When_ClientSecret_IsNull()
	{
		var invalidClientOptions = new CloudIqClientOptions
		{
			ClientId = "valid-ClientId",
			BaseUri = "https://valid-BaseUri.com"
		};

		var result = _validator.Validate(invalidClientOptions);
		result.Errors.First().ErrorMessage.Should().BeEquivalentTo(ValidationConstants.ClientSecretValidationConstant);
	}

	/// <summary>Verifies that a validation error is raised when BaseUri is null.</summary>
	[Fact]
	public void Validator_Should_HaveError_When_BaseUri_IsNull()
	{
		var invalidClientOptions = new CloudIqClientOptions
		{
			ClientId = "valid-ClientId",
			ClientSecret = "valid-ClientSecret"
		};

		var result = _validator.Validate(invalidClientOptions);
		result.Errors.First().ErrorMessage.Should().BeEquivalentTo(ValidationConstants.BaseUriValidationConstant);
	}
}
