using Dell.CloudIq.Api.Constants;
using Dell.CloudIq.Api.Validators;
using FluentAssertions;

namespace Dell.CloudIq.Api.Test;
public class CloudIQClientOptionsValidatorTests
{
	private readonly CloudIQClientOptionsValidator _validator;

	public CloudIQClientOptionsValidatorTests()
	{
		_validator = new CloudIQClientOptionsValidator();
	}

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
