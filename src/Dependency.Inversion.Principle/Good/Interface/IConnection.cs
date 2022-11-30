namespace Dependency.Inversion.Principle.Good.Interface
{
    public interface IConnection
    {
        bool Connect();

        T Save<T>(T obj);
    }
}
