using System.ComponentModel;

namespace AppRestaurante.Core.Modelos
{
    public class Plato
    {
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
