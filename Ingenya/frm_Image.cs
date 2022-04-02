using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ingenya
{
   
    public partial class frm_Image : Form
    {
        public frm_Image()
        {
            InitializeComponent();

            MaximizeBox = false;

            MinimizeBox = false;
        }

        public frm_Image(string ruta)
        {
            InitializeComponent();

            MaximizeBox = false;

            MinimizeBox = false;

            if (ruta == "1")
            {
                // var outPutDirectory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().CodeBase);
                //  var logoimage = Path.Combine(outPutDirectory, "Imagenes\\CleanRoom_Classification.png");
                // string relLogo = new Uri(logoimage).LocalPath;
                Size size = new Size(500, 280);
                pic_Box.Size = size;
                this.Size = size;
                this.Text = "Cleanroom Classification Chart";
                pic_Box.Image = Image.FromFile(@"C:\Referencias\Imagenes\CleanRoom_Classification.png");
                pic_Box.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            if (ruta == "2")
            {
                // var outPutDirectory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().CodeBase);
                //  var logoimage = Path.Combine(outPutDirectory, "Imagenes\\CleanRoom_Classification.png");
                // string relLogo = new Uri(logoimage).LocalPath;
                Size size = new Size(514, 503);
                pic_Box.Size = size;
                this.Size = size;
                this.Text = "Moisture Permeation";
                pic_Box.Image = Image.FromFile(@"C:\Referencias\Imagenes\Moinsture_Permeation.png");
                pic_Box.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            if (ruta == "3")
            {
                // var outPutDirectory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().CodeBase);
                //  var logoimage = Path.Combine(outPutDirectory, "Imagenes\\CleanRoom_Classification.png");
                // string relLogo = new Uri(logoimage).LocalPath;
                Size size = new Size(527, 105);
                pic_Box.Size = size;
                this.Size = size;
                this.Text = "Factors For Contruction";
                pic_Box.Image = Image.FromFile(@"C:\Referencias\Imagenes\Factors_Contruction.png");
                pic_Box.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            if (ruta == "4")
            {
                // var outPutDirectory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().CodeBase);
                //  var logoimage = Path.Combine(outPutDirectory, "Imagenes\\CleanRoom_Classification.png");
                // string relLogo = new Uri(logoimage).LocalPath;
                Size size = new Size(527, 105);
                pic_Box.Size = size;
                this.Size = size;
                this.Text = "Factors For Vapor Barriers";
                pic_Box.Image = Image.FromFile(@"C:\Referencias\Imagenes\Factors_Vapor.png");
                pic_Box.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            if (ruta == "5")
            {
                // var outPutDirectory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().CodeBase);
                //  var logoimage = Path.Combine(outPutDirectory, "Imagenes\\CleanRoom_Classification.png");
                // string relLogo = new Uri(logoimage).LocalPath;
                Size size = new Size(827, 605);
                pic_Box.Size = size;
                this.Size = size;
                this.Text = "Building Element";
                pic_Box.Image = Image.FromFile(@"C:\Referencias\Imagenes\Building_Elements.png");
                pic_Box.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }
    }
}
