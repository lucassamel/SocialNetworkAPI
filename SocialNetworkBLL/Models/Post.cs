using ServiceStack.DataAnnotations;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SocialNetworkBLL.Models
{
    public class Post
    {
        [Key]
        public int PostId { get; set; }
        public string Tipo { get; set; }
        public DateTime DataPost { get; set; }

        public int UserId { get; set; }

        public List<Comentario> Comentarios { get; set; }
    }
}
