using Ingenya.ApiCore;
using Ingenya.Entities;
using System;
using System.Collections;
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
    public partial class frm_BuscarCliente : Form
    {
        public Int32 id_Cliente;
        public string nombre_Cliente;

        public List<Cliente> lista;

        public ICliente cliente { get; set; }

        public frm_BuscarCliente()
        {
            InitializeComponent();

            MaximizeBox = false;

            MinimizeBox = false;

            CargarClientes();
        }

        private void CargarClientes()
        {
            ClienteManagement clienteManagement = new ClienteManagement();

            try
            {
                lista = (List<Cliente>)clienteManagement.RetrieveAllCliente();

                if (lista != null)
                {
                    dgv_Clientes.DataSource = lista;
                    dgv_Clientes.Refresh();

                    if (dgv_Clientes.Rows.Count > 0)
                    {
                        dgv_Clientes.Rows[0].Selected = true;
                    }
                }


            }
            catch (Exception)
            {
                MessageBox.Show("Hubo un error al listar los clientes");
            }
        }

        private void Dgv_Clientes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            id_Cliente = Int32.Parse(dgv_Clientes.SelectedRows[0].Cells[0].Value.ToString());

            nombre_Cliente = dgv_Clientes.SelectedRows[0].Cells[1].Value.ToString();

            cliente.BuscarCliente(nombre_Cliente, id_Cliente);

            this.Close();
        }

        private void Txt_Search_TextChanged(object sender, EventArgs e)
        {
            List<Cliente> items = new List<Cliente>();

            if (txt_Search.Text != string.Empty)
            {
                foreach (Cliente cli in lista)
                {
                    if (cli.Nombre.Contains(txt_Search.Text))
                    {
                        items.Add(cli);
                    }
                }

                dgv_Clientes.DataSource = items;
            }
            else
            {
                dgv_Clientes.DataSource = lista;
            }
        }
    }
}
