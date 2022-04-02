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
    public partial class frm_Proyecto : Form , ICliente
    {
        private Int32 id_Cliente;

        private Utilities.Acciones AccionPantalla;

        private List<Proyecto> lista;

        private List<ProyectoInfo> listaGrid;

        public frm_Proyecto()
        {
            InitializeComponent();

            AccionPantalla = Utilities.Acciones.Listar;

            MaximizeBox = false;

            MinimizeBox = false;

            LlamarAcccion();

            CargarBotones();

            CargarModo();
        }

        public void BuscarCliente(string nombreCliente, int idCliente)
        {
            txt_Cliente.Text = nombreCliente;

            id_Cliente = idCliente;
        }

        private void Btn_BuscarCliente_Click(object sender, EventArgs e)
        {
            frm_BuscarCliente cliente = new frm_BuscarCliente
            {
                cliente = this
            };
            cliente.Show();
        }

        private bool ValidaCampos()
        {
            bool _return = true;

            if (txt_Nombre.Text.Equals(string.Empty))
            {
                MessageBox.Show("Favor ingresar el nombre del proyecto");
                _return = false;
            }

            if (txt_Cliente.Text.Equals(string.Empty))
            {
                MessageBox.Show("Favor buscar un cliente asociado al proyecto");
                _return = false;
            }

            return _return;

        }

        private void Btn_Insertar_Click(object sender, EventArgs e)
        {
            AccionPantalla = Utilities.Acciones.Insertar;

            CargarBotones();

            CargarModo();

            txt_IdProyecto.Text = BuscarId().ToString();
        }

        public int BuscarId()
        {
            int max = 0;
            if (lista != null)
            {
                foreach (var item in lista)
                {
                    if (item.IdProyecto > max)
                        max = item.IdProyecto;
                }
            }

            max++;

            return max;
        }

        private void Btn_Actualizar_Click(object sender, EventArgs e)
        {
            AccionPantalla = Utilities.Acciones.Modificar;

            CargarBotones();

            CargarModo();
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
            btn_BuscarCliente.Enabled = habilitar;
        }

        private void Btn_Aceptar_Click(object sender, EventArgs e)
        {
            if (ValidaCampos())
            {
                LlamarAcccion();

                AccionPantalla = Utilities.Acciones.Listar;

                LlamarAcccion();

                CargarModo();

                CargarBotones();

                this.ActiveControl = null;
            }
        }

        private void LlamarAcccion()
        {
            if (AccionPantalla == Utilities.Acciones.Insertar)
            {
                InsertarProyecto();
            }
            else if (AccionPantalla == Utilities.Acciones.Modificar)
            {
                ModificarProyecto();
            }
            else if (AccionPantalla == Utilities.Acciones.Eliminar)
            {
                EliminarProyecto();
            }
            else if (AccionPantalla == Utilities.Acciones.Cargar)
            {
                CargarProyecto();
            }
            else
            {
                ListarProyecto();
            }
        }

        private void InsertarProyecto()
        {
            Proyecto proyecto = new Proyecto
            {
                IdProyecto = Int32.Parse(txt_IdProyecto.Text),
                NombreProyecto = txt_Nombre.Text
            };

            Cliente cliente = new Cliente
            {
                IdCliente = id_Cliente
            };

            ClienteManagement clienteManagement = new ClienteManagement();

            try
            {
                cliente = clienteManagement.RetrieveClientebyId (cliente);
            }
            catch (Exception)
            {
                MessageBox.Show("Hubo un error al buscar el cliente");
            }

            proyecto.ObjClient = cliente;

            proyecto.Fecha = DateTime.Now;

            ProyectoManagement proyectoManagement = new ProyectoManagement();

            try
            {
                proyectoManagement.CreateProyecto(proyecto);

                MessageBox.Show("Se ingreso el proyecto correctamente");
            }
            catch (Exception)
            {
                MessageBox.Show("Hubo un error al ingresar proyecto el cliente");
            }
        }

        private void ModificarProyecto()
        {
            Proyecto proyecto = new Proyecto
            {
                IdProyecto = Int32.Parse(txt_IdProyecto.Text),
                NombreProyecto = txt_Nombre.Text
            };

            Cliente cliente = new Cliente
            {
                IdCliente = id_Cliente
            };

            ClienteManagement clienteManagement = new ClienteManagement();

            try
            {
                cliente = clienteManagement.RetrieveClientebyId(cliente);
            }
            catch (Exception)
            {
                MessageBox.Show("Hubo un error al buscar el cliente");
            }

            proyecto.ObjClient = cliente;

            proyecto.Fecha = DateTime.Parse(txt_Fecha.Text);

            ProyectoManagement proyectoManagement = new ProyectoManagement();

            try
            {
                proyectoManagement.UpdateProyecto(proyecto);

                MessageBox.Show("Se actualizo el proyecto correctamente");
            }
            catch (Exception)
            {
                MessageBox.Show("Hubo un error al actualizar proyecto el cliente");
            }
        }

        private void EliminarProyecto()
        {
            Proyecto proyecto = new Proyecto
            {
                IdProyecto = Int32.Parse(txt_IdProyecto.Text)
            };

            ProyectoManagement proyectoManagement = new ProyectoManagement();

            try
            {
                proyectoManagement.DeleteProyecto(proyecto);

                MessageBox.Show("Se elimino el proyecto correctamente");
            }
            catch (Exception)
            {
                MessageBox.Show("Hubo un error al eliminar proyecto el cliente");
            }
        }

        private void CargarProyecto()
        {
            if (dgv_ListaProyecto.DataSource != null)
            {
                txt_IdProyecto.Text = dgv_ListaProyecto.SelectedRows[0].Cells[0].Value.ToString();
                txt_Nombre.Text = dgv_ListaProyecto.SelectedRows[0].Cells[2].Value.ToString();
                txt_Cliente.Text = dgv_ListaProyecto.SelectedRows[0].Cells[1].Value.ToString();
                txt_Fecha.Text = dgv_ListaProyecto.SelectedRows[0].Cells[3].Value.ToString();
                //txt_Site.Text = dgv_ListaProyecto.SelectedRows[0].Cells[3].Value.ToString();
                //txt_Telefono.Text = dgv_ListaProyecto.SelectedRows[0].Cells[4].Value.ToString();
                //txt_Direccion.Text = dgv_ListaProyecto.SelectedRows[0].Cells[5].Value.ToString();
                //txt_Correo.Text = dgv_ListaProyecto.SelectedRows[0].Cells[6].Value.ToString();
            }
        }

        private void ListarProyecto()
        {
            ProyectoManagement proyectoManagement = new ProyectoManagement();

            try
            {
                lista = (List<Proyecto>)proyectoManagement.RetrieveAllProyecto();

                if (lista != null)
                {
                    GenerarListaGrid(lista);

                    if (lista.Count > 0)
                    {
                        dgv_ListaProyecto.DataSource = listaGrid;
                        dgv_ListaProyecto.Refresh();

                        dgv_ListaProyecto.Rows[0].Selected = true;

                        dgv_ListaProyecto.Enabled = true;

                        CargarProyecto();
                    }
                    else
                    {
                        dgv_ListaProyecto.DataSource = null;
                        dgv_ListaProyecto.Enabled = false;
                    }
                }
                else
                {
                    dgv_ListaProyecto.DataSource = null;
                    dgv_ListaProyecto.Enabled = false;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Hubo un error al listar los proyectos");
            }
        }

        public void GenerarListaGrid(List<Proyecto> lista)
        {
            listaGrid = new List<ProyectoInfo>();

            foreach (var item in lista)
            {
                ProyectoInfo proyec = new ProyectoInfo();

                ClienteManagement clienteManagement = new ClienteManagement();

                var cliente = clienteManagement.RetrieveClientebyId(item.ObjClient);

                proyec.IdProyecto = item.IdProyecto;
                proyec.NombreProyecto = item.NombreProyecto;
                proyec.nombreCliente = cliente.Nombre;
                proyec.Fecha = item.Fecha;

                listaGrid.Add(proyec);
            }

        }

        private void CargarBotones()
        {
            if (AccionPantalla == Utilities.Acciones.Insertar)
            {
                txt_IdProyecto.Text = string.Empty;
                txt_Nombre.Text = string.Empty;
                txt_Cliente.Text = string.Empty;
                txt_Fecha.Text = DateTime.Now.ToShortDateString();

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

        private void Btn_Cancelar_Click(object sender, EventArgs e)
        {
            AccionPantalla = Utilities.Acciones.Listar;

            CargarProyecto();

            CargarBotones();
        }

        private void Dgv_ListaProyecto_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            CargarProyecto();
        }

        public class ProyectoInfo
        {
            public int IdProyecto { get; set; }
            public string nombreCliente { get; set; }
            public string NombreProyecto { get; set; }
            public DateTime Fecha { get; set; }

        }
    }
}
