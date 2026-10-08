using clubdeportivo.config;
using clubdeportivo.model;
using clubdeportivo.service;

namespace clubdeportivo.igu
{
    public partial class Dashboard : FormBase
    {
        private Login login;
        private Session session;
        public Dashboard(Login login)
        {
            this.login = login;
            session = Session.getInstance();
            InitializeComponent();
            lblUsuario.Text = $"Bienvenido {session.Nombre}";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblUsuario_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            IngresoSocio popUpIngreso = new IngresoSocio();
            popUpIngreso.Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
            login.Show();
        }

        private void Dashboard_FormClosing(object sender, FormClosingEventArgs e)
        {
            login.Show();
        }

        private void btnAltaSocio_Click(object sender, EventArgs e)
        {
            Persona persona = new Persona();
            persona.Nombre = "Julieta";
            persona.Apellido = "Sosa";
            persona.Dni = "43567334";
            persona.Direccion = "Av. Maipu 343";
            persona.Telefono = "1154667433";
            persona.Email = "jsosa63@gmail.com";
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
                        popUpAltaDatos.ShowDialog();
                    }
                    catch (Exception ex)
                    {
                        SocioYaExistentePopUp pop = new SocioYaExistentePopUp();
                        pop.ShowDialog();
                    }
                }
                
            }
        }
    }
}
