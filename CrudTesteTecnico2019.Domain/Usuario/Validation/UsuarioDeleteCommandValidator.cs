using CrudTesteTecnico2019.Domain.Usuario.Command;
using FluentValidation;

namespace CrudTesteTecnico2019.Domain.Usuario.Validation
{
    public class UsuarioDeleteCommandValidator : AbstractValidator<UsuarioDeleteCommand>
    {
        public UsuarioDeleteCommandValidator()
        {
            RuleFor(x => x.Id)
                .GreaterThan(0).WithMessage("O id do usuário deve ser informado.");
        }
    }
}
