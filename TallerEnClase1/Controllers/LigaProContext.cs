using Microsoft.EntityFrameworkCore;
using TallerEnClase1.Controllers;
using TallerEnClase1.Models; 

namespace TallerEnClase1.Data 
{
    public class LigaProContext : DbContext
    {
        public LigaProContext(DbContextOptions<LigaProContext> options) : base(options)
        {
        }

        
        public DbSet<Estadio> Estadios { get; set; }
        public DbSet<Jugador> Jugadores { get; set; }
        public DbSet<Equipo> Equipos { get; set; }
    }
}
