using System;
using System.Collections.Generic;
using System.Text;

namespace SocialNetworkBLL.Models
{
    class Perfil
    {
        public int IdPerfil { get; set; }
        public List<Usuario> Amizades { get; set; }
        public Boolean Privado { get; set; }
    }
}
