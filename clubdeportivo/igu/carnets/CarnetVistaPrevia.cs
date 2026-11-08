using clubdeportivo.dto;
using clubdeportivo.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace clubdeportivo.igu.carnets
{
    public partial class CarnetVistaPrevia : FormBase
    {
        public CarnetVistaPrevia(Socio socio)
        {
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
    }
}
