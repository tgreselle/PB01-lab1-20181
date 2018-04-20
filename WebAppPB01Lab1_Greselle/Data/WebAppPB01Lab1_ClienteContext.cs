using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace WebAppPB01Lab1_Greselle.Models
{
    public class WebAppPB01Lab1_ClienteContext : DbContext
    {
        public WebAppPB01Lab1_ClienteContext (DbContextOptions<WebAppPB01Lab1_ClienteContext> options)
            : base(options)
        {
        }

        public DbSet<WebAppPB01Lab1_Greselle.Models.Cliente> Cliente { get; set; }
    }
}
