using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace AmirMVC.Models
{
    public class AmirMVCContext : DbContext
    {
        public AmirMVCContext (DbContextOptions<AmirMVCContext> options)
            : base(options)
        {
        }

        public DbSet<AmirMVC.Models.Movie> Movie { get; set; }
    }
}
