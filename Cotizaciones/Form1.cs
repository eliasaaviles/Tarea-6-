using Cotizaciones.UI.RegistroPersonas;
using Cotizaciones.UI.Registro;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cotizaciones
{
    public partial class VentanaPrincipal : Form
    {
        public VentanaPrincipal()
        {
            InitializeComponent();
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistroPersonas registropersonas = new RegistroPersonas();
            registropersonas.Show();
        }

        private void articuloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistroProducto registroproducto = new RegistroProducto();
            registroproducto.Show();
        }

        private void cotizacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistroCotizaciones registro = new RegistroCotizaciones();
            
            registro.Show();
        }
    }
}

