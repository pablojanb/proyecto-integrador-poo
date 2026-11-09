
using clubdeportivo.igu;

namespace clubdeportivo
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new Dashboard());
        }
    }
}