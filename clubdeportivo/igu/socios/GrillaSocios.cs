using clubdeportivo.dto;
using clubdeportivo.service;

namespace clubdeportivo.igu.socios
{
    public partial class GrillaSocios : FormBase
    {
        private SocioService socioService;
        private List<SocioGrillaDTO> sociosDto;

        public GrillaSocios()
        {
            InitializeComponent();
            socioService = new SocioService();
            cargarDatos();
            configGrilla();
        }

        public void cargarDatos()
        {
            sociosDto = socioService.obtenerTodosConVencimiento();
        }

        public void configGrilla()
        {
            gridSocios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gridSocios.AllowUserToAddRows = false;
            gridSocios.AllowUserToDeleteRows = false;
            gridSocios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gridSocios.MultiSelect = false;
            gridSocios.ReadOnly = true;
            gridSocios.DataSource = sociosDto;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void GrillaSocios_Load(object sender, EventArgs e)
        {

        }

        private void gridSocios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
