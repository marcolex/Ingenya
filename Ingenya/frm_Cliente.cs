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
    public partial class frm_Cliente : Form
    {
        private Utilities.Acciones AccionPantalla;

        List<Cliente> lista;
        public frm_Cliente()
        {
            InitializeComponent();

            AccionPantalla = Utilities.Acciones.Listar;

            MaximizeBox = false;

            MinimizeBox = false;

            LlamarAcccion();

            CargarBotones();

            CargarModo();
        }

        private void Btn_Actualizar_Click(object sender, EventArgs e)
        {
            AccionPantalla = Utilities.Acciones.Modificar;

            CargarBotones();

            CargarModo();
        }

        private void Txt_Telefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            //We only want to allow numeric style chars
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                //Setting e.Handled cancels the keypress event, so the key is not entered
                e.Handled = true;
            }

            // we only allow one decimal point here
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private bool ValidaCampos()
        {
            bool _return = true;

            if (txt_Nombre.Text.Equals(string.Empty))
            {
                MessageBox.Show("Favor ingresar el nombre del cliente");
                _return = false;
            }


            if (!txt_Correo.Text.Equals(string.Empty))
            {
                if (!txt_Correo.Text.Contains("@"))
                {
                    MessageBox.Show("Favor ingresar un email correcto");
                    _return = false;
                }
            }

            return _return;

        }

        private void Btn_Insertar_Click(object sender, EventArgs e)
        {
            AccionPantalla = Utilities.Acciones.Insertar;

            CargarBotones();

            CargarModo();

            txt_IdCliente.Text = BuscarId().ToString();

        }

        public int BuscarId()
        {
            int max = 0;
            if (lista != null)
            {
                foreach (var item in lista)
                {
                    if (item.IdCliente > max)
                        max = item.IdCliente;
                }
            }

            max++;

            return max;
        }

        private void Btn_Eliminar_Click(object sender, EventArgs e)
        {
            AccionPantalla = Utilities.Acciones.Eliminar;

            CargarBotones();

            CargarModo();
        }

        public void CargarModo()
        {
            if (AccionPantalla == Utilities.Acciones.Insertar || AccionPantalla == Utilities.Acciones.Modificar)
            {
                HabilitarBotones(true);
            }
            else
            {
                HabilitarBotones(false);
            }
        }

        public void HabilitarBotones(bool habilitar)
        {
            txt_Nombre.Enabled = habilitar;
            txt_Site.Enabled = habilitar;
            txt_Telefono.Enabled = habilitar;
            txt_Direccion.Enabled = habilitar;
            txt_Correo.Enabled = habilitar;
        }

        private void Btn_Aceptar_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            if (ValidaCampos())
            {
                LlamarAcccion();

                AccionPantalla = Utilities.Acciones.Listar;

                LlamarAcccion();

                CargarModo();

                CargarBotones();

                this.ActiveControl = null;
            }

            Cursor.Current = Cursors.Default;
        }

        private void LlamarAcccion()
        {
            if (AccionPantalla == Utilities.Acciones.Insertar)
            {
                InsertarCliente();
            }
            else if (AccionPantalla == Utilities.Acciones.Modificar)
            {
                ModificarCliente();
            }
            else if (AccionPantalla == Utilities.Acciones.Eliminar)
            {
                EliminarCliente();
            }
            else if (AccionPantalla == Utilities.Acciones.Cargar)
            {
                CargarCliente();
            }
            else
            {
                ListarCliente();
            }
        }

        private void InsertarCliente()
        {
            Cliente cliente = new Cliente
            {
                IdCliente = Int32.Parse(txt_IdCliente.Text),
                Nombre = txt_Nombre.Text,
                Site = txt_Site.Text,
                Telefono = txt_Telefono.Text,
                Direccion = txt_Direccion.Text,
                CorreoContacto = txt_Correo.Text
            };

            ClienteManagement clienteManagement = new ClienteManagement();

            try
            {
                clienteManagement.CreateCliente(cliente);

                MessageBox.Show("Se ingreso el cliente correctamente");
            }
            catch (Exception)
            {
                MessageBox.Show("Hubo un error al ingresar el cliente");
            }
        }

        private void ModificarCliente()
        {
            Cliente cliente = new Cliente
            {
                IdCliente = Int32.Parse(txt_IdCliente.Text),
                Nombre = txt_Nombre.Text,
                Site = txt_Site.Text,
                Telefono = txt_Telefono.Text,
                Direccion = txt_Direccion.Text,
                CorreoContacto = txt_Correo.Text
            };

            ClienteManagement clienteManagement = new ClienteManagement();

                try
                {
                    clienteManagement.UpdateCliente(cliente);

                    MessageBox.Show("Se actualizo el cliente correctamente");
                }
                catch (Exception)
                {
                    MessageBox.Show("Hubo un error al actualizar el cliente");
                }
        }

        private void EliminarCliente()
        {

            Cliente cliente = new Cliente
            {
                IdCliente = Int32.Parse(txt_IdCliente.Text)
            };

            ClienteManagement clienteManagement = new ClienteManagement();

            try
            {
                clienteManagement.DeleteCliente(cliente);

                MessageBox.Show("Se elimino el cliente correctamente");
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("FOREIGN KEY"))
                {
                   MessageBox.Show("No se puede eliminar un cliente que tiene proyectos asociados");

                    AccionPantalla = Utilities.Acciones.Listar;

                    CargarBotones();
                }
                else
                {
                  MessageBox.Show("Hubo un error al eliminar el cliente");
                }
                
            }
        }

        private void CargarCliente()
        {
            txt_IdCliente.Text = dgv_ListaCliente.SelectedRows[0].Cells[0].Value.ToString();
            txt_Nombre.Text = dgv_ListaCliente.SelectedRows[0].Cells[1].Value.ToString();
            txt_Site.Text = dgv_ListaCliente.SelectedRows[0].Cells[2].Value.ToString();
            txt_Telefono.Text = dgv_ListaCliente.SelectedRows[0].Cells[3].Value.ToString();
            txt_Direccion.Text = dgv_ListaCliente.SelectedRows[0].Cells[4].Value.ToString();
            txt_Correo.Text = dgv_ListaCliente.SelectedRows[0].Cells[5].Value.ToString();
        }


        private void ListarCliente()
        {
            ClienteManagement clienteManagement = new ClienteManagement();

            try
            {
                lista = (List<Cliente>)clienteManagement.RetrieveAllCliente();

                if (lista != null)
                {
                    if (lista.Count > 0)
                    {
                        dgv_ListaCliente.DataSource = lista;
                        dgv_ListaCliente.Refresh();

                        dgv_ListaCliente.Rows[0].Selected = true;

                        dgv_ListaCliente.Enabled = true;

                        CargarCliente();
                    }
                    else
                    {
                        dgv_ListaCliente.DataSource = null;
                        dgv_ListaCliente.Enabled = false;
                    }
                }
                else
                {
                    dgv_ListaCliente.DataSource = null;
                    dgv_ListaCliente.Enabled = false;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Hubo un error al listar los clientes");
            }
        }

        private void CargarBotones()
        {
            if (AccionPantalla == Utilities.Acciones.Insertar)
            {
                txt_IdCliente.Text = string.Empty;
                txt_Nombre.Text = string.Empty;
                txt_Site.Text = string.Empty;
                txt_Direccion.Text = string.Empty;
                txt_Telefono.Text = string.Empty;
                txt_Correo.Text = string.Empty;

                btn_Insertar.BackColor = Color.Green;

                btn_Actualizar.Enabled = false;
                btn_Eliminar.Enabled = false;

                btn_Aceptar.Enabled = true;
                btn_Cancelar.Enabled = true;
            }
            else if (AccionPantalla == Utilities.Acciones.Modificar)
            {
                btn_Actualizar.BackColor = Color.SkyBlue;

                btn_Insertar.Enabled = false;
                btn_Eliminar.Enabled = false;

                btn_Aceptar.Enabled = true;
                btn_Cancelar.Enabled = true;
            }
            else if (AccionPantalla == Utilities.Acciones.Eliminar)
            {
                btn_Eliminar.BackColor = Color.LightCoral;

                btn_Insertar.Enabled = false;
                btn_Actualizar.Enabled = false;

                btn_Aceptar.Enabled = true;
                btn_Cancelar.Enabled = true;
            }
            else
            {
                txt_Nombre.Enabled = false;
                txt_Site.Enabled = false;
                txt_Direccion.Enabled = false;
                txt_Telefono.Enabled = false;
                txt_Correo.Enabled = false;

                btn_Insertar.BackColor = SystemColors.Control;
                btn_Actualizar.BackColor = SystemColors.Control;
                btn_Eliminar.BackColor = SystemColors.Control;

                if (lista != null)
                {
                    btn_Insertar.Enabled = true;
                    btn_Actualizar.Enabled = true;
                    btn_Eliminar.Enabled = true;
                }
                else
                {
                    btn_Insertar.Enabled = true;
                }

                btn_Aceptar.Enabled = false;
                btn_Cancelar.Enabled = false;
            }
        }

        private void Dgv_ListaCliente_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            CargarCliente();
        }

        private void Btn_Cancelar_Click(object sender, EventArgs e)
        {
            AccionPantalla = Utilities.Acciones.Listar;

            CargarCliente();

            CargarBotones();
        }
    }
}
