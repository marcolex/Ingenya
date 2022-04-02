namespace Ingenya
{
    partial class frm_Room
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Room));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_Percentage = new MaterialSkin.Controls.MaterialLabel();
            this.lbl_IdRoom = new MaterialSkin.Controls.MaterialLabel();
            this.lbl_NombreRoom = new MaterialSkin.Controls.MaterialLabel();
            this.lbl_Rooms = new MaterialSkin.Controls.MaterialLabel();
            this.lbl_Proyecto = new MaterialSkin.Controls.MaterialLabel();
            this.txt_Proyecto = new System.Windows.Forms.TextBox();
            this.txt_Buscar = new System.Windows.Forms.Button();
            this.dgv_Rooms = new System.Windows.Forms.DataGridView();
            this.idRoom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_Insertar = new System.Windows.Forms.Button();
            this.btn_Actualizar = new System.Windows.Forms.Button();
            this.btn_Eliminar = new System.Windows.Forms.Button();
            this.txt_IdRoom = new System.Windows.Forms.TextBox();
            this.txt_Nombre = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_Aceptar = new System.Windows.Forms.Button();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.lblRooms = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Rooms)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 125F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.lbl_Percentage, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.lbl_IdRoom, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.lbl_NombreRoom, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.lbl_Rooms, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lbl_Proyecto, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.txt_Proyecto, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.txt_Buscar, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.dgv_Rooms, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.txt_IdRoom, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.txt_Nombre, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.progressBar, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.lblRooms, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 9;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 300F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(536, 566);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lbl_Percentage
            // 
            this.lbl_Percentage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Percentage.AutoSize = true;
            this.lbl_Percentage.Depth = 0;
            this.lbl_Percentage.Font = new System.Drawing.Font("Roboto", 11F);
            this.lbl_Percentage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_Percentage.Location = new System.Drawing.Point(3, 465);
            this.lbl_Percentage.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_Percentage.Name = "lbl_Percentage";
            this.lbl_Percentage.Size = new System.Drawing.Size(119, 19);
            this.lbl_Percentage.TabIndex = 19;
            this.lbl_Percentage.Text = "0%";
            this.lbl_Percentage.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_IdRoom
            // 
            this.lbl_IdRoom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_IdRoom.AutoSize = true;
            this.lbl_IdRoom.Depth = 0;
            this.lbl_IdRoom.Font = new System.Drawing.Font("Roboto", 11F);
            this.lbl_IdRoom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_IdRoom.Location = new System.Drawing.Point(3, 405);
            this.lbl_IdRoom.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_IdRoom.Name = "lbl_IdRoom";
            this.lbl_IdRoom.Size = new System.Drawing.Size(119, 19);
            this.lbl_IdRoom.TabIndex = 14;
            this.lbl_IdRoom.Text = "Id Room";
            // 
            // lbl_NombreRoom
            // 
            this.lbl_NombreRoom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_NombreRoom.AutoSize = true;
            this.lbl_NombreRoom.Depth = 0;
            this.lbl_NombreRoom.Font = new System.Drawing.Font("Roboto", 11F);
            this.lbl_NombreRoom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_NombreRoom.Location = new System.Drawing.Point(3, 435);
            this.lbl_NombreRoom.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_NombreRoom.Name = "lbl_NombreRoom";
            this.lbl_NombreRoom.Size = new System.Drawing.Size(119, 19);
            this.lbl_NombreRoom.TabIndex = 7;
            this.lbl_NombreRoom.Text = "Nombre";
            // 
            // lbl_Rooms
            // 
            this.lbl_Rooms.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Rooms.AutoSize = true;
            this.lbl_Rooms.Depth = 0;
            this.lbl_Rooms.Font = new System.Drawing.Font("Roboto", 11F);
            this.lbl_Rooms.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_Rooms.Location = new System.Drawing.Point(3, 35);
            this.lbl_Rooms.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_Rooms.Name = "lbl_Rooms";
            this.lbl_Rooms.Size = new System.Drawing.Size(119, 19);
            this.lbl_Rooms.TabIndex = 4;
            this.lbl_Rooms.Text = "Rooms";
            // 
            // lbl_Proyecto
            // 
            this.lbl_Proyecto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Proyecto.AutoSize = true;
            this.lbl_Proyecto.Depth = 0;
            this.lbl_Proyecto.Font = new System.Drawing.Font("Roboto", 11F);
            this.lbl_Proyecto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_Proyecto.Location = new System.Drawing.Point(3, 5);
            this.lbl_Proyecto.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_Proyecto.Name = "lbl_Proyecto";
            this.lbl_Proyecto.Size = new System.Drawing.Size(119, 19);
            this.lbl_Proyecto.TabIndex = 1;
            this.lbl_Proyecto.Text = "Proyecto";
            // 
            // txt_Proyecto
            // 
            this.txt_Proyecto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Proyecto.Enabled = false;
            this.txt_Proyecto.Location = new System.Drawing.Point(128, 5);
            this.txt_Proyecto.Name = "txt_Proyecto";
            this.txt_Proyecto.Size = new System.Drawing.Size(144, 20);
            this.txt_Proyecto.TabIndex = 2;
            // 
            // txt_Buscar
            // 
            this.txt_Buscar.Location = new System.Drawing.Point(278, 3);
            this.txt_Buscar.Name = "txt_Buscar";
            this.txt_Buscar.Size = new System.Drawing.Size(75, 23);
            this.txt_Buscar.TabIndex = 3;
            this.txt_Buscar.Text = "Buscar";
            this.txt_Buscar.UseVisualStyleBackColor = true;
            this.txt_Buscar.Click += new System.EventHandler(this.Txt_Buscar_Click);
            // 
            // dgv_Rooms
            // 
            this.dgv_Rooms.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_Rooms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Rooms.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idRoom,
            this.Nombre});
            this.tableLayoutPanel1.SetColumnSpan(this.dgv_Rooms, 3);
            this.dgv_Rooms.Location = new System.Drawing.Point(3, 63);
            this.dgv_Rooms.MultiSelect = false;
            this.dgv_Rooms.Name = "dgv_Rooms";
            this.dgv_Rooms.ReadOnly = true;
            this.dgv_Rooms.RowHeadersWidth = 51;
            this.dgv_Rooms.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Rooms.Size = new System.Drawing.Size(369, 294);
            this.dgv_Rooms.TabIndex = 5;
            this.dgv_Rooms.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_Rooms_CellClick);
            this.dgv_Rooms.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_Rooms_CellDoubleClick);
            // 
            // idRoom
            // 
            this.idRoom.DataPropertyName = "idRoom";
            this.idRoom.HeaderText = "idRoom";
            this.idRoom.MinimumWidth = 6;
            this.idRoom.Name = "idRoom";
            this.idRoom.ReadOnly = true;
            this.idRoom.Width = 125;
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "Nombre";
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.MinimumWidth = 6;
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 175;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel1.SetColumnSpan(this.tableLayoutPanel2, 2);
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.Controls.Add(this.btn_Insertar, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btn_Actualizar, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.btn_Eliminar, 2, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 363);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(269, 33);
            this.tableLayoutPanel2.TabIndex = 13;
            // 
            // btn_Insertar
            // 
            this.btn_Insertar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Insertar.Location = new System.Drawing.Point(3, 5);
            this.btn_Insertar.Name = "btn_Insertar";
            this.btn_Insertar.Size = new System.Drawing.Size(83, 23);
            this.btn_Insertar.TabIndex = 0;
            this.btn_Insertar.Text = "Insertar";
            this.btn_Insertar.UseVisualStyleBackColor = true;
            this.btn_Insertar.Click += new System.EventHandler(this.Btn_Insertar_Click);
            // 
            // btn_Actualizar
            // 
            this.btn_Actualizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Actualizar.Location = new System.Drawing.Point(92, 5);
            this.btn_Actualizar.Name = "btn_Actualizar";
            this.btn_Actualizar.Size = new System.Drawing.Size(83, 23);
            this.btn_Actualizar.TabIndex = 1;
            this.btn_Actualizar.Text = "Actualizar";
            this.btn_Actualizar.UseVisualStyleBackColor = true;
            this.btn_Actualizar.Click += new System.EventHandler(this.Btn_Actualizar_Click);
            // 
            // btn_Eliminar
            // 
            this.btn_Eliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Eliminar.Location = new System.Drawing.Point(181, 5);
            this.btn_Eliminar.Name = "btn_Eliminar";
            this.btn_Eliminar.Size = new System.Drawing.Size(85, 23);
            this.btn_Eliminar.TabIndex = 2;
            this.btn_Eliminar.Text = "Eliminar";
            this.btn_Eliminar.UseVisualStyleBackColor = true;
            this.btn_Eliminar.Click += new System.EventHandler(this.Btn_Eliminar_Click);
            // 
            // txt_IdRoom
            // 
            this.txt_IdRoom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.txt_IdRoom, 2);
            this.txt_IdRoom.Enabled = false;
            this.txt_IdRoom.Location = new System.Drawing.Point(128, 405);
            this.txt_IdRoom.Name = "txt_IdRoom";
            this.txt_IdRoom.Size = new System.Drawing.Size(244, 20);
            this.txt_IdRoom.TabIndex = 15;
            // 
            // txt_Nombre
            // 
            this.txt_Nombre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.txt_Nombre, 2);
            this.txt_Nombre.Location = new System.Drawing.Point(128, 435);
            this.txt_Nombre.Name = "txt_Nombre";
            this.txt_Nombre.Size = new System.Drawing.Size(244, 20);
            this.txt_Nombre.TabIndex = 16;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel1.SetColumnSpan(this.tableLayoutPanel3, 2);
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.btn_Aceptar, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.btn_Cancelar, 1, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(128, 493);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(244, 33);
            this.tableLayoutPanel3.TabIndex = 17;
            // 
            // btn_Aceptar
            // 
            this.btn_Aceptar.Location = new System.Drawing.Point(3, 3);
            this.btn_Aceptar.Name = "btn_Aceptar";
            this.btn_Aceptar.Size = new System.Drawing.Size(75, 23);
            this.btn_Aceptar.TabIndex = 0;
            this.btn_Aceptar.Text = "Aceptar";
            this.btn_Aceptar.UseVisualStyleBackColor = true;
            this.btn_Aceptar.Click += new System.EventHandler(this.Btn_Aceptar_Click);
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.Location = new System.Drawing.Point(125, 3);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(75, 23);
            this.btn_Cancelar.TabIndex = 1;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            this.btn_Cancelar.Click += new System.EventHandler(this.Btn_Eliminar_Click);
            // 
            // progressBar
            // 
            this.progressBar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.progressBar, 2);
            this.progressBar.Location = new System.Drawing.Point(128, 463);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(244, 23);
            this.progressBar.TabIndex = 18;
            // 
            // lblRooms
            // 
            this.lblRooms.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRooms.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.lblRooms, 2);
            this.lblRooms.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRooms.ForeColor = System.Drawing.Color.Red;
            this.lblRooms.Location = new System.Drawing.Point(128, 36);
            this.lblRooms.Name = "lblRooms";
            this.lblRooms.Size = new System.Drawing.Size(244, 17);
            this.lblRooms.TabIndex = 20;
            // 
            // frm_Room
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 581);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_Room";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Room";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Rooms)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private MaterialSkin.Controls.MaterialLabel lbl_Rooms;
        private MaterialSkin.Controls.MaterialLabel lbl_Proyecto;
        private System.Windows.Forms.TextBox txt_Proyecto;
        private System.Windows.Forms.Button txt_Buscar;
        private System.Windows.Forms.DataGridView dgv_Rooms;
        private System.Windows.Forms.DataGridViewTextBoxColumn idRoom;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private MaterialSkin.Controls.MaterialLabel lbl_NombreRoom;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btn_Insertar;
        private System.Windows.Forms.Button btn_Actualizar;
        private System.Windows.Forms.Button btn_Eliminar;
        private MaterialSkin.Controls.MaterialLabel lbl_IdRoom;
        private System.Windows.Forms.TextBox txt_IdRoom;
        private System.Windows.Forms.TextBox txt_Nombre;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button btn_Aceptar;
        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.ProgressBar progressBar;
        private MaterialSkin.Controls.MaterialLabel lbl_Percentage;
        private System.Windows.Forms.Label lblRooms;
    }
}