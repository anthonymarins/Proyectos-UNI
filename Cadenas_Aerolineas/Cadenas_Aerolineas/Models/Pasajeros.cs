using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cadenas_Aerolineas.Models
{
    public class Pasajeros
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        [Required, MaxLength(50)]
        public string Name { get; set; }
        [Required, MaxLength(50)]
        public string APaterno { get; set; }
        [Required, MaxLength(50)]
        public string AMaterno { get; set; }
        [Required, MaxLength(50)]
        public string Email { get; set; }
        [Required]
        public int Telefono { get; set; }
        [Required]
        [ForeignKey("IdPaises")]
        public int IdPais { get; set; }
        public Paises IdPaises { get; set; }
    }
}
