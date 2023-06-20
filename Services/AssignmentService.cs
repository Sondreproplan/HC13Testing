namespace HC13Testing.Services;

public interface IAssignmentService
{
    string MyCustomResolver(string name);
}

public class AssignmentService : IAssignmentService
{
    public string MyCustomResolver(string name) => $"Assignment name: {name}";
}