using clubdeportivo.model;
using clubdeportivo.service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace clubdeportivo.igu
{
    public partial class ConfirmarAltaSocio : Form
    {
        public ConfirmarAltaSocio()
        {
            InitializeComponent();
        }

        private void lblConfirmacion_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
