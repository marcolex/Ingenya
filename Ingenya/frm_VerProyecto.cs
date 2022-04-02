using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ingenya
{
    public partial class frm_VerProyecto : Form , IProyecto
    {
        Int32 id_Proyecto;
        public frm_VerProyecto()
        {
            InitializeComponent();
        }

        public void BuscarProyecto(string nombreProyecto, Int32 idProyecto)
        {
            txt_Proyecto.Text = nombreProyecto;

            id_Proyecto = idProyecto;
        }

        private void Btn_Buscar_Click(object sender, EventArgs e)
        {
            frm_BuscarProyecto proyecto = new frm_BuscarProyecto
            {
                proyecto = this
            };
            proyecto.Show();
        }
    }
}
