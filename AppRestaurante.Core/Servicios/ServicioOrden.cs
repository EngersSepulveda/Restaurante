using System.Collections.Generic;
using AppRestaurante.Core.Data;
using AppRestaurante.Core.Modelos;

namespace AppRestaurante.Core.Servicios
{
    public class ServicioOrden
    {
        public void AgregarOrdenes(List<Orden> ordenes)
        {
            AlmacenOrdenes.Ordenes.AddRange(ordenes);
        }

        public List<Orden> ObtenerOrdenes()
        {
            return AlmacenOrdenes.Ordenes;
        }
    }
}
