using System.Collections.Generic;
using AppRestaurante.Core.Modelos;

namespace AppRestaurante.Core.Data
{
    public static class Menu
    {
        public static List<Plato> Platos { get; } = new List<Plato>
        {
            new Plato { Entrada = "Croquetas de pollo", PlatoFuerte = "Bistec encebollado", Postre = "Dulce de leche", Bebida = "Coca cola"},
            new Plato { Entrada = "Mozarella sticks", PlatoFuerte = "Bacon cheeseburger", Postre = "Habichuela con dulce", Bebida = "Jugo de naranja"},
            new Plato { Entrada = "Bollitos de yuca", PlatoFuerte = "Pollo a la plancha", Postre = "Helado", Bebida = "Té frío"},
            new Plato { Entrada = "Sopa", PlatoFuerte = "Lasaña", Postre = "Majarete", Bebida = "Cerveza"},
            new Plato { Entrada = "Pan de ajo", PlatoFuerte = "Parrillada mixta", Postre = "Brownie", Bebida = "Whisky"},
            new Plato { PlatoFuerte = "Mofongo"},
            new Plato { PlatoFuerte = "Tacos"},
            new Plato { PlatoFuerte = "Churrasco"},
            new Plato { PlatoFuerte = "Cachapa"},
            new Plato { PlatoFuerte = "Empanadas"},
        };
    }
}
