using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SocialNetworkBLL.Models;

namespace SocialNetworkAPI.Data
{
    public class SocialNetworkContext : DbContext
    {
        public SocialNetworkContext (DbContextOptions<SocialNetworkContext> options)
            : base(options)
        {
        }

        public DbSet<SocialNetworkBLL.Models.Usuario> Usuario { get; set; }
    }
}
