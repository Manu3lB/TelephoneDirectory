using FluentValidation;

namespace TelephoneDirectory
{
    public class DirectoryValidator : AbstractValidator<Contact>{

        List<Contact> _contact = new List<Contact>();

        public DirectoryValidator(List<Contact> contact ){
            RuleFor(x => x.name).NotEmpty().MaximumLength(30);
            RuleFor(x => x.phoneNumber).NotNull().MinimumLength(7).MaximumLength(7).WithMessage("Debe ingresar un número de telefono fijo de 7 digitos. Gracias");
            RuleFor(x => x.cellPhone).NotNull().MinimumLength(7).MaximumLength(10).WithMessage("Debe ingresar un número de celular de 10 digitos. Gracias");
            _contact = contact;
        }
    }

}