namespace CSharpRecordComparisonTest.TargetClasses;

public record SimpleRecordWithSortableList(int Id, string Name, SortedSet<int> Numbers)
{
}
