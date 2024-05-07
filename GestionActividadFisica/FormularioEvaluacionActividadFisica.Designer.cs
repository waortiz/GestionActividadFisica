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
            this.dtpFechaEvaluacion = new System.Windows.Forms.DateTimePicker();
            this.lblFechaEvaluacion = new System.Windows.Forms.Label();
            this.chkDiabetes = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.chkCancer = new System.Windows.Forms.CheckBox();
            this.lblSexo = new System.Windows.Forms.Label();
            this.cboCiudadEvaluacion = new System.Windows.Forms.ComboBox();
            this.lblCiudadEvaluacion = new System.Windows.Forms.Label();
            this.lblPeso = new System.Windows.Forms.Label();
            this.txtPeso = new System.Windows.Forms.TextBox();
            this.txtTalla = new System.Windows.Forms.TextBox();
            this.lblTalla = new System.Windows.Forms.Label();
            this.lblCondicionEmocional = new System.Windows.Forms.Label();
            this.rdbAlegre = new System.Windows.Forms.RadioButton();
            this.rdbNormal = new System.Windows.Forms.RadioButton();
            this.rdbTriste = new System.Windows.Forms.RadioButton();
            this.gbCondicionEmocional = new System.Windows.Forms.GroupBox();
            this.gbSexo = new System.Windows.Forms.GroupBox();
            this.rdbMasculino = new System.Windows.Forms.RadioButton();
            this.rdbFemenino = new System.Windows.Forms.RadioButton();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.gbCondicionEmocional.SuspendLayout();
            this.gbSexo.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtpFechaEvaluacion
            // 
            this.dtpFechaEvaluacion.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaEvaluacion.Location = new System.Drawing.Point(244, 78);
            this.dtpFechaEvaluacion.Name = "dtpFechaEvaluacion";
            this.dtpFechaEvaluacion.Size = new System.Drawing.Size(338, 23);
            this.dtpFechaEvaluacion.TabIndex = 0;
            // 
            // lblFechaEvaluacion
            // 
            this.lblFechaEvaluacion.AutoSize = true;
            this.lblFechaEvaluacion.Location = new System.Drawing.Point(93, 86);
            this.lblFechaEvaluacion.Name = "lblFechaEvaluacion";
            this.lblFechaEvaluacion.Size = new System.Drawing.Size(98, 15);
            this.lblFechaEvaluacion.TabIndex = 1;
            this.lblFechaEvaluacion.Text = "Fecha evaluación";
            // 
            // chkDiabetes
            // 
            this.chkDiabetes.AutoSize = true;
            this.chkDiabetes.Location = new System.Drawing.Point(249, 134);
            this.chkDiabetes.Name = "chkDiabetes";
            this.chkDiabetes.Size = new System.Drawing.Size(71, 19);
            this.chkDiabetes.TabIndex = 2;
            this.chkDiabetes.Text = "Diabetes";
            this.chkDiabetes.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(93, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Antecedentes";
            // 
            // chkCancer
            // 
            this.chkCancer.AutoSize = true;
            this.chkCancer.Location = new System.Drawing.Point(353, 135);
            this.chkCancer.Name = "chkCancer";
            this.chkCancer.Size = new System.Drawing.Size(63, 19);
            this.chkCancer.TabIndex = 4;
            this.chkCancer.Text = "Cáncer";
            this.chkCancer.UseVisualStyleBackColor = true;
            // 
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.Location = new System.Drawing.Point(91, 201);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(32, 15);
            this.lblSexo.TabIndex = 7;
            this.lblSexo.Text = "Sexo";
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
            this.cboCiudadEvaluacion.Location = new System.Drawing.Point(249, 227);
            this.cboCiudadEvaluacion.Name = "cboCiudadEvaluacion";
            this.cboCiudadEvaluacion.Size = new System.Drawing.Size(338, 23);
            this.cboCiudadEvaluacion.TabIndex = 8;
            // 
            // lblCiudadEvaluacion
            // 
            this.lblCiudadEvaluacion.AutoSize = true;
            this.lblCiudadEvaluacion.Location = new System.Drawing.Point(93, 230);
            this.lblCiudadEvaluacion.Name = "lblCiudadEvaluacion";
            this.lblCiudadEvaluacion.Size = new System.Drawing.Size(105, 15);
            this.lblCiudadEvaluacion.TabIndex = 9;
            this.lblCiudadEvaluacion.Text = "Ciudad Evaluación";
            // 
            // lblPeso
            // 
            this.lblPeso.AutoSize = true;
            this.lblPeso.Location = new System.Drawing.Point(93, 280);
            this.lblPeso.Name = "lblPeso";
            this.lblPeso.Size = new System.Drawing.Size(32, 15);
            this.lblPeso.TabIndex = 10;
            this.lblPeso.Text = "Peso";
            // 
            // txtPeso
            // 
            this.txtPeso.Location = new System.Drawing.Point(249, 272);
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Size = new System.Drawing.Size(338, 23);
            this.txtPeso.TabIndex = 11;
            // 
            // txtTalla
            // 
            this.txtTalla.Location = new System.Drawing.Point(249, 316);
            this.txtTalla.Name = "txtTalla";
            this.txtTalla.Size = new System.Drawing.Size(338, 23);
            this.txtTalla.TabIndex = 13;
            // 
            // lblTalla
            // 
            this.lblTalla.AutoSize = true;
            this.lblTalla.Location = new System.Drawing.Point(93, 324);
            this.lblTalla.Name = "lblTalla";
            this.lblTalla.Size = new System.Drawing.Size(30, 15);
            this.lblTalla.TabIndex = 12;
            this.lblTalla.Text = "Talla";
            // 
            // lblCondicionEmocional
            // 
            this.lblCondicionEmocional.AutoSize = true;
            this.lblCondicionEmocional.Location = new System.Drawing.Point(93, 376);
            this.lblCondicionEmocional.Name = "lblCondicionEmocional";
            this.lblCondicionEmocional.Size = new System.Drawing.Size(121, 15);
            this.lblCondicionEmocional.TabIndex = 14;
            this.lblCondicionEmocional.Text = "Condición emocional";
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
            // gbCondicionEmocional
            // 
            this.gbCondicionEmocional.Controls.Add(this.rdbAlegre);
            this.gbCondicionEmocional.Controls.Add(this.rdbTriste);
            this.gbCondicionEmocional.Controls.Add(this.rdbNormal);
            this.gbCondicionEmocional.Location = new System.Drawing.Point(249, 354);
            this.gbCondicionEmocional.Name = "gbCondicionEmocional";
            this.gbCondicionEmocional.Size = new System.Drawing.Size(338, 52);
            this.gbCondicionEmocional.TabIndex = 18;
            this.gbCondicionEmocional.TabStop = false;
            // 
            // gbSexo
            // 
            this.gbSexo.Controls.Add(this.rdbMasculino);
            this.gbSexo.Controls.Add(this.rdbFemenino);
            this.gbSexo.Location = new System.Drawing.Point(249, 173);
            this.gbSexo.Name = "gbSexo";
            this.gbSexo.Size = new System.Drawing.Size(338, 43);
            this.gbSexo.TabIndex = 19;
            this.gbSexo.TabStop = false;
            // 
            // rdbMasculino
            // 
            this.rdbMasculino.AutoSize = true;
            this.rdbMasculino.Location = new System.Drawing.Point(181, 14);
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
            this.rdbFemenino.Location = new System.Drawing.Point(77, 14);
            this.rdbFemenino.Name = "rdbFemenino";
            this.rdbFemenino.Size = new System.Drawing.Size(78, 19);
            this.rdbFemenino.TabIndex = 7;
            this.rdbFemenino.TabStop = true;
            this.rdbFemenino.Text = "Femenino";
            this.rdbFemenino.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(522, 435);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(117, 39);
            this.btnGuardar.TabIndex = 20;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(374, 435);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(117, 39);
            this.btnCancelar.TabIndex = 21;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // FormularioEvaluacionActividadFisica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 486);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.gbSexo);
            this.Controls.Add(this.gbCondicionEmocional);
            this.Controls.Add(this.lblCondicionEmocional);
            this.Controls.Add(this.txtTalla);
            this.Controls.Add(this.lblTalla);
            this.Controls.Add(this.txtPeso);
            this.Controls.Add(this.lblPeso);
            this.Controls.Add(this.lblCiudadEvaluacion);
            this.Controls.Add(this.cboCiudadEvaluacion);
            this.Controls.Add(this.lblSexo);
            this.Controls.Add(this.chkCancer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chkDiabetes);
            this.Controls.Add(this.lblFechaEvaluacion);
            this.Controls.Add(this.dtpFechaEvaluacion);
            this.Name = "FormularioEvaluacionActividadFisica";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Evaluación Actividad Física";
            this.gbCondicionEmocional.ResumeLayout(false);
            this.gbCondicionEmocional.PerformLayout();
            this.gbSexo.ResumeLayout(false);
            this.gbSexo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DateTimePicker dtpFechaEvaluacion;
        private Label lblFechaEvaluacion;
        private CheckBox chkDiabetes;
        private Label label1;
        private CheckBox chkCancer;
        private Label lblSexo;
        private ComboBox cboCiudadEvaluacion;
        private Label lblCiudadEvaluacion;
        private Label lblPeso;
        private TextBox txtPeso;
        private TextBox txtTalla;
        private Label lblTalla;
        private Label lblCondicionEmocional;
        private RadioButton rdbAlegre;
        private RadioButton rdbNormal;
        private RadioButton rdbTriste;
        private GroupBox gbCondicionEmocional;
        private GroupBox gbSexo;
        private RadioButton rdbMasculino;
        private RadioButton rdbFemenino;
        private Button btnGuardar;
        private Button btnCancelar;
    }
}