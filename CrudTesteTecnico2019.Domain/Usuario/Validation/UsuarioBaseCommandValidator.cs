using CrudTesteTecnico2019.Domain.Usuario.Command;
using CrudTesteTecnico2019.Domain.Usuario.Enum;
using FluentValidation;
using System;

namespace CrudTesteTecnico2019.Domain.Usuario.Validation
{
    public class UsuarioBaseCommandValidator : AbstractValidator<UsuarioBaseCommand>
    {
        public UsuarioBaseCommandValidator()
        {
            RuleFor(x => x.Nome)
                .NotEmpty().WithMessage("O nome do usuário deve ser informado.")
                .Length(3, 100).WithMessage("O nome deve ter no mínimo 3 caracteres e no máximo 200 caracteres.");

            RuleFor(x => x.Sobrenome)
                .NotEmpty().WithMessage("O sobrenome do usuário deve ser informado.")
                .Length(3, 100).WithMessage("O sobrenome deve ter no mínimo 3 caracteres e no máximo 200 caracteres.");

            RuleFor(x => x.Email)
                .NotEmpty().WithMessage("O e-mail do usuário deve ser informado.")
                .EmailAddress().WithMessage("E-mail inválido.");

            RuleFor(x => x.DataNascimento)
                .NotEmpty().WithMessage("O data de nascimento do usuário deve ser informada.")
                .LessThan(DateTime.Now).WithMessage("Data de nascimento inválida.")
                .GreaterThanOrEqualTo(DateTime.MinValue).WithMessage("Data de nascimento inválida.");

            RuleFor(x => x.Perfil)
                .LessThan((int)Perfil.Administrador).WithMessage("Perfil informado inválido.")
                .GreaterThan((int)Perfil.Usuario).WithMessage("Perfil informado inválido.");
        }
    }
}
