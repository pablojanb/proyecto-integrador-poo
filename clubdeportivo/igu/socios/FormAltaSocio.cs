namespace AltaSocioPrueba
{
    public partial class FormAltaSocio : Form
    {
        public FormAltaSocio()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(txtNombre.Text) ||
                string.IsNullOrWhiteSpace(txtApellido.Text) ||
                string.IsNullOrWhiteSpace(txtDni.Text))
{
                MessageBox.Show("Por favor complete todos los campos obligatorios.",
                    "Datos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult resultado = MessageBox.Show(
                $"¿Confirma el alta del socio?\n\n" +
                $"Nombre: {txtNombre.Text} {txtApellido.Text}\n" +
                $"DNI: {txtDni.Text}\n" +
                $"Teléfono: {txtTelefono.Text}",
                "Confirmar alta de socio",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                MessageBox.Show("Socio dado de alta correctamente.",
                    "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }
    }
}
