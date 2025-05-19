using System;
using System.ComponentModel.DataAnnotations;  // si aún no lo tienes

namespace MiPrimeraAppWeb.Models
{
    public class GuestEntry
    {
        [Required]
        public string Name { get; set; } = "";      // inicializa con cadena vacía

        [Required]
        public string Message { get; set; } = "";   // inicializa con cadena vacía

        public DateTime Date { get; set; }
    }
}
