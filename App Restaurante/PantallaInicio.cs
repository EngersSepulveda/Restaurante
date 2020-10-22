using System;
using System.Windows.Forms;
using AppRestaurante.Core.Data;
using AppRestaurante.Core.Servicios;

namespace App_Restaurante
{
    public partial class PantallaInicio : Form
    {
        public PantallaInicio()
        {
            InitializeComponent();
        }

        private void AbrirPantallaCantPersonas(string nombreMesa)
        {
            this.Hide();

            var pantallaCantPersonas = new PantallaCantidadPersonas(this, nombreMesa);
            pantallaCantPersonas.Show();
        }

        private void btnMesa1_Click(object sender, EventArgs e)
        {
            AbrirPantallaCantPersonas(btnMesa1.Text);
        }

        private void btnMesa2_Click(object sender, EventArgs e)
        {
            AbrirPantallaCantPersonas(btnMesa2.Text);
        }

        private void btnMesa3_Click(object sender, EventArgs e)
        {
            AbrirPantallaCantPersonas(btnMesa3.Text);
        }

        private void btnMesa4_Click(object sender, EventArgs e)
        {
            AbrirPantallaCantPersonas(btnMesa4.Text);
        }

        private void btnVerOrdenes_Click(object sender, EventArgs e)
        {
            this.Hide();

            var pantallaVerOrdenes = new PantallaVerOrdenes(this, new ServicioOrden());
            pantallaVerOrdenes.Show();
        }
    }
}
