using Cotizaciones.Entidades;
using Cotizaciones.UI.RegistroPersonas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Cotizaciones.UI.RegistroPersonas
{
    public partial class RegistroPersonas : Form
    {
      

        public RegistroPersonas()
        {
            InitializeComponent();
        }
       public  Personas LlenaClase()
        {
            Personas personas = new Personas
            {
                PersonaId = Convert.ToInt32(IDNum.Value),
                Nombre = NombreBox.Text,
                Apellido = ApellidoBox.Text,
                Direccion = DireccionBox.Text
            };

            return personas;
        }



        private void BuscarBoton_Click(object sender, EventArgs e)
        {
            int ID = Convert.ToInt32(IDNum.Value);
            Personas personas = BLL.PersonaBLL.Buscar(ID);

            if (personas != null)
            {
               
                NombreBox.Text = personas.Nombre;
                ApellidoBox.Text = personas.Apellido;
                DireccionBox.Text = personas.Direccion;
                }
            else
                MessageBox.Show("No encontrado","Intente de nuevo",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void NuevoBoton_Click(object sender, EventArgs e)
        {
            IDNum.Value = 0;
            NombreBox.Clear();
            ApellidoBox.Clear();
            DireccionBox.Clear();
          }

        private void GuardarBoton_Click(object sender, EventArgs e)
        {

            Personas personas;
            bool Paso = false;


            personas = LlenaClase();

             if (IDNum.Value == 0)
                Paso = BLL.PersonaBLL.Guardar(personas);
            else

                Paso = BLL.PersonaBLL.Modificar(personas);

            //Informar el resultado
            if (Paso)
                MessageBox.Show("Guardado!!", "",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("No se pudo guardar!!", "",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void Personas_Load(object sender, EventArgs e)
        {

        }

        private void EliminarBoton_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(IDNum.Value);


            if (BLL.PersonaBLL.Eliminar(id))
                MessageBox.Show("Eliminado!!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("No se pudo eliminar!!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        
      
    }
}
    


