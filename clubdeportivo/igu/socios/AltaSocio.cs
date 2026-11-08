using clubdeportivo.igu;
using clubdeportivo.igu.socios;
using clubdeportivo.model;
using clubdeportivo.service;
using System.Diagnostics;

namespace AltaSocioPrueba
{
    public partial class AltaSocio : FormBase
    {
        private SocioService socioService;
        public AltaSocio()
        {
            socioService = new SocioService();
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
        public Boolean CamposSonValidos()
        {
            return (
               (!string.IsNullOrWhiteSpace(txtNombre.Text) && txtNombre.Text != "Nombre") &&
               (!string.IsNullOrWhiteSpace(txtApellido.Text) && txtApellido.Text != "Apellido") &&
               (!string.IsNullOrWhiteSpace(txtDni.Text) && txtDni.Text != "DNI") &&
               (!string.IsNullOrWhiteSpace(txtDireccion.Text) && txtDireccion.Text != "Dirección") &&
               (!string.IsNullOrWhiteSpace(txtEmail.Text) && txtEmail.Text != "Email") &&
               chbAptoFisico.Checked
               );
        }
        private void btnCrear_Click(object sender, EventArgs e)
        {
            if (!CamposSonValidos())
            {
                CamposObligatorios camposObl = new CamposObligatorios();
                camposObl.Show();
                return;
            }
            Persona persona = new Persona();
            persona.Nombre = txtNombre.Text;
            persona.Apellido = txtApellido.Text;
            persona.Dni = txtDni.Text;
            persona.Direccion = txtDireccion.Text;
            persona.Telefono = txtTelefono.Text;
            persona.Email = txtEmail.Text;
            persona.AptoFisico = true;
            using (ConfirmarAltaSocio popUpConfirmar = new ConfirmarAltaSocio())
            {
                if (popUpConfirmar.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
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
            txtNombre.Text = "Nombre";
            txtApellido.Text = "Apellido";
            txtDni.Text = "DNI";
            txtDireccion.Text = "Dirección";
            txtTelefono.Text = "Telefóno";
            txtEmail.Text = "Email";
            dtpFechaNacimiento.Value = DateTime.Today;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Dashboard dash = new Dashboard();
            dash.Show();
            this.Close();
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtApellido_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNombre_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == "Nombre")
            {
                txtNombre.Text = "";
            }
        }

        private void txtApellido_Click(object sender, EventArgs e)
        {
            if (txtApellido.Text == "Apellido")
            {
                txtApellido.Text = "";
            }
        }

        private void txtDni_Click(object sender, EventArgs e)
        {
            if (txtDni.Text == "DNI")
            {
                txtDni.Text = "";
            }
        }

        private void txtDireccion_Click(object sender, EventArgs e)
        {
            if (txtDireccion.Text == "Dirección")
            {
                txtDireccion.Text = "";
            }
        }

        private void txtTelefono_Click(object sender, EventArgs e)
        {
            if (txtTelefono.Text == "Teléfono")
            {
                txtTelefono.Text = "";
            }
        }

        private void txtEmail_Click(object sender, EventArgs e)
        {
            if (txtEmail.Text == "Email")
            {
                txtEmail.Text = "";
            }
        }

        private void txtNombre_Leave(object sender, EventArgs e)
        {
            if (txtNombre.Text == "")
            {
                txtNombre.Text = "Nombre";
            }
        }

        private void txtApellido_Leave(object sender, EventArgs e)
        {
            if (txtApellido.Text == "")
            {
                txtApellido.Text = "Apellido";
            }
        }

        private void txtDni_Leave(object sender, EventArgs e)
        {
            if (txtDni.Text == "")
            {
                txtDni.Text = "DNI";
            }
        }

        private void txtDireccion_Leave(object sender, EventArgs e)
        {
            if (txtDireccion.Text == "")
            {
                txtDireccion.Text = "Dirección";
            }
        }

        private void txtTelefono_Leave(object sender, EventArgs e)
        {
            if (txtTelefono.Text == "")
            {
                txtTelefono.Text = "Teléfono";
            }
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            if (txtEmail.Text == "")
            {
                txtEmail.Text = "Email";
            }
        }
    }
}
