using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PPAI_V3.Interfaz
{
    public partial class PantallaGestionRegistroResultadoRevisionManual : Form
    {
        
        
        
        
        public PantallaGestionRegistroResultadoRevisionManual()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            habilitarVentana();
        }
        private void habilitarVentana()
        {
            this.Enabled = true;
        }

        private void PantallaGestionRegistroResultadoRevisionManual_Load(object sender, EventArgs e)
        {

        }
    }
}
