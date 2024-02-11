namespace CSharpRecordComparisonTest.TargetClasses;

public record RecordType1(int Id, string Name) : IBase
{
    public string GetKey() => $"{Id}";
}
