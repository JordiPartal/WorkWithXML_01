using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FicherosXML_Partal_Jordi
{
    public partial class FrmMenuPrincipal : Form
    {
        public FrmMenuPrincipal()
        {
            InitializeComponent();
        }

        private void OnClickPanelSeleccionado(object sender,  EventArgs evento)
        {
            Planeta.FrmPlaneta Planetas = new Planeta.FrmPlaneta();
            Panel Seleccion = ((Panel)sender);
            
            if (Seleccion.Tag.ToString() == "Planeta")
            {
                this.Hide();
                Planetas.Show();
            }
            else
            {
                MessageBox.Show("Estamos trabajando en ello");
            }
        }
    }
}
