namespace Cotizaciones.UI.RegistroPersonas
{
    partial class RegistroPersonas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistroPersonas));
            this.IDNum = new System.Windows.Forms.NumericUpDown();
            this.NombreBox = new System.Windows.Forms.TextBox();
            this.ApellidoBox = new System.Windows.Forms.TextBox();
            this.DireccionBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.GuardarBoton = new System.Windows.Forms.Button();
            this.NuevoBoton = new System.Windows.Forms.Button();
            this.EliminarBoton = new System.Windows.Forms.Button();
            this.BuscarBoton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.IDNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // IDNum
            // 
            this.IDNum.Location = new System.Drawing.Point(61, 56);
            this.IDNum.Name = "IDNum";
            this.IDNum.Size = new System.Drawing.Size(50, 20);
            this.IDNum.TabIndex = 0;
            // 
            // NombreBox
            // 
            this.NombreBox.Location = new System.Drawing.Point(61, 94);
            this.NombreBox.Name = "NombreBox";
            this.NombreBox.Size = new System.Drawing.Size(150, 20);
            this.NombreBox.TabIndex = 2;
            // 
            // ApellidoBox
            // 
            this.ApellidoBox.Location = new System.Drawing.Point(61, 131);
            this.ApellidoBox.Name = "ApellidoBox";
            this.ApellidoBox.Size = new System.Drawing.Size(150, 20);
            this.ApellidoBox.TabIndex = 3;
            // 
            // DireccionBox
            // 
            this.DireccionBox.Location = new System.Drawing.Point(61, 169);
            this.DireccionBox.Name = "DireccionBox";
            this.DireccionBox.Size = new System.Drawing.Size(150, 20);
            this.DireccionBox.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Apellido";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Nombre";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 176);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Direccion";
            // 
            // GuardarBoton
            // 
            this.GuardarBoton.Location = new System.Drawing.Point(243, 135);
            this.GuardarBoton.Name = "GuardarBoton";
            this.GuardarBoton.Size = new System.Drawing.Size(75, 23);
            this.GuardarBoton.TabIndex = 10;
            this.GuardarBoton.Text = "Guardar";
            this.GuardarBoton.UseVisualStyleBackColor = true;
            this.GuardarBoton.Click += new System.EventHandler(this.GuardarBoton_Click);
            // 
            // NuevoBoton
            // 
            this.NuevoBoton.Location = new System.Drawing.Point(243, 94);
            this.NuevoBoton.Name = "NuevoBoton";
            this.NuevoBoton.Size = new System.Drawing.Size(75, 23);
            this.NuevoBoton.TabIndex = 11;
            this.NuevoBoton.Text = "Nuevo";
            this.NuevoBoton.UseVisualStyleBackColor = true;
            this.NuevoBoton.Click += new System.EventHandler(this.NuevoBoton_Click);
            // 
            // EliminarBoton
            // 
            this.EliminarBoton.Location = new System.Drawing.Point(243, 174);
            this.EliminarBoton.Name = "EliminarBoton";
            this.EliminarBoton.Size = new System.Drawing.Size(75, 23);
            this.EliminarBoton.TabIndex = 12;
            this.EliminarBoton.Text = "Eliminar";
            this.EliminarBoton.UseVisualStyleBackColor = true;
            this.EliminarBoton.Click += new System.EventHandler(this.EliminarBoton_Click);
            // 
            // BuscarBoton
            // 
            this.BuscarBoton.Location = new System.Drawing.Point(117, 53);
            this.BuscarBoton.Name = "BuscarBoton";
            this.BuscarBoton.Size = new System.Drawing.Size(56, 23);
            this.BuscarBoton.TabIndex = 13;
            this.BuscarBoton.Text = "Buscar";
            this.BuscarBoton.UseVisualStyleBackColor = true;
            this.BuscarBoton.Click += new System.EventHandler(this.BuscarBoton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(218, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // Personas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 213);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BuscarBoton);
            this.Controls.Add(this.EliminarBoton);
            this.Controls.Add(this.NuevoBoton);
            this.Controls.Add(this.GuardarBoton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DireccionBox);
            this.Controls.Add(this.ApellidoBox);
            this.Controls.Add(this.NombreBox);
            this.Controls.Add(this.IDNum);
            this.Name = "Personas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Personas";
            this.Load += new System.EventHandler(this.Personas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.IDNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown IDNum;
        private System.Windows.Forms.TextBox NombreBox;
        private System.Windows.Forms.TextBox ApellidoBox;
        private System.Windows.Forms.TextBox DireccionBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button GuardarBoton;
        private System.Windows.Forms.Button NuevoBoton;
        private System.Windows.Forms.Button EliminarBoton;
        private System.Windows.Forms.Button BuscarBoton;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}