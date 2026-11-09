using AltaSocioPrueba;
using clubdeportivo.config;
using clubdeportivo.igu.carnets;
using clubdeportivo.igu.pagos;
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
            AltaSocio form = new AltaSocio();
            form.Show();
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

        private void btnEmitirCarnet_Click(object sender, EventArgs e)
        {
            CarnetPopUp popUp = new CarnetPopUp();
            popUp.ShowDialog();
        }

        private void btnPagos_Click(object sender, EventArgs e)
        {
            PagosPopUp popUp = new PagosPopUp();
            popUp.ShowDialog();
        }
    }
}
