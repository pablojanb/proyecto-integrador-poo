using clubdeportivo.config;
using clubdeportivo.igu;
using clubdeportivo.model;
using clubdeportivo.service;

namespace clubdeportivo
{
    public partial class Login : FormBase
    {
        private PersonaService personaService;
        private EmpleadoAdministrativo empleado;
        private EmpleadoAdministrativoService empleadoAdministrativoService;

        public Login()
        {
            personaService = new PersonaService();
            empleadoAdministrativoService = new EmpleadoAdministrativoService();
            InicializarDatos.InicializarDB();
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void UserText_TextChanged(object sender, EventArgs e)
        {
        }

        private void PassText_TextChanged(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = true;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void LoginLbl_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void BTNLogin_Click(object sender, EventArgs e)
        {

        }
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            
            empleado = empleadoAdministrativoService.obtenerEmpleadoPorUsername(username);
            Boolean passwordCorrecto = password == empleado.Password;
            if (passwordCorrecto)
            {
                inicializarSesion();
                Dashboard dashboard = new Dashboard(this);
                dashboard.Show();
                this.Hide();
            }
            else
            {
                CredencialesIncorrectas popUp = new CredencialesIncorrectas();
                popUp.ShowDialog();
            }
            txtUsername.Text = "Ingrese su usuario";
            txtPassword.Text = "Ingrese su contraseña";
            txtPassword.UseSystemPasswordChar = false;
        }

        private void inicializarSesion()
        {
            Persona persona = personaService.obtenerPersonaPorNroLegajo(empleado.NumLegajo);
            Session session = Session.getInstance();
            session.Nombre = persona.Nombre;
            session.Username = empleado.Username;
        }
        private void txtUsername_Click(object sender, EventArgs e)
        {
            txtUsername.Text = "";
        }

        private void txtPassword_Click(object sender, EventArgs e)
        {
            txtPassword.Text = "";
        }

        private void txtUsername_Leave(object sender, EventArgs e)
        {
            if (txtUsername.Text == "")
            {
                txtUsername.Text = "Ingrese su usuario";
            }
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (txtPassword.Text == "")
            {
                txtPassword.Text = "Ingrese su contraseña";
                txtPassword.UseSystemPasswordChar = false;
            }
        }
    }
}
