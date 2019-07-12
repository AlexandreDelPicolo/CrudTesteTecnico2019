using FluentValidation;

namespace CrudTesteTecnico2019.Domain.Usuario.Validation
{
    public class AtualizarUsuarioCommandValidator : UsuarioBaseCommandValidator
    {
        public AtualizarUsuarioCommandValidator()
        {
            RuleFor(x => x.Id).GreaterThan(0).WithMessage("O id do usuário deve ser informado.");
        }
    }
}
