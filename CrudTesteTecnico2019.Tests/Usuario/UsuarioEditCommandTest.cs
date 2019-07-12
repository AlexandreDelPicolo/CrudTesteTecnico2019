using CrudTesteTecnico2019.Domain.Usuario.Command;
using CrudTesteTecnico2019.Domain.Usuario.Enum;
using CrudTesteTecnico2019.Domain.Usuario.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;

namespace CrudTesteTecnico2019.Tests.Usuario
{
    [TestClass]
    public class UsuarioEditCommandTest : UsuarioBaseCommandTest
    {
        [TestMethod]
        public void DeveSer_Invalido_Quando_Id_Nao_Informado()
        {
            UsuarioEditCommand command = new UsuarioEditCommand
            {
                Nome = "Alexandre",
                Sobrenome = "Del Picolo",
                Email = "delpicolo.alexandre@gmail.com",
                DataNascimento = DateTime.Now.AddYears(-1),
                Perfil = (int)Perfil.Administrador
            };

            UsuarioEditCommandValidator validator = new UsuarioEditCommandValidator();
            FluentValidation.Results.ValidationResult modelState = validator.Validate(command);
            Assert.IsTrue(modelState.Errors.Any(x => x.PropertyName == nameof(command.Id)));
        }

        [TestMethod]
        public void DeveSer_Invalido_Quando_Id_Igual_Zero()
        {
            UsuarioEditCommand command = new UsuarioEditCommand
            {
                Id = 0,
                Nome = "Alexandre",
                Sobrenome = "Del Picolo",
                Email = "delpicolo.alexandre@gmail.com",
                DataNascimento = DateTime.Now.AddYears(-1),
                Perfil = (int)Perfil.Administrador
            };

            UsuarioEditCommandValidator validator = new UsuarioEditCommandValidator();
            FluentValidation.Results.ValidationResult modelState = validator.Validate(command);
            Assert.IsTrue(modelState.Errors.Any(x => x.PropertyName == nameof(command.Id)));
        }
    }
}
