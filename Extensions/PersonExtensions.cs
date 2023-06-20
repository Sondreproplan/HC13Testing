using HC13Testing.Services;
using HC13Testing.Types;

namespace HC13Testing.Extensions;

// Annotation-based
[ExtendObjectType<Person>]
public static class PersonExtensions
{
    public static string MyCustomPersonResolver([Parent] Person person, IPersonService personService) => personService.MyCustomResolver(person.Name);
}