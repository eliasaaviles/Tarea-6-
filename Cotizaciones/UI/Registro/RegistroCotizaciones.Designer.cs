namespace Cotizaciones.UI.Registro
{
    partial class RegistroCotizaciones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistroCotizaciones));
            this.CotizacionIDNum = new System.Windows.Forms.NumericUpDown();
            this.FechaCotPicker = new System.Windows.Forms.DateTimePicker();
            this.ProductoBox = new System.Windows.Forms.ComboBox();
            this.CantidadBox = new System.Windows.Forms.TextBox();
            this.PrecioBox = new System.Windows.Forms.TextBox();
            this.ImporteBox = new System.Windows.Forms.TextBox();
            this.AgregarBoton = new System.Windows.Forms.Button();
            this.PersonaBox = new System.Windows.Forms.ComboBox();
            this.dataGridDetalle = new System.Windows.Forms.DataGridView();
            this.ObservacionBox = new System.Windows.Forms.TextBox();
            this.TotalNum = new System.Windows.Forms.NumericUpDown();
            this.NuevoBoton = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.BuscarCotBoton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.CotizacionIDNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDetalle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TotalNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // CotizacionIDNum
            // 
            this.CotizacionIDNum.Location = new System.Drawing.Point(89, 41);
            this.CotizacionIDNum.Name = "CotizacionIDNum";
            this.CotizacionIDNum.Size = new System.Drawing.Size(74, 20);
            this.CotizacionIDNum.TabIndex = 0;
            // 
            // FechaCotPicker
            // 
            this.FechaCotPicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.FechaCotPicker.Location = new System.Drawing.Point(471, 41);
            this.FechaCotPicker.Name = "FechaCotPicker";
            this.FechaCotPicker.Size = new System.Drawing.Size(121, 20);
            this.FechaCotPicker.TabIndex = 2;
            // 
            // ProductoBox
            // 
            this.ProductoBox.FormattingEnabled = true;
            this.ProductoBox.Location = new System.Drawing.Point(12, 117);
            this.ProductoBox.Name = "ProductoBox";
            this.ProductoBox.Size = new System.Drawing.Size(121, 21);
            this.ProductoBox.TabIndex = 3;
            // 
            // CantidadBox
            // 
            this.CantidadBox.Location = new System.Drawing.Point(138, 118);
            this.CantidadBox.Name = "CantidadBox";
            this.CantidadBox.Size = new System.Drawing.Size(120, 20);
            this.CantidadBox.TabIndex = 4;
            // 
            // PrecioBox
            // 
            this.PrecioBox.Location = new System.Drawing.Point(264, 118);
            this.PrecioBox.Name = "PrecioBox";
            this.PrecioBox.Size = new System.Drawing.Size(120, 20);
            this.PrecioBox.TabIndex = 5;
            this.PrecioBox.TextChanged += new System.EventHandler(this.PrecioBox_TextChanged);
            // 
            // ImporteBox
            // 
            this.ImporteBox.Location = new System.Drawing.Point(390, 118);
            this.ImporteBox.Name = "ImporteBox";
            this.ImporteBox.Size = new System.Drawing.Size(120, 20);
            this.ImporteBox.TabIndex = 6;
            // 
            // AgregarBoton
            // 
            this.AgregarBoton.Location = new System.Drawing.Point(516, 115);
            this.AgregarBoton.Name = "AgregarBoton";
            this.AgregarBoton.Size = new System.Drawing.Size(75, 23);
            this.AgregarBoton.TabIndex = 7;
            this.AgregarBoton.Text = "Agregar";
            this.AgregarBoton.UseVisualStyleBackColor = true;
            this.AgregarBoton.Click += new System.EventHandler(this.button1_Click);
            // 
            // PersonaBox
            // 
            this.PersonaBox.FormattingEnabled = true;
            this.PersonaBox.Location = new System.Drawing.Point(58, 67);
            this.PersonaBox.Name = "PersonaBox";
            this.PersonaBox.Size = new System.Drawing.Size(534, 21);
            this.PersonaBox.TabIndex = 8;
            // 
            // dataGridDetalle
            // 
            this.dataGridDetalle.AllowUserToAddRows = false;
            this.dataGridDetalle.AllowUserToDeleteRows = false;
            this.dataGridDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridDetalle.Location = new System.Drawing.Point(11, 150);
            this.dataGridDetalle.Name = "dataGridDetalle";
            this.dataGridDetalle.ReadOnly = true;
            this.dataGridDetalle.Size = new System.Drawing.Size(580, 150);
            this.dataGridDetalle.TabIndex = 9;
            // 
            // ObservacionBox
            // 
            this.ObservacionBox.Location = new System.Drawing.Point(11, 328);
            this.ObservacionBox.Multiline = true;
            this.ObservacionBox.Name = "ObservacionBox";
            this.ObservacionBox.Size = new System.Drawing.Size(267, 115);
            this.ObservacionBox.TabIndex = 10;
            // 
            // TotalNum
            // 
            this.TotalNum.Location = new System.Drawing.Point(471, 328);
            this.TotalNum.Name = "TotalNum";
            this.TotalNum.Size = new System.Drawing.Size(120, 20);
            this.TotalNum.TabIndex = 11;
            // 
            // NuevoBoton
            // 
            this.NuevoBoton.Location = new System.Drawing.Point(338, 328);
            this.NuevoBoton.Name = "NuevoBoton";
            this.NuevoBoton.Size = new System.Drawing.Size(75, 23);
            this.NuevoBoton.TabIndex = 12;
            this.NuevoBoton.Text = "Nuevo";
            this.NuevoBoton.UseVisualStyleBackColor = true;
            this.NuevoBoton.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(338, 377);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 13;
            this.button3.Text = "Guardar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(338, 420);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 14;
            this.button4.Text = "Eliminar";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // BuscarCotBoton
            // 
            this.BuscarCotBoton.Location = new System.Drawing.Point(169, 38);
            this.BuscarCotBoton.Name = "BuscarCotBoton";
            this.BuscarCotBoton.Size = new System.Drawing.Size(75, 23);
            this.BuscarCotBoton.TabIndex = 15;
            this.BuscarCotBoton.Text = "Buscar";
            this.BuscarCotBoton.UseVisualStyleBackColor = true;
            this.BuscarCotBoton.Click += new System.EventHandler(this.BuscarCotBoton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "ID Cotizacion";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Producto";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(140, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Cantidad";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(264, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Precio";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(390, 98);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "Importe";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(430, 46);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 22;
            this.label7.Text = "Fecha";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(475, 312);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 13);
            this.label8.TabIndex = 23;
            this.label8.Text = "Total";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(11, 312);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 13);
            this.label9.TabIndex = 24;
            this.label9.Text = "Observaciones";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(459, 365);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(133, 78);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            // 
            // RegistroCotizaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BuscarCotBoton);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.NuevoBoton);
            this.Controls.Add(this.TotalNum);
            this.Controls.Add(this.ObservacionBox);
            this.Controls.Add(this.dataGridDetalle);
            this.Controls.Add(this.PersonaBox);
            this.Controls.Add(this.AgregarBoton);
            this.Controls.Add(this.ImporteBox);
            this.Controls.Add(this.PrecioBox);
            this.Controls.Add(this.CantidadBox);
            this.Controls.Add(this.ProductoBox);
            this.Controls.Add(this.FechaCotPicker);
            this.Controls.Add(this.CotizacionIDNum);
            this.Name = "RegistroCotizaciones";
            this.Text = "RegistroCotizaciones";
            ((System.ComponentModel.ISupportInitialize)(this.CotizacionIDNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDetalle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TotalNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown CotizacionIDNum;
        private System.Windows.Forms.DateTimePicker FechaCotPicker;
        private System.Windows.Forms.ComboBox ProductoBox;
        private System.Windows.Forms.TextBox CantidadBox;
        private System.Windows.Forms.TextBox PrecioBox;
        private System.Windows.Forms.TextBox ImporteBox;
        private System.Windows.Forms.Button AgregarBoton;
        private System.Windows.Forms.ComboBox PersonaBox;
        private System.Windows.Forms.DataGridView dataGridDetalle;
        private System.Windows.Forms.TextBox ObservacionBox;
        private System.Windows.Forms.NumericUpDown TotalNum;
        private System.Windows.Forms.Button NuevoBoton;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button BuscarCotBoton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}