namespace App_Restaurante
{
    partial class PantallaInicio
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.button4 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnMesa1 = new System.Windows.Forms.Button();
            this.btnMesa2 = new System.Windows.Forms.Button();
            this.btnMesa4 = new System.Windows.Forms.Button();
            this.btnMesa3 = new System.Windows.Forms.Button();
            this.btnVerOrdenes = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(3, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 0;
            this.button3.Text = "button2";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(3, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 0;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Location = new System.Drawing.Point(12, 12);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(285, 195);
            this.flowLayoutPanel2.TabIndex = 0;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(0, 0);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(601, 433);
            this.panel1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnMesa1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnMesa2, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnMesa4, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnMesa3, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnVerOrdenes, 0, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 0F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(601, 433);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.label1, 2);
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(595, 30);
            this.label1.TabIndex = 4;
            this.label1.Text = "Escoja la mesa a la que servirá";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnMesa1
            // 
            this.btnMesa1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnMesa1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnMesa1.Location = new System.Drawing.Point(3, 33);
            this.btnMesa1.Name = "btnMesa1";
            this.btnMesa1.Size = new System.Drawing.Size(294, 170);
            this.btnMesa1.TabIndex = 0;
            this.btnMesa1.Text = "Mesa 1";
            this.btnMesa1.UseVisualStyleBackColor = true;
            this.btnMesa1.Click += new System.EventHandler(this.btnMesa1_Click);
            // 
            // btnMesa2
            // 
            this.btnMesa2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnMesa2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnMesa2.Location = new System.Drawing.Point(303, 33);
            this.btnMesa2.Name = "btnMesa2";
            this.btnMesa2.Size = new System.Drawing.Size(295, 170);
            this.btnMesa2.TabIndex = 0;
            this.btnMesa2.Text = "Mesa 2";
            this.btnMesa2.UseVisualStyleBackColor = true;
            this.btnMesa2.Click += new System.EventHandler(this.btnMesa2_Click);
            // 
            // btnMesa4
            // 
            this.btnMesa4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnMesa4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnMesa4.Location = new System.Drawing.Point(303, 209);
            this.btnMesa4.Name = "btnMesa4";
            this.btnMesa4.Size = new System.Drawing.Size(295, 170);
            this.btnMesa4.TabIndex = 0;
            this.btnMesa4.Text = "Mesa 4";
            this.btnMesa4.UseVisualStyleBackColor = true;
            this.btnMesa4.Click += new System.EventHandler(this.btnMesa4_Click);
            // 
            // btnMesa3
            // 
            this.btnMesa3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnMesa3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnMesa3.Location = new System.Drawing.Point(3, 209);
            this.btnMesa3.Name = "btnMesa3";
            this.btnMesa3.Size = new System.Drawing.Size(294, 170);
            this.btnMesa3.TabIndex = 0;
            this.btnMesa3.Text = "Mesa 3";
            this.btnMesa3.UseVisualStyleBackColor = true;
            this.btnMesa3.Click += new System.EventHandler(this.btnMesa3_Click);
            // 
            // btnVerOrdenes
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.btnVerOrdenes, 2);
            this.btnVerOrdenes.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnVerOrdenes.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnVerOrdenes.Location = new System.Drawing.Point(3, 385);
            this.btnVerOrdenes.Name = "btnVerOrdenes";
            this.btnVerOrdenes.Size = new System.Drawing.Size(595, 45);
            this.btnVerOrdenes.TabIndex = 5;
            this.btnVerOrdenes.Text = "Ver todas las ordenes";
            this.btnVerOrdenes.UseVisualStyleBackColor = true;
            this.btnVerOrdenes.Click += new System.EventHandler(this.btnVerOrdenes_Click);
            // 
            // PantallaInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 433);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "PantallaInicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnMesa1;
        private System.Windows.Forms.Button btnMesa4;
        private System.Windows.Forms.Button btnMesa3;
        private System.Windows.Forms.Button btnMesa2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnVerOrdenes;
    }
}

