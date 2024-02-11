using System.Collections.Immutable;
namespace CSharpRecordComparisonTest.TargetClasses;

public record SimpleRecordWithImmutableList(int Id, string Name, ImmutableList<int> Numbers)
{
}
