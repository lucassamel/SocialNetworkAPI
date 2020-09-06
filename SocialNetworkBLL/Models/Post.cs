using System;
using System.Collections.Generic;
using System.Text;

namespace SocialNetworkBLL.Models
{
    class Post
    {

        public int Id { get; set; }
        public string Tipo { get; set; }
        public DateTime DataPost { get; set; }

        public int UserId { get; set; }
    }
}
