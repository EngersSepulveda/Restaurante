using System.Windows.Forms;
using AppRestaurante.Core.Data;
using AppRestaurante.Core.Servicios;

namespace App_Restaurante
{
    public partial class PantallaCantidadPersonas : Form
    {
        private readonly PantallaInicio _pantallaInicio;
        private readonly string _nombreMesa;

        public PantallaCantidadPersonas(PantallaInicio pantallaInicio, string nombreMesa)
        {
            _pantallaInicio = pantallaInicio;
            _nombreMesa = nombreMesa;
            InitializeComponent();
        }

        private void btnSiguiente_Click(object sender, System.EventArgs e)
        {
            bool fueConvertido = int.TryParse(txtCantPersonas.Text, out int cantPersonas);

            if (fueConvertido && cantPersonas > 0 && cantPersonas <= 4)
            {
                var pantallaPedido = new PantallaPedido(_pantallaInicio, new ServicioOrden(), _nombreMesa, cantPersonas);
                pantallaPedido.Show();

                this.Close();
            }
            else
            {
                MessageBox.Show("La cantidad de personas debe ser entre 1 y 4");
            }
        }
    }
}
