using clubdeportivo.model;
using clubdeportivo.service;

namespace clubdeportivo.igu
{
    public partial class IngresoSocio : FormBase
    {
        private SocioService socioService;
        private PersonaService personaService;
        private IngresoService ingresoService;
        public IngresoSocio()
        {
            socioService = new SocioService();
            personaService = new PersonaService();
            ingresoService = new IngresoService();
            InitializeComponent();
            cmbDni.SelectedIndex = 0;
            cmbIngreso.SelectedIndex = 0;
        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNoSocio_Click(object sender, EventArgs e)
        {
            IngresoNoSocio popUpIngresoNoSocio = new IngresoNoSocio();
            popUpIngresoNoSocio.Show();
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Persona persona;
            string registro = cmbIngreso.Text;
            string dato = cmbDni.Text;
            if (dato == "DNI")
            {
                string dniPersona = txtDni.Text;
                persona = personaService.obtenerPersonaPorDni(dniPersona);
            }
            else
            {
                long nroSocio = long.Parse(txtDni.Text);
                persona = personaService.obtenerPersonaPorNroSocio(nroSocio);
            }
            if (registro == "Ingreso")
            {

            }
            else
            {

            }

        }

        private void cmbIngreso_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void txtDni_Leave(object sender, EventArgs e)
        {
            if (txtDni.Text == "")
            {
                txtDni.Text = "Ingrese número";
            }
        }

        private void txtDni_MouseClick(object sender, MouseEventArgs e)
        {
            txtDni.Text = "";
        }
    }
}
