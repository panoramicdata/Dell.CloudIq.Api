using Dell.CloudIq.Api.Constants;
using FluentValidation;

namespace Dell.CloudIq.Api.Validators;

internal class CloudIQClientOptionsValidator : AbstractValidator<CloudIqClientOptions>
{
	internal CloudIQClientOptionsValidator()
	{
		RuleFor(c => c.ClientId).NotEmpty().WithMessage(ValidationConstants.ClientIdValidationConstant);
		RuleFor(c => c.ClientSecret).NotEmpty().WithMessage(ValidationConstants.ClientSecretValidationConstant);
		RuleFor(c => c.BaseUri).NotEmpty().WithMessage(ValidationConstants.BaseUriValidationConstant);
	}
}