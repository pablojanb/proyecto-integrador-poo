
namespace clubdeportivo.igu
{
    public partial class AltaSocioPopUp : FormBase
    {
        public AltaSocioPopUp(string nombre, string apellido, string dni, long numAfiliado)
        {
            InitializeComponent();
            lblNombre.Text = $"Nombre: {nombre}";
            lblApellido.Text = $"Apellido: {apellido}";
            lblDni.Text = $"Dni: {dni}";
            lblNumAfiliado.Text = $"N° de afiliado: {numAfiliado}";
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
