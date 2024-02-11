namespace CSharpRecordComparisonTest.Tests;

public record RecordType3(int IdWithDifferentKey, string Name) : IBase
{
    public string GetKey() => $"{IdWithDifferentKey}";
}