using ServiceStack.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Text;

namespace SocialNetworkBLL.Models
{
    public class Comentario
    {
        [ForeignKey("Post")]
        public int ComentarioId { get; set; }
        public string Coment { get; set; }
        public DateTime Data { get; set; }

        public Post PostId { get; set; }
        public Post Post { get; set; }
    }
}
