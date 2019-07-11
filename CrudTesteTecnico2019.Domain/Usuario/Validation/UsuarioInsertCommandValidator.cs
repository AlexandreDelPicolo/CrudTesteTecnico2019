using CrudTesteTecnico2019.Domain.Usuario.Command;
using FluentValidation;
using System;

namespace CrudTesteTecnico2019.Domain.Usuario.Validation
{
    public class UsuarioCommandValidator : AbstractValidator<UsuarioBaseCommand>
    {
        public UsuarioCommandValidator()
        {
            RuleFor(x => x.Nome)
                .NotEmpty().WithMessage("O nome do usuário deve ser informado.")
                .Length(3, 100).WithMessage("O nome deve ter no mínimo 3 caracteres e np máximo 200 caracteres.");

            RuleFor(x => x.Sobrenome)
                .NotEmpty().WithMessage("O sobrenome do usuário deve ser informado.")
                .Length(3, 100).WithMessage("O sobrenome deve ter no mínimo 3 caracteres e np máximo 200 caracteres.");

            RuleFor(x => x.Email)
                .NotEmpty().WithMessage("O e-mail do usuário deve ser informado.")
                .EmailAddress().WithMessage("E-mail inválido.");

            RuleFor(x => x.DataNascimento)
                .NotEmpty().WithMessage("O data de nascimento do usuário deve ser informada.")
                .LessThan(DateTime.MinValue).WithMessage("Data de nascimento inválida.")
                .GreaterThanOrEqualTo(DateTime.Now).WithMessage("Data de nascimento inválida.");

            RuleFor(x => x.Perfil)
                .GreaterThan(0).WithMessage("Perfil informado inválido.");
        }
    }
}
