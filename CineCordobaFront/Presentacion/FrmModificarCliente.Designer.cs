namespace CineCordobaFront.Presentacion
{
    partial class FrmModificarCliente
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
            lblTipoDocumento = new Label();
            lblNombre = new Label();
            dtpFechaNacimiento = new DateTimePicker();
            lblApellido = new Label();
            lblBarrio = new Label();
            lblAltura = new Label();
            lblDocumento = new Label();
            lblFechaNacimiento = new Label();
            lblTelefono = new Label();
            cboTipoDocumento = new ComboBox();
            lblCalle = new Label();
            BtnModificar = new Button();
            btnCancelar = new Button();
            LblTitulo = new Label();
            txtNombre = new TextBox();
            lblEmail = new Label();
            txtEmail = new TextBox();
            txtDocumento = new TextBox();
            txtAltura = new TextBox();
            txtCalle = new TextBox();
            txtTelefono = new TextBox();
            txtApellido = new TextBox();
            cboBarrio = new ComboBox();
            lblClienteNro = new Label();
            SuspendLayout();
            // 
            // lblTipoDocumento
            // 
            lblTipoDocumento.AutoSize = true;
            lblTipoDocumento.Location = new Point(82, 380);
            lblTipoDocumento.Name = "lblTipoDocumento";
            lblTipoDocumento.Size = new Size(114, 15);
            lblTipoDocumento.TabIndex = 3;
            lblTipoDocumento.Text = "Tipo de documento:";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(82, 116);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(54, 15);
            lblNombre.TabIndex = 4;
            lblNombre.Text = "Nombre:";
            // 
            // dtpFechaNacimiento
            // 
            dtpFechaNacimiento.Location = new Point(82, 322);
            dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            dtpFechaNacimiento.Size = new Size(215, 23);
            dtpFechaNacimiento.TabIndex = 5;
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Location = new Point(421, 116);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(54, 15);
            lblApellido.TabIndex = 6;
            lblApellido.Text = "Apellido:";
            lblApellido.Click += lblApellido_Click;
            // 
            // lblBarrio
            // 
            lblBarrio.AutoSize = true;
            lblBarrio.Location = new Point(422, 298);
            lblBarrio.Name = "lblBarrio";
            lblBarrio.Size = new Size(38, 15);
            lblBarrio.TabIndex = 8;
            lblBarrio.Text = "Barrio";
            // 
            // lblAltura
            // 
            lblAltura.AutoSize = true;
            lblAltura.Location = new Point(422, 455);
            lblAltura.Name = "lblAltura";
            lblAltura.Size = new Size(42, 15);
            lblAltura.TabIndex = 10;
            lblAltura.Text = "Altura:";
            // 
            // lblDocumento
            // 
            lblDocumento.AutoSize = true;
            lblDocumento.Location = new Point(82, 455);
            lblDocumento.Name = "lblDocumento";
            lblDocumento.Size = new Size(73, 15);
            lblDocumento.TabIndex = 12;
            lblDocumento.Text = "Documento:";
            // 
            // lblFechaNacimiento
            // 
            lblFechaNacimiento.AutoSize = true;
            lblFechaNacimiento.Location = new Point(82, 298);
            lblFechaNacimiento.Name = "lblFechaNacimiento";
            lblFechaNacimiento.Size = new Size(120, 15);
            lblFechaNacimiento.TabIndex = 13;
            lblFechaNacimiento.Text = "Fecha de nacimiento:";
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Location = new Point(82, 213);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(58, 15);
            lblTelefono.TabIndex = 18;
            lblTelefono.Text = "Telefono: ";
            // 
            // cboTipoDocumento
            // 
            cboTipoDocumento.FormattingEnabled = true;
            cboTipoDocumento.Location = new Point(82, 409);
            cboTipoDocumento.Name = "cboTipoDocumento";
            cboTipoDocumento.Size = new Size(215, 23);
            cboTipoDocumento.TabIndex = 19;
            // 
            // lblCalle
            // 
            lblCalle.AutoSize = true;
            lblCalle.Location = new Point(422, 380);
            lblCalle.Name = "lblCalle";
            lblCalle.Size = new Size(36, 15);
            lblCalle.TabIndex = 20;
            lblCalle.Text = "Calle:";
            // 
            // BtnModificar
            // 
            BtnModificar.Location = new Point(82, 571);
            BtnModificar.Name = "BtnModificar";
            BtnModificar.RightToLeft = RightToLeft.No;
            BtnModificar.Size = new Size(138, 42);
            BtnModificar.TabIndex = 21;
            BtnModificar.Text = "Modificar";
            BtnModificar.UseVisualStyleBackColor = true;
            BtnModificar.Click += BtnModificar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(498, 571);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(138, 42);
            btnCancelar.TabIndex = 22;
            btnCancelar.Text = "Salir";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // LblTitulo
            // 
            LblTitulo.AutoSize = true;
            LblTitulo.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            LblTitulo.Location = new Point(255, 9);
            LblTitulo.Name = "LblTitulo";
            LblTitulo.Size = new Size(203, 32);
            LblTitulo.TabIndex = 23;
            LblTitulo.Text = "Modificar clientes";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(82, 143);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(215, 23);
            txtNombre.TabIndex = 24;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(421, 213);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(39, 15);
            lblEmail.TabIndex = 27;
            lblEmail.Text = "Email:";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(421, 233);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(215, 23);
            txtEmail.TabIndex = 28;
            // 
            // txtDocumento
            // 
            txtDocumento.Location = new Point(82, 485);
            txtDocumento.Name = "txtDocumento";
            txtDocumento.Size = new Size(215, 23);
            txtDocumento.TabIndex = 32;
            // 
            // txtAltura
            // 
            txtAltura.Location = new Point(421, 485);
            txtAltura.Name = "txtAltura";
            txtAltura.Size = new Size(215, 23);
            txtAltura.TabIndex = 33;
            // 
            // txtCalle
            // 
            txtCalle.Location = new Point(421, 409);
            txtCalle.Name = "txtCalle";
            txtCalle.Size = new Size(215, 23);
            txtCalle.TabIndex = 34;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(82, 233);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(215, 23);
            txtTelefono.TabIndex = 35;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(421, 143);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(215, 23);
            txtApellido.TabIndex = 36;
            // 
            // cboBarrio
            // 
            cboBarrio.FormattingEnabled = true;
            cboBarrio.Location = new Point(421, 325);
            cboBarrio.Name = "cboBarrio";
            cboBarrio.Size = new Size(215, 23);
            cboBarrio.TabIndex = 37;
            // 
            // lblClienteNro
            // 
            lblClienteNro.AutoSize = true;
            lblClienteNro.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblClienteNro.Location = new Point(82, 69);
            lblClienteNro.Name = "lblClienteNro";
            lblClienteNro.Size = new Size(92, 21);
            lblClienteNro.TabIndex = 38;
            lblClienteNro.Text = "Cliente Nro:";
            // 
            // FrmModificarCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(675, 658);
            Controls.Add(lblClienteNro);
            Controls.Add(cboBarrio);
            Controls.Add(txtApellido);
            Controls.Add(txtTelefono);
            Controls.Add(txtCalle);
            Controls.Add(txtAltura);
            Controls.Add(txtDocumento);
            Controls.Add(txtEmail);
            Controls.Add(lblEmail);
            Controls.Add(txtNombre);
            Controls.Add(LblTitulo);
            Controls.Add(btnCancelar);
            Controls.Add(BtnModificar);
            Controls.Add(lblCalle);
            Controls.Add(cboTipoDocumento);
            Controls.Add(lblTelefono);
            Controls.Add(lblFechaNacimiento);
            Controls.Add(lblDocumento);
            Controls.Add(lblAltura);
            Controls.Add(lblBarrio);
            Controls.Add(lblApellido);
            Controls.Add(dtpFechaNacimiento);
            Controls.Add(lblNombre);
            Controls.Add(lblTipoDocumento);
            Name = "FrmModificarCliente";
            Text = "FrmModificarCliente";
            Load += FrmModificarCliente_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblTipoDocumento;
        private Label lblNombre;
        private DateTimePicker dtpFechaNacimiento;
        private Label lblApellido;
        private Label lblBarrio;
        private Label lblAltura;
        private Label lblDocumento;
        private Label lblFechaNacimiento;
        private Label lblTelefono;
        private ComboBox cboTipoDocumento;
        private Label lblCalle;
        private Button BtnModificar;
        private Button btnCancelar;
        private Label LblTitulo;
        private TextBox txtNombre;
        private Label lblEmail;
        private TextBox txtEmail;
        private TextBox txtDocumento;
        private TextBox txtAltura;
        private TextBox txtCalle;
        private TextBox txtTelefono;
        private TextBox txtApellido;
        private ComboBox cboBarrio;
        private Label lblClienteNro;
    }
}