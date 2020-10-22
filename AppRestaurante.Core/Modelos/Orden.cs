using System.ComponentModel;

namespace AppRestaurante.Core.Modelos
{
    public class Orden
    {
        [DisplayName("Nombre del cliente")]
        public string NombreCliente { get; set; }

        [DisplayName("Mesa")]
        public string Mesa { get; set; }

        [DisplayName("Entradas")]
        public string Entrada { get; set; }

        [DisplayName("Plato fuerte")]
        public string PlatoFuerte { get; set; }

        [DisplayName("Postres")]
        public string Postre { get; set; }

        [DisplayName("Bebidas")]
        public string Bebida { get; set; }
    }
}
