using HC13Testing.Services;
using HC13Testing.Types;

namespace HC13Testing.Extensions;

// Code-first
public class AssignmentTypeExtensions : ObjectTypeExtension<Assignment>
{
    protected override void Configure(IObjectTypeDescriptor<Assignment> descriptor)
    {
        descriptor
            .Field("myCustomAssignmentResolver")
            .Type<StringType>()
            .ResolveWith<AssignmentTypeResolvers>(x => AssignmentTypeResolvers.MyCustomResolver(default!, default!));
    }
}

internal class AssignmentTypeResolvers
{
    public static string MyCustomResolver([Parent] Assignment assignment, IAssignmentService assignmentService)
        => assignmentService.MyCustomResolver(assignment.Name);
}
