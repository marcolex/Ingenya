namespace Ingenya
{
    partial class frm_Proyecto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Proyecto));
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_IdProyecto = new MaterialSkin.Controls.MaterialLabel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_Aceptar = new System.Windows.Forms.Button();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.txt_Fecha = new System.Windows.Forms.TextBox();
            this.txt_IdProyecto = new System.Windows.Forms.TextBox();
            this.lbl_Fecha = new MaterialSkin.Controls.MaterialLabel();
            this.lbl_NombreCliente = new MaterialSkin.Controls.MaterialLabel();
            this.txt_Nombre = new System.Windows.Forms.TextBox();
            this.lbl_Cliente = new MaterialSkin.Controls.MaterialLabel();
            this.dgv_ListaProyecto = new System.Windows.Forms.DataGridView();
            this.IdProyecto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_Insertar = new System.Windows.Forms.Button();
            this.btn_Actualizar = new System.Windows.Forms.Button();
            this.btn_Eliminar = new System.Windows.Forms.Button();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.txt_Cliente = new System.Windows.Forms.TextBox();
            this.btn_BuscarCliente = new System.Windows.Forms.Button();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ListaProyecto)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 307F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.lbl_IdProyecto, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel1, 1, 6);
            this.tableLayoutPanel3.Controls.Add(this.txt_Fecha, 1, 5);
            this.tableLayoutPanel3.Controls.Add(this.txt_IdProyecto, 1, 2);
            this.tableLayoutPanel3.Controls.Add(this.lbl_Fecha, 0, 5);
            this.tableLayoutPanel3.Controls.Add(this.lbl_NombreCliente, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.txt_Nombre, 1, 3);
            this.tableLayoutPanel3.Controls.Add(this.lbl_Cliente, 0, 4);
            this.tableLayoutPanel3.Controls.Add(this.dgv_ListaProyecto, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel4, 1, 4);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(4, 0);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 8;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 185F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 49F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 49F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 49F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(753, 471);
            this.tableLayoutPanel3.TabIndex = 14;
            // 
            // lbl_IdProyecto
            // 
            this.lbl_IdProyecto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_IdProyecto.AutoSize = true;
            this.lbl_IdProyecto.Depth = 0;
            this.lbl_IdProyecto.Font = new System.Drawing.Font("Roboto", 11F);
            this.lbl_IdProyecto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_IdProyecto.Location = new System.Drawing.Point(4, 240);
            this.lbl_IdProyecto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_IdProyecto.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_IdProyecto.Name = "lbl_IdProyecto";
            this.lbl_IdProyecto.Size = new System.Drawing.Size(299, 24);
            this.lbl_IdProyecto.TabIndex = 0;
            this.lbl_IdProyecto.Text = "id Proyecto";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.btn_Aceptar, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_Cancelar, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(311, 398);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 41F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(438, 41);
            this.tableLayoutPanel1.TabIndex = 14;
            // 
            // btn_Aceptar
            // 
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
            this.btn_Cancelar.Location = new System.Drawing.Point(223, 4);
            this.btn_Cancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(100, 28);
            this.btn_Cancelar.TabIndex = 1;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            this.btn_Cancelar.Click += new System.EventHandler(this.Btn_Cancelar_Click);
            // 
            // txt_Fecha
            // 
            this.txt_Fecha.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Fecha.Enabled = false;
            this.txt_Fecha.Location = new System.Drawing.Point(311, 361);
            this.txt_Fecha.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Fecha.MaxLength = 8;
            this.txt_Fecha.Name = "txt_Fecha";
            this.txt_Fecha.Size = new System.Drawing.Size(438, 22);
            this.txt_Fecha.TabIndex = 8;
            // 
            // txt_IdProyecto
            // 
            this.txt_IdProyecto.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_IdProyecto.Enabled = false;
            this.txt_IdProyecto.Location = new System.Drawing.Point(311, 238);
            this.txt_IdProyecto.Margin = new System.Windows.Forms.Padding(4);
            this.txt_IdProyecto.Name = "txt_IdProyecto";
            this.txt_IdProyecto.Size = new System.Drawing.Size(438, 22);
            this.txt_IdProyecto.TabIndex = 5;
            // 
            // lbl_Fecha
            // 
            this.lbl_Fecha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Fecha.AutoSize = true;
            this.lbl_Fecha.Depth = 0;
            this.lbl_Fecha.Font = new System.Drawing.Font("Roboto", 11F);
            this.lbl_Fecha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_Fecha.Location = new System.Drawing.Point(4, 363);
            this.lbl_Fecha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Fecha.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_Fecha.Name = "lbl_Fecha";
            this.lbl_Fecha.Size = new System.Drawing.Size(299, 24);
            this.lbl_Fecha.TabIndex = 3;
            this.lbl_Fecha.Text = "Fecha Creacion";
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
            // txt_Nombre
            // 
            this.txt_Nombre.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Nombre.Location = new System.Drawing.Point(311, 275);
            this.txt_Nombre.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Nombre.Name = "txt_Nombre";
            this.txt_Nombre.Size = new System.Drawing.Size(438, 22);
            this.txt_Nombre.TabIndex = 6;
            // 
            // lbl_Cliente
            // 
            this.lbl_Cliente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Cliente.AutoSize = true;
            this.lbl_Cliente.Depth = 0;
            this.lbl_Cliente.Font = new System.Drawing.Font("Roboto", 11F);
            this.lbl_Cliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_Cliente.Location = new System.Drawing.Point(4, 320);
            this.lbl_Cliente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Cliente.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_Cliente.Name = "lbl_Cliente";
            this.lbl_Cliente.Size = new System.Drawing.Size(299, 24);
            this.lbl_Cliente.TabIndex = 2;
            this.lbl_Cliente.Text = "Cliente";
            // 
            // dgv_ListaProyecto
            // 
            this.dgv_ListaProyecto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_ListaProyecto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ListaProyecto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdProyecto,
            this.Nombre,
            this.Cliente,
            this.Fecha});
            this.tableLayoutPanel3.SetColumnSpan(this.dgv_ListaProyecto, 2);
            this.dgv_ListaProyecto.Location = new System.Drawing.Point(4, 4);
            this.dgv_ListaProyecto.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_ListaProyecto.MultiSelect = false;
            this.dgv_ListaProyecto.Name = "dgv_ListaProyecto";
            this.dgv_ListaProyecto.ReadOnly = true;
            this.dgv_ListaProyecto.RowHeadersWidth = 51;
            this.dgv_ListaProyecto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_ListaProyecto.Size = new System.Drawing.Size(745, 177);
            this.dgv_ListaProyecto.TabIndex = 0;
            this.dgv_ListaProyecto.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_ListaProyecto_CellClick);
            // 
            // IdProyecto
            // 
            this.IdProyecto.DataPropertyName = "IdProyecto";
            this.IdProyecto.HeaderText = "idProyecto";
            this.IdProyecto.MinimumWidth = 6;
            this.IdProyecto.Name = "IdProyecto";
            this.IdProyecto.ReadOnly = true;
            this.IdProyecto.Width = 125;
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "NombreProyecto";
            this.Nombre.HeaderText = "Proyecto";
            this.Nombre.MinimumWidth = 6;
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 125;
            // 
            // Cliente
            // 
            this.Cliente.DataPropertyName = "NombreCliente";
            this.Cliente.HeaderText = "Cliente";
            this.Cliente.MinimumWidth = 6;
            this.Cliente.Name = "Cliente";
            this.Cliente.ReadOnly = true;
            this.Cliente.Width = 125;
            // 
            // Fecha
            // 
            this.Fecha.DataPropertyName = "Fecha";
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.MinimumWidth = 6;
            this.Fecha.Name = "Fecha";
            this.Fecha.ReadOnly = true;
            this.Fecha.Width = 125;
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
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel4.Controls.Add(this.txt_Cliente, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.btn_BuscarCliente, 1, 0);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(311, 312);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(438, 41);
            this.tableLayoutPanel4.TabIndex = 15;
            // 
            // txt_Cliente
            // 
            this.txt_Cliente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Cliente.Enabled = false;
            this.txt_Cliente.Location = new System.Drawing.Point(4, 9);
            this.txt_Cliente.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Cliente.Name = "txt_Cliente";
            this.txt_Cliente.Size = new System.Drawing.Size(298, 22);
            this.txt_Cliente.TabIndex = 0;
            // 
            // btn_BuscarCliente
            // 
            this.btn_BuscarCliente.Location = new System.Drawing.Point(310, 4);
            this.btn_BuscarCliente.Margin = new System.Windows.Forms.Padding(4);
            this.btn_BuscarCliente.Name = "btn_BuscarCliente";
            this.btn_BuscarCliente.Size = new System.Drawing.Size(100, 28);
            this.btn_BuscarCliente.TabIndex = 1;
            this.btn_BuscarCliente.Text = "Buscar";
            this.btn_BuscarCliente.UseVisualStyleBackColor = true;
            this.btn_BuscarCliente.Click += new System.EventHandler(this.Btn_BuscarCliente_Click);
            // 
            // frm_Proyecto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 484);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm_Proyecto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Proyecto";
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ListaProyecto)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private MaterialSkin.Controls.MaterialLabel lbl_IdProyecto;
        private System.Windows.Forms.TextBox txt_IdProyecto;
        private MaterialSkin.Controls.MaterialLabel lbl_NombreCliente;
        private MaterialSkin.Controls.MaterialLabel lbl_Cliente;
        private System.Windows.Forms.TextBox txt_Nombre;
        private System.Windows.Forms.DataGridView dgv_ListaProyecto;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btn_Aceptar;
        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btn_Insertar;
        private System.Windows.Forms.Button btn_Actualizar;
        private System.Windows.Forms.Button btn_Eliminar;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TextBox txt_Cliente;
        private System.Windows.Forms.Button btn_BuscarCliente;
        private System.Windows.Forms.TextBox txt_Fecha;
        private MaterialSkin.Controls.MaterialLabel lbl_Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdProyecto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
    }
}