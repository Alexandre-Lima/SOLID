using Dependency.Inversion.Principle.Good.Interface;

namespace Dependency.Inversion.Principle.Good.Connection
{
    public class SqlServerConnection : IConnection
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
