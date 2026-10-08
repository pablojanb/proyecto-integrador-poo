using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace clubdeportivo.igu
{
    public partial class AltaSocioPopUp : Form
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
