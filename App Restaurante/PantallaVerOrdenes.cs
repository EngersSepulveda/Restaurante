using System.Windows.Forms;
using AppRestaurante.Core.Servicios;

namespace App_Restaurante
{
    public partial class PantallaVerOrdenes : Form
    {
        private readonly PantallaInicio _pantallaInicio;

        public PantallaVerOrdenes(PantallaInicio pantallaInicio, ServicioOrden servicioOrden)
        {
            _pantallaInicio = pantallaInicio;
            InitializeComponent();

            dgvOrdenes.DataSource = servicioOrden.ObtenerOrdenes();
        }

        private void btnVolver_Click(object sender, System.EventArgs e)
        {
            this.Close();

            _pantallaInicio.Show();
        }
    }
}
