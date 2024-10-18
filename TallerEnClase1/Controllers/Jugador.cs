using System.ComponentModel.DataAnnotations;

namespace TallerEnClase1.Controllers
{
    public class Jugador
    {
        [Key]
        public int IdJugador { get; set; }

        [MaxLength(100)]
        public string NombreJugador { get; set; }

        [MaxLength(100)]
        public string Posicion { get; set; }

        [Range(0, 50)]
        public int Edad { get; set; }

        
        public int EquipoId { get; set; }
        public Equipo Equipo { get; set; }
    }
}