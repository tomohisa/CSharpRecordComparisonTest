namespace CSharpRecordComparisonTest.RecordTypes;

public record SimpleRecord(int Id, string Name)
{
    
}

public class SimpleClass
{
    public SimpleClass(int id, string name)
    {
        Id = id;
        Name = name;
    }
    public int Id { get; set; }
    public string Name { get; set; }
}
