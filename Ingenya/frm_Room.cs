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
    public partial class frm_Room : Form , IProyecto
    {
        public Int32 id_Proyecto;

        public Proyecto proyecto;

        private Utilities.Acciones AccionPantalla;

        private List<ProyectoRoom> lista;

        private List<Room> listaGrid;

        double Count;

        int numero;

        public frm_Room()
        {
            InitializeComponent();

            AccionPantalla = Utilities.Acciones.Listar;

            MaximizeBox = false;

            MinimizeBox = false;

            CargarBotones();

            CargarModo();
        }

        public void BuscarProyecto(string nombreProyecto, int idProyecto)
        {
            Cursor.Current = Cursors.WaitCursor;

            txt_Proyecto.Text = nombreProyecto;

            id_Proyecto = idProyecto;

            ProyectoManagement proyectoManagement = new ProyectoManagement();

            proyecto = new Proyecto
            {
                IdProyecto = idProyecto
            };

            try
            {
                proyecto = proyectoManagement.RetrieveProyecto(proyecto);
            }
            catch (Exception)
            {
                MessageBox.Show("Hubo un error al cargar la informacion del proyecto");
            }


            LlamarAcccion();

            CargarBotones();

            CargarModo();

            Cursor.Current = Cursors.Default;
        }

        private void Txt_Buscar_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            frm_BuscarProyecto proyecto = new frm_BuscarProyecto
            {
                proyecto = this
            };
            Cursor.Current = Cursors.Default;
            proyecto.Show();
        }

        private bool ValidaCampos()
        {
            bool _return = true;

            if (txt_Nombre.Text.Equals(string.Empty))
            {
                MessageBox.Show("Favor ingresar el nombre del room");
                _return = false;
            }

            return _return;

        }

        private void Btn_Insertar_Click(object sender, EventArgs e)
        {
            AccionPantalla = Utilities.Acciones.Insertar;

            CargarBotones();

            CargarModo();

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
                InsertarRoom();
            }
            else if (AccionPantalla == Utilities.Acciones.Modificar)
            {
                ModificarRoom();
            }
            else if (AccionPantalla == Utilities.Acciones.Eliminar)
            {
                EliminarRoom();
            }
            else if (AccionPantalla == Utilities.Acciones.Cargar)
            {
                CargarRoom();
            }
            else
            {
                ListarRoom();
            }
        }

        private void InsertarRoom()
        {
            btn_Aceptar.Enabled = false;
            btn_Cancelar.Enabled = false;

            Cursor.Current = Cursors.WaitCursor;

            Count = 0;
            Room room = new Room
            {
                Nombre = txt_Nombre.Text
            };
            RoomManagement roomManagement = new RoomManagement();
            try
            {
                //room = roomManagement.RCreateRoom(room);

                roomManagement.CreateRoom(room);
            }
            catch (Exception)
            {
                MessageBox.Show("Hubo un error al ingresar el room");
            }

            List<Room> lista = (List<Room>)roomManagement.RetrieveAllRoom();

            room = lista.Last();

            ProyectoRoom proyectoRoom = new ProyectoRoom
            {
                ObjRoom = room,
                ObjProyecto = proyecto,
                ObjCartaPsicometrica = new CartaPsicometrica(),
                ObjConcentracionParticula = new ConcentracionParticula(),
                ObjGraficoNivelActividad = new GraficoNivelActividad(),
                ObjGraNivActCalorLatente = new GraNivActCalorLatente(),
                ObjProcesoCartaPsicometrica = new ProcesoCartaPsicometrica(),
                ObjProvedor = new Provedor()
            };

            ProyectoRoomManagement proyectoRoomManagement = new ProyectoRoomManagement();

            try
            {
                //proyectoRoom = proyectoRoomManagement.RCreateProyectoRoom(proyectoRoom);

                proyectoRoomManagement.CreateProyectoRoom(proyectoRoom);

                List<ProyectoRoom> listaPR = (List<ProyectoRoom>)proyectoRoomManagement.RetrieveAllProyectoRoom();

                proyectoRoom = listaPR.Last();
            }
            catch (Exception)
            {
                MessageBox.Show("Hubo un error al ingresar el room del proyecto " + txt_Proyecto.Text);
            }

            proyectoRoom = BuscarProyectoRoom(proyectoRoom);

            numero = 0;

            CrearEstructuraProyectoRoom(proyectoRoom);

            CreacionConcentracionParticula(proyectoRoom);

            CreacionFuga(proyectoRoom);

            progressBar.Value = progressBar.Maximum;

            lbl_Percentage.Text = "100%";

            Cursor.Current = Cursors.Default;

            MessageBox.Show("Se ingreso el room del proyecto " + txt_Proyecto.Text + " correctamente");

            lbl_Percentage.Text = "0%";
        }

        private ProyectoRoom BuscarProyectoRoom(ProyectoRoom proyectoRoom)
        {
            ProyectoRoomManagement proyectoRoomManagement = new ProyectoRoomManagement();

            ProyectoRoom proyectoRoom2 = new ProyectoRoom();

            Proyecto proyecto = new Proyecto
            {
                IdProyecto = id_Proyecto
            };

            proyectoRoom2.ObjProyecto = proyecto;

            try
            {
                lista = (List<ProyectoRoom>)proyectoRoomManagement.RetrieveProyectoRoomXProyecto(proyectoRoom2);

                proyectoRoom = lista.Last();
            }
            catch (Exception)
            {
                throw;
            }

            return proyectoRoom;
        }

        private void CrearEstructuraProyectoRoom(ProyectoRoom proyectoRoom)
        {
            List<NombreParametro> listaNombreParametros;

            NombreParametroManagement nombreParametroManagement = new NombreParametroManagement();

            Parametro parametro;

            ProyectoParametroManagement proyectoParametroManagement;

            ProyectoParametro proyectoParametro;

            try
            {
                listaNombreParametros = (List<NombreParametro>)nombreParametroManagement.RetrieveAllNombreParametro();
            }
            catch (Exception)
            {
                throw;
            }

            List<Parametro> listaParametros;

            ParametroManagement parametroManagement = new ParametroManagement();

            try
            {
                listaParametros = (List<Parametro>)parametroManagement.RetrieveAllParametro();
            }
            catch (Exception)
            {
                throw;
            }

            foreach (var item in listaNombreParametros)
            {
                //parametroManagement = new ParametroManagement();

                //

                //parametro.ObjNombreParametro = item;
                //parametro.Valor = 1;
                //parametro.Fecha = DateTime.Now;

                //try
                //{
                //    parametro = parametroManagement.RCreateParametro(parametro);
                //}
                //catch (Exception ex)
                //{
                //    throw;
                //}

                parametro = new Parametro
                {
                    IdParametro = item.IdNombreParametro
                };

                proyectoParametroManagement = new ProyectoParametroManagement();

                proyectoParametro = new ProyectoParametro
                {
                    ObjParametro = parametro
                };

                var par = listaParametros.Where(x => x.IdParametro == parametro.IdParametro).First();
               
                proyectoParametro.Valor = par.Valor;

                proyectoParametro.ObjProyectoRoom = proyectoRoom;

                try
                {
                    proyectoParametroManagement.CreateProyectoParametro(proyectoParametro);
                }
                catch (Exception)
                {
                    throw;
                }



                if (numero != Math.Truncate(Count))
                {
                    numero = Int32.Parse(Math.Truncate(Count).ToString());

                    lbl_Percentage.Text = numero + "%";
                    lbl_Percentage.Refresh();

                    progressBar.Increment(1);
                }

                Count += 0.37;
            }


        }

        private void CreacionConcentracionParticula(ProyectoRoom proyectoRoom)
        {

            ConcentracionParticulaManagement concentracionParticulaManagement = new ConcentracionParticulaManagement();

            ConcentracionParticula concentracionParticula;

            Int32 count = 0;
            while (count < 20)
            {
                concentracionParticula = new ConcentracionParticula
                {
                    ObjProyectoRoom = proyectoRoom,
                    Tiempo = (count < 10) ? "00:0" + count : "00:" + count,
                    ConceIncome = 1,
                    ConcenPartiFin = 1,
                    ConcenPartiGen = 1,
                    ConcenPartiIni = 1,
                    PartiFin = 1,
                    PartiIni = 1,
                    PartiRetorna = 1
                };

                try
                {
                    concentracionParticulaManagement.CreateConcentracionParticula(concentracionParticula);
                }
                catch (Exception)
                {
                    throw;
                }


                if (numero != Math.Truncate(Count))
                {
                    numero = Int32.Parse(Math.Truncate(Count).ToString());

                    progressBar.Increment(1);
                }

                Count += 0.4;

                count++;
            }
        }


        private void CreacionFuga(ProyectoRoom proyectoRoom)
        {

            FugaManagement fugaManagement = new FugaManagement();

            Fuga fuga;

            NombreParametro nombreParametro;

            List<Int32> lista = new List<int> { 88, 89, 90, 91, 92, 93, 94, 95, 96, 97, 98 };

            Int32 count = 0;
            while (count<11)
            {
                fuga = new Fuga();

                nombreParametro = new NombreParametro
                {
                    IdNombreParametro = lista[count]
                };

                fuga.ObjProyectoRoom = proyectoRoom;
                fuga.ObjNombreParametro = nombreParametro;
                fuga.Factor = 1;
                fuga.Area = 0;
                fuga.Cantidad = 0;
                fuga.Flow = 0;
                try
                {
                    fugaManagement.CreateFuga(fuga);
                }
                catch (Exception)
                {
                    throw;
                }

                count++;
            }

            //ConcentracionParticulaManagement concentracionParticulaManagement = new ConcentracionParticulaManagement();

            //ConcentracionParticula concentracionParticula;

            //Int32 count = 0;
            //while (count < 20)
            //{
            //    concentracionParticula = new ConcentracionParticula();

            //    concentracionParticula.ObjProyectoRoom = proyectoRoom;
            //    concentracionParticula.Tiempo = (count < 10) ? "00:0" + count : "00:" + count;

            //    try
            //    {
            //        concentracionParticulaManagement.CreateConcentracionParticula(concentracionParticula);
            //    }
            //    catch (Exception)
            //    {
            //        throw;
            //    }


            //    if (numero != Math.Truncate(Count))
            //    {
            //        numero = Int32.Parse(Math.Truncate(Count).ToString());

            //        progressBar.Increment(1);
            //    }

            //    Count += 0.4;

            //    count++;
            //}
        }

        private void ModificarRoom()
        {
            Room room = new Room
            {
                IdRoom = Int32.Parse(txt_IdRoom.Text),
                Nombre = txt_Nombre.Text
            };
            RoomManagement roomManagement = new RoomManagement();

            try
            {
                roomManagement.UpdateRoom(room);

                MessageBox.Show("Se actualizo el room correctamente");
            }
            catch (Exception)
            {
                MessageBox.Show("Hubo un error al actualizar el room");
            }
        }

        private void EliminarRoom()
        {
            Room room = new Room
            {
                IdRoom = Int32.Parse(txt_IdRoom.Text)
            };
            RoomManagement roomManagement = new RoomManagement();

            try
            {
                roomManagement.DeleteRoom(room);

                MessageBox.Show("Se elimino el room correctamente");
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("FOREIGN KEY"))
                {
                    MessageBox.Show("No se puede eliminar un room que tiene parametros asociados");

                    AccionPantalla = Utilities.Acciones.Listar;

                    CargarBotones();
                }
                else
                {
                    MessageBox.Show("Hubo un error al actualizar el room");
                }

            }
        }

        private void ListarRoom()
        {
            ProyectoRoomManagement proyectoRoomManagement = new ProyectoRoomManagement();

            ProyectoRoom proyectoRoom = new ProyectoRoom();

            Proyecto proyecto = new Proyecto
            {
                IdProyecto = id_Proyecto
            };

            proyectoRoom.ObjProyecto = proyecto;  

            try
            {
                lista = (List<ProyectoRoom>)proyectoRoomManagement.RetrieveProyectoRoomXProyecto(proyectoRoom);

                if (lista != null)
                {
                    GenerarListaGrid(lista);

                    if (lista.Count > 0)
                    {
                        dgv_Rooms.DataSource = listaGrid;
                        dgv_Rooms.Refresh();

                        dgv_Rooms.Rows[0].Selected = true;

                        dgv_Rooms.Enabled = true;

                        lblRooms.Text = string.Empty;

                        CargarRoom();                       
                    }
                    else
                    {
                        dgv_Rooms.DataSource = null;

                        dgv_Rooms.Enabled = false;

                    }
                }
                else
                {
                    dgv_Rooms.DataSource = null;

                    dgv_Rooms.Enabled = false;

                    lblRooms.Text = "No existen rooms para este proyecto";
                }

                CargarBotones();
            }
            catch (Exception msg)
            {
                MessageBox.Show("Hubo un error al listar los rooms");
            }
        }

        public void GenerarListaGrid(List<ProyectoRoom> lista)
        {
            listaGrid = new List<Room>();

            foreach (var item in lista)
            {
                Room room = new Room();

                RoomManagement roomManagement = new RoomManagement();

                var varRoom = roomManagement.RetrieveRoom(item.ObjRoom);

                room.IdRoom = varRoom.IdRoom;
                room.Nombre = varRoom.Nombre;

                listaGrid.Add(room);
            }
        }


        private void CargarRoom()
        {
            if (dgv_Rooms.DataSource != null)
            {
                txt_IdRoom.Text = dgv_Rooms.SelectedRows[0].Cells[0].Value.ToString();
                txt_Nombre.Text = dgv_Rooms.SelectedRows[0].Cells[1].Value.ToString();
                //txt_Site.Text = dgv_ListaProyecto.SelectedRows[0].Cells[3].Value.ToString();
                //txt_Telefono.Text = dgv_ListaProyecto.SelectedRows[0].Cells[4].Value.ToString();
                //txt_Direccion.Text = dgv_ListaProyecto.SelectedRows[0].Cells[5].Value.ToString();
                //txt_Correo.Text = dgv_ListaProyecto.SelectedRows[0].Cells[6].Value.ToString();
            }
        }

        private void CargarBotones()
        {
            progressBar.Value = 0;

            if (AccionPantalla == Utilities.Acciones.Insertar)
            {
                txt_IdRoom.Text = string.Empty;
                txt_Nombre.Text = string.Empty;

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
                btn_Insertar.BackColor = SystemColors.Control;
                btn_Actualizar.BackColor = SystemColors.Control;
                btn_Eliminar.BackColor = SystemColors.Control;

                if (!txt_Proyecto.Text.Equals(string.Empty))
                {
                    btn_Insertar.Enabled = true;

                    if (lista != null)
                    {
                        btn_Actualizar.Enabled = true;
                        btn_Eliminar.Enabled = true;
                    }
                }
                else
                {
                    if (lista != null)
                    {
                        if (lista.Count > 0)
                        {
                            btn_Insertar.Enabled = true;
                            btn_Actualizar.Enabled = true;
                            btn_Eliminar.Enabled = true;
                        }
                        else
                        {
                            btn_Insertar.Enabled = true;
                            btn_Actualizar.Enabled = false;
                            btn_Eliminar.Enabled = false;
                        }
                    }
                    else
                    {
                        btn_Insertar.Enabled = false;
                        btn_Actualizar.Enabled = false;
                        btn_Eliminar.Enabled = false;
                    }

                }

                btn_Aceptar.Enabled = false;
                btn_Cancelar.Enabled = false;
            }
        }

        private void Btn_Cancelar_Click(object sender, EventArgs e)
        {
            AccionPantalla = Utilities.Acciones.Listar;

            CargarBotones();
        }

        private void Dgv_Rooms_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            Int32 id_Room = Int32.Parse(dgv_Rooms.SelectedRows[0].Cells[0].Value.ToString());

            string nombreRoom = dgv_Rooms.SelectedRows[0].Cells[1].Value.ToString();

            ProyectoRoom proyectoRoom = new ProyectoRoom();

            Room room = new Room
            {
                IdRoom = id_Room
            };

            proyectoRoom.ObjProyecto = proyecto;

            proyectoRoom.ObjRoom = room;

            ProyectoRoomManagement proyectoRoomManagement = new ProyectoRoomManagement();

           proyectoRoom = proyectoRoomManagement.RetriveProyectoByRoomStatement(proyectoRoom);

            frm_CreaProyecto objForm = new frm_CreaProyecto(proyectoRoom, txt_Proyecto.Text , nombreRoom);
            //objForm.TopLevel = false;
            // content.Controls.Add(objForm);
            objForm.Show();

            Cursor.Current = Cursors.Default;
        }

        private void Dgv_Rooms_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            CargarRoom();

            Cursor.Current = Cursors.Default;
        }
    }
}
