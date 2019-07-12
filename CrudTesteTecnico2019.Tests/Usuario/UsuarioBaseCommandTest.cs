using CrudTesteTecnico2019.Domain.Usuario.Command;
using CrudTesteTecnico2019.Domain.Usuario.Enum;
using CrudTesteTecnico2019.Domain.Usuario.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;

namespace CrudTesteTecnico2019.Tests.Usuario
{
    [TestClass]
    public class UsuarioBaseCommandTest
    {
        [TestMethod]
        public void DeveSer_Invalido_Quando_DataNascimento_Maior_Que_Data_Atual()
        {
            var command = new UsuarioBaseCommand
            {
                Nome = "Alexandre",
                Sobrenome = "Del Picolo",
                Email = "delpicolo.alexandre@gmail.com",
                DataNascimento = DateTime.Now.AddYears(1),
                Perfil = (int)Perfil.Administrador
            };

            var modelState = new UsuarioBaseCommandValidator().Validate(command);

            Assert.IsTrue(modelState.Errors.Any(x => x.PropertyName == nameof(command.DataNascimento)));
        }

        [TestMethod]
        public void DeveSer_Invalido_Quando_DataNascimento_Nao_Informada()
        {
            var command = new UsuarioBaseCommand
            {
                Nome = "Alexandre",
                Sobrenome = "Del Picolo",
                Email = "delpicolo.alexandre@gmail.com",
                Perfil = (int)Perfil.Administrador
            };

            var modelState = new UsuarioBaseCommandValidator().Validate(command);

            Assert.IsTrue(modelState.Errors.Any(x => x.PropertyName == nameof(command.DataNascimento)));
        }

        [TestMethod]
        public void DeveSer_Invalido_Quando_Email_Invalido()
        {
            var command = new UsuarioBaseCommand
            {
                Nome = "Alexandre",
                Sobrenome = "Del Picolo",
                Email = "1234",
                DataNascimento = DateTime.Now.AddYears(-1),
                Perfil = (int)Perfil.Administrador
            };

            var modelState = new UsuarioBaseCommandValidator().Validate(command);

            Assert.IsTrue(modelState.Errors.Any(x => x.PropertyName == nameof(command.Email)));
        }

        [TestMethod]
        public void DeveSer_Invalido_Quando_Email_Nao_Informado()
        {
            var command = new UsuarioBaseCommand
            {
                Nome = "Alexandre",
                Sobrenome = "Del Picolo",
                DataNascimento = DateTime.Now.AddYears(-1),
                Perfil = (int)Perfil.Administrador
            };

            var modelState = new UsuarioBaseCommandValidator().Validate(command);

            Assert.IsTrue(modelState.Errors.Any(x => x.PropertyName == nameof(command.Email)));
        }

        [TestMethod]
        public void DeveSer_Invalido_Quando_Nome_Maior_Que_Cem_Caracteres()
        {
            var command = new UsuarioBaseCommand
            {
                Nome = "01234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890",
                Sobrenome = "Del Picolo",
                Email = "delpicolo.alexandre@gmail.com",
                DataNascimento = DateTime.Now.AddYears(-1),
                Perfil = (int)Perfil.Administrador
            };

            var modelState = new UsuarioBaseCommandValidator().Validate(command);

            Assert.IsTrue(modelState.Errors.Any(x => x.PropertyName == nameof(command.Nome)));
        }

        [TestMethod]
        public void DeveSer_Invalido_Quando_Nome_Menor_Que_Tres_Caracteres()
        {
            var command = new UsuarioBaseCommand
            {
                Nome = "12",
                Sobrenome = "Del Picolo",
                Email = "delpicolo.alexandre@gmail.com",
                DataNascimento = DateTime.Now.AddYears(-1),
                Perfil = (int)Perfil.Administrador
            };

            var modelState = new UsuarioBaseCommandValidator().Validate(command);

            Assert.IsTrue(modelState.Errors.Any(x => x.PropertyName == nameof(command.Nome)));
        }

        [TestMethod]
        public void DeveSer_Invalido_Quando_Nome_Nao_Informado()
        {
            var command = new UsuarioBaseCommand
            {
                Sobrenome = "Del Picolo",
                Email = "delpicolo.alexandre@gmail.com",
                DataNascimento = DateTime.Now.AddYears(-1),
                Perfil = (int)Perfil.Administrador
            };

            var modelState = new UsuarioBaseCommandValidator().Validate(command);

            Assert.IsTrue(modelState.Errors.Any(x => x.PropertyName == nameof(command.Nome)));
        }

        [TestMethod]
        public void DeveSer_Invalido_Quando_Perfil_Nao_Existe()
        {
            var command = new UsuarioBaseCommand
            {
                Nome = "Alexandre",
                Sobrenome = "Del Picolo",
                Email = "delpicolo.alexandre@gmail.com",
                DataNascimento = DateTime.Now.AddYears(-1),
                Perfil = 99
            };

            var modelState = new UsuarioBaseCommandValidator().Validate(command);

            Assert.IsTrue(modelState.Errors.Any(x => x.PropertyName == nameof(command.Perfil)));
        }

        [TestMethod]
        public void DeveSer_Invalido_Quando_Perfil_Nao_Informado()
        {
            var command = new UsuarioBaseCommand
            {
                Nome = "Alexandre",
                Sobrenome = "Del Picolo",
                Email = "delpicolo.alexandre@gmail.com",
                DataNascimento = DateTime.Now.AddYears(-1)
            };

            var modelState = new UsuarioBaseCommandValidator().Validate(command);

            Assert.IsTrue(modelState.Errors.Any(x => x.PropertyName == nameof(command.Perfil)));
        }

        [TestMethod]
        public void DeveSer_Invalido_Quando_Sobrenome_Maior_Que_Cem_Caracteres()
        {
            var command = new UsuarioBaseCommand
            {
                Nome = "Alexandre",
                Sobrenome = "01234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890",
                Email = "delpicolo.alexandre@gmail.com",
                DataNascimento = DateTime.Now.AddYears(-1),
                Perfil = (int)Perfil.Administrador
            };

            var modelState = new UsuarioBaseCommandValidator().Validate(command);

            Assert.IsTrue(modelState.Errors.Any(x => x.PropertyName == nameof(command.Sobrenome)));
        }

        [TestMethod]
        public void DeveSer_Invalido_Quando_Sobrenome_Menor_Que_Tres_Caracteres()
        {
            var command = new UsuarioBaseCommand
            {
                Nome = "Alexandre",
                Sobrenome = "12",
                Email = "delpicolo.alexandre@gmail.com",
                DataNascimento = DateTime.Now.AddYears(-1),
                Perfil = (int)Perfil.Administrador
            };

            var modelState = new UsuarioBaseCommandValidator().Validate(command);

            Assert.IsTrue(modelState.Errors.Any(x => x.PropertyName == nameof(command.Sobrenome)));
        }

        [TestMethod]
        public void DeveSer_Invalido_Quando_Sobrenome_Nao_Informado()
        {
            var command = new UsuarioBaseCommand
            {
                Nome = "Alexandre",
                Email = "delpicolo.alexandre@gmail.com",
                DataNascimento = DateTime.Now.AddYears(-1),
                Perfil = (int)Perfil.Administrador
            };

            var modelState = new UsuarioBaseCommandValidator().Validate(command);

            Assert.IsTrue(modelState.Errors.Any(x => x.PropertyName == nameof(command.Sobrenome)));
        }
    }
}