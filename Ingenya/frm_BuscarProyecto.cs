using Ingenya.ApiCore;
using Ingenya.Entities;
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
    public partial class frm_BuscarProyecto : Form
    {
        public Int32 id_Proyecto;
        public string nombre_Proyecto;

        List<Proyecto> lista;

        public IProyecto proyecto { get; set; }

        public frm_BuscarProyecto()
        {
            InitializeComponent();

            MaximizeBox = false;

            MinimizeBox = false;

            CargarProyectos();
        }

        private void CargarProyectos()
        {
            ProyectoManagement proyectoManagement = new ProyectoManagement();

            try
            {
                lista = (List<Proyecto>)proyectoManagement.RetrieveAllProyecto();

                if (lista != null)
                {
                    dgv_Proyectos.DataSource = lista;

                    dgv_Proyectos.Refresh();

                    if (dgv_Proyectos.Rows.Count > 0)
                    {
                        dgv_Proyectos.Rows[0].Selected = true;
                    }
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Hubo un error al listar los proyectos");
            }
        }

        private void Txt_Search_TextChanged(object sender, EventArgs e)
        {
            List<Proyecto> items = new List<Proyecto>();

            if (txt_Search.Text != string.Empty)
            {
                foreach (Proyecto pro in lista)
                {
                    if (pro.NombreProyecto.Contains(txt_Search.Text))
                    {
                        items.Add(pro);
                    }
                }

                dgv_Proyectos.DataSource = items;
            }
            else
            {
                dgv_Proyectos.DataSource = lista;
            }
        }

        private void Dgv_Proyectos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            id_Proyecto = Int32.Parse(dgv_Proyectos.SelectedRows[0].Cells[0].Value.ToString());

            nombre_Proyecto = dgv_Proyectos.SelectedRows[0].Cells[2].Value.ToString();

            proyecto.BuscarProyecto(nombre_Proyecto, id_Proyecto);

            this.Close();
        }
    }
}
