
namespace clubdeportivo.igu
{
    public partial class ConfirmarAltaSocio : FormBase
    {
        public ConfirmarAltaSocio()
        {
            InitializeComponent();
        }

        private void lblConfirmacion_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
