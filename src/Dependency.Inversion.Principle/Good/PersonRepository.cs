using Dependency.Inversion.Principle.Good.Interface;

namespace Dependency.Inversion.Principle.Good
{
    public class PersonRepository
    {
        IConnection _connection;

        public PersonRepository(IConnection connection)
        {
            _connection = connection;
        }
                     
        public dynamic AddPerson(dynamic person)
        {
            if (_connection.Connect())
                return _connection.Save(person);

            throw new ArgumentException("Failed to connect database.");
        }
    }
}
