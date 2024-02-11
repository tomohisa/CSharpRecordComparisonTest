namespace CSharpRecordComparisonTest.TargetClasses;

public record RecordWithArray1(int Id, string Name, List<string> Values) : IBaseWithArray
{
    public string GetKey() => $"{Id}";
    public List<string> GetValues() => Values;
}