using CrudTesteTecnico2019.Domain.Usuario.Command;
using CrudTesteTecnico2019.Domain.Usuario.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace CrudTesteTecnico2019.Tests.Usuario
{
    [TestClass]
    public class ExcluirUsuarioCommandTest : UsuarioBaseCommandTest
    {
        [TestMethod]
        public void DeveSer_Invalido_Quando_Id_Igual_Zero()
        {
            var command = new ExcluirUsuarioCommand { Id = 0 };

            var modelState = new ExcluirUsuarioCommandValidator().Validate(command);

            Assert.IsTrue(modelState.Errors.Any(x => x.PropertyName == nameof(command.Id)));
        }

        [TestMethod]
        public void DeveSer_Invalido_Quando_Id_Nao_Informado()
        {
            var command = new ExcluirUsuarioCommand { };

            var modelState = new ExcluirUsuarioCommandValidator().Validate(command);

            Assert.IsTrue(modelState.Errors.Any(x => x.PropertyName == nameof(command.Id)));
        }
    }
}