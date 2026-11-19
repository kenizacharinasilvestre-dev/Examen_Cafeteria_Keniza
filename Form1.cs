using System;
using System.Windows.Forms;

namespace Examen_Cafeteria_Keniza
{
    public partial class Form1 : Form
    {
        decimal subtotal = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txtCliente.Text == "")
            {
                MessageBox.Show("Ingrese el nombre del cliente");
                txtCliente.Focus();
            }
            else if (txtProducto.Text == "")
            {
                MessageBox.Show("Ingrese el producto");
                txtProducto.Focus();
            }
            else if (txtPrecio.Text == "")
            {
                MessageBox.Show("Ingrese el precio");
                txtPrecio.Focus();
            }
            else
            {
                decimal precio;
                int cantidad = Convert.ToInt32(nudCantidad.Value);

                if (decimal.TryParse(txtPrecio.Text, out precio) == false || precio <= 0)
                {
                    MessageBox.Show("Ingrese un precio valido");
                    txtPrecio.Focus();
                    return;
                }

                string producto = txtProducto.Text;

                if (rbtGrande.Checked)
                {
                    precio = precio + 25;
                }

                if (chkPorcionExtra.Checked)
                {
                    precio = precio + 30;
                }

                decimal totalProducto = precio * cantidad;

                ListViewItem fila = new ListViewItem(cantidad.ToString());
                fila.SubItems.Add(producto);
                fila.SubItems.Add(precio.ToString("N2"));
                fila.SubItems.Add(totalProducto.ToString("N2"));

                lstPedido.Items.Add(fila);

                subtotal = subtotal + totalProducto;

                MessageBox.Show("Producto agregado correctamente");

                txtProducto.Clear();
                txtPrecio.Clear();
                nudCantidad.Value = 1;
                rbtNormal.Checked = true;
                chkPorcionExtra.Checked = false;
            }
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (lstPedido.Items.Count == 0)
            {
                MessageBox.Show("Agregue productos al pedido");
            }
            else
            {
                decimal descuento = 0;
                decimal empaque = 0;

                if (chkFrecuente.Checked)
                {
                    descuento = subtotal * 0.10m;
                }

                if (rbtLlevar.Checked)
                {
                    empaque = 20;
                }

                decimal baseImponible = subtotal - descuento + empaque;
                decimal itbis = baseImponible * 0.18m;
                decimal total = baseImponible + itbis;

                lblSubtotal.Text = "RD$" + subtotal.ToString("N2");
                lblDescuento.Text = "RD$" + descuento.ToString("N2");
                lblEmpaque.Text = "RD$" + empaque.ToString("N2");
                lblItbis.Text = "RD$" + itbis.ToString("N2");
                lblTotal.Text = "RD$" + total.ToString("N2");

                MessageBox.Show("Total a pagar: RD$" + total.ToString("N2"));
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtCliente.Clear();
            txtProducto.Clear();
            txtPrecio.Clear();

            lstPedido.Items.Clear();

            subtotal = 0;

            chkFrecuente.Checked = false;
            chkPorcionExtra.Checked = false;

            rbtNormal.Checked = true;
            rbtLocal.Checked = true;

            nudCantidad.Value = 1;
            dtpFecha.Value = DateTime.Today;

            lblSubtotal.Text = "RD$0.00";
            lblDescuento.Text = "RD$0.00";
            lblEmpaque.Text = "RD$0.00";
            lblItbis.Text = "RD$0.00";
            lblTotal.Text = "RD$0.00";
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult respuesta;

            respuesta = MessageBox.Show(
                "¿Desea salir del programa?",
                "Confirmar salida",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (respuesta == DialogResult.Yes)
            {
                Close();
            }
        }
    }
}