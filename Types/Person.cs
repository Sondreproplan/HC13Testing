namespace HC13Testing.Types;

public class Person
{
    public Guid Id { get; set; }
    public string Name { get; set; } = string.Empty;

    public List<Assignment> Assignments { get; set; } = new();
}