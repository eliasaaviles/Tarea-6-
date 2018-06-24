using Cotizaciones.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cotizaciones.UI.Registro
{
    public partial class RegistroProducto : Form
    {
        public RegistroProducto()
        {
            InitializeComponent();
        }

        private void BuscarProdBoton_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(IDProdNum.Value);
            Articulos articulo = BLL.ArticuloBLL.Buscar(id);

            if (articulo != null)
            {

                DescripcionBox.Text = articulo.Descripcion;
                PrecioNum.Value = articulo.Precio;
                FechaVenPicker.Text = articulo.FechaVencimiento.ToString();
                CantidadNum.Value = articulo.CantidadCotizada;

            }
            else
                MessageBox.Show("No se encontro", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void GuardarProdBoton_Click(object sender, EventArgs e)
        {
            bool paso = false;



            if (IDProdNum.Value == 0)
                paso = BLL.ArticuloBLL.Guardar(LlenarClase());
            else
                paso = BLL.ArticuloBLL.Modificar(LlenarClase());

            //Informar el resultado
            if (paso)

                MessageBox.Show("Guardado", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("No se pudo guardar", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
            private Articulos LlenarClase()
            {

                Articulos producto = new Articulos();

                producto.ArticuloId = Convert.ToInt32(IDProdNum.Value);
                producto.Descripcion = DescripcionProdBox.Text;
            producto.FechaVencimiento = FechaVenPicker.Value;
            producto.Precio = Convert.ToInt32(PrecioNum.Value);
                producto.CantidadCotizada = Convert.ToInt32(CantidadNum.Text);

                return producto;
            }

        private void RegistroProducto_Load(object sender, EventArgs e)
        {

        }

        private void NuevoProdBoton_Click(object sender, EventArgs e)
        {
            IDProdNum.Value = 0;
            DescripcionBox.Clear();
            PrecioNum.Value = 0;
            CantidadNum.Value=0;
        }

        private void EliminarProdBoton_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(IDProdNum.Value);

            if (BLL.ArticuloBLL.Eliminar(id))
                MessageBox.Show("Eliminado", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("No se pudo eliminar", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void PrecioNum_ValueChanged(object sender, EventArgs e)
        {

        }
    }
    }


