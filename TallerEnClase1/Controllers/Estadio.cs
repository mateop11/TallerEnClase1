using System.ComponentModel.DataAnnotations;

namespace TallerEnClase1.Controllers
{
    public class Estadio
    {
        [Key]
        public int IdEstadio { get; set; }

        [MaxLength(200)]
        public string Direccion { get; set; }

        [MaxLength(200)]
        public string CiudadEstadio { get; set; }

        public int Capacidad { get; set; }
    }
}