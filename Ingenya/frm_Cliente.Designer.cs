namespace Ingenya
{
    partial class frm_Cliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Cliente));
            this.lbl_IdCliente = new MaterialSkin.Controls.MaterialLabel();
            this.lbl_NombreCliente = new MaterialSkin.Controls.MaterialLabel();
            this.lbl_Site = new MaterialSkin.Controls.MaterialLabel();
            this.lbl_Telefono = new MaterialSkin.Controls.MaterialLabel();
            this.lbl_Direccion = new MaterialSkin.Controls.MaterialLabel();
            this.txt_IdCliente = new System.Windows.Forms.TextBox();
            this.txt_Nombre = new System.Windows.Forms.TextBox();
            this.txt_Site = new System.Windows.Forms.TextBox();
            this.txt_Telefono = new System.Windows.Forms.TextBox();
            this.txt_Direccion = new System.Windows.Forms.TextBox();
            this.txt_Correo = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_Insertar = new System.Windows.Forms.Button();
            this.btn_Actualizar = new System.Windows.Forms.Button();
            this.btn_Eliminar = new System.Windows.Forms.Button();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_CorreoContacto = new MaterialSkin.Controls.MaterialLabel();
            this.dgv_ListaCliente = new System.Windows.Forms.DataGridView();
            this.IdCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Site = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CorreoContacto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_Aceptar = new System.Windows.Forms.Button();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ListaCliente)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_IdCliente
            // 
            this.lbl_IdCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_IdCliente.AutoSize = true;
            this.lbl_IdCliente.Depth = 0;
            this.lbl_IdCliente.Font = new System.Drawing.Font("Roboto", 11F);
            this.lbl_IdCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_IdCliente.Location = new System.Drawing.Point(4, 240);
            this.lbl_IdCliente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_IdCliente.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_IdCliente.Name = "lbl_IdCliente";
            this.lbl_IdCliente.Size = new System.Drawing.Size(299, 24);
            this.lbl_IdCliente.TabIndex = 0;
            this.lbl_IdCliente.Text = "Id Cliente";
            // 
            // lbl_NombreCliente
            // 
            this.lbl_NombreCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_NombreCliente.AutoSize = true;
            this.lbl_NombreCliente.Depth = 0;
            this.lbl_NombreCliente.Font = new System.Drawing.Font("Roboto", 11F);
            this.lbl_NombreCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_NombreCliente.Location = new System.Drawing.Point(4, 277);
            this.lbl_NombreCliente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_NombreCliente.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_NombreCliente.Name = "lbl_NombreCliente";
            this.lbl_NombreCliente.Size = new System.Drawing.Size(299, 24);
            this.lbl_NombreCliente.TabIndex = 1;
            this.lbl_NombreCliente.Text = "Nombre";
            // 
            // lbl_Site
            // 
            this.lbl_Site.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Site.AutoSize = true;
            this.lbl_Site.Depth = 0;
            this.lbl_Site.Font = new System.Drawing.Font("Roboto", 11F);
            this.lbl_Site.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_Site.Location = new System.Drawing.Point(4, 314);
            this.lbl_Site.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Site.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_Site.Name = "lbl_Site";
            this.lbl_Site.Size = new System.Drawing.Size(299, 24);
            this.lbl_Site.TabIndex = 2;
            this.lbl_Site.Text = "Site";
            // 
            // lbl_Telefono
            // 
            this.lbl_Telefono.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Telefono.AutoSize = true;
            this.lbl_Telefono.Depth = 0;
            this.lbl_Telefono.Font = new System.Drawing.Font("Roboto", 11F);
            this.lbl_Telefono.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_Telefono.Location = new System.Drawing.Point(4, 351);
            this.lbl_Telefono.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Telefono.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_Telefono.Name = "lbl_Telefono";
            this.lbl_Telefono.Size = new System.Drawing.Size(299, 24);
            this.lbl_Telefono.TabIndex = 3;
            this.lbl_Telefono.Text = "Telefono";
            // 
            // lbl_Direccion
            // 
            this.lbl_Direccion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Direccion.AutoSize = true;
            this.lbl_Direccion.Depth = 0;
            this.lbl_Direccion.Font = new System.Drawing.Font("Roboto", 11F);
            this.lbl_Direccion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_Direccion.Location = new System.Drawing.Point(4, 388);
            this.lbl_Direccion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Direccion.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_Direccion.Name = "lbl_Direccion";
            this.lbl_Direccion.Size = new System.Drawing.Size(299, 24);
            this.lbl_Direccion.TabIndex = 4;
            this.lbl_Direccion.Text = "Direccion";
            // 
            // txt_IdCliente
            // 
            this.txt_IdCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_IdCliente.Enabled = false;
            this.txt_IdCliente.Location = new System.Drawing.Point(311, 238);
            this.txt_IdCliente.Margin = new System.Windows.Forms.Padding(4);
            this.txt_IdCliente.Name = "txt_IdCliente";
            this.txt_IdCliente.Size = new System.Drawing.Size(686, 22);
            this.txt_IdCliente.TabIndex = 5;
            // 
            // txt_Nombre
            // 
            this.txt_Nombre.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Nombre.Enabled = false;
            this.txt_Nombre.Location = new System.Drawing.Point(311, 275);
            this.txt_Nombre.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Nombre.Name = "txt_Nombre";
            this.txt_Nombre.Size = new System.Drawing.Size(686, 22);
            this.txt_Nombre.TabIndex = 6;
            // 
            // txt_Site
            // 
            this.txt_Site.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Site.Enabled = false;
            this.txt_Site.Location = new System.Drawing.Point(311, 312);
            this.txt_Site.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Site.Name = "txt_Site";
            this.txt_Site.Size = new System.Drawing.Size(686, 22);
            this.txt_Site.TabIndex = 7;
            // 
            // txt_Telefono
            // 
            this.txt_Telefono.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Telefono.Enabled = false;
            this.txt_Telefono.Location = new System.Drawing.Point(311, 349);
            this.txt_Telefono.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Telefono.MaxLength = 8;
            this.txt_Telefono.Name = "txt_Telefono";
            this.txt_Telefono.Size = new System.Drawing.Size(686, 22);
            this.txt_Telefono.TabIndex = 8;
            this.txt_Telefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_Telefono_KeyPress);
            // 
            // txt_Direccion
            // 
            this.txt_Direccion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Direccion.Enabled = false;
            this.txt_Direccion.Location = new System.Drawing.Point(311, 386);
            this.txt_Direccion.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Direccion.MaxLength = 100;
            this.txt_Direccion.Name = "txt_Direccion";
            this.txt_Direccion.Size = new System.Drawing.Size(686, 22);
            this.txt_Direccion.TabIndex = 9;
            // 
            // txt_Correo
            // 
            this.txt_Correo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Correo.Enabled = false;
            this.txt_Correo.Location = new System.Drawing.Point(311, 423);
            this.txt_Correo.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Correo.MaxLength = 100;
            this.txt_Correo.Name = "txt_Correo";
            this.txt_Correo.Size = new System.Drawing.Size(686, 22);
            this.txt_Correo.TabIndex = 11;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.Controls.Add(this.btn_Insertar, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btn_Actualizar, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.btn_Eliminar, 2, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(4, 189);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(299, 41);
            this.tableLayoutPanel2.TabIndex = 12;
            // 
            // btn_Insertar
            // 
            this.btn_Insertar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Insertar.Enabled = false;
            this.btn_Insertar.Location = new System.Drawing.Point(4, 6);
            this.btn_Insertar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Insertar.Name = "btn_Insertar";
            this.btn_Insertar.Size = new System.Drawing.Size(91, 28);
            this.btn_Insertar.TabIndex = 0;
            this.btn_Insertar.Text = "Insertar";
            this.btn_Insertar.UseVisualStyleBackColor = true;
            this.btn_Insertar.Click += new System.EventHandler(this.Btn_Insertar_Click);
            // 
            // btn_Actualizar
            // 
            this.btn_Actualizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Actualizar.Enabled = false;
            this.btn_Actualizar.Location = new System.Drawing.Point(103, 6);
            this.btn_Actualizar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Actualizar.Name = "btn_Actualizar";
            this.btn_Actualizar.Size = new System.Drawing.Size(91, 28);
            this.btn_Actualizar.TabIndex = 1;
            this.btn_Actualizar.Text = "Actualizar";
            this.btn_Actualizar.UseVisualStyleBackColor = true;
            this.btn_Actualizar.Click += new System.EventHandler(this.Btn_Actualizar_Click);
            // 
            // btn_Eliminar
            // 
            this.btn_Eliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Eliminar.Enabled = false;
            this.btn_Eliminar.Location = new System.Drawing.Point(202, 6);
            this.btn_Eliminar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Eliminar.Name = "btn_Eliminar";
            this.btn_Eliminar.Size = new System.Drawing.Size(93, 28);
            this.btn_Eliminar.TabIndex = 2;
            this.btn_Eliminar.Text = "Eliminar";
            this.btn_Eliminar.UseVisualStyleBackColor = true;
            this.btn_Eliminar.Click += new System.EventHandler(this.Btn_Eliminar_Click);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 307F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.lbl_CorreoContacto, 0, 7);
            this.tableLayoutPanel3.Controls.Add(this.txt_Correo, 1, 7);
            this.tableLayoutPanel3.Controls.Add(this.txt_Direccion, 1, 6);
            this.tableLayoutPanel3.Controls.Add(this.lbl_IdCliente, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.lbl_Direccion, 0, 6);
            this.tableLayoutPanel3.Controls.Add(this.txt_Telefono, 1, 5);
            this.tableLayoutPanel3.Controls.Add(this.txt_IdCliente, 1, 2);
            this.tableLayoutPanel3.Controls.Add(this.lbl_Telefono, 0, 5);
            this.tableLayoutPanel3.Controls.Add(this.txt_Site, 1, 4);
            this.tableLayoutPanel3.Controls.Add(this.lbl_NombreCliente, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.lbl_Site, 0, 4);
            this.tableLayoutPanel3.Controls.Add(this.txt_Nombre, 1, 3);
            this.tableLayoutPanel3.Controls.Add(this.dgv_ListaCliente, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel1, 1, 8);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(8, 11);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 10;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 185F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 49F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 49F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1001, 555);
            this.tableLayoutPanel3.TabIndex = 13;
            // 
            // lbl_CorreoContacto
            // 
            this.lbl_CorreoContacto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_CorreoContacto.AutoSize = true;
            this.lbl_CorreoContacto.Depth = 0;
            this.lbl_CorreoContacto.Font = new System.Drawing.Font("Roboto", 11F);
            this.lbl_CorreoContacto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_CorreoContacto.Location = new System.Drawing.Point(4, 425);
            this.lbl_CorreoContacto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_CorreoContacto.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_CorreoContacto.Name = "lbl_CorreoContacto";
            this.lbl_CorreoContacto.Size = new System.Drawing.Size(299, 24);
            this.lbl_CorreoContacto.TabIndex = 13;
            this.lbl_CorreoContacto.Text = "Correo Contacto";
            // 
            // dgv_ListaCliente
            // 
            this.dgv_ListaCliente.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_ListaCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ListaCliente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdCliente,
            this.Nombre,
            this.Site,
            this.Telefono,
            this.Direccion,
            this.CorreoContacto});
            this.tableLayoutPanel3.SetColumnSpan(this.dgv_ListaCliente, 2);
            this.dgv_ListaCliente.Location = new System.Drawing.Point(4, 4);
            this.dgv_ListaCliente.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_ListaCliente.MultiSelect = false;
            this.dgv_ListaCliente.Name = "dgv_ListaCliente";
            this.dgv_ListaCliente.ReadOnly = true;
            this.dgv_ListaCliente.RowHeadersWidth = 51;
            this.dgv_ListaCliente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_ListaCliente.Size = new System.Drawing.Size(993, 177);
            this.dgv_ListaCliente.TabIndex = 0;
            this.dgv_ListaCliente.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_ListaCliente_CellClick);
            // 
            // IdCliente
            // 
            this.IdCliente.DataPropertyName = "IdCliente";
            this.IdCliente.HeaderText = "Cliente";
            this.IdCliente.MinimumWidth = 6;
            this.IdCliente.Name = "IdCliente";
            this.IdCliente.ReadOnly = true;
            this.IdCliente.Width = 125;
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "Nombre";
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.MinimumWidth = 6;
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 125;
            // 
            // Site
            // 
            this.Site.DataPropertyName = "Site";
            this.Site.HeaderText = "Site";
            this.Site.MinimumWidth = 6;
            this.Site.Name = "Site";
            this.Site.ReadOnly = true;
            this.Site.Width = 125;
            // 
            // Telefono
            // 
            this.Telefono.DataPropertyName = "Telefono";
            this.Telefono.HeaderText = "Telefono";
            this.Telefono.MinimumWidth = 6;
            this.Telefono.Name = "Telefono";
            this.Telefono.ReadOnly = true;
            this.Telefono.Width = 125;
            // 
            // Direccion
            // 
            this.Direccion.DataPropertyName = "Direccion";
            this.Direccion.HeaderText = "Direccion";
            this.Direccion.MinimumWidth = 6;
            this.Direccion.Name = "Direccion";
            this.Direccion.ReadOnly = true;
            this.Direccion.Width = 125;
            // 
            // CorreoContacto
            // 
            this.CorreoContacto.DataPropertyName = "CorreoContacto";
            this.CorreoContacto.HeaderText = "Correo";
            this.CorreoContacto.MinimumWidth = 6;
            this.CorreoContacto.Name = "CorreoContacto";
            this.CorreoContacto.ReadOnly = true;
            this.CorreoContacto.Width = 125;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.btn_Aceptar, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_Cancelar, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(311, 460);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(686, 41);
            this.tableLayoutPanel1.TabIndex = 14;
            // 
            // btn_Aceptar
            // 
            this.btn_Aceptar.Enabled = false;
            this.btn_Aceptar.Location = new System.Drawing.Point(4, 4);
            this.btn_Aceptar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Aceptar.Name = "btn_Aceptar";
            this.btn_Aceptar.Size = new System.Drawing.Size(100, 28);
            this.btn_Aceptar.TabIndex = 0;
            this.btn_Aceptar.Text = "Aceptar";
            this.btn_Aceptar.UseVisualStyleBackColor = true;
            this.btn_Aceptar.Click += new System.EventHandler(this.Btn_Aceptar_Click);
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.Enabled = false;
            this.btn_Cancelar.Location = new System.Drawing.Point(347, 4);
            this.btn_Cancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(100, 28);
            this.btn_Cancelar.TabIndex = 1;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            this.btn_Cancelar.Click += new System.EventHandler(this.Btn_Cancelar_Click);
            // 
            // frm_Cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1025, 581);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm_Cliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cliente";
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ListaCliente)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private MaterialSkin.Controls.MaterialLabel lbl_IdCliente;
        private MaterialSkin.Controls.MaterialLabel lbl_NombreCliente;
        private MaterialSkin.Controls.MaterialLabel lbl_Site;
        private MaterialSkin.Controls.MaterialLabel lbl_Telefono;
        private MaterialSkin.Controls.MaterialLabel lbl_Direccion;
        private System.Windows.Forms.TextBox txt_Correo;
        private System.Windows.Forms.TextBox txt_Direccion;
        private System.Windows.Forms.TextBox txt_Telefono;
        private System.Windows.Forms.TextBox txt_Site;
        private System.Windows.Forms.TextBox txt_Nombre;
        private System.Windows.Forms.TextBox txt_IdCliente;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.DataGridView dgv_ListaCliente;
        private MaterialSkin.Controls.MaterialLabel lbl_CorreoContacto;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btn_Insertar;
        private System.Windows.Forms.Button btn_Actualizar;
        private System.Windows.Forms.Button btn_Eliminar;
        private System.Windows.Forms.Button btn_Aceptar;
        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Site;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn Direccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn CorreoContacto;
    }
}