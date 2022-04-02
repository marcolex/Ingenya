using Ingenya.ApiCore;
using Ingenya.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Ingenya
{
    public partial class Form1 : Form
    {
        public Form1()
        {

            InitializeComponent();
        }



        private void MaterialFlatButton1_Click(object sender, EventArgs e)
        {

        }

        private void MaterialFlatButton1_MouseHover(object sender, EventArgs e)
        {

        }

        private void MaterialTabSelector1_Click(object sender, EventArgs e)
        {

        }

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void Content_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void Btn_Max_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void Btn_Min_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_VerProyecto_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            frm_CreaProyecto objForm = new frm_CreaProyecto(null, null, null);
            //objForm.TopLevel = false;
            // content.Controls.Add(objForm);
            objForm.Show();

            Cursor.Current = Cursors.Default;
        }

        static class Global
        {
            private static string _globalVar = "";

            public static string GlobalVar
            {
                get { return _globalVar; }
                set { _globalVar = value; }
            }
        }

        private void Btn_CrearCliente_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            frm_Cliente frmCliente = new frm_Cliente();
            frmCliente.Show();

            Cursor.Current = Cursors.Default;
        }

        private void Btn_VerProyecto_Click_1(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            frm_VerProyecto verProyecto = new frm_VerProyecto();
            verProyecto.Show();

            Cursor.Current = Cursors.Default;
        }

        private void Btn_Proyecto_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            frm_Proyecto frm_Proyecto = new frm_Proyecto();
            frm_Proyecto.Show();

            Cursor.Current = Cursors.Default;
        }

        private void Btn_Rooms_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            frm_Room frm_Room = new frm_Room();
            frm_Room.Show();

            Cursor.Current = Cursors.Default;
        }

        private void Btn_Test_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            Int32 id_Room = 1;

            string nombreRoom = "Room Test";

            Proyecto proyecto = new Proyecto
            {
                IdProyecto = 1
            };

            ProyectoRoom proyectoRoom = new ProyectoRoom();

            Room room = new Room
            {
                IdRoom = id_Room
            };

            proyectoRoom.ObjProyecto = proyecto;

            proyectoRoom.ObjRoom = room;

            ProyectoRoomManagement proyectoRoomManagement = new ProyectoRoomManagement();

            proyectoRoom = proyectoRoomManagement.RetriveProyectoByRoomStatement(proyectoRoom);

            Form2 objForm = new Form2(proyectoRoom, "Proyecto Test", nombreRoom);
            //objForm.TopLevel = false;
            // content.Controls.Add(objForm);
            objForm.Show();

            Cursor.Current = Cursors.Default;
        }

    }
}

