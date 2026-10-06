using clubdeportivo.config;
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
    public partial class Dashboard : Form
    {
        private Login login;
        private Session session;
        public Dashboard(Login login)
        {
            this.login = login;
            session = Session.getInstance();
            InitializeComponent();
            lblUsuario.Text = $"Bienvenido {session.Nombre}";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblUsuario_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            IngresoSocio popUpIngreso = new IngresoSocio();
            popUpIngreso.Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
            login.Show();
        }

        private void Dashboard_FormClosing(object sender, FormClosingEventArgs e)
        {
            login.Show();
        }
    }
}
