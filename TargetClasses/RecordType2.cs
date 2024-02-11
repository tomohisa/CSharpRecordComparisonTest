namespace CSharpRecordComparisonTest.Tests;

public record RecordType2(int Id, string Name) : IBase
{
    public string GetKey() => $"{Id}";
}