using clubdeportivo.dto;
using clubdeportivo.model;
using clubdeportivo.service;
using clubdeportivo.utils;

namespace clubdeportivo.igu.socios
{
    public partial class GrillaSocios : FormBase
    {
        private List<Socio> socios;
        private SocioService socioService;
        private SocioDTOMapper sociosMapper;
        private List<SocioGrillaDTO> sociosDto;

        public GrillaSocios()
        {
            InitializeComponent();
            socioService = new SocioService();
            sociosMapper = new SocioDTOMapper();
            cargarDatos();
            configGrilla();
        }

        public void cargarDatos()
        {
            socios = socioService.obtenerTodos();
            sociosDto = sociosMapper.toDtoList(socios);
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
    }
}
