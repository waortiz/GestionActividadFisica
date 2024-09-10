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
            this.components = new System.ComponentModel.Container();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.gbDatosBasicos = new System.Windows.Forms.GroupBox();
            this.gbSexo = new System.Windows.Forms.GroupBox();
            this.rdbMasculino = new System.Windows.Forms.RadioButton();
            this.rdbFemenino = new System.Windows.Forms.RadioButton();
            this.lblSexo = new System.Windows.Forms.Label();
            this.lblFechaNacimiento = new System.Windows.Forms.Label();
            this.dtpFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.txtNumeroDocumento = new System.Windows.Forms.TextBox();
            this.lblNumeroDocumento = new System.Windows.Forms.Label();
            this.lblTipoDocumento = new System.Windows.Forms.Label();
            this.cboTipoDocumento = new System.Windows.Forms.ComboBox();
            this.txtSegundoApellido = new System.Windows.Forms.TextBox();
            this.lblSegundoApellido = new System.Windows.Forms.Label();
            this.txtPrimerApellido = new System.Windows.Forms.TextBox();
            this.lblPrimerApellido = new System.Windows.Forms.Label();
            this.txtSegundoNombre = new System.Windows.Forms.TextBox();
            this.lblSegundoNombre = new System.Windows.Forms.Label();
            this.txtPrimerNombre = new System.Windows.Forms.TextBox();
            this.lblPrimerNombre = new System.Windows.Forms.Label();
            this.gbEvaluacion = new System.Windows.Forms.GroupBox();
            this.gbCondicionEmocional = new System.Windows.Forms.GroupBox();
            this.rdbAlegre = new System.Windows.Forms.RadioButton();
            this.rdbTriste = new System.Windows.Forms.RadioButton();
            this.rdbNormal = new System.Windows.Forms.RadioButton();
            this.lblCondicionEmocional = new System.Windows.Forms.Label();
            this.txtTalla = new System.Windows.Forms.TextBox();
            this.lblTalla = new System.Windows.Forms.Label();
            this.txtPeso = new System.Windows.Forms.TextBox();
            this.lblPeso = new System.Windows.Forms.Label();
            this.lblCiudadEvaluacion = new System.Windows.Forms.Label();
            this.cboCiudadEvaluacion = new System.Windows.Forms.ComboBox();
            this.chkCancer = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.chkDiabetes = new System.Windows.Forms.CheckBox();
            this.lblFechaEvaluacion = new System.Windows.Forms.Label();
            this.dtpFechaEvaluacion = new System.Windows.Forms.DateTimePicker();
            this.erpError = new System.Windows.Forms.ErrorProvider(this.components);
            this.gbDatosBasicos.SuspendLayout();
            this.gbSexo.SuspendLayout();
            this.gbEvaluacion.SuspendLayout();
            this.gbCondicionEmocional.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erpError)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(1147, 477);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(117, 39);
            this.btnGuardar.TabIndex = 20;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(1006, 477);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(117, 39);
            this.btnCancelar.TabIndex = 21;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // gbDatosBasicos
            // 
            this.gbDatosBasicos.Controls.Add(this.gbSexo);
            this.gbDatosBasicos.Controls.Add(this.lblSexo);
            this.gbDatosBasicos.Controls.Add(this.lblFechaNacimiento);
            this.gbDatosBasicos.Controls.Add(this.dtpFechaNacimiento);
            this.gbDatosBasicos.Controls.Add(this.txtNumeroDocumento);
            this.gbDatosBasicos.Controls.Add(this.lblNumeroDocumento);
            this.gbDatosBasicos.Controls.Add(this.lblTipoDocumento);
            this.gbDatosBasicos.Controls.Add(this.cboTipoDocumento);
            this.gbDatosBasicos.Controls.Add(this.txtSegundoApellido);
            this.gbDatosBasicos.Controls.Add(this.lblSegundoApellido);
            this.gbDatosBasicos.Controls.Add(this.txtPrimerApellido);
            this.gbDatosBasicos.Controls.Add(this.lblPrimerApellido);
            this.gbDatosBasicos.Controls.Add(this.txtSegundoNombre);
            this.gbDatosBasicos.Controls.Add(this.lblSegundoNombre);
            this.gbDatosBasicos.Controls.Add(this.txtPrimerNombre);
            this.gbDatosBasicos.Controls.Add(this.lblPrimerNombre);
            this.gbDatosBasicos.Location = new System.Drawing.Point(54, 35);
            this.gbDatosBasicos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbDatosBasicos.Name = "gbDatosBasicos";
            this.gbDatosBasicos.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbDatosBasicos.Size = new System.Drawing.Size(595, 398);
            this.gbDatosBasicos.TabIndex = 22;
            this.gbDatosBasicos.TabStop = false;
            this.gbDatosBasicos.Text = "Datos Básicos";
            // 
            // gbSexo
            // 
            this.gbSexo.Controls.Add(this.rdbMasculino);
            this.gbSexo.Controls.Add(this.rdbFemenino);
            this.gbSexo.Location = new System.Drawing.Point(206, 310);
            this.gbSexo.Name = "gbSexo";
            this.gbSexo.Size = new System.Drawing.Size(338, 43);
            this.gbSexo.TabIndex = 36;
            this.gbSexo.TabStop = false;
            // 
            // rdbMasculino
            // 
            this.rdbMasculino.AutoSize = true;
            this.rdbMasculino.Location = new System.Drawing.Point(181, 16);
            this.rdbMasculino.Name = "rdbMasculino";
            this.rdbMasculino.Size = new System.Drawing.Size(80, 19);
            this.rdbMasculino.TabIndex = 8;
            this.rdbMasculino.TabStop = true;
            this.rdbMasculino.Text = "Masculino";
            this.rdbMasculino.UseVisualStyleBackColor = true;
            // 
            // rdbFemenino
            // 
            this.rdbFemenino.AutoSize = true;
            this.rdbFemenino.Location = new System.Drawing.Point(77, 16);
            this.rdbFemenino.Name = "rdbFemenino";
            this.rdbFemenino.Size = new System.Drawing.Size(78, 19);
            this.rdbFemenino.TabIndex = 7;
            this.rdbFemenino.TabStop = true;
            this.rdbFemenino.Text = "Femenino";
            this.rdbFemenino.UseVisualStyleBackColor = true;
            // 
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.Location = new System.Drawing.Point(35, 327);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(32, 15);
            this.lblSexo.TabIndex = 35;
            this.lblSexo.Text = "Sexo";
            // 
            // lblFechaNacimiento
            // 
            this.lblFechaNacimiento.AutoSize = true;
            this.lblFechaNacimiento.Location = new System.Drawing.Point(35, 272);
            this.lblFechaNacimiento.Name = "lblFechaNacimiento";
            this.lblFechaNacimiento.Size = new System.Drawing.Size(117, 15);
            this.lblFechaNacimiento.TabIndex = 33;
            this.lblFechaNacimiento.Text = "Fecha de nacimiento";
            // 
            // dtpFechaNacimiento
            // 
            this.dtpFechaNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaNacimiento.Location = new System.Drawing.Point(206, 268);
            this.dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            this.dtpFechaNacimiento.Size = new System.Drawing.Size(338, 23);
            this.dtpFechaNacimiento.TabIndex = 32;
            // 
            // txtNumeroDocumento
            // 
            this.txtNumeroDocumento.Location = new System.Drawing.Point(206, 225);
            this.txtNumeroDocumento.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNumeroDocumento.Name = "txtNumeroDocumento";
            this.txtNumeroDocumento.Size = new System.Drawing.Size(338, 23);
            this.txtNumeroDocumento.TabIndex = 31;
            // 
            // lblNumeroDocumento
            // 
            this.lblNumeroDocumento.AutoSize = true;
            this.lblNumeroDocumento.Location = new System.Drawing.Point(35, 225);
            this.lblNumeroDocumento.Name = "lblNumeroDocumento";
            this.lblNumeroDocumento.Size = new System.Drawing.Size(132, 15);
            this.lblNumeroDocumento.TabIndex = 30;
            this.lblNumeroDocumento.Text = "Número de documento";
            // 
            // lblTipoDocumento
            // 
            this.lblTipoDocumento.AutoSize = true;
            this.lblTipoDocumento.Location = new System.Drawing.Point(35, 188);
            this.lblTipoDocumento.Name = "lblTipoDocumento";
            this.lblTipoDocumento.Size = new System.Drawing.Size(111, 15);
            this.lblTipoDocumento.TabIndex = 29;
            this.lblTipoDocumento.Text = "Tipo de documento";
            // 
            // cboTipoDocumento
            // 
            this.cboTipoDocumento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipoDocumento.FormattingEnabled = true;
            this.cboTipoDocumento.Location = new System.Drawing.Point(206, 185);
            this.cboTipoDocumento.Name = "cboTipoDocumento";
            this.cboTipoDocumento.Size = new System.Drawing.Size(338, 23);
            this.cboTipoDocumento.TabIndex = 28;
            // 
            // txtSegundoApellido
            // 
            this.txtSegundoApellido.Location = new System.Drawing.Point(206, 150);
            this.txtSegundoApellido.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSegundoApellido.Name = "txtSegundoApellido";
            this.txtSegundoApellido.Size = new System.Drawing.Size(338, 23);
            this.txtSegundoApellido.TabIndex = 7;
            // 
            // lblSegundoApellido
            // 
            this.lblSegundoApellido.AutoSize = true;
            this.lblSegundoApellido.Location = new System.Drawing.Point(35, 155);
            this.lblSegundoApellido.Name = "lblSegundoApellido";
            this.lblSegundoApellido.Size = new System.Drawing.Size(99, 15);
            this.lblSegundoApellido.TabIndex = 6;
            this.lblSegundoApellido.Text = "Segundo apellido";
            // 
            // txtPrimerApellido
            // 
            this.txtPrimerApellido.Location = new System.Drawing.Point(206, 110);
            this.txtPrimerApellido.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPrimerApellido.Name = "txtPrimerApellido";
            this.txtPrimerApellido.Size = new System.Drawing.Size(338, 23);
            this.txtPrimerApellido.TabIndex = 5;
            // 
            // lblPrimerApellido
            // 
            this.lblPrimerApellido.AutoSize = true;
            this.lblPrimerApellido.Location = new System.Drawing.Point(35, 115);
            this.lblPrimerApellido.Name = "lblPrimerApellido";
            this.lblPrimerApellido.Size = new System.Drawing.Size(87, 15);
            this.lblPrimerApellido.TabIndex = 4;
            this.lblPrimerApellido.Text = "Primer apellido";
            // 
            // txtSegundoNombre
            // 
            this.txtSegundoNombre.Location = new System.Drawing.Point(206, 73);
            this.txtSegundoNombre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSegundoNombre.Name = "txtSegundoNombre";
            this.txtSegundoNombre.Size = new System.Drawing.Size(338, 23);
            this.txtSegundoNombre.TabIndex = 3;
            // 
            // lblSegundoNombre
            // 
            this.lblSegundoNombre.AutoSize = true;
            this.lblSegundoNombre.Location = new System.Drawing.Point(35, 78);
            this.lblSegundoNombre.Name = "lblSegundoNombre";
            this.lblSegundoNombre.Size = new System.Drawing.Size(99, 15);
            this.lblSegundoNombre.TabIndex = 2;
            this.lblSegundoNombre.Text = "Segundo nombre";
            // 
            // txtPrimerNombre
            // 
            this.txtPrimerNombre.Location = new System.Drawing.Point(206, 32);
            this.txtPrimerNombre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPrimerNombre.Name = "txtPrimerNombre";
            this.txtPrimerNombre.Size = new System.Drawing.Size(338, 23);
            this.txtPrimerNombre.TabIndex = 1;
            // 
            // lblPrimerNombre
            // 
            this.lblPrimerNombre.AutoSize = true;
            this.lblPrimerNombre.Location = new System.Drawing.Point(35, 38);
            this.lblPrimerNombre.Name = "lblPrimerNombre";
            this.lblPrimerNombre.Size = new System.Drawing.Size(87, 15);
            this.lblPrimerNombre.TabIndex = 0;
            this.lblPrimerNombre.Text = "Primer nombre";
            // 
            // gbEvaluacion
            // 
            this.gbEvaluacion.Controls.Add(this.gbCondicionEmocional);
            this.gbEvaluacion.Controls.Add(this.lblCondicionEmocional);
            this.gbEvaluacion.Controls.Add(this.txtTalla);
            this.gbEvaluacion.Controls.Add(this.lblTalla);
            this.gbEvaluacion.Controls.Add(this.txtPeso);
            this.gbEvaluacion.Controls.Add(this.lblPeso);
            this.gbEvaluacion.Controls.Add(this.lblCiudadEvaluacion);
            this.gbEvaluacion.Controls.Add(this.cboCiudadEvaluacion);
            this.gbEvaluacion.Controls.Add(this.chkCancer);
            this.gbEvaluacion.Controls.Add(this.label1);
            this.gbEvaluacion.Controls.Add(this.chkDiabetes);
            this.gbEvaluacion.Controls.Add(this.lblFechaEvaluacion);
            this.gbEvaluacion.Controls.Add(this.dtpFechaEvaluacion);
            this.gbEvaluacion.Location = new System.Drawing.Point(668, 35);
            this.gbEvaluacion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbEvaluacion.Name = "gbEvaluacion";
            this.gbEvaluacion.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbEvaluacion.Size = new System.Drawing.Size(597, 398);
            this.gbEvaluacion.TabIndex = 23;
            this.gbEvaluacion.TabStop = false;
            this.gbEvaluacion.Text = "Evaluación";
            // 
            // gbCondicionEmocional
            // 
            this.gbCondicionEmocional.Controls.Add(this.rdbAlegre);
            this.gbCondicionEmocional.Controls.Add(this.rdbTriste);
            this.gbCondicionEmocional.Controls.Add(this.rdbNormal);
            this.gbCondicionEmocional.Location = new System.Drawing.Point(190, 263);
            this.gbCondicionEmocional.Name = "gbCondicionEmocional";
            this.gbCondicionEmocional.Size = new System.Drawing.Size(338, 52);
            this.gbCondicionEmocional.TabIndex = 33;
            this.gbCondicionEmocional.TabStop = false;
            // 
            // rdbAlegre
            // 
            this.rdbAlegre.AutoSize = true;
            this.rdbAlegre.Location = new System.Drawing.Point(54, 22);
            this.rdbAlegre.Name = "rdbAlegre";
            this.rdbAlegre.Size = new System.Drawing.Size(59, 19);
            this.rdbAlegre.TabIndex = 15;
            this.rdbAlegre.TabStop = true;
            this.rdbAlegre.Text = "Alegre";
            this.rdbAlegre.UseVisualStyleBackColor = true;
            // 
            // rdbTriste
            // 
            this.rdbTriste.AutoSize = true;
            this.rdbTriste.Location = new System.Drawing.Point(232, 22);
            this.rdbTriste.Name = "rdbTriste";
            this.rdbTriste.Size = new System.Drawing.Size(52, 19);
            this.rdbTriste.TabIndex = 17;
            this.rdbTriste.TabStop = true;
            this.rdbTriste.Text = "Triste";
            this.rdbTriste.UseVisualStyleBackColor = true;
            // 
            // rdbNormal
            // 
            this.rdbNormal.AutoSize = true;
            this.rdbNormal.Location = new System.Drawing.Point(142, 22);
            this.rdbNormal.Name = "rdbNormal";
            this.rdbNormal.Size = new System.Drawing.Size(65, 19);
            this.rdbNormal.TabIndex = 16;
            this.rdbNormal.TabStop = true;
            this.rdbNormal.Text = "Normal";
            this.rdbNormal.UseVisualStyleBackColor = true;
            // 
            // lblCondicionEmocional
            // 
            this.lblCondicionEmocional.AutoSize = true;
            this.lblCondicionEmocional.Location = new System.Drawing.Point(41, 288);
            this.lblCondicionEmocional.Name = "lblCondicionEmocional";
            this.lblCondicionEmocional.Size = new System.Drawing.Size(121, 15);
            this.lblCondicionEmocional.TabIndex = 32;
            this.lblCondicionEmocional.Text = "Condición emocional";
            // 
            // txtTalla
            // 
            this.txtTalla.Location = new System.Drawing.Point(190, 224);
            this.txtTalla.Name = "txtTalla";
            this.txtTalla.Size = new System.Drawing.Size(338, 23);
            this.txtTalla.TabIndex = 31;
            // 
            // lblTalla
            // 
            this.lblTalla.AutoSize = true;
            this.lblTalla.Location = new System.Drawing.Point(41, 230);
            this.lblTalla.Name = "lblTalla";
            this.lblTalla.Size = new System.Drawing.Size(30, 15);
            this.lblTalla.TabIndex = 30;
            this.lblTalla.Text = "Talla";
            // 
            // txtPeso
            // 
            this.txtPeso.Location = new System.Drawing.Point(190, 178);
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Size = new System.Drawing.Size(338, 23);
            this.txtPeso.TabIndex = 29;
            // 
            // lblPeso
            // 
            this.lblPeso.AutoSize = true;
            this.lblPeso.Location = new System.Drawing.Point(41, 183);
            this.lblPeso.Name = "lblPeso";
            this.lblPeso.Size = new System.Drawing.Size(32, 15);
            this.lblPeso.TabIndex = 28;
            this.lblPeso.Text = "Peso";
            // 
            // lblCiudadEvaluacion
            // 
            this.lblCiudadEvaluacion.AutoSize = true;
            this.lblCiudadEvaluacion.Location = new System.Drawing.Point(39, 136);
            this.lblCiudadEvaluacion.Name = "lblCiudadEvaluacion";
            this.lblCiudadEvaluacion.Size = new System.Drawing.Size(105, 15);
            this.lblCiudadEvaluacion.TabIndex = 27;
            this.lblCiudadEvaluacion.Text = "Ciudad Evaluación";
            // 
            // cboCiudadEvaluacion
            // 
            this.cboCiudadEvaluacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCiudadEvaluacion.FormattingEnabled = true;
            this.cboCiudadEvaluacion.Items.AddRange(new object[] {
            "MEDELLÍN",
            "CALI",
            "SABANETA",
            "BELLO",
            "EVIGADO ",
            "LA ESTRELLA"});
            this.cboCiudadEvaluacion.Location = new System.Drawing.Point(190, 134);
            this.cboCiudadEvaluacion.Name = "cboCiudadEvaluacion";
            this.cboCiudadEvaluacion.Size = new System.Drawing.Size(338, 23);
            this.cboCiudadEvaluacion.TabIndex = 26;
            // 
            // chkCancer
            // 
            this.chkCancer.AutoSize = true;
            this.chkCancer.Location = new System.Drawing.Point(296, 86);
            this.chkCancer.Name = "chkCancer";
            this.chkCancer.Size = new System.Drawing.Size(63, 19);
            this.chkCancer.TabIndex = 24;
            this.chkCancer.Text = "Cáncer";
            this.chkCancer.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 15);
            this.label1.TabIndex = 23;
            this.label1.Text = "Antecedentes";
            // 
            // chkDiabetes
            // 
            this.chkDiabetes.AutoSize = true;
            this.chkDiabetes.Location = new System.Drawing.Point(190, 86);
            this.chkDiabetes.Name = "chkDiabetes";
            this.chkDiabetes.Size = new System.Drawing.Size(71, 19);
            this.chkDiabetes.TabIndex = 22;
            this.chkDiabetes.Text = "Diabetes";
            this.chkDiabetes.UseVisualStyleBackColor = true;
            // 
            // lblFechaEvaluacion
            // 
            this.lblFechaEvaluacion.AutoSize = true;
            this.lblFechaEvaluacion.Location = new System.Drawing.Point(39, 33);
            this.lblFechaEvaluacion.Name = "lblFechaEvaluacion";
            this.lblFechaEvaluacion.Size = new System.Drawing.Size(98, 15);
            this.lblFechaEvaluacion.TabIndex = 21;
            this.lblFechaEvaluacion.Text = "Fecha evaluación";
            // 
            // dtpFechaEvaluacion
            // 
            this.dtpFechaEvaluacion.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaEvaluacion.Location = new System.Drawing.Point(190, 29);
            this.dtpFechaEvaluacion.Name = "dtpFechaEvaluacion";
            this.dtpFechaEvaluacion.Size = new System.Drawing.Size(338, 23);
            this.dtpFechaEvaluacion.TabIndex = 20;
            // 
            // erpError
            // 
            this.erpError.ContainerControl = this;
            // 
            // FormularioEvaluacionActividadFisica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1328, 554);
            this.Controls.Add(this.gbEvaluacion);
            this.Controls.Add(this.gbDatosBasicos);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Name = "FormularioEvaluacionActividadFisica";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Evaluación Actividad Física";
            this.Load += new System.EventHandler(this.FormularioEvaluacionActividadFisica_Load);
            this.gbDatosBasicos.ResumeLayout(false);
            this.gbDatosBasicos.PerformLayout();
            this.gbSexo.ResumeLayout(false);
            this.gbSexo.PerformLayout();
            this.gbEvaluacion.ResumeLayout(false);
            this.gbEvaluacion.PerformLayout();
            this.gbCondicionEmocional.ResumeLayout(false);
            this.gbCondicionEmocional.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erpError)).EndInit();
            this.ResumeLayout(false);

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