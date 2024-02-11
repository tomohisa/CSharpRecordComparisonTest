using System.Collections.Immutable;
namespace CSharpRecordComparisonTest.TargetClasses;

public record SubRecordWithImmutableList(int Id, string Name, ImmutableList<int> Numbers)
{
}
