namespace CineCordobaFront.Presentacion
{
    partial class FrmConsultarCliente
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
            LblTitulo = new Label();
            cboSeleccionarCliente = new ComboBox();
            LblSeleccionarCliente = new Label();
            dgvConsultarClientes = new DataGridView();
            BtnSalir = new Button();
            BtnConsultar = new Button();
            ColId = new DataGridViewTextBoxColumn();
            colnom = new DataGridViewTextBoxColumn();
            ColApellido = new DataGridViewTextBoxColumn();
            ColFechaNacimiento = new DataGridViewTextBoxColumn();
            ColTelefono = new DataGridViewTextBoxColumn();
            ColEmail = new DataGridViewTextBoxColumn();
            colCalle = new DataGridViewTextBoxColumn();
            colAltura = new DataGridViewTextBoxColumn();
            ColDocumento = new DataGridViewTextBoxColumn();
            ColModificar = new DataGridViewButtonColumn();
            ColEliminar = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)dgvConsultarClientes).BeginInit();
            SuspendLayout();
            // 
            // LblTitulo
            // 
            LblTitulo.AutoSize = true;
            LblTitulo.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            LblTitulo.Location = new Point(535, 9);
            LblTitulo.Name = "LblTitulo";
            LblTitulo.Size = new Size(203, 32);
            LblTitulo.TabIndex = 0;
            LblTitulo.Text = "Consultar clientes";
            // 
            // cboSeleccionarCliente
            // 
            cboSeleccionarCliente.FormattingEnabled = true;
            cboSeleccionarCliente.Location = new Point(37, 110);
            cboSeleccionarCliente.Name = "cboSeleccionarCliente";
            cboSeleccionarCliente.Size = new Size(194, 23);
            cboSeleccionarCliente.TabIndex = 1;
            cboSeleccionarCliente.SelectedIndexChanged += cboSeleccionarCliente_SelectedIndexChanged;
            // 
            // LblSeleccionarCliente
            // 
            LblSeleccionarCliente.AutoSize = true;
            LblSeleccionarCliente.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            LblSeleccionarCliente.Location = new Point(37, 57);
            LblSeleccionarCliente.Name = "LblSeleccionarCliente";
            LblSeleccionarCliente.Size = new Size(170, 25);
            LblSeleccionarCliente.TabIndex = 0;
            LblSeleccionarCliente.Text = "Seleccionar cliente";
            // 
            // dgvConsultarClientes
            // 
            dgvConsultarClientes.AllowUserToAddRows = false;
            dgvConsultarClientes.BackgroundColor = SystemColors.ActiveCaption;
            dgvConsultarClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvConsultarClientes.Columns.AddRange(new DataGridViewColumn[] { ColId, colnom, ColApellido, ColFechaNacimiento, ColTelefono, ColEmail, colCalle, colAltura, ColDocumento, ColModificar, ColEliminar });
            dgvConsultarClientes.GridColor = SystemColors.ButtonShadow;
            dgvConsultarClientes.Location = new Point(37, 158);
            dgvConsultarClientes.Name = "dgvConsultarClientes";
            dgvConsultarClientes.RowTemplate.Height = 25;
            dgvConsultarClientes.Size = new Size(1208, 311);
            dgvConsultarClientes.TabIndex = 3;
            dgvConsultarClientes.CellContentClick += dataGridView1_CellContentClick;
            // 
            // BtnSalir
            // 
            BtnSalir.Location = new Point(1110, 507);
            BtnSalir.Name = "BtnSalir";
            BtnSalir.Size = new Size(138, 42);
            BtnSalir.TabIndex = 4;
            BtnSalir.Text = "Salir";
            BtnSalir.UseVisualStyleBackColor = true;
            BtnSalir.Click += BtnSalir_Click;
            // 
            // BtnConsultar
            // 
            BtnConsultar.Location = new Point(270, 110);
            BtnConsultar.Name = "BtnConsultar";
            BtnConsultar.Size = new Size(93, 23);
            BtnConsultar.TabIndex = 2;
            BtnConsultar.Text = "Consultar";
            BtnConsultar.UseVisualStyleBackColor = true;
            BtnConsultar.Click += BtnConsultar_Click;
            // 
            // ColId
            // 
            ColId.HeaderText = "ID Cliente";
            ColId.Name = "ColId";
            ColId.ReadOnly = true;
            // 
            // colnom
            // 
            colnom.HeaderText = "Nombre";
            colnom.Name = "colnom";
            // 
            // ColApellido
            // 
            ColApellido.HeaderText = "Apellido";
            ColApellido.Name = "ColApellido";
            ColApellido.ReadOnly = true;
            // 
            // ColFechaNacimiento
            // 
            ColFechaNacimiento.HeaderText = "Fecha Nacimiento";
            ColFechaNacimiento.Name = "ColFechaNacimiento";
            ColFechaNacimiento.ReadOnly = true;
            ColFechaNacimiento.Width = 130;
            // 
            // ColTelefono
            // 
            ColTelefono.HeaderText = "Telefono";
            ColTelefono.Name = "ColTelefono";
            ColTelefono.ReadOnly = true;
            // 
            // ColEmail
            // 
            ColEmail.HeaderText = "Email";
            ColEmail.Name = "ColEmail";
            ColEmail.ReadOnly = true;
            ColEmail.Width = 150;
            // 
            // colCalle
            // 
            colCalle.HeaderText = "Calle";
            colCalle.Name = "colCalle";
            // 
            // colAltura
            // 
            colAltura.HeaderText = "Altura";
            colAltura.Name = "colAltura";
            colAltura.Width = 90;
            // 
            // ColDocumento
            // 
            ColDocumento.HeaderText = "Numero Documento";
            ColDocumento.Name = "ColDocumento";
            ColDocumento.ReadOnly = true;
            // 
            // ColModificar
            // 
            ColModificar.HeaderText = "Modificar";
            ColModificar.Name = "ColModificar";
            ColModificar.Resizable = DataGridViewTriState.True;
            ColModificar.SortMode = DataGridViewColumnSortMode.Automatic;
            ColModificar.Text = "Modificar";
            ColModificar.UseColumnTextForButtonValue = true;
            // 
            // ColEliminar
            // 
            ColEliminar.HeaderText = "Eliminar";
            ColEliminar.Name = "ColEliminar";
            ColEliminar.Resizable = DataGridViewTriState.True;
            ColEliminar.SortMode = DataGridViewColumnSortMode.Automatic;
            ColEliminar.Text = "Eliminar";
            ColEliminar.UseColumnTextForButtonValue = true;
            // 
            // FrmConsultarCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1260, 603);
            Controls.Add(BtnConsultar);
            Controls.Add(BtnSalir);
            Controls.Add(dgvConsultarClientes);
            Controls.Add(LblSeleccionarCliente);
            Controls.Add(cboSeleccionarCliente);
            Controls.Add(LblTitulo);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "FrmConsultarCliente";
            Text = "FrmConsultarCliente";
            Load += FrmConsultarCliente_Load;
            ((System.ComponentModel.ISupportInitialize)dgvConsultarClientes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LblTitulo;
        private ComboBox cboSeleccionarCliente;
        private Label LblSeleccionarCliente;
        private DataGridView dgvConsultarClientes;
        private Button BtnSalir;
        private Button BtnConsultar;
        private DataGridViewTextBoxColumn ColId;
        private DataGridViewTextBoxColumn colnom;
        private DataGridViewTextBoxColumn ColApellido;
        private DataGridViewTextBoxColumn ColFechaNacimiento;
        private DataGridViewTextBoxColumn ColTelefono;
        private DataGridViewTextBoxColumn ColEmail;
        private DataGridViewTextBoxColumn colCalle;
        private DataGridViewTextBoxColumn colAltura;
        private DataGridViewTextBoxColumn ColDocumento;
        private DataGridViewButtonColumn ColModificar;
        private DataGridViewButtonColumn ColEliminar;
    }
}