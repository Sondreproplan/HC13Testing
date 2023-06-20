using HC13Testing.Services;
using HC13Testing.Types;

namespace HC13Testing;

[QueryType]
public static class Query
{
    public static string Hello(IPersonService personService) => personService.HelloWorld();

    public static Person GetPerson(IPersonService personService) => personService.GetPerson();
}