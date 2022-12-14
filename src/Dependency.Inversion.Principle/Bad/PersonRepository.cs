using Dependency.Inversion.Principle.Bad.Connection;

namespace Dependency.Inversion.Principle.Bad
{
    /// <summary>
    /// Princípio da Inversão de Dependência — Dependa de abstrações e não de implementações.
    /// </summary>
    public class PersonRepository
    {
        SqlServerConnection _connection;

        public PersonRepository()
        {
            _connection = new SqlServerConnection();
        }

        public dynamic AddPerson(dynamic person)
        {
            if (_connection.Connect())
                return _connection.Save(person);

            throw new ArgumentException("Failed to connect database.");
        }
    }
}