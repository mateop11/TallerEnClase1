using System.ComponentModel.DataAnnotations;

namespace TallerEnClase1.Controllers
{
    public class Equipo
    {
        [Key]
        public int IdEquipo { get; set; }

        [MaxLength(200)]
        public string NombreEquipo { get; set; }

        [MaxLength(200)]
        public string CiudadEquipo { get; set; }

        public int Titulos { get; set; }

        public string AceptaExtranjeros { get; set; }

        
        public ICollection<Jugador> Jugadores { get; set; }
    }
}
