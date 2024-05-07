using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionActividadFisica
{
    public partial class FormularioEvaluacionActividadFisica : Form
    {
        private DateTime fechaEvaluacion;
        private string? antecedentes;
        private string? sexo;
        private string? ciudadEvaluacion;
        private double peso;
        private double talla;
        private string? condicionEmocional;

        public FormularioEvaluacionActividadFisica()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //TODO: Pendiente de validaciones
            fechaEvaluacion = dtpFechaEvaluacion.Value;
            antecedentes = (chkCancer.Checked ? "Cáncer" : ", ") +
                    (chkDiabetes.Checked ? "Diabetes" : "");
            sexo = rdbMasculino.Checked ? "Masculino" : "Femenino";
            ciudadEvaluacion = cboCiudadEvaluacion.SelectedItem as string;
            double.TryParse(txtPeso.Text, out peso);
            double.TryParse(txtTalla.Text, out talla);
            talla = Convert.ToDouble(txtTalla.Text);
            condicionEmocional = rdbAlegre.Checked ? "Alegre" : "Triste";

            var datos = @"Fecha Evaluación: " + fechaEvaluacion +
                         "Antecedentes: " + antecedentes +
                         "Sexo: " + sexo +
                         "Ciudad Evaluación: " + ciudadEvaluacion+
                         "Peso: " + peso+
                         "Talla: " + talla+
                         "Condición emocional: " + condicionEmocional;

            MessageBox.Show(datos, "Datos", MessageBoxButtons.OK);
        }
    }
}
