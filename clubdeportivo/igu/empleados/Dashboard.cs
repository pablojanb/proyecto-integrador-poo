using clubdeportivo.config;
using clubdeportivo.igu.socios;
using clubdeportivo.model;
using clubdeportivo.service;

namespace clubdeportivo.igu
{
    public partial class Dashboard : FormBase
    {
        private Session session;
        public Dashboard()
        {
            session = Session.getInstance();
            InitializeComponent();
            lblTitle.Parent = imgFondo;
            lblUsuario.Parent = imgFondo;
            lblUsuario.BackColor = Color.Transparent;
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
            session.CerrarSesion();
        }

        private void Dashboard_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void btnAltaSocio_Click(object sender, EventArgs e)
        {
            //TODO mover lógica al form de alta cuando este listo
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

        private void Dashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            session.CerrarSesion();
        }

        private void btnVencimientos_Click(object sender, EventArgs e)
        {
            GrillaSocios grillaSocios = new GrillaSocios();
            grillaSocios.ShowDialog();
        }
    }
}
