using FluentValidation;

namespace TelephoneDirectory
{
    public class DirectoryValidator : AbstractValidator<Contact>{

        List<Contact> _contact = new List<Contact>();

        public DirectoryValidator(List<Contact> contact){
            RuleFor(x => x.name).NotEmpty().MaximumLength(50).Must(ExistContact);
            RuleFor(x => x.phoneNumber).NotNull().MaximumLength(7).WithMessage("Debe ingresar un número de telefono. fijo de 7 digitos. Gracias");
            RuleFor(x => x.cellPhone).NotNull().MaximumLength(10).WithMessage("Debe ingresar un número de celular de 10 digitos. Gracias");
            _contact = contact;
        }

        public bool ExistContact(string _name)
        => _contact.Any(d => d.name == _name) ? false : true;

    }

}