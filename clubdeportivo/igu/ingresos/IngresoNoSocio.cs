
using clubdeportivo.igu.ingresos;
using clubdeportivo.model;
using clubdeportivo.service;
using System.Diagnostics;

namespace clubdeportivo.igu
{
    public partial class IngresoNoSocio : FormBase
    {
        private PersonaService personaService;
        private IngresoService ingresoService;
        public IngresoNoSocio()
        {
            ingresoService = new IngresoService();
            personaService = new PersonaService();
            InitializeComponent();
        }

        private void IngresoNoSocio_Load(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_Leave(object sender, EventArgs e)
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

        private void btnAceptar_Click_1(object sender, EventArgs e)
        {
            Persona persona = new Persona(txtNombre.Text, txtApellido.Text, txtDni.Text, txtDireccion.Text,
                txtTelefono.Text, txtEmail.Text);
            using (ConfirmarIngreso confirmar = new ConfirmarIngreso())
            {
                if (confirmar.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        Persona guardada = personaService.crearPersona(persona);
                        ingresoService.crearNuevoIngreso(guardada, DateTime.Now);
                        this.Close();
                    }
                    catch
                    {
                        ErrorPrimerIngreso errorIngreso = new ErrorPrimerIngreso();
                        errorIngreso.ShowDialog();
                    }
                }
            }
        }
    }
}
