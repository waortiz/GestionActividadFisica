using Entidades;
using Negocio;

namespace GestionActividadFisica
{
    public partial class FormularioEvaluacionActividadFisica : Form
    {
        private IServicioEvaluacion servicioEvaluacion;
        private IServicioMaestro servicioMaestro;

        private string primerNombre;
        private string segundoNombre;
        private string primerApellido;
        private string segundoApellido;
        private Sexo sexo;
        private TipoDocumento tipoDocumento;
        private string numeroDocumento;
        private DateTime fechaNacimiento;

        private DateTime fechaEvaluacion;
        private bool antecedenteDiabetes;
        private bool antecedenteCancer;
        private Ciudad ciudadEvaluacion;
        private decimal peso;
        private decimal talla;
        private CondicionEmocional condicionEmocional;

        public FormularioEvaluacionActividadFisica()
        {
            InitializeComponent();

            servicioEvaluacion = new ServicioEvaluacion();
            servicioMaestro = new ServicioMaestro();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                primerNombre = txtPrimerNombre.Text;
                segundoNombre = txtSegundoNombre.Text;
                primerApellido = txtPrimerApellido.Text;
                segundoApellido = txtSegundoApellido.Text;
                tipoDocumento = cboTipoDocumento.SelectedItem as TipoDocumento;
                numeroDocumento = txtNumeroDocumento.Text;
                fechaNacimiento = dtpFechaNacimiento.Value;
                sexo = rdbMasculino.Checked ?
                    new Sexo()
                    {
                        Id = (int)Entidades.Enumeraciones.Sexo.Masculino,
                        Nombre = "Masculino"
                    } :
                    new Sexo()
                    {
                        Id = (int)Entidades.Enumeraciones.Sexo.Femenino,
                        Nombre = "Femenino"
                    };

                fechaEvaluacion = dtpFechaEvaluacion.Value;
                antecedenteCancer = chkCancer.Checked;
                antecedenteDiabetes = chkDiabetes.Checked;
                ciudadEvaluacion = cboCiudadEvaluacion.SelectedItem as Ciudad;
                decimal.TryParse(txtPeso.Text, out peso);
                decimal.TryParse(txtTalla.Text, out talla);

                condicionEmocional = new CondicionEmocional()
                {
                    Id = rdbAlegre.Checked ? (int)Entidades.Enumeraciones.CondicionEmocional.Alegre :
                         rdbNormal.Checked ? (int)Entidades.Enumeraciones.CondicionEmocional.Normal :
                         (int)Entidades.Enumeraciones.CondicionEmocional.Triste
                };

                var evaluacion = new Evaluacion()
                {
                    Persona = new Persona()
                    {
                        PrimerNombre = primerNombre,
                        SegundoNombre = segundoNombre,
                        PrimerApellido = primerApellido,
                        SegundoApellido = segundoApellido,
                        Sexo = sexo,
                        TipoDocumento = tipoDocumento,
                        NumeroDocumento = numeroDocumento,
                        FechaNacimiento = fechaNacimiento
                    },
                    Fecha = fechaEvaluacion,
                    Ciudad = ciudadEvaluacion,
                    AntecendenteCancer = antecedenteCancer,
                    AntecendenteDiabetes = antecedenteDiabetes,
                    Peso = peso,
                    Talla = talla,
                    CondicionEmocional = condicionEmocional
                };

                servicioEvaluacion.GuardarEvaluacion(evaluacion);

                var datos = @"Evaluación almacenada correctamente";

                MessageBox.Show(datos, "Datos", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Revise los datos ingresados", "Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidarDatos()
        {
            bool datosCorrectos = true;

            erpError.SetError(txtPrimerNombre, null);
            erpError.SetError(txtPrimerApellido, null);
            erpError.SetError(cboTipoDocumento, null);
            erpError.SetError(txtNumeroDocumento, null);
            erpError.SetError(dtpFechaNacimiento, null);
            erpError.SetError(rdbMasculino, null);

            erpError.SetError(dtpFechaEvaluacion, null);
            erpError.SetError(cboCiudadEvaluacion, null);
            erpError.SetError(txtPeso, null);
            erpError.SetError(txtTalla, null);
            erpError.SetError(rdbAlegre, null);
            erpError.SetError(rdbNormal, null);

            if (string.IsNullOrEmpty(txtPrimerNombre.Text))
            {
                datosCorrectos = false;
                erpError.SetError(txtPrimerNombre, "Debe ingresar el primer nombre");
            }

            if (cboTipoDocumento.SelectedItem == null)
            {
                datosCorrectos = false; erpError.SetError(cboTipoDocumento, "Debe seleccionar el tipo de documento");
            }

            if (string.IsNullOrEmpty(txtNumeroDocumento.Text))
            {
                datosCorrectos = false;
                erpError.SetError(txtNumeroDocumento, "Debe ingresar el número de documento");
            }

            if (dtpFechaNacimiento.Value > DateTime.Now)
            {
                datosCorrectos = false;
                erpError.SetError(dtpFechaNacimiento, "La fecha de nacimiento no debe ser mayor a la fecha actual");
            }

            if (!rdbMasculino.Checked && !rdbFemenino.Checked)
            {
                datosCorrectos = false;
                erpError.SetError(rdbMasculino, "Debe seleccionar el sexo");
            }

            if (dtpFechaEvaluacion.Value > DateTime.Now)
            {
                datosCorrectos = false;
                erpError.SetError(dtpFechaEvaluacion, "La fecha de evaluación no debe ser mayor a la fecha actual");
            }

            if (cboCiudadEvaluacion == null)
            {
                datosCorrectos = false; erpError.SetError(cboCiudadEvaluacion, "Debe seleccionar la ciudad de evaluación");
            }

            if (string.IsNullOrEmpty(txtPeso.Text))
            {
                datosCorrectos = false;
                erpError.SetError(txtPeso, "Debe ingresar el peso");
            }

            if (string.IsNullOrEmpty(txtTalla.Text))
            {
                datosCorrectos = false;
                erpError.SetError(txtTalla, "Debe ingresar la talla");
            }

            if (!rdbAlegre.Checked && !rdbNormal.Checked && !rdbTriste.Checked)
            {
                datosCorrectos = false;
                erpError.SetError(rdbAlegre, "Debe indicar el estado emocional");
            }

            return datosCorrectos;
        }

        private void FormularioEvaluacionActividadFisica_Load(object sender, EventArgs e)
        {
            cboTipoDocumento.DisplayMember = "Nombre";
            cboTipoDocumento.DataSource = servicioMaestro.ObtenerTiposDocumento();

            cboCiudadEvaluacion.DisplayMember = "Nombre";
            cboCiudadEvaluacion.DataSource = servicioMaestro.ObtenerCiudades();
        }

        private void txtTalla_KeyPress(object sender, KeyPressEventArgs e)
        {
            var caracter = e.KeyChar;
            if (caracter != ',' && caracter != '0' && caracter != '1' && caracter != '2' &&
                caracter != '3' && caracter != '4' && caracter != '5' &&
                caracter != '6' && caracter != '7' && caracter != '8' &&
                caracter != '9' && (int)caracter != 8)
            {
                e.Handled = true;
            }
        }

        private void txtPeso_KeyPress(object sender, KeyPressEventArgs e)
        {
            var caracter = e.KeyChar;
            if (caracter != ',' && caracter != '0' && caracter != '1' && caracter != '2' &&
                caracter != '3' && caracter != '4' && caracter != '5' &&
                caracter != '6' && caracter != '7' && caracter != '8' &&
                caracter != '9' && (int)caracter != 8)
            {
                e.Handled = true;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
