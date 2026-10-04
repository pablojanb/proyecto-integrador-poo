using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace clubdeportivo.igu
{
    public partial class CredencialesIncorrectas : Form
    {
        public CredencialesIncorrectas()
        {
            InitializeComponent();
        }

        private void lblConfirmacion_Click(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
