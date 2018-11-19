using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models.Entidades;

namespace WebApplication1.Models.Contexto
{
    public class Contexto : DbContext
    {

        public Contexto(DbContextOptions<Contexto> option) : base(option)
        {
            Database.EnsureCreated();
        }


        public DbSet<bec_institutos_promociones> bec_institutos_promociones { get; set; }
        public DbSet<bec_beacons_institutos> bec_beacons_institutos { get; set; }
    }
}
