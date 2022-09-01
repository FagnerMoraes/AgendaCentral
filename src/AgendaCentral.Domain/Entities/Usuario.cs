using AgendaCentral.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaCentral.Domain.Entities
{
    public class Usuario
    {
        public int UsuarioId { get; private set; }

        public string NameUsuario { get; private set; }

        public Role Role { get; private set; }
    }
}
