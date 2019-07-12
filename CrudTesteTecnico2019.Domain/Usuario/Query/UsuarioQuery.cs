using CrudTesteTecnico2019.Model.Usuario;
using MediatR;
using System.Collections.Generic;

namespace CrudTesteTecnico2019.Domain.Usuario.Query
{
    public class UsuarioQuery : IRequest<IEnumerable<UsuarioModel>> { }
}
