using System.Collections.Generic;
using System.Windows.Forms;
using AppRestaurante.Core.Data;
using AppRestaurante.Core.Modelos;
using AppRestaurante.Core.Servicios;

namespace App_Restaurante
{
    public partial class PantallaPedido : Form
    {
        private int NumeroComensalActual { get; set; } = 1;
        private List<Orden> OrdenesCliente { get; set; } = new List<Orden>();

        private readonly PantallaInicio _pantallaInicio;
        private readonly ServicioOrden _servicioOrden;
        private readonly string _nombreMesa;
        private readonly int _cantPersonas;

        public PantallaPedido(PantallaInicio pantallaInicio, ServicioOrden servicioOrden, string nombreMesa, int cantPersonas)
        {
            _pantallaInicio = pantallaInicio;
            _servicioOrden = servicioOrden;
            _nombreMesa = nombreMesa;
            _cantPersonas = cantPersonas;
            InitializeComponent();

            dgvMenu.DataSource = Menu.Platos;

            HacerPedido();
        }

        private void HacerPedido()
        {
            if (NumeroComensalActual <= _cantPersonas)
            {
                lbTitulo.Text = $"Elija su pedido ({NumeroComensalActual++} de {_cantPersonas})";
                return;
            }

            // Cuando todas las personas terminen de ordenar, se guardan las ordenes
            _servicioOrden.AgregarOrdenes(OrdenesCliente);

            // Vaciamos la lista de ordenes para que las demás mesas no tengan las ordenes de clientes pasados
            VaciarOrdenesCliente();

            // Luego, se envía al usuario a la pantalla principal
            MessageBox.Show("Pedido realizado exitosamente!");
            IrPantallaInicio();
        }

        private void IrPantallaInicio()
        {
            _pantallaInicio.Show();

            this.Close();
        }

        private void LimpiarPedido()
        {
            txtNombre.Text = "";
            lbEntrada.Text = "";
            lbPlatoFuerte.Text = "";
            lbPostre.Text = "";
            lbBebida.Text = "";
        }

        private void VaciarOrdenesCliente()
        {
            OrdenesCliente = new List<Orden>();
        }

        private void btnSiguientePedido_Click(object sender, System.EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text) || string.IsNullOrWhiteSpace(lbEntrada.Text) ||
                string.IsNullOrWhiteSpace(lbPlatoFuerte.Text) || string.IsNullOrWhiteSpace(lbPostre.Text) ||
                string.IsNullOrWhiteSpace(lbBebida.Text))
            {
                MessageBox.Show("Debe ingresar el nombre del cliente y seleccionar una entrada, un plato fuerte, un postre y una bebida.");
                return;
            }

            // Lógica para agregar ordenes
            var orden = new Orden
            {
                NombreCliente = txtNombre.Text,
                Mesa = _nombreMesa,
                Entrada = lbEntrada.Text,
                PlatoFuerte = lbPlatoFuerte.Text,
                Postre = lbPostre.Text,
                Bebida = lbBebida.Text
            };

            OrdenesCliente.Add(orden);

            LimpiarPedido();

            HacerPedido();
        }

        private void dgvMenu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            object contenidoCelda;

            switch (dgvMenu.SelectedCells[0].ColumnIndex)
            {
                case 0:
                    contenidoCelda = dgvMenu.Rows[e.RowIndex].Cells[0].Value;

                    if (contenidoCelda != null)
                    {
                        lbEntrada.Text = contenidoCelda.ToString();
                    }

                    break;
                case 1:
                    contenidoCelda = dgvMenu.Rows[e.RowIndex].Cells[1].Value;

                    if (contenidoCelda != null)
                    {
                        lbPlatoFuerte.Text = contenidoCelda.ToString();
                    }

                    break;
                case 2:
                    contenidoCelda = dgvMenu.Rows[e.RowIndex].Cells[2].Value;

                    if (contenidoCelda != null)
                    {
                        lbPostre.Text = contenidoCelda.ToString();
                    }

                    break;
                case 3:
                    contenidoCelda = dgvMenu.Rows[e.RowIndex].Cells[3].Value;

                    if (contenidoCelda != null)
                    {
                        lbBebida.Text = contenidoCelda.ToString();
                    }

                    break;
            }
        }

        private void btnCancelarOrden_Click(object sender, System.EventArgs e)
        {
            VaciarOrdenesCliente();
            IrPantallaInicio();
        }
    }
}
