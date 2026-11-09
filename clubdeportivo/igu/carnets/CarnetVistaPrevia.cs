using clubdeportivo.model;
using clubdeportivo.service;

namespace clubdeportivo.igu.carnets
{
    public partial class CarnetVistaPrevia : FormBase
    {
        private CarnetService carnetService;

        private Socio socio;
        public CarnetVistaPrevia(Socio socio)
        {
            carnetService = new CarnetService();
            this.socio = socio;
            InitializeComponent();
            lblNombre.Text = $"Nombre: {socio.Nombre}";
            lblApellido.Text = $"Apellido: {socio.Apellido}";
            lblDni.Text = $"DNI: {socio.Dni}";
            lblNumAfiliado.Text = $"N° Afiliado: {socio.NumAfiliado}";
            lblFechaAlta.Text = socio.FechaAlta.ToShortDateString();
        }

        private void CarnetVistaPrevia_Load(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEntregar_Click(object sender, EventArgs e)
        {
            bool entregado = carnetService.entregarCarnet(socio.Id);
            if (entregado)
            {
                CarnetEntregadoPopUp popUp = new CarnetEntregadoPopUp();
                popUp.ShowDialog();
                this.Close();
            }
        }
    }
}
