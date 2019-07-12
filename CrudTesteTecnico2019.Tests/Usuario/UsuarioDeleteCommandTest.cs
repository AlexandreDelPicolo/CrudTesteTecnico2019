using CrudTesteTecnico2019.Domain.Usuario.Command;
using CrudTesteTecnico2019.Domain.Usuario.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace CrudTesteTecnico2019.Tests.Usuario
{
    [TestClass]
    public class UsuarioDeleteCommandTest : UsuarioBaseCommandTest
    {
        [TestMethod]
        public void DeveSer_Invalido_Quando_Id_Nao_Informado()
        {
            UsuarioDeleteCommand command = new UsuarioDeleteCommand { };

            UsuarioDeleteCommandValidator validator = new UsuarioDeleteCommandValidator();
            FluentValidation.Results.ValidationResult modelState = validator.Validate(command);
            Assert.IsTrue(modelState.Errors.Any(x => x.PropertyName == nameof(command.Id)));
        }

        [TestMethod]
        public void DeveSer_Invalido_Quando_Id_Igual_Zero()
        {
            UsuarioDeleteCommand command = new UsuarioDeleteCommand
            {
                Id = 0
            };

            UsuarioDeleteCommandValidator validator = new UsuarioDeleteCommandValidator();
            FluentValidation.Results.ValidationResult modelState = validator.Validate(command);
            Assert.IsTrue(modelState.Errors.Any(x => x.PropertyName == nameof(command.Id)));
        }
    }
}
