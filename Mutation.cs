using HC13Testing.Services;
using HC13Testing.Types;

namespace HC13Testing;

[MutationType]
public static class Mutation
{
    public static Person AddPerson(IPersonService personService) 
        => personService.AddPerson();
}