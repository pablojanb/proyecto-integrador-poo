
namespace clubdeportivo.igu
{
    public partial class SesionTimer : FormBase
    {
        private int segundosRestantes = 3;

        private System.Windows.Forms.Timer timerCuenta;
        public SesionTimer()
        {
            InitializeComponent();
            timerCuenta = new System.Windows.Forms.Timer();
            timerCuenta.Interval = 1000;
            timerCuenta.Tick += TimerCuenta_Tick;

            ActualizarTexto();
            timerCuenta.Start();
        }

        private void TimerCuenta_Tick(object sender, EventArgs e)
        {
            segundosRestantes--;

            ActualizarTexto();

            if (segundosRestantes <= 0)
            {
                timerCuenta.Stop();
                this.DialogResult = DialogResult.Abort;
                this.Close();
            }
        }

        private void ActualizarTexto()
        {
            int minutos = segundosRestantes / 60;
            int segundos = segundosRestantes % 60;

            lblTimer.Text = $"{minutos:00}:{segundos:00}";
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
