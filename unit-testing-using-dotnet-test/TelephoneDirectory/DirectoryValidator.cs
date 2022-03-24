using FluentValidation;

namespace TelephoneDirectory
{
    public class DirectoryValidator : AbstractValidator<Contact>
    {

        List<Contact> _contact = new List<Contact>();

        public DirectoryValidator(List<Contact> contact)
        {
            RuleFor(x => x.name).Cascade(CascadeMode.Stop).NotEmpty().WithMessage("El nombre es obligatorio").MaximumLength(10).WithMessage("El nombre no debe superar los 10 caracteres");
            RuleFor(x => x.phoneNumber).Cascade(CascadeMode.Stop).NotNull().MinimumLength(7).WithMessage("Debe ingresar un número de telefono fijo 7 digitos. Gracias")
            .MaximumLength(7).WithMessage("Debe ingresar un número de telefono fijo 7 digitos. Gracias");
            RuleFor(x => x.cellPhone).Cascade(CascadeMode.Stop).NotNull().MinimumLength(10).WithMessage("Debe ingresar un número de celular de 10 digitos. Gracias")
            .MaximumLength(10).WithMessage("Debe ingresar un número de telefono fijo 7 digitos. Gracias");
            _contact = contact;
        }

        //.When(ValidateName)
        private bool ValidateName(Contact contact)
        {
            bool nameValidate = true;
            do
            {
                Console.WriteLine("Es obligatorio ingresar el nombre del contacto en este campo");
                Console.WriteLine("\nEscriba el nombre del contacto :");
                contact.name = Console.ReadLine();
                nameValidate = false;
            } while (contact.name == null || contact.name == "");
            return nameValidate;
        }

    }

}