using clubdeportivo.igu;
using clubdeportivo.model;
using clubdeportivo.service;

namespace AltaSocioPrueba
{
    public partial class FormAltaSocio : FormBase
    {
        public FormAltaSocio()
        {
            InitializeComponent();
            dtpFechaNacimiento.Format = DateTimePickerFormat.Short;
            dtpFechaNacimiento.CustomFormat = "dd/MM/yyyy";
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {

        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text) ||
               string.IsNullOrWhiteSpace(txtApellido.Text) ||
               string.IsNullOrWhiteSpace(txtDni.Text))
            {
                MessageBox.Show("Por favor complete todos los campos obligatorios.",
                    "Datos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Persona persona = new Persona();
            persona.Nombre = txtNombre.Text;
            persona.Apellido = txtApellido.Text;
            persona.Dni = txtDni.Text;
            persona.Direccion = txtDirección.Text;
            persona.Telefono = txtTelefono.Text;
            persona.Email = txtEmail.Text;
            using (ConfirmarAltaSocio popUpConfirmar = new ConfirmarAltaSocio())
            {
                if (popUpConfirmar.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        SocioService socioService = new SocioService();
                        Socio socio = socioService.crearSocio(persona);
                        AltaSocioPopUp popUpAltaDatos = new AltaSocioPopUp(persona.Nombre, persona.Apellido,
                            persona.Dni, socio.NumAfiliado);
                        if (popUpAltaDatos.ShowDialog() == DialogResult.OK)
                        {
                            this.Close();
                        }
                    }
                    catch (Exception ex)
                    {
                        SocioYaExistentePopUp pop = new SocioYaExistentePopUp();
                        pop.ShowDialog();
                    }
                }

            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtDni.Text = "";
            txtDirección.Text = "";
            txtTelefono.Text = "";
            txtEmail.Text = "";
            dtpFechaNacimiento.Value = DateTime.Today;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Dashboard dash = new Dashboard();
            dash.Show();
            this.Close();
        }
    }
}
