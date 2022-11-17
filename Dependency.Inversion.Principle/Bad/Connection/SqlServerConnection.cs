namespace Dependency.Inversion.Principle.Bad.Connection
{
    public class SqlServerConnection
    {
        public bool Connect()
        {
            // faz a conexão

            return true;
        }

        public T Save<T>(T obj)
        {
            //salva o objeto

            return obj;
        }
    }
}
