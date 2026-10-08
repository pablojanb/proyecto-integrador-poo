
using clubdeportivo.igu;

namespace clubdeportivo.config
{
    internal class Session
    {
        private string username;
        private string nombre;

        private Point ultimaPosicion;
        private int segundosSinMovimiento = 0;
        private System.Windows.Forms.Timer timerMouse;

        private static Session? session = null;

        private Session() {
            ultimaPosicion = Cursor.Position;

            timerMouse = new System.Windows.Forms.Timer();
            timerMouse.Interval = 1000;
            timerMouse.Tick += TimerMouse_Tick;
            timerMouse.Start();
        }

        public static Session getInstance()
        {
            if (session == null)
            {
                session = new Session();
            }
            return session;
        }

        public string Username { get => username; set => username = value; }
        public string Nombre { get => nombre; set => nombre = value; }

        private void TimerMouse_Tick(object sender, EventArgs e)
        {
            Point posicionActual = Cursor.Position;

            if (posicionActual == ultimaPosicion)
            {
                segundosSinMovimiento++;

                if (segundosSinMovimiento >= 3)
                {
                    timerMouse.Stop();
                    EventoSinMovimiento();
                }
            }
            else
            {
                segundosSinMovimiento = 0;
                ultimaPosicion = posicionActual;
            }
        }

        private void EventoSinMovimiento()
        {
            using (SesionTimer timer = new SesionTimer())
            {
                if (timer.ShowDialog() != DialogResult.OK)
                {
                    CerrarSesion();
                }
                else
                {
                    timerMouse.Start();
                }
            }
        }

        public void CerrarSesion()
        {
            username = null;
            nombre = null;

            foreach (Form form in Application.OpenForms.Cast<Form>().ToList())
            {
                if (!(form is Login))
                {
                    form.Close();
                } else
                {
                    form.Show();
                    form.BringToFront();
                }
            }
        }
    }
}
