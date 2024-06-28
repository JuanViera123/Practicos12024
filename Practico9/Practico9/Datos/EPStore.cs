using Practico8.Modelos.Dto;

namespace Practico8.Datos
{
    public class EPStore
    {
        public static List<EPDto> EPList = new List<EPDto>
        {
             new EPDto{Id = 1, Nombre="Vista a la Piscina", Ocupantes = 3, MetrosCuadrados = 50},
             new EPDto{Id = 2, Nombre="Vista a la Playa", Ocupantes = 2, MetrosCuadrados = 100}
        };
    }
}
