using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace clubdeportivo.igu.ingresos
{
    public partial class ErrorPrimerIngreso : FormBase
    {
        public ErrorPrimerIngreso()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
