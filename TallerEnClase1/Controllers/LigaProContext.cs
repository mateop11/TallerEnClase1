using Microsoft.EntityFrameworkCore;
using TallerEnClase1.Controllers;
using TallerEnClase1.Models; // Asegúrate de usar el namespace correcto para los modelos

namespace TallerEnClase1.Data // Cambia esto según donde esté ubicada la clase
{
    public class LigaProContext : DbContext
    {
        public LigaProContext(DbContextOptions<LigaProContext> options) : base(options)
        {
        }

        // DbSet para mapear las clases de modelo a tablas de la base de datos
        public DbSet<Estadio> Estadios { get; set; }
        public DbSet<Jugador> Jugadores { get; set; }
        public DbSet<Equipo> Equipos { get; set; }
    }
}
