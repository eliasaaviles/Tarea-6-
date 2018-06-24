using Cotizaciones.DAL;
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
    public partial class RegistroCotizaciones : Form
    {
        public RegistroCotizaciones()
        {
            InitializeComponent();
        }

        private void BuscarCotBoton_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(CotizacionIDNum.Value);
            Cotizacioness Cotizacion = BLL.CotizacionesBLL.Buscar(id);

            if (Cotizacion != null)
            {
                LlenarCampos(Cotizacion);
            }
            else
                MessageBox.Show("No se encontro!", "Fallo",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<DetalleCotizaciones> detalle = new List<DetalleCotizaciones>();

            if (dataGridDetalle.DataSource != null)
            {
                detalle = (List<DetalleCotizaciones>)dataGridDetalle.DataSource;
            }


            detalle.Add(
                new DetalleCotizaciones(
                    id: 0,
                    cotizacioId: (int)CotizacionIDNum.Value,
                    personaId: (int)PersonaBox.SelectedValue,
                    articuloId: (int)ProductoBox.SelectedValue,
                    cantidad: (int)Convert.ToInt32(CantidadBox.Text),
                    precio: (int)Convert.ToInt32(PrecioBox.Text),
                    importe: (int)Convert.ToInt32(ImporteBox.Text)

                ));


            dataGridDetalle.DataSource = null;
            dataGridDetalle.DataSource = detalle;


        }

        private void button2_Click(object sender, EventArgs e)
        {
            CotizacionIDNum.Value = 0;
            FechaCotPicker.Value = DateTime.Now;
            ObservacionBox.Clear();
            CantidadBox.Clear();
            PrecioBox.Clear();
            ImporteBox.Clear();
            TotalNum.Value = 0;

            dataGridDetalle.DataSource = null;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Cotizacioness cotizacion;
            bool Paso = false;

            cotizacion = LlenaClase();


            if (CotizacionIDNum.Value == 0)
                Paso = BLL.CotizacionesBLL.Guardar(cotizacion);
            else

                Paso = BLL.CotizacionesBLL.Modificar(cotizacion);


            if (Paso)
            {
                NuevoBoton.PerformClick();
                MessageBox.Show("Guardado!!", "Exito",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("No se pudo guardar!!", "Fallo",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(CotizacionIDNum.Value);

            if (BLL.CotizacionesBLL.Eliminar(id))
                MessageBox.Show("Eliminado!!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("No se pudo eliminar!!", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void LlenarComboBox()
        {
            Repositorio<Personas> repositorio = new Repositorio<Personas>(new Contexto());
            Repositorio<Articulos> repositori = new Repositorio<Articulos>(new Contexto());
            PersonaBox.DataSource = repositorio.GetList(c => true);
            PersonaBox.ValueMember = "PersonaId";
            PersonaBox.DisplayMember = "Nombres";

            ProductoBox.DataSource = repositori.GetList(c => true);
            ProductoBox.ValueMember = "ArticuloId";
            ProductoBox.DisplayMember = "Descripcion";
        }
        private Cotizacioness LlenaClase()
        {
            Cotizacioness cotizacion = new Cotizacioness();

            cotizacion.CotizacionId = Convert.ToInt32(CotizacionIDNum.Value);
            cotizacion.Fecha = FechaCotPicker.Text;
            cotizacion.Comentario = ObservacionBox.Text;


            foreach (DataGridViewRow item in dataGridDetalle.Rows)
            {
                cotizacion.AgregarDetalle(
                    ToInt(item.Cells["id"].Value),
                    ToInt(item.Cells["CotizacionId"].Value),
                    ToInt(item.Cells["PersonaId"].Value),
                    ToInt(item.Cells["ArticuloId"].Value),
                    ToInt(item.Cells["Cantidad"].Value),
                   ToInt(item.Cells["Precio"].Value),
                    ToInt(item.Cells["Importe"].Value)
                  );
            }
            return cotizacion;
        }
        private int ToInt(object valor)
        {
            int retorno = 0;

            int.TryParse(valor.ToString(), out retorno);

            return retorno;
        }
        private void LlenarCampos(Cotizacioness cotizacion)
        {
            CotizacionIDNum.Value = cotizacion.CotizacionId;
            FechaCotPicker.Text = cotizacion.Fecha;
            ObservacionBox.Text = cotizacion.Comentario;


            dataGridDetalle.DataSource = cotizacion.Detalle;


            dataGridDetalle.Columns["Id"].Visible = false;
            dataGridDetalle.Columns["CotizacionId"].Visible = false;
        }

        private void PrecioBox_TextChanged(object sender, EventArgs e)
        {

            if (Convert.ToInt32(PrecioBox.Text) != 0)
            {

                TotalNum.Value += Convert.ToInt32(PrecioBox.Text);

            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
