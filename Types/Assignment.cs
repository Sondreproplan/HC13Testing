namespace HC13Testing.Types;

public class Assignment
{
    public Guid Id { get; set; }
    public string Name { get; set; } = string.Empty;

    public Guid PersonId { get; set; }
}