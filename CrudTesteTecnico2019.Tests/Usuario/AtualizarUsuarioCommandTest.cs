using CrudTesteTecnico2019.Domain.Usuario.Command;
using CrudTesteTecnico2019.Domain.Usuario.Enum;
using CrudTesteTecnico2019.Domain.Usuario.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;

namespace CrudTesteTecnico2019.Tests.Usuario
{
    [TestClass]
    public class AtualizarUsuarioCommandTest : UsuarioBaseCommandTest
    {
        [TestMethod]
        public void DeveSer_Invalido_Quando_Id_Igual_Zero()
        {
            var command = new AtualizarUsuarioCommand
            {
                Id = 0,
                Nome = "Alexandre",
                Sobrenome = "Del Picolo",
                Email = "delpicolo.alexandre@gmail.com",
                DataNascimento = DateTime.Now.AddYears(-1),
                Perfil = (int)Perfil.Administrador
            };

            var modelState = new AtualizarUsuarioCommandValidator().Validate(command);

            Assert.IsTrue(modelState.Errors.Any(x => x.PropertyName == nameof(command.Id)));
        }

        [TestMethod]
        public void DeveSer_Invalido_Quando_Id_Nao_Informado()
        {
            var command = new AtualizarUsuarioCommand
            {
                Nome = "Alexandre",
                Sobrenome = "Del Picolo",
                Email = "delpicolo.alexandre@gmail.com",
                DataNascimento = DateTime.Now.AddYears(-1),
                Perfil = (int)Perfil.Administrador
            };

            var modelState = new AtualizarUsuarioCommandValidator().Validate(command);

            Assert.IsTrue(modelState.Errors.Any(x => x.PropertyName == nameof(command.Id)));
        }
    }
}