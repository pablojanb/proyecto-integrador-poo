

using clubdeportivo.igu.ingresos;
using clubdeportivo.model;
using clubdeportivo.service;
using System.Diagnostics;

namespace clubdeportivo.igu.pagos
{
    public partial class PagosPopUp : FormBase
    {
        private SocioService socioService;
        public PagosPopUp()
        {
            socioService = new SocioService();
            InitializeComponent();
            cmbIngreso.SelectedIndex = 0;
            cmbMonto.SelectedIndex = 0;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtDni_Click(object sender, EventArgs e)
        {
            if (txtDni.Text == "Ingrese número")
            {
                txtDni.Text = "";
            }
        }

        private void txtMonto_Click(object sender, EventArgs e)
        {
            if (txtMonto.Text == "Ingrese monto")
            {
                txtMonto.Text = "";
            }
        }

        private void txtDni_Leave(object sender, EventArgs e)
        {
            if (txtMonto.Text == "")
            {
                txtMonto.Text = "Ingrese número";
            }
        }

        private void txtMonto_Leave(object sender, EventArgs e)
        {
            if (txtMonto.Text == "")
            {
                txtMonto.Text = "Ingrese monto";
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                Socio socio = null;
                string registro = cmbIngreso.Text;
                string medioPago = cmbMonto.Text;
                decimal monto = decimal.Parse(txtMonto.Text);
                if (cmbIngreso.Text == "DNI")
                {
                    string dniSocio = txtDni.Text;
                    socio = socioService.obtenerSocioPorDni(dniSocio);
                }
                else
                {
                    long nroSocio = long.Parse(txtDni.Text);
                    socio = socioService.obtenerSocioPorNroSocio(nroSocio);
                }
                bool pagoAceptado = socioService.pagarMembresia(socio, medioPago, monto);
                if (pagoAceptado)
                {
                    PagoExitoso popUp = new PagoExitoso();
                    popUp.ShowDialog();
                    this.Close();
                } else
                {
                    ErrorMonto popUp = new ErrorMonto();
                    popUp.ShowDialog();
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
    }
}
