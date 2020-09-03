using System;
using System.Collections.Generic;
using System.Text;

namespace SocialNetworkBLL.Models
{
    class Usuario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Email { get; set; }
        public DateTime Aniversario { get; set; }
    }
}
