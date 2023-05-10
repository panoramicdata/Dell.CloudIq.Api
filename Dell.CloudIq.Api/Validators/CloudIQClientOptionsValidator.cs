using FluentValidation;

namespace Dell.CloudIq.Api.Validators;

public class CloudIQClientOptionsValidator : AbstractValidator<CloudIQClientOptions>
{
	public CloudIQClientOptionsValidator()
	{
		RuleFor(c => c.ClientId).NotEmpty();
		RuleFor(c => c.ClientSecret).NotEmpty();
		RuleFor(c => c.BaseUri).NotEmpty();
	}
}