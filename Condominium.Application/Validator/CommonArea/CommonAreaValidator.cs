using Condominium.Application.Dtos.Request;
using FluentValidation;

namespace Condominium.Application.Validator.CommonArea
{
	public class CommonAreaValidator : AbstractValidator<CommonAreaRequestDto>
	{
		public CommonAreaValidator()
		{
			RuleFor(x => x.Name).NotNull().WithMessage("El nombre no puede ser nulo")
				.NotEmpty().WithMessage("Debe completar el campo nombre")
				.MaximumLength(32).WithMessage("El nombre no puede tener mas de 32 caracteres");

			RuleFor(x => x.Picture).NotNull().WithMessage("La foto no puede ser nula")
				.NotEmpty().WithMessage("Debe completar el espacio foto");
		}
	}
}
