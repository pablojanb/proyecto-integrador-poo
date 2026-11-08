using clubdeportivo.model;
using clubdeportivo.service;
using System.Diagnostics;

namespace clubdeportivo.igu.carnets
{
    public partial class CarnetPopUp : FormBase
    {

        private SocioService socioService;
        public CarnetPopUp()
        {
            socioService = new SocioService();
            InitializeComponent();
            cmbDni.SelectedIndex = 0;
        }

        private void CarnetPopUp_Load(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Socio socio = null;

            try
            {
                if (cmbDni.Text == "DNI")
                {
                    socio = socioService.obtenerSocioPorDni(txtDni.Text);
                }
                else if (cmbDni.Text == "N° de socio")
                {
                    socio = socioService.obtenerSocioPorNroSocio(long.Parse(txtDni.Text));
                }


                if (socio != null)
                {
                    CarnetVistaPrevia vistaPrevia = new CarnetVistaPrevia(socio);
                    vistaPrevia.ShowDialog();
                }
                else
                {
                    ErrorCarnet error = new ErrorCarnet();
                    error.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                if (ex.GetType() == typeof(FormatException))
                {
                    FormatoInvalido formatoInvalido = new FormatoInvalido();
                    formatoInvalido.ShowDialog();
                }
            }
        }

        private void txtDni_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDni_Click(object sender, EventArgs e)
        {
            if (txtDni.Text == "Ingrese número")
            {
                txtDni.Text = "";
            }
        }

        private void txtDni_Leave(object sender, EventArgs e)
        {
            if (txtDni.Text == "")
            {
                txtDni.Text = "Ingrese número";
            }
        }
    }
}
