using clubdeportivo.igu;
using clubdeportivo.service;
using System.Diagnostics;

namespace clubdeportivo
{
    public partial class Login : Form
    {
        private SocioService socioService;
        public Login()
        {
            socioService = new SocioService();
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
            Boolean estaLogueado = socioService.validarLogin(username, password);
            if (estaLogueado)
            {
                Dashboard dashboard = new Dashboard();
                dashboard.Show();
                this.Hide();
            }
            else
            {
                CredencialesIncorrectas popUp = new CredencialesIncorrectas();
                popUp.ShowDialog();
            }
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
            }
        }
    }
}
