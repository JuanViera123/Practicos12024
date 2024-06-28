using System.ComponentModel.DataAnnotations;

namespace Practico8.Modelos.Dto
{
    public class EPDto
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(20)]
        public string Nombre { get; set; }


        public int Ocupantes { get; set; }
        public int MetrosCuadrados { get; set; }
    }
}
