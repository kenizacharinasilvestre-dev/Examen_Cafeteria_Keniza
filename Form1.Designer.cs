namespace Examen_Cafeteria_Keniza
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.TextBox txtProducto;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.NumericUpDown nudCantidad;
        private System.Windows.Forms.CheckBox chkFrecuente;
        private System.Windows.Forms.CheckBox chkPorcionExtra;
        private System.Windows.Forms.RadioButton rbtNormal;
        private System.Windows.Forms.RadioButton rbtGrande;
        private System.Windows.Forms.RadioButton rbtLocal;
        private System.Windows.Forms.RadioButton rbtLlevar;
        private System.Windows.Forms.ListView lstPedido;
        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.Label lblDescuento;
        private System.Windows.Forms.Label lblEmpaque;
        private System.Windows.Forms.Label lblItbis;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnSalir;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.txtProducto = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.nudCantidad = new System.Windows.Forms.NumericUpDown();
            this.chkFrecuente = new System.Windows.Forms.CheckBox();
            this.chkPorcionExtra = new System.Windows.Forms.CheckBox();
            this.rbtNormal = new System.Windows.Forms.RadioButton();
            this.rbtGrande = new System.Windows.Forms.RadioButton();
            this.rbtLocal = new System.Windows.Forms.RadioButton();
            this.rbtLlevar = new System.Windows.Forms.RadioButton();
            this.lstPedido = new System.Windows.Forms.ListView();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.lblDescuento = new System.Windows.Forms.Label();
            this.lblEmpaque = new System.Windows.Forms.Label();
            this.lblItbis = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();

            System.Windows.Forms.Label titulo = new System.Windows.Forms.Label();
            System.Windows.Forms.Label lblCliente = new System.Windows.Forms.Label();
            System.Windows.Forms.Label lblFecha = new System.Windows.Forms.Label();
            System.Windows.Forms.Label lblProducto = new System.Windows.Forms.Label();
            System.Windows.Forms.Label lblPrecio = new System.Windows.Forms.Label();
            System.Windows.Forms.Label lblCantidad = new System.Windows.Forms.Label();
            System.Windows.Forms.Label lblDetalle = new System.Windows.Forms.Label();
            System.Windows.Forms.GroupBox grupoTamano = new System.Windows.Forms.GroupBox();
            System.Windows.Forms.GroupBox grupoServicio = new System.Windows.Forms.GroupBox();
            System.Windows.Forms.Label lblSub = new System.Windows.Forms.Label();
            System.Windows.Forms.Label lblDesc = new System.Windows.Forms.Label();
            System.Windows.Forms.Label lblEmp = new System.Windows.Forms.Label();
            System.Windows.Forms.Label lblImp = new System.Windows.Forms.Label();
            System.Windows.Forms.Label lblTot = new System.Windows.Forms.Label();

            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).BeginInit();
            this.SuspendLayout();

            this.Text = "Cafeteria El Buen Sabor";
            this.ClientSize = new System.Drawing.Size(790, 570);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.BackColor = System.Drawing.Color.WhiteSmoke;

            titulo.Text = "CAFETERIA EL BUEN SABOR";
            titulo.Font = new System.Drawing.Font("Arial", 17, System.Drawing.FontStyle.Bold);
            titulo.Location = new System.Drawing.Point(230, 15);
            titulo.AutoSize = true;

            lblCliente.Text = "Cliente:";
            lblCliente.Location = new System.Drawing.Point(20, 55);
            lblCliente.AutoSize = true;

            this.txtCliente.Location = new System.Drawing.Point(100, 52);
            this.txtCliente.Size = new System.Drawing.Size(200, 25);

            lblFecha.Text = "Fecha:";
            lblFecha.Location = new System.Drawing.Point(20, 90);
            lblFecha.AutoSize = true;

            this.dtpFecha.Location = new System.Drawing.Point(100, 87);
            this.dtpFecha.Size = new System.Drawing.Size(200, 25);
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;

            this.chkFrecuente.Text = "Cliente frecuente";
            this.chkFrecuente.Location = new System.Drawing.Point(20, 125);
            this.chkFrecuente.AutoSize = true;

            lblProducto.Text = "Producto:";
            lblProducto.Location = new System.Drawing.Point(20, 165);
            lblProducto.AutoSize = true;

            this.txtProducto.Location = new System.Drawing.Point(100, 162);
            this.txtProducto.Size = new System.Drawing.Size(200, 25);

            lblPrecio.Text = "Precio:";
            lblPrecio.Location = new System.Drawing.Point(20, 200);
            lblPrecio.AutoSize = true;

            this.txtPrecio.Location = new System.Drawing.Point(100, 197);
            this.txtPrecio.Size = new System.Drawing.Size(200, 25);

            lblCantidad.Text = "Cantidad:";
            lblCantidad.Location = new System.Drawing.Point(20, 235);
            lblCantidad.AutoSize = true;

            this.nudCantidad.Location = new System.Drawing.Point(100, 232);
            this.nudCantidad.Minimum = 1;
            this.nudCantidad.Maximum = 100;
            this.nudCantidad.Value = 1;

            grupoTamano.Text = "Tamaño";
            grupoTamano.Location = new System.Drawing.Point(20, 275);
            grupoTamano.Size = new System.Drawing.Size(175, 100);

            this.rbtNormal.Text = "Normal";
            this.rbtNormal.Location = new System.Drawing.Point(12, 25);
            this.rbtNormal.AutoSize = true;
            this.rbtNormal.Checked = true;

            this.rbtGrande.Text = "Grande (+RD$25)";
            this.rbtGrande.Location = new System.Drawing.Point(12, 60);
            this.rbtGrande.AutoSize = true;

            grupoTamano.Controls.Add(this.rbtNormal);
            grupoTamano.Controls.Add(this.rbtGrande);

            grupoServicio.Text = "Servicio";
            grupoServicio.Location = new System.Drawing.Point(205, 275);
            grupoServicio.Size = new System.Drawing.Size(210, 100);

            this.rbtLocal.Text = "Consumir en local";
            this.rbtLocal.Location = new System.Drawing.Point(12, 25);
            this.rbtLocal.AutoSize = true;
            this.rbtLocal.Checked = true;

            this.rbtLlevar.Text = "Para llevar";
            this.rbtLlevar.Location = new System.Drawing.Point(12, 60);
            this.rbtLlevar.AutoSize = true;

            grupoServicio.Controls.Add(this.rbtLocal);
            grupoServicio.Controls.Add(this.rbtLlevar);

            this.chkPorcionExtra.Text = "Porción extra (+RD$30)";
            this.chkPorcionExtra.Location = new System.Drawing.Point(20, 390);
            this.chkPorcionExtra.AutoSize = true;

            lblDetalle.Text = "Detalle del pedido";
            lblDetalle.Location = new System.Drawing.Point(445, 85);
            lblDetalle.AutoSize = true;

            this.lstPedido.Location = new System.Drawing.Point(445, 110);
            this.lstPedido.Size = new System.Drawing.Size(310, 200);
            this.lstPedido.View = System.Windows.Forms.View.Details;
            this.lstPedido.FullRowSelect = true;
            this.lstPedido.GridLines = true;
            this.lstPedido.Columns.Add("Cant", 40);
            this.lstPedido.Columns.Add("Producto", 115);
            this.lstPedido.Columns.Add("Precio", 70);
            this.lstPedido.Columns.Add("Total", 75);

            lblSub.Text = "Subtotal:";
            lblSub.Location = new System.Drawing.Point(445, 325);
            lblSub.AutoSize = true;

            this.lblSubtotal.Text = "RD$0.00";
            this.lblSubtotal.Location = new System.Drawing.Point(560, 325);
            this.lblSubtotal.AutoSize = true;

            lblDesc.Text = "Descuento:";
            lblDesc.Location = new System.Drawing.Point(445, 355);
            lblDesc.AutoSize = true;

            this.lblDescuento.Text = "RD$0.00";
            this.lblDescuento.Location = new System.Drawing.Point(560, 355);
            this.lblDescuento.AutoSize = true;

            lblEmp.Text = "Empaque:";
            lblEmp.Location = new System.Drawing.Point(445, 385);
            lblEmp.AutoSize = true;

            this.lblEmpaque.Text = "RD$0.00";
            this.lblEmpaque.Location = new System.Drawing.Point(560, 385);
            this.lblEmpaque.AutoSize = true;

            lblImp.Text = "ITBIS (18%):";
            lblImp.Location = new System.Drawing.Point(445, 415);
            lblImp.AutoSize = true;

            this.lblItbis.Text = "RD$0.00";
            this.lblItbis.Location = new System.Drawing.Point(560, 415);
            this.lblItbis.AutoSize = true;

            lblTot.Text = "TOTAL A PAGAR:";
            lblTot.Location = new System.Drawing.Point(445, 455);
            lblTot.AutoSize = true;
            lblTot.Font = new System.Drawing.Font("Arial", 10, System.Drawing.FontStyle.Bold);

            this.lblTotal.Text = "RD$0.00";
            this.lblTotal.Location = new System.Drawing.Point(580, 455);
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Arial", 10, System.Drawing.FontStyle.Bold);

            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.Location = new System.Drawing.Point(445, 45);
            this.btnAgregar.Size = new System.Drawing.Size(90, 32);

            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.Location = new System.Drawing.Point(20, 445);
            this.btnCalcular.Size = new System.Drawing.Size(110, 35);

            this.btnLimpiar.Text = "Nuevo pedido";
            this.btnLimpiar.Location = new System.Drawing.Point(145, 445);
            this.btnLimpiar.Size = new System.Drawing.Size(120, 35);

            this.btnSalir.Text = "Salir";
            this.btnSalir.Location = new System.Drawing.Point(280, 445);
            this.btnSalir.Size = new System.Drawing.Size(100, 35);

            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);

            this.Controls.Add(titulo);
            this.Controls.Add(lblCliente);
            this.Controls.Add(this.txtCliente);
            this.Controls.Add(lblFecha);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.chkFrecuente);
            this.Controls.Add(lblProducto);
            this.Controls.Add(this.txtProducto);
            this.Controls.Add(lblPrecio);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(lblCantidad);
            this.Controls.Add(this.nudCantidad);
            this.Controls.Add(grupoTamano);
            this.Controls.Add(grupoServicio);
            this.Controls.Add(this.chkPorcionExtra);
            this.Controls.Add(lblDetalle);
            this.Controls.Add(this.lstPedido);
            this.Controls.Add(lblSub);
            this.Controls.Add(this.lblSubtotal);
            this.Controls.Add(lblDesc);
            this.Controls.Add(this.lblDescuento);
            this.Controls.Add(lblEmp);
            this.Controls.Add(this.lblEmpaque);
            this.Controls.Add(lblImp);
            this.Controls.Add(this.lblItbis);
            this.Controls.Add(lblTot);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnSalir);

            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}