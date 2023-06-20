using HC13Testing.Types;

namespace HC13Testing.Services;

public interface IPersonService
{
    Person AddPerson();
    Person GetPerson();
    string HelloWorld();
    string MyCustomResolver(string name);
}

public class PersonService : IPersonService
{
    public Person AddPerson()
    {
        return new Person
        {
            Id = Guid.NewGuid(),
            Name = "Test"
        };
    }

    public Person GetPerson()
    {
        return new Person
        {
            Id = Guid.NewGuid(),
            Name = "Lars",
            Assignments = new List<Assignment>
            {
                new()
                {
                    Id = Guid.NewGuid(),
                    Name = "Danse samba"
                }
            }
        };
    }

    public string HelloWorld() => "HelloWorld World!";

    public string MyCustomResolver(string name) => $"Person name: {name}";
}