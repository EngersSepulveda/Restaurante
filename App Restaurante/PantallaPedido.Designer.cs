namespace App_Restaurante
{
    partial class PantallaPedido
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbTitulo = new System.Windows.Forms.Label();
            this.dgvMenu = new System.Windows.Forms.DataGridView();
            this.btnSiguientePedido = new System.Windows.Forms.Button();
            this.btnCancelarOrden = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbEntrada = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbPlatoFuerte = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbPostre = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lbBebida = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMenu)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.txtNombre, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lbTitulo, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.dgvMenu, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnSiguientePedido, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.btnCancelarOrden, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.panel4, 3, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 464);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(3, 48);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(194, 23);
            this.txtNombre.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre:";
            // 
            // lbTitulo
            // 
            this.lbTitulo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbTitulo.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.lbTitulo, 3);
            this.lbTitulo.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbTitulo.Location = new System.Drawing.Point(3, 0);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(594, 30);
            this.lbTitulo.TabIndex = 2;
            this.lbTitulo.Text = "Elija su pedido ({ordenActual} de {totalOrdenes})";
            // 
            // dgvMenu
            // 
            this.dgvMenu.AllowUserToAddRows = false;
            this.dgvMenu.AllowUserToDeleteRows = false;
            this.dgvMenu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableLayoutPanel1.SetColumnSpan(this.dgvMenu, 4);
            this.dgvMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMenu.Location = new System.Drawing.Point(3, 77);
            this.dgvMenu.Name = "dgvMenu";
            this.dgvMenu.ReadOnly = true;
            this.dgvMenu.Size = new System.Drawing.Size(794, 295);
            this.dgvMenu.TabIndex = 9;
            this.dgvMenu.Text = "dataGridView2";
            this.dgvMenu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMenu_CellClick);
            // 
            // btnSiguientePedido
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.btnSiguientePedido, 2);
            this.btnSiguientePedido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSiguientePedido.Location = new System.Drawing.Point(203, 417);
            this.btnSiguientePedido.Name = "btnSiguientePedido";
            this.btnSiguientePedido.Size = new System.Drawing.Size(394, 44);
            this.btnSiguientePedido.TabIndex = 10;
            this.btnSiguientePedido.Text = "Siguiente orden";
            this.btnSiguientePedido.UseVisualStyleBackColor = true;
            this.btnSiguientePedido.Click += new System.EventHandler(this.btnSiguientePedido_Click);
            // 
            // btnCancelarOrden
            // 
            this.btnCancelarOrden.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCancelarOrden.Location = new System.Drawing.Point(603, 3);
            this.btnCancelarOrden.Name = "btnCancelarOrden";
            this.btnCancelarOrden.Size = new System.Drawing.Size(194, 24);
            this.btnCancelarOrden.TabIndex = 11;
            this.btnCancelarOrden.Text = "Cancelar orden";
            this.btnCancelarOrden.UseVisualStyleBackColor = true;
            this.btnCancelarOrden.Click += new System.EventHandler(this.btnCancelarOrden_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbEntrada);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 378);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(194, 33);
            this.panel1.TabIndex = 12;
            // 
            // lbEntrada
            // 
            this.lbEntrada.AutoSize = true;
            this.lbEntrada.Location = new System.Drawing.Point(60, 9);
            this.lbEntrada.Name = "lbEntrada";
            this.lbEntrada.Size = new System.Drawing.Size(0, 15);
            this.lbEntrada.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Entrada:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lbPlatoFuerte);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(203, 378);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(194, 33);
            this.panel2.TabIndex = 13;
            // 
            // lbPlatoFuerte
            // 
            this.lbPlatoFuerte.AutoSize = true;
            this.lbPlatoFuerte.Location = new System.Drawing.Point(77, 9);
            this.lbPlatoFuerte.Name = "lbPlatoFuerte";
            this.lbPlatoFuerte.Size = new System.Drawing.Size(0, 15);
            this.lbPlatoFuerte.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(0, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Plato fuerte:";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lbPostre);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(403, 378);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(194, 33);
            this.panel3.TabIndex = 14;
            // 
            // lbPostre
            // 
            this.lbPostre.AutoSize = true;
            this.lbPostre.Location = new System.Drawing.Point(49, 9);
            this.lbPostre.Name = "lbPostre";
            this.lbPostre.Size = new System.Drawing.Size(0, 15);
            this.lbPostre.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(0, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "Postre:";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.lbBebida);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(603, 378);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(194, 33);
            this.panel4.TabIndex = 15;
            // 
            // lbBebida
            // 
            this.lbBebida.AutoSize = true;
            this.lbBebida.Location = new System.Drawing.Point(52, 9);
            this.lbBebida.Name = "lbBebida";
            this.lbBebida.Size = new System.Drawing.Size(0, 15);
            this.lbBebida.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(0, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 15);
            this.label5.TabIndex = 0;
            this.label5.Text = "Bebida:";
            // 
            // PantallaPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 464);
            this.ControlBox = false;
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "PantallaPedido";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TopMost = true;
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMenu)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lbTitulo;
        private System.Windows.Forms.DataGridView dgvMenu;
        private System.Windows.Forms.Button btnSiguientePedido;
        private System.Windows.Forms.Button btnCancelarOrden;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbEntrada;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbPlatoFuerte;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lbPostre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lbBebida;
        private System.Windows.Forms.Label label5;
    }
}