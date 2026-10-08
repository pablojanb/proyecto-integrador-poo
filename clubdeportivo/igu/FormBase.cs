using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace clubdeportivo.igu
{
    public partial class FormBase : Form
    {
        public FormBase()
        {
            InitializeComponent();
            this.BackColor = Color.White;
            this.Icon = new Icon(
                new MemoryStream(Properties.Resources.ifts_icon)
            );
        }
    }
}
