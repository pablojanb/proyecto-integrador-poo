
namespace clubdeportivo.config
{
    internal class Session
    {
        private string username;
        private string nombre;

        private static Session? session = null;

        private Session() {}

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
    }
}
