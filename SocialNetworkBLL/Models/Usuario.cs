using System;
using System.Collections.Generic;
using System.Text;

namespace SocialNetworkBLL.Models
{
    public class Usuario : Perfil
    {
        public int UsuarioId { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Email { get; set; }
        public DateTime Aniversario { get; set; }
        public string Localidade { get; set; }
    }
}
