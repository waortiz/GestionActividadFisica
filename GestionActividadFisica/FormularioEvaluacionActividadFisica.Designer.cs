namespace GestionActividadFisica
{
    partial class FormularioEvaluacionActividadFisica
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
            components = new System.ComponentModel.Container();
            btnGuardar = new Button();
            btnCancelar = new Button();
            gbDatosBasicos = new GroupBox();
            gbSexo = new GroupBox();
            rdbMasculino = new RadioButton();
            rdbFemenino = new RadioButton();
            lblSexo = new Label();
            lblFechaNacimiento = new Label();
            dtpFechaNacimiento = new DateTimePicker();
            txtNumeroDocumento = new TextBox();
            lblNumeroDocumento = new Label();
            lblTipoDocumento = new Label();
            cboTipoDocumento = new ComboBox();
            txtSegundoApellido = new TextBox();
            lblSegundoApellido = new Label();
            txtPrimerApellido = new TextBox();
            lblPrimerApellido = new Label();
            txtSegundoNombre = new TextBox();
            lblSegundoNombre = new Label();
            txtPrimerNombre = new TextBox();
            lblPrimerNombre = new Label();
            gbEvaluacion = new GroupBox();
            gbCondicionEmocional = new GroupBox();
            rdbAlegre = new RadioButton();
            rdbTriste = new RadioButton();
            rdbNormal = new RadioButton();
            lblCondicionEmocional = new Label();
            txtTalla = new TextBox();
            lblTalla = new Label();
            txtPeso = new TextBox();
            lblPeso = new Label();
            lblCiudadEvaluacion = new Label();
            cboCiudadEvaluacion = new ComboBox();
            chkCancer = new CheckBox();
            label1 = new Label();
            chkDiabetes = new CheckBox();
            lblFechaEvaluacion = new Label();
            dtpFechaEvaluacion = new DateTimePicker();
            erpError = new ErrorProvider(components);
            gbDatosBasicos.SuspendLayout();
            gbSexo.SuspendLayout();
            gbEvaluacion.SuspendLayout();
            gbCondicionEmocional.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)erpError).BeginInit();
            SuspendLayout();
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(1311, 636);
            btnGuardar.Margin = new Padding(3, 4, 3, 4);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(134, 52);
            btnGuardar.TabIndex = 20;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(1150, 636);
            btnCancelar.Margin = new Padding(3, 4, 3, 4);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(134, 52);
            btnCancelar.TabIndex = 21;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // gbDatosBasicos
            // 
            gbDatosBasicos.Controls.Add(gbSexo);
            gbDatosBasicos.Controls.Add(lblSexo);
            gbDatosBasicos.Controls.Add(lblFechaNacimiento);
            gbDatosBasicos.Controls.Add(dtpFechaNacimiento);
            gbDatosBasicos.Controls.Add(txtNumeroDocumento);
            gbDatosBasicos.Controls.Add(lblNumeroDocumento);
            gbDatosBasicos.Controls.Add(lblTipoDocumento);
            gbDatosBasicos.Controls.Add(cboTipoDocumento);
            gbDatosBasicos.Controls.Add(txtSegundoApellido);
            gbDatosBasicos.Controls.Add(lblSegundoApellido);
            gbDatosBasicos.Controls.Add(txtPrimerApellido);
            gbDatosBasicos.Controls.Add(lblPrimerApellido);
            gbDatosBasicos.Controls.Add(txtSegundoNombre);
            gbDatosBasicos.Controls.Add(lblSegundoNombre);
            gbDatosBasicos.Controls.Add(txtPrimerNombre);
            gbDatosBasicos.Controls.Add(lblPrimerNombre);
            gbDatosBasicos.Location = new Point(62, 47);
            gbDatosBasicos.Name = "gbDatosBasicos";
            gbDatosBasicos.Size = new Size(680, 530);
            gbDatosBasicos.TabIndex = 22;
            gbDatosBasicos.TabStop = false;
            gbDatosBasicos.Text = "Datos Básicos";
            // 
            // gbSexo
            // 
            gbSexo.Controls.Add(rdbMasculino);
            gbSexo.Controls.Add(rdbFemenino);
            gbSexo.Location = new Point(235, 413);
            gbSexo.Margin = new Padding(3, 4, 3, 4);
            gbSexo.Name = "gbSexo";
            gbSexo.Padding = new Padding(3, 4, 3, 4);
            gbSexo.Size = new Size(386, 57);
            gbSexo.TabIndex = 36;
            gbSexo.TabStop = false;
            // 
            // rdbMasculino
            // 
            rdbMasculino.AutoSize = true;
            rdbMasculino.Location = new Point(207, 21);
            rdbMasculino.Margin = new Padding(3, 4, 3, 4);
            rdbMasculino.Name = "rdbMasculino";
            rdbMasculino.Size = new Size(97, 24);
            rdbMasculino.TabIndex = 8;
            rdbMasculino.TabStop = true;
            rdbMasculino.Text = "Masculino";
            rdbMasculino.UseVisualStyleBackColor = true;
            // 
            // rdbFemenino
            // 
            rdbFemenino.AutoSize = true;
            rdbFemenino.Location = new Point(88, 21);
            rdbFemenino.Margin = new Padding(3, 4, 3, 4);
            rdbFemenino.Name = "rdbFemenino";
            rdbFemenino.Size = new Size(95, 24);
            rdbFemenino.TabIndex = 7;
            rdbFemenino.TabStop = true;
            rdbFemenino.Text = "Femenino";
            rdbFemenino.UseVisualStyleBackColor = true;
            // 
            // lblSexo
            // 
            lblSexo.AutoSize = true;
            lblSexo.Location = new Point(40, 436);
            lblSexo.Name = "lblSexo";
            lblSexo.Size = new Size(41, 20);
            lblSexo.TabIndex = 35;
            lblSexo.Text = "Sexo";
            // 
            // lblFechaNacimiento
            // 
            lblFechaNacimiento.AutoSize = true;
            lblFechaNacimiento.Location = new Point(40, 362);
            lblFechaNacimiento.Name = "lblFechaNacimiento";
            lblFechaNacimiento.Size = new Size(146, 20);
            lblFechaNacimiento.TabIndex = 33;
            lblFechaNacimiento.Text = "Fecha de nacimiento";
            // 
            // dtpFechaNacimiento
            // 
            dtpFechaNacimiento.Format = DateTimePickerFormat.Short;
            dtpFechaNacimiento.Location = new Point(235, 357);
            dtpFechaNacimiento.Margin = new Padding(3, 4, 3, 4);
            dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            dtpFechaNacimiento.Size = new Size(386, 27);
            dtpFechaNacimiento.TabIndex = 32;
            // 
            // txtNumeroDocumento
            // 
            txtNumeroDocumento.Location = new Point(235, 300);
            txtNumeroDocumento.Name = "txtNumeroDocumento";
            txtNumeroDocumento.Size = new Size(386, 27);
            txtNumeroDocumento.TabIndex = 31;
            // 
            // lblNumeroDocumento
            // 
            lblNumeroDocumento.AutoSize = true;
            lblNumeroDocumento.Location = new Point(40, 300);
            lblNumeroDocumento.Name = "lblNumeroDocumento";
            lblNumeroDocumento.Size = new Size(164, 20);
            lblNumeroDocumento.TabIndex = 30;
            lblNumeroDocumento.Text = "Número de documento";
            // 
            // lblTipoDocumento
            // 
            lblTipoDocumento.AutoSize = true;
            lblTipoDocumento.Location = new Point(40, 250);
            lblTipoDocumento.Name = "lblTipoDocumento";
            lblTipoDocumento.Size = new Size(140, 20);
            lblTipoDocumento.TabIndex = 29;
            lblTipoDocumento.Text = "Tipo de documento";
            // 
            // cboTipoDocumento
            // 
            cboTipoDocumento.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTipoDocumento.FormattingEnabled = true;
            cboTipoDocumento.Items.AddRange(new object[] { "MEDELLÍN", "CALI", "SABANETA", "BELLO", "EVIGADO ", "LA ESTRELLA" });
            cboTipoDocumento.Location = new Point(235, 247);
            cboTipoDocumento.Margin = new Padding(3, 4, 3, 4);
            cboTipoDocumento.Name = "cboTipoDocumento";
            cboTipoDocumento.Size = new Size(386, 28);
            cboTipoDocumento.TabIndex = 28;
            // 
            // txtSegundoApellido
            // 
            txtSegundoApellido.Location = new Point(235, 200);
            txtSegundoApellido.Name = "txtSegundoApellido";
            txtSegundoApellido.Size = new Size(386, 27);
            txtSegundoApellido.TabIndex = 7;
            // 
            // lblSegundoApellido
            // 
            lblSegundoApellido.AutoSize = true;
            lblSegundoApellido.Location = new Point(40, 207);
            lblSegundoApellido.Name = "lblSegundoApellido";
            lblSegundoApellido.Size = new Size(127, 20);
            lblSegundoApellido.TabIndex = 6;
            lblSegundoApellido.Text = "Segundo apellido";
            // 
            // txtPrimerApellido
            // 
            txtPrimerApellido.Location = new Point(235, 146);
            txtPrimerApellido.Name = "txtPrimerApellido";
            txtPrimerApellido.Size = new Size(386, 27);
            txtPrimerApellido.TabIndex = 5;
            // 
            // lblPrimerApellido
            // 
            lblPrimerApellido.AutoSize = true;
            lblPrimerApellido.Location = new Point(40, 153);
            lblPrimerApellido.Name = "lblPrimerApellido";
            lblPrimerApellido.Size = new Size(111, 20);
            lblPrimerApellido.TabIndex = 4;
            lblPrimerApellido.Text = "Primer apellido";
            // 
            // txtSegundoNombre
            // 
            txtSegundoNombre.Location = new Point(235, 97);
            txtSegundoNombre.Name = "txtSegundoNombre";
            txtSegundoNombre.Size = new Size(386, 27);
            txtSegundoNombre.TabIndex = 3;
            // 
            // lblSegundoNombre
            // 
            lblSegundoNombre.AutoSize = true;
            lblSegundoNombre.Location = new Point(40, 104);
            lblSegundoNombre.Name = "lblSegundoNombre";
            lblSegundoNombre.Size = new Size(124, 20);
            lblSegundoNombre.TabIndex = 2;
            lblSegundoNombre.Text = "Segundo nombre";
            // 
            // txtPrimerNombre
            // 
            txtPrimerNombre.Location = new Point(235, 43);
            txtPrimerNombre.Name = "txtPrimerNombre";
            txtPrimerNombre.Size = new Size(386, 27);
            txtPrimerNombre.TabIndex = 1;
            // 
            // lblPrimerNombre
            // 
            lblPrimerNombre.AutoSize = true;
            lblPrimerNombre.Location = new Point(40, 50);
            lblPrimerNombre.Name = "lblPrimerNombre";
            lblPrimerNombre.Size = new Size(108, 20);
            lblPrimerNombre.TabIndex = 0;
            lblPrimerNombre.Text = "Primer nombre";
            // 
            // gbEvaluacion
            // 
            gbEvaluacion.Controls.Add(gbCondicionEmocional);
            gbEvaluacion.Controls.Add(lblCondicionEmocional);
            gbEvaluacion.Controls.Add(txtTalla);
            gbEvaluacion.Controls.Add(lblTalla);
            gbEvaluacion.Controls.Add(txtPeso);
            gbEvaluacion.Controls.Add(lblPeso);
            gbEvaluacion.Controls.Add(lblCiudadEvaluacion);
            gbEvaluacion.Controls.Add(cboCiudadEvaluacion);
            gbEvaluacion.Controls.Add(chkCancer);
            gbEvaluacion.Controls.Add(label1);
            gbEvaluacion.Controls.Add(chkDiabetes);
            gbEvaluacion.Controls.Add(lblFechaEvaluacion);
            gbEvaluacion.Controls.Add(dtpFechaEvaluacion);
            gbEvaluacion.Location = new Point(763, 47);
            gbEvaluacion.Name = "gbEvaluacion";
            gbEvaluacion.Size = new Size(682, 530);
            gbEvaluacion.TabIndex = 23;
            gbEvaluacion.TabStop = false;
            gbEvaluacion.Text = "Evaluación";
            // 
            // gbCondicionEmocional
            // 
            gbCondicionEmocional.Controls.Add(rdbAlegre);
            gbCondicionEmocional.Controls.Add(rdbTriste);
            gbCondicionEmocional.Controls.Add(rdbNormal);
            gbCondicionEmocional.Location = new Point(217, 351);
            gbCondicionEmocional.Margin = new Padding(3, 4, 3, 4);
            gbCondicionEmocional.Name = "gbCondicionEmocional";
            gbCondicionEmocional.Padding = new Padding(3, 4, 3, 4);
            gbCondicionEmocional.Size = new Size(386, 69);
            gbCondicionEmocional.TabIndex = 33;
            gbCondicionEmocional.TabStop = false;
            // 
            // rdbAlegre
            // 
            rdbAlegre.AutoSize = true;
            rdbAlegre.Location = new Point(62, 30);
            rdbAlegre.Margin = new Padding(3, 4, 3, 4);
            rdbAlegre.Name = "rdbAlegre";
            rdbAlegre.Size = new Size(74, 24);
            rdbAlegre.TabIndex = 15;
            rdbAlegre.TabStop = true;
            rdbAlegre.Text = "Alegre";
            rdbAlegre.UseVisualStyleBackColor = true;
            // 
            // rdbTriste
            // 
            rdbTriste.AutoSize = true;
            rdbTriste.Location = new Point(265, 30);
            rdbTriste.Margin = new Padding(3, 4, 3, 4);
            rdbTriste.Name = "rdbTriste";
            rdbTriste.Size = new Size(65, 24);
            rdbTriste.TabIndex = 17;
            rdbTriste.TabStop = true;
            rdbTriste.Text = "Triste";
            rdbTriste.UseVisualStyleBackColor = true;
            // 
            // rdbNormal
            // 
            rdbNormal.AutoSize = true;
            rdbNormal.Location = new Point(162, 30);
            rdbNormal.Margin = new Padding(3, 4, 3, 4);
            rdbNormal.Name = "rdbNormal";
            rdbNormal.Size = new Size(80, 24);
            rdbNormal.TabIndex = 16;
            rdbNormal.TabStop = true;
            rdbNormal.Text = "Normal";
            rdbNormal.UseVisualStyleBackColor = true;
            // 
            // lblCondicionEmocional
            // 
            lblCondicionEmocional.AutoSize = true;
            lblCondicionEmocional.Location = new Point(47, 384);
            lblCondicionEmocional.Name = "lblCondicionEmocional";
            lblCondicionEmocional.Size = new Size(150, 20);
            lblCondicionEmocional.TabIndex = 32;
            lblCondicionEmocional.Text = "Condición emocional";
            // 
            // txtTalla
            // 
            txtTalla.Location = new Point(217, 299);
            txtTalla.Margin = new Padding(3, 4, 3, 4);
            txtTalla.Name = "txtTalla";
            txtTalla.Size = new Size(386, 27);
            txtTalla.TabIndex = 31;
            txtTalla.KeyPress += txtTalla_KeyPress;
            // 
            // lblTalla
            // 
            lblTalla.AutoSize = true;
            lblTalla.Location = new Point(47, 306);
            lblTalla.Name = "lblTalla";
            lblTalla.Size = new Size(39, 20);
            lblTalla.TabIndex = 30;
            lblTalla.Text = "Talla";
            // 
            // txtPeso
            // 
            txtPeso.Location = new Point(217, 237);
            txtPeso.Margin = new Padding(3, 4, 3, 4);
            txtPeso.Name = "txtPeso";
            txtPeso.Size = new Size(386, 27);
            txtPeso.TabIndex = 29;
            txtPeso.KeyPress += txtPeso_KeyPress;
            // 
            // lblPeso
            // 
            lblPeso.AutoSize = true;
            lblPeso.Location = new Point(47, 244);
            lblPeso.Name = "lblPeso";
            lblPeso.Size = new Size(39, 20);
            lblPeso.TabIndex = 28;
            lblPeso.Text = "Peso";
            // 
            // lblCiudadEvaluacion
            // 
            lblCiudadEvaluacion.AutoSize = true;
            lblCiudadEvaluacion.Location = new Point(45, 181);
            lblCiudadEvaluacion.Name = "lblCiudadEvaluacion";
            lblCiudadEvaluacion.Size = new Size(131, 20);
            lblCiudadEvaluacion.TabIndex = 27;
            lblCiudadEvaluacion.Text = "Ciudad Evaluación";
            // 
            // cboCiudadEvaluacion
            // 
            cboCiudadEvaluacion.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCiudadEvaluacion.FormattingEnabled = true;
            cboCiudadEvaluacion.Items.AddRange(new object[] { "MEDELLÍN", "CALI", "SABANETA", "BELLO", "EVIGADO ", "LA ESTRELLA" });
            cboCiudadEvaluacion.Location = new Point(217, 178);
            cboCiudadEvaluacion.Margin = new Padding(3, 4, 3, 4);
            cboCiudadEvaluacion.Name = "cboCiudadEvaluacion";
            cboCiudadEvaluacion.Size = new Size(386, 28);
            cboCiudadEvaluacion.TabIndex = 26;
            // 
            // chkCancer
            // 
            chkCancer.AutoSize = true;
            chkCancer.Location = new Point(338, 114);
            chkCancer.Margin = new Padding(3, 4, 3, 4);
            chkCancer.Name = "chkCancer";
            chkCancer.Size = new Size(76, 24);
            chkCancer.TabIndex = 24;
            chkCancer.Text = "Cáncer";
            chkCancer.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(45, 118);
            label1.Name = "label1";
            label1.Size = new Size(99, 20);
            label1.TabIndex = 23;
            label1.Text = "Antecedentes";
            // 
            // chkDiabetes
            // 
            chkDiabetes.AutoSize = true;
            chkDiabetes.Location = new Point(217, 114);
            chkDiabetes.Margin = new Padding(3, 4, 3, 4);
            chkDiabetes.Name = "chkDiabetes";
            chkDiabetes.Size = new Size(90, 24);
            chkDiabetes.TabIndex = 22;
            chkDiabetes.Text = "Diabetes";
            chkDiabetes.UseVisualStyleBackColor = true;
            // 
            // lblFechaEvaluacion
            // 
            lblFechaEvaluacion.AutoSize = true;
            lblFechaEvaluacion.Location = new Point(45, 44);
            lblFechaEvaluacion.Name = "lblFechaEvaluacion";
            lblFechaEvaluacion.Size = new Size(122, 20);
            lblFechaEvaluacion.TabIndex = 21;
            lblFechaEvaluacion.Text = "Fecha evaluación";
            // 
            // dtpFechaEvaluacion
            // 
            dtpFechaEvaluacion.Format = DateTimePickerFormat.Short;
            dtpFechaEvaluacion.Location = new Point(217, 39);
            dtpFechaEvaluacion.Margin = new Padding(3, 4, 3, 4);
            dtpFechaEvaluacion.Name = "dtpFechaEvaluacion";
            dtpFechaEvaluacion.Size = new Size(386, 27);
            dtpFechaEvaluacion.TabIndex = 20;
            // 
            // erpError
            // 
            erpError.ContainerControl = this;
            // 
            // FormularioEvaluacionActividadFisica
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1518, 739);
            Controls.Add(gbEvaluacion);
            Controls.Add(gbDatosBasicos);
            Controls.Add(btnCancelar);
            Controls.Add(btnGuardar);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormularioEvaluacionActividadFisica";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Evaluación Actividad Física";
            Load += FormularioEvaluacionActividadFisica_Load;
            gbDatosBasicos.ResumeLayout(false);
            gbDatosBasicos.PerformLayout();
            gbSexo.ResumeLayout(false);
            gbSexo.PerformLayout();
            gbEvaluacion.ResumeLayout(false);
            gbEvaluacion.PerformLayout();
            gbCondicionEmocional.ResumeLayout(false);
            gbCondicionEmocional.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)erpError).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button btnGuardar;
        private Button btnCancelar;
        private GroupBox gbDatosBasicos;
        private GroupBox gbEvaluacion;
        private Label lblFechaNacimiento;
        private DateTimePicker dtpFechaNacimiento;
        private TextBox txtNumeroDocumento;
        private Label lblNumeroDocumento;
        private Label lblTipoDocumento;
        private ComboBox cboTipoDocumento;
        private TextBox txtSegundoApellido;
        private Label lblSegundoApellido;
        private TextBox txtPrimerApellido;
        private Label lblPrimerApellido;
        private TextBox txtSegundoNombre;
        private Label lblSegundoNombre;
        private TextBox txtPrimerNombre;
        private Label lblPrimerNombre;
        private GroupBox gbCondicionEmocional;
        private RadioButton rdbAlegre;
        private RadioButton rdbTriste;
        private RadioButton rdbNormal;
        private Label lblCondicionEmocional;
        private TextBox txtTalla;
        private Label lblTalla;
        private TextBox txtPeso;
        private Label lblPeso;
        private Label lblCiudadEvaluacion;
        private ComboBox cboCiudadEvaluacion;
        private CheckBox chkCancer;
        private Label label1;
        private CheckBox chkDiabetes;
        private Label lblFechaEvaluacion;
        private DateTimePicker dtpFechaEvaluacion;
        private GroupBox gbSexo;
        private RadioButton rdbMasculino;
        private RadioButton rdbFemenino;
        private Label lblSexo;
        private ErrorProvider erpError;
    }
}