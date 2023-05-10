using Dell.CloudIq.Api.Constants;
using FluentValidation;

namespace Dell.CloudIq.Api.Validators;

public class CloudIQClientOptionsValidator : AbstractValidator<CloudIQClientOptions>
{
	public CloudIQClientOptionsValidator()
	{
		RuleFor(c => c.ClientId).NotEmpty().WithMessage(ValidationConstants.ClientIdValidationConstant);
		RuleFor(c => c.ClientSecret).NotEmpty().WithMessage(ValidationConstants.ClientSecretValidationConstant);
		RuleFor(c => c.BaseUri).NotEmpty().WithMessage(ValidationConstants.BaseUriValidationConstant);
	}
}