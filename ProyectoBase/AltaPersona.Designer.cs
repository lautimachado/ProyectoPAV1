namespace ProyectoBase
{
    partial class AltaPersona
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
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.lblApellido = new System.Windows.Forms.Label();
            this.txtFechaNacimiento = new System.Windows.Forms.MaskedTextBox();
            this.lblFechaNacimiento = new System.Windows.Forms.Label();
            this.lblSexo = new System.Windows.Forms.Label();
            this.pnlSexo = new System.Windows.Forms.Panel();
            this.rbOtro = new System.Windows.Forms.RadioButton();
            this.rbMasculino = new System.Windows.Forms.RadioButton();
            this.rbFemenino = new System.Windows.Forms.RadioButton();
            this.lblTipoDoc = new System.Windows.Forms.Label();
            this.cmbTipoDoc = new System.Windows.Forms.ComboBox();
            this.lnlNumeroDoc = new System.Windows.Forms.Label();
            this.txtNumeroDoc = new System.Windows.Forms.MaskedTextBox();
            this.lblCalle = new System.Windows.Forms.Label();
            this.lblNumeroCalle = new System.Windows.Forms.Label();
            this.txtCalle = new System.Windows.Forms.TextBox();
            this.txtNroCalle = new System.Windows.Forms.MaskedTextBox();
            this.chkSoltero = new System.Windows.Forms.CheckBox();
            this.chkCasado = new System.Windows.Forms.CheckBox();
            this.chkHijos = new System.Windows.Forms.CheckBox();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.txtCantidadHijos = new System.Windows.Forms.MaskedTextBox();
            this.cmbCarrera = new System.Windows.Forms.ComboBox();
            this.lblCarrera = new System.Windows.Forms.Label();
            this.btnGuardarPersona = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.lblAltaDeNuevaPersona = new System.Windows.Forms.Label();
            this.gdrPersonas = new System.Windows.Forms.DataGridView();
            this.TipoDocumento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Documento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apelldio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlSexo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdrPersonas)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(105, 31);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(69, 17);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(180, 31);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(159, 20);
            this.txtNombre.TabIndex = 1;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(180, 48);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(159, 20);
            this.txtApellido.TabIndex = 3;
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellido.Location = new System.Drawing.Point(103, 48);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(71, 17);
            this.lblApellido.TabIndex = 2;
            this.lblApellido.Text = "Apellido:";
            // 
            // txtFechaNacimiento
            // 
            this.txtFechaNacimiento.Location = new System.Drawing.Point(180, 65);
            this.txtFechaNacimiento.Mask = "00/00/0000";
            this.txtFechaNacimiento.Name = "txtFechaNacimiento";
            this.txtFechaNacimiento.Size = new System.Drawing.Size(65, 20);
            this.txtFechaNacimiento.TabIndex = 4;
            this.txtFechaNacimiento.ValidatingType = typeof(System.DateTime);
            // 
            // lblFechaNacimiento
            // 
            this.lblFechaNacimiento.AutoSize = true;
            this.lblFechaNacimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaNacimiento.Location = new System.Drawing.Point(11, 65);
            this.lblFechaNacimiento.Name = "lblFechaNacimiento";
            this.lblFechaNacimiento.Size = new System.Drawing.Size(163, 17);
            this.lblFechaNacimiento.TabIndex = 5;
            this.lblFechaNacimiento.Text = "Fecha de nacimiento:";
            // 
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSexo.Location = new System.Drawing.Point(125, 82);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(48, 17);
            this.lblSexo.TabIndex = 6;
            this.lblSexo.Text = "Sexo:";
            // 
            // pnlSexo
            // 
            this.pnlSexo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlSexo.Controls.Add(this.rbOtro);
            this.pnlSexo.Controls.Add(this.rbMasculino);
            this.pnlSexo.Controls.Add(this.rbFemenino);
            this.pnlSexo.Location = new System.Drawing.Point(180, 82);
            this.pnlSexo.Name = "pnlSexo";
            this.pnlSexo.Size = new System.Drawing.Size(84, 73);
            this.pnlSexo.TabIndex = 7;
            // 
            // rbOtro
            // 
            this.rbOtro.AutoSize = true;
            this.rbOtro.Location = new System.Drawing.Point(3, 45);
            this.rbOtro.Name = "rbOtro";
            this.rbOtro.Size = new System.Drawing.Size(45, 17);
            this.rbOtro.TabIndex = 10;
            this.rbOtro.TabStop = true;
            this.rbOtro.Text = "Otro";
            this.rbOtro.UseVisualStyleBackColor = true;
            // 
            // rbMasculino
            // 
            this.rbMasculino.AutoSize = true;
            this.rbMasculino.Location = new System.Drawing.Point(3, -1);
            this.rbMasculino.Name = "rbMasculino";
            this.rbMasculino.Size = new System.Drawing.Size(73, 17);
            this.rbMasculino.TabIndex = 8;
            this.rbMasculino.TabStop = true;
            this.rbMasculino.Text = "Masculino";
            this.rbMasculino.UseVisualStyleBackColor = true;
            // 
            // rbFemenino
            // 
            this.rbFemenino.AutoSize = true;
            this.rbFemenino.Location = new System.Drawing.Point(5, 22);
            this.rbFemenino.Name = "rbFemenino";
            this.rbFemenino.Size = new System.Drawing.Size(71, 17);
            this.rbFemenino.TabIndex = 9;
            this.rbFemenino.TabStop = true;
            this.rbFemenino.Text = "Femenino";
            this.rbFemenino.UseVisualStyleBackColor = true;
            // 
            // lblTipoDoc
            // 
            this.lblTipoDoc.AutoSize = true;
            this.lblTipoDoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoDoc.Location = new System.Drawing.Point(21, 151);
            this.lblTipoDoc.Name = "lblTipoDoc";
            this.lblTipoDoc.Size = new System.Drawing.Size(152, 17);
            this.lblTipoDoc.TabIndex = 8;
            this.lblTipoDoc.Text = "Tipo de documento:";
            // 
            // cmbTipoDoc
            // 
            this.cmbTipoDoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoDoc.FormattingEnabled = true;
            this.cmbTipoDoc.Location = new System.Drawing.Point(180, 151);
            this.cmbTipoDoc.Name = "cmbTipoDoc";
            this.cmbTipoDoc.Size = new System.Drawing.Size(121, 21);
            this.cmbTipoDoc.TabIndex = 9;
            // 
            // lnlNumeroDoc
            // 
            this.lnlNumeroDoc.AutoSize = true;
            this.lnlNumeroDoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnlNumeroDoc.Location = new System.Drawing.Point(-2, 181);
            this.lnlNumeroDoc.Name = "lnlNumeroDoc";
            this.lnlNumeroDoc.Size = new System.Drawing.Size(176, 17);
            this.lnlNumeroDoc.TabIndex = 10;
            this.lnlNumeroDoc.Text = "Numero de documento:";
            // 
            // txtNumeroDoc
            // 
            this.txtNumeroDoc.Location = new System.Drawing.Point(180, 178);
            this.txtNumeroDoc.Mask = "99999999";
            this.txtNumeroDoc.Name = "txtNumeroDoc";
            this.txtNumeroDoc.Size = new System.Drawing.Size(100, 20);
            this.txtNumeroDoc.TabIndex = 11;
            this.txtNumeroDoc.ValidatingType = typeof(int);
            // 
            // lblCalle
            // 
            this.lblCalle.AutoSize = true;
            this.lblCalle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCalle.Location = new System.Drawing.Point(124, 209);
            this.lblCalle.Name = "lblCalle";
            this.lblCalle.Size = new System.Drawing.Size(49, 17);
            this.lblCalle.TabIndex = 12;
            this.lblCalle.Text = "Calle:";
            // 
            // lblNumeroCalle
            // 
            this.lblNumeroCalle.AutoSize = true;
            this.lblNumeroCalle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroCalle.Location = new System.Drawing.Point(42, 235);
            this.lblNumeroCalle.Name = "lblNumeroCalle";
            this.lblNumeroCalle.Size = new System.Drawing.Size(131, 17);
            this.lblNumeroCalle.TabIndex = 13;
            this.lblNumeroCalle.Text = "Numero de calle:";
            // 
            // txtCalle
            // 
            this.txtCalle.Location = new System.Drawing.Point(180, 209);
            this.txtCalle.Name = "txtCalle";
            this.txtCalle.Size = new System.Drawing.Size(159, 20);
            this.txtCalle.TabIndex = 14;
            // 
            // txtNroCalle
            // 
            this.txtNroCalle.Location = new System.Drawing.Point(180, 235);
            this.txtNroCalle.Mask = "99999";
            this.txtNroCalle.Name = "txtNroCalle";
            this.txtNroCalle.Size = new System.Drawing.Size(100, 20);
            this.txtNroCalle.TabIndex = 15;
            this.txtNroCalle.ValidatingType = typeof(int);
            // 
            // chkSoltero
            // 
            this.chkSoltero.AutoSize = true;
            this.chkSoltero.Location = new System.Drawing.Point(180, 262);
            this.chkSoltero.Name = "chkSoltero";
            this.chkSoltero.Size = new System.Drawing.Size(59, 17);
            this.chkSoltero.TabIndex = 16;
            this.chkSoltero.Text = "Soltero";
            this.chkSoltero.UseVisualStyleBackColor = true;
            // 
            // chkCasado
            // 
            this.chkCasado.AutoSize = true;
            this.chkCasado.Location = new System.Drawing.Point(180, 286);
            this.chkCasado.Name = "chkCasado";
            this.chkCasado.Size = new System.Drawing.Size(62, 17);
            this.chkCasado.TabIndex = 17;
            this.chkCasado.Text = "Casado";
            this.chkCasado.UseVisualStyleBackColor = true;
            // 
            // chkHijos
            // 
            this.chkHijos.AutoSize = true;
            this.chkHijos.Location = new System.Drawing.Point(180, 310);
            this.chkHijos.Name = "chkHijos";
            this.chkHijos.Size = new System.Drawing.Size(49, 17);
            this.chkHijos.TabIndex = 18;
            this.chkHijos.Text = "Hijos";
            this.chkHijos.UseVisualStyleBackColor = true;
            this.chkHijos.CheckedChanged += new System.EventHandler(this.chkHijos_CheckedChanged);
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(235, 311);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(91, 13);
            this.lblCantidad.TabIndex = 19;
            this.lblCantidad.Text = "Cantidad de hijos:";
            // 
            // txtCantidadHijos
            // 
            this.txtCantidadHijos.Location = new System.Drawing.Point(332, 307);
            this.txtCantidadHijos.Mask = "12";
            this.txtCantidadHijos.Name = "txtCantidadHijos";
            this.txtCantidadHijos.Size = new System.Drawing.Size(21, 20);
            this.txtCantidadHijos.TabIndex = 20;
            this.txtCantidadHijos.ValidatingType = typeof(int);
            // 
            // cmbCarrera
            // 
            this.cmbCarrera.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCarrera.FormattingEnabled = true;
            this.cmbCarrera.Location = new System.Drawing.Point(180, 338);
            this.cmbCarrera.Name = "cmbCarrera";
            this.cmbCarrera.Size = new System.Drawing.Size(121, 21);
            this.cmbCarrera.TabIndex = 22;
            // 
            // lblCarrera
            // 
            this.lblCarrera.AutoSize = true;
            this.lblCarrera.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCarrera.Location = new System.Drawing.Point(103, 338);
            this.lblCarrera.Name = "lblCarrera";
            this.lblCarrera.Size = new System.Drawing.Size(68, 17);
            this.lblCarrera.TabIndex = 21;
            this.lblCarrera.Text = "Carrera:";
            // 
            // btnGuardarPersona
            // 
            this.btnGuardarPersona.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarPersona.Location = new System.Drawing.Point(52, 388);
            this.btnGuardarPersona.Name = "btnGuardarPersona";
            this.btnGuardarPersona.Size = new System.Drawing.Size(119, 50);
            this.btnGuardarPersona.TabIndex = 23;
            this.btnGuardarPersona.Text = "Guardar persona";
            this.btnGuardarPersona.UseVisualStyleBackColor = true;
            this.btnGuardarPersona.Click += new System.EventHandler(this.btnGuardarPersona_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Location = new System.Drawing.Point(177, 388);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(115, 50);
            this.btnLimpiar.TabIndex = 24;
            this.btnLimpiar.Text = "Limpiar campos";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // lblAltaDeNuevaPersona
            // 
            this.lblAltaDeNuevaPersona.AutoSize = true;
            this.lblAltaDeNuevaPersona.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAltaDeNuevaPersona.ForeColor = System.Drawing.Color.Lime;
            this.lblAltaDeNuevaPersona.Location = new System.Drawing.Point(-2, -1);
            this.lblAltaDeNuevaPersona.Name = "lblAltaDeNuevaPersona";
            this.lblAltaDeNuevaPersona.Size = new System.Drawing.Size(229, 25);
            this.lblAltaDeNuevaPersona.TabIndex = 25;
            this.lblAltaDeNuevaPersona.Text = "Alta de nueva persona";
            // 
            // gdrPersonas
            // 
            this.gdrPersonas.AllowUserToAddRows = false;
            this.gdrPersonas.AllowUserToDeleteRows = false;
            this.gdrPersonas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gdrPersonas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TipoDocumento,
            this.Documento,
            this.Nombre,
            this.Apelldio});
            this.gdrPersonas.Location = new System.Drawing.Point(395, 31);
            this.gdrPersonas.Name = "gdrPersonas";
            this.gdrPersonas.ReadOnly = true;
            this.gdrPersonas.Size = new System.Drawing.Size(628, 407);
            this.gdrPersonas.TabIndex = 26;
            // 
            // TipoDocumento
            // 
            this.TipoDocumento.DataPropertyName = "IdTipoDocumento";
            this.TipoDocumento.HeaderText = "Tipo de documento";
            this.TipoDocumento.Name = "TipoDocumento";
            this.TipoDocumento.ReadOnly = true;
            this.TipoDocumento.Width = 80;
            // 
            // Documento
            // 
            this.Documento.DataPropertyName = "NumeroDocumento";
            this.Documento.HeaderText = "Documento";
            this.Documento.Name = "Documento";
            this.Documento.ReadOnly = true;
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = " Nombre";
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 250;
            // 
            // Apelldio
            // 
            this.Apelldio.DataPropertyName = "Apellido";
            this.Apelldio.HeaderText = "Apellido";
            this.Apelldio.Name = "Apelldio";
            this.Apelldio.ReadOnly = true;
            this.Apelldio.Width = 250;
            // 
            // AltaPersona
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1035, 450);
            this.Controls.Add(this.gdrPersonas);
            this.Controls.Add(this.lblAltaDeNuevaPersona);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnGuardarPersona);
            this.Controls.Add(this.cmbCarrera);
            this.Controls.Add(this.lblCarrera);
            this.Controls.Add(this.txtCantidadHijos);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.chkHijos);
            this.Controls.Add(this.chkCasado);
            this.Controls.Add(this.chkSoltero);
            this.Controls.Add(this.txtNroCalle);
            this.Controls.Add(this.txtCalle);
            this.Controls.Add(this.lblNumeroCalle);
            this.Controls.Add(this.lblCalle);
            this.Controls.Add(this.txtNumeroDoc);
            this.Controls.Add(this.lnlNumeroDoc);
            this.Controls.Add(this.cmbTipoDoc);
            this.Controls.Add(this.lblTipoDoc);
            this.Controls.Add(this.pnlSexo);
            this.Controls.Add(this.lblSexo);
            this.Controls.Add(this.lblFechaNacimiento);
            this.Controls.Add(this.txtFechaNacimiento);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblNombre);
            this.Name = "AltaPersona";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alta de nueva persona";
            this.Load += new System.EventHandler(this.AltaPersona_Load);
            this.pnlSexo.ResumeLayout(false);
            this.pnlSexo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdrPersonas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.MaskedTextBox txtFechaNacimiento;
        private System.Windows.Forms.Label lblFechaNacimiento;
        private System.Windows.Forms.Label lblSexo;
        private System.Windows.Forms.Panel pnlSexo;
        private System.Windows.Forms.RadioButton rbMasculino;
        private System.Windows.Forms.RadioButton rbFemenino;
        private System.Windows.Forms.RadioButton rbOtro;
        private System.Windows.Forms.Label lblTipoDoc;
        private System.Windows.Forms.ComboBox cmbTipoDoc;
        private System.Windows.Forms.Label lnlNumeroDoc;
        private System.Windows.Forms.MaskedTextBox txtNumeroDoc;
        private System.Windows.Forms.Label lblCalle;
        private System.Windows.Forms.Label lblNumeroCalle;
        private System.Windows.Forms.TextBox txtCalle;
        private System.Windows.Forms.MaskedTextBox txtNroCalle;
        private System.Windows.Forms.CheckBox chkSoltero;
        private System.Windows.Forms.CheckBox chkCasado;
        private System.Windows.Forms.CheckBox chkHijos;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.MaskedTextBox txtCantidadHijos;
        private System.Windows.Forms.ComboBox cmbCarrera;
        private System.Windows.Forms.Label lblCarrera;
        private System.Windows.Forms.Button btnGuardarPersona;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Label lblAltaDeNuevaPersona;
        private System.Windows.Forms.DataGridView gdrPersonas;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoDocumento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Documento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apelldio;
    }
}