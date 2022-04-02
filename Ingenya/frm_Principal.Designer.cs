namespace Ingenya
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Drawner = new System.Windows.Forms.Panel();
            this.btn_Rooms = new MaterialSkin.Controls.MaterialFlatButton();
            this.btn_CrearCliente = new MaterialSkin.Controls.MaterialFlatButton();
            this.btn_Proyecto = new MaterialSkin.Controls.MaterialFlatButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.content = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_Max = new System.Windows.Forms.Button();
            this.btn_Min = new System.Windows.Forms.Button();
            this.btn_Close = new System.Windows.Forms.Button();
            this.Drawner.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.content.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Drawner
            // 
            this.Drawner.BackColor = System.Drawing.Color.White;
            this.Drawner.Controls.Add(this.btn_Rooms);
            this.Drawner.Controls.Add(this.btn_CrearCliente);
            this.Drawner.Controls.Add(this.btn_Proyecto);
            this.Drawner.Controls.Add(this.pictureBox1);
            this.Drawner.Dock = System.Windows.Forms.DockStyle.Left;
            this.Drawner.Location = new System.Drawing.Point(0, 0);
            this.Drawner.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Drawner.Name = "Drawner";
            this.Drawner.Size = new System.Drawing.Size(341, 762);
            this.Drawner.TabIndex = 0;
            // 
            // btn_Rooms
            // 
            this.btn_Rooms.AutoSize = true;
            this.btn_Rooms.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_Rooms.Depth = 0;
            this.btn_Rooms.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Rooms.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.btn_Rooms.Icon = null;
            this.btn_Rooms.Location = new System.Drawing.Point(0, 145);
            this.btn_Rooms.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_Rooms.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_Rooms.Name = "btn_Rooms";
            this.btn_Rooms.Primary = false;
            this.btn_Rooms.Size = new System.Drawing.Size(341, 36);
            this.btn_Rooms.TabIndex = 14;
            this.btn_Rooms.Text = "Rooms";
            this.btn_Rooms.UseVisualStyleBackColor = true;
            this.btn_Rooms.Click += new System.EventHandler(this.Btn_Rooms_Click);
            // 
            // btn_CrearCliente
            // 
            this.btn_CrearCliente.AutoSize = true;
            this.btn_CrearCliente.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_CrearCliente.Depth = 0;
            this.btn_CrearCliente.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_CrearCliente.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.btn_CrearCliente.Icon = null;
            this.btn_CrearCliente.Location = new System.Drawing.Point(0, 109);
            this.btn_CrearCliente.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_CrearCliente.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_CrearCliente.Name = "btn_CrearCliente";
            this.btn_CrearCliente.Primary = false;
            this.btn_CrearCliente.Size = new System.Drawing.Size(341, 36);
            this.btn_CrearCliente.TabIndex = 12;
            this.btn_CrearCliente.Text = "Clientes";
            this.btn_CrearCliente.UseVisualStyleBackColor = true;
            this.btn_CrearCliente.Click += new System.EventHandler(this.Btn_CrearCliente_Click);
            // 
            // btn_Proyecto
            // 
            this.btn_Proyecto.AutoSize = true;
            this.btn_Proyecto.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_Proyecto.Depth = 0;
            this.btn_Proyecto.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Proyecto.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.btn_Proyecto.Icon = null;
            this.btn_Proyecto.Location = new System.Drawing.Point(0, 73);
            this.btn_Proyecto.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_Proyecto.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_Proyecto.Name = "btn_Proyecto";
            this.btn_Proyecto.Primary = false;
            this.btn_Proyecto.Size = new System.Drawing.Size(341, 36);
            this.btn_Proyecto.TabIndex = 7;
            this.btn_Proyecto.Text = "Proyectos";
            this.btn_Proyecto.UseVisualStyleBackColor = true;
            this.btn_Proyecto.Click += new System.EventHandler(this.Btn_Proyecto_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(341, 73);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // content
            // 
            this.content.Controls.Add(this.panel1);
            this.content.Dock = System.Windows.Forms.DockStyle.Fill;
            this.content.Location = new System.Drawing.Point(341, 0);
            this.content.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.content.Name = "content";
            this.content.Size = new System.Drawing.Size(750, 762);
            this.content.TabIndex = 1;
            this.content.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Content_MouseDown);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Red;
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(750, 73);
            this.panel1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.Controls.Add(this.btn_Max, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_Min, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_Close, 4, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(750, 73);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // btn_Max
            // 
            this.btn_Max.Image = ((System.Drawing.Image)(resources.GetObject("btn_Max.Image")));
            this.btn_Max.Location = new System.Drawing.Point(647, 2);
            this.btn_Max.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Max.Name = "btn_Max";
            this.btn_Max.Size = new System.Drawing.Size(29, 30);
            this.btn_Max.TabIndex = 0;
            this.btn_Max.UseVisualStyleBackColor = true;
            this.btn_Max.Visible = false;
            this.btn_Max.Click += new System.EventHandler(this.Btn_Max_Click);
            // 
            // btn_Min
            // 
            this.btn_Min.Image = ((System.Drawing.Image)(resources.GetObject("btn_Min.Image")));
            this.btn_Min.Location = new System.Drawing.Point(682, 2);
            this.btn_Min.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Min.Name = "btn_Min";
            this.btn_Min.Size = new System.Drawing.Size(29, 30);
            this.btn_Min.TabIndex = 1;
            this.btn_Min.UseVisualStyleBackColor = true;
            this.btn_Min.Click += new System.EventHandler(this.Btn_Min_Click);
            // 
            // btn_Close
            // 
            this.btn_Close.Image = ((System.Drawing.Image)(resources.GetObject("btn_Close.Image")));
            this.btn_Close.Location = new System.Drawing.Point(717, 2);
            this.btn_Close.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(29, 30);
            this.btn_Close.TabIndex = 2;
            this.btn_Close.UseVisualStyleBackColor = true;
            this.btn_Close.Click += new System.EventHandler(this.Btn_Close_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1091, 762);
            this.Controls.Add(this.content);
            this.Controls.Add(this.Drawner);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_Principal";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.Drawner.ResumeLayout(false);
            this.Drawner.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.content.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Drawner;
        private System.Windows.Forms.Panel content;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btn_Max;
        private System.Windows.Forms.Button btn_Min;
        private System.Windows.Forms.Button btn_Close;
        private MaterialSkin.Controls.MaterialFlatButton btn_Proyecto;
        private MaterialSkin.Controls.MaterialFlatButton btn_CrearCliente;
        private MaterialSkin.Controls.MaterialFlatButton btn_Rooms;
    }
}

