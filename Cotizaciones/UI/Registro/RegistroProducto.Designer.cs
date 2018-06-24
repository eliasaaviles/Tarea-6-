namespace Cotizaciones.UI.Registro
{
    partial class RegistroProducto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistroProducto));
            this.IDProdNum = new System.Windows.Forms.NumericUpDown();
            this.DescripcionBox = new System.Windows.Forms.TextBox();
            this.PrecioNum = new System.Windows.Forms.NumericUpDown();
            this.CantidadNum = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.DescripcionProdBox = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.BuscarProdBoton = new System.Windows.Forms.Button();
            this.GuardarProdBoton = new System.Windows.Forms.Button();
            this.NuevoProdBoton = new System.Windows.Forms.Button();
            this.EliminarProdBoton = new System.Windows.Forms.Button();
            this.FechaVenPicker = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.IDProdNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PrecioNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CantidadNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // IDProdNum
            // 
            this.IDProdNum.Location = new System.Drawing.Point(81, 41);
            this.IDProdNum.Name = "IDProdNum";
            this.IDProdNum.Size = new System.Drawing.Size(55, 20);
            this.IDProdNum.TabIndex = 0;
            // 
            // DescripcionBox
            // 
            this.DescripcionBox.Location = new System.Drawing.Point(81, 108);
            this.DescripcionBox.Name = "DescripcionBox";
            this.DescripcionBox.Size = new System.Drawing.Size(254, 20);
            this.DescripcionBox.TabIndex = 1;
            // 
            // PrecioNum
            // 
            this.PrecioNum.Location = new System.Drawing.Point(81, 153);
            this.PrecioNum.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.PrecioNum.Name = "PrecioNum";
            this.PrecioNum.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.PrecioNum.Size = new System.Drawing.Size(96, 20);
            this.PrecioNum.TabIndex = 2;
            this.PrecioNum.ValueChanged += new System.EventHandler(this.PrecioNum_ValueChanged);
            // 
            // CantidadNum
            // 
            this.CantidadNum.Location = new System.Drawing.Point(81, 248);
            this.CantidadNum.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.CantidadNum.Name = "CantidadNum";
            this.CantidadNum.Size = new System.Drawing.Size(96, 20);
            this.CantidadNum.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "ID Producto";
            // 
            // DescripcionProdBox
            // 
            this.DescripcionProdBox.AutoSize = true;
            this.DescripcionProdBox.Location = new System.Drawing.Point(13, 114);
            this.DescripcionProdBox.Name = "DescripcionProdBox";
            this.DescripcionProdBox.Size = new System.Drawing.Size(63, 13);
            this.DescripcionProdBox.TabIndex = 6;
            this.DescripcionProdBox.Text = "Descripcion";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Precio";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 254);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Cantidad";
            // 
            // BuscarProdBoton
            // 
            this.BuscarProdBoton.Location = new System.Drawing.Point(142, 42);
            this.BuscarProdBoton.Name = "BuscarProdBoton";
            this.BuscarProdBoton.Size = new System.Drawing.Size(75, 23);
            this.BuscarProdBoton.TabIndex = 10;
            this.BuscarProdBoton.Text = "Buscar";
            this.BuscarProdBoton.UseVisualStyleBackColor = true;
            this.BuscarProdBoton.Click += new System.EventHandler(this.BuscarProdBoton_Click);
            // 
            // GuardarProdBoton
            // 
            this.GuardarProdBoton.Location = new System.Drawing.Point(19, 309);
            this.GuardarProdBoton.Name = "GuardarProdBoton";
            this.GuardarProdBoton.Size = new System.Drawing.Size(75, 23);
            this.GuardarProdBoton.TabIndex = 11;
            this.GuardarProdBoton.Text = "Guardar";
            this.GuardarProdBoton.UseVisualStyleBackColor = true;
            this.GuardarProdBoton.Click += new System.EventHandler(this.GuardarProdBoton_Click);
            // 
            // NuevoProdBoton
            // 
            this.NuevoProdBoton.Location = new System.Drawing.Point(135, 309);
            this.NuevoProdBoton.Name = "NuevoProdBoton";
            this.NuevoProdBoton.Size = new System.Drawing.Size(75, 23);
            this.NuevoProdBoton.TabIndex = 12;
            this.NuevoProdBoton.Text = "Nuevo";
            this.NuevoProdBoton.UseVisualStyleBackColor = true;
            this.NuevoProdBoton.Click += new System.EventHandler(this.NuevoProdBoton_Click);
            // 
            // EliminarProdBoton
            // 
            this.EliminarProdBoton.Location = new System.Drawing.Point(260, 309);
            this.EliminarProdBoton.Name = "EliminarProdBoton";
            this.EliminarProdBoton.Size = new System.Drawing.Size(75, 23);
            this.EliminarProdBoton.TabIndex = 13;
            this.EliminarProdBoton.Text = "Eliminar";
            this.EliminarProdBoton.UseVisualStyleBackColor = true;
            this.EliminarProdBoton.Click += new System.EventHandler(this.EliminarProdBoton_Click);
            // 
            // FechaVenPicker
            // 
            this.FechaVenPicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.FechaVenPicker.Location = new System.Drawing.Point(135, 202);
            this.FechaVenPicker.Name = "FechaVenPicker";
            this.FechaVenPicker.Size = new System.Drawing.Size(200, 20);
            this.FechaVenPicker.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 208);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Fecha de Vencimiento";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(223, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(137, 63);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // RegistroProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 368);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.EliminarProdBoton);
            this.Controls.Add(this.NuevoProdBoton);
            this.Controls.Add(this.GuardarProdBoton);
            this.Controls.Add(this.BuscarProdBoton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DescripcionProdBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CantidadNum);
            this.Controls.Add(this.FechaVenPicker);
            this.Controls.Add(this.PrecioNum);
            this.Controls.Add(this.DescripcionBox);
            this.Controls.Add(this.IDProdNum);
            this.Name = "RegistroProducto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegistroProducto";
            this.Load += new System.EventHandler(this.RegistroProducto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.IDProdNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PrecioNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CantidadNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown IDProdNum;
        private System.Windows.Forms.TextBox DescripcionBox;
        private System.Windows.Forms.NumericUpDown PrecioNum;
        private System.Windows.Forms.NumericUpDown CantidadNum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label DescripcionProdBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button BuscarProdBoton;
        private System.Windows.Forms.Button GuardarProdBoton;
        private System.Windows.Forms.Button NuevoProdBoton;
        private System.Windows.Forms.Button EliminarProdBoton;
        private System.Windows.Forms.DateTimePicker FechaVenPicker;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}