using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using apirest_entity_framework.Models;

namespace apirest_entity_framework.Data
{
    public class apirest_entity_frameworkContext : DbContext
    {
        public apirest_entity_frameworkContext (DbContextOptions<apirest_entity_frameworkContext> options)
            : base(options)
        {
        }

        public DbSet<apirest_entity_framework.Models.Book> Book { get; set; }
    }
}
