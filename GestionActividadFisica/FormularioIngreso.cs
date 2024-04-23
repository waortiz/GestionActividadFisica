using GestionActividadFisica;

namespace GesttionActividadFisica
{
    public partial class FormularioIngreso : Form
    {
        public FormularioIngreso()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            var form = new FormularioPrincipal();
            form.Show();
            Hide();
        }
    }
}