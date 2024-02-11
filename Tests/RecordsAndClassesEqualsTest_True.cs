using CSharpRecordComparisonTest.TargetClasses;
namespace CSharpRecordComparisonTest.Tests;

public class RecordsAndClassesEqualsTest_True
{
    [Fact]
    public void SimpleRecord()
    {
        var record1 = new SimpleRecord(1, "Test");
        var record2 = new SimpleRecord(1, "Test");
        Assert.True(record1 == record2);
        Assert.True(record1.Equals(record2));
        Assert.False(record1 != record2);
        Assert.False(!record1.Equals(record2));
        Assert.Equal(record1, record2);
    }
    [Fact]
    public void SimpleClassWithEquatable()
    {
        var class1 = new SimpleClassWithEquatable(1, "Test");
        var class2 = new SimpleClassWithEquatable(1, "Test");
        Assert.True(class1 == class2);
        Assert.True(class1.Equals(class2));
        Assert.False(class1 != class2);
        Assert.False(!class1.Equals(class2));
        Assert.Equal(class1, class2);
    }
    [Fact]
    public void SimpleRecordWithListWithEqualsOverrides()
    {
        var record1 = new SimpleRecordWithListWithEqualsOverrides(1, "Test", new List<int> { 1, 2, 3 });
        var record2 = new SimpleRecordWithListWithEqualsOverrides(1, "Test", new List<int> { 1, 2, 3 });
        Assert.True(record1 == record2);
        Assert.True(record1.Equals(record2));
        Assert.False(record1 != record2);
        Assert.False(!record1.Equals(record2));
        Assert.Equal(record1, record2);
    }
    [Fact]
    public void SimpleRecordWithListAndSameKindOfSubclassWithEqualsOverrides()
    {
        var record1 = new SimpleRecordWithListAndSameKindOfSubclassWithEqualsOverrides(
            1,
            "Test",
            new List<SubRecordWithListWithOverridenEquals>
            {
                new(1, "Test", new List<int> { 1, 2, 3 }),
                new(2, "Test", new List<int> { 1, 2, 3 })
            });
        var record2 = new SimpleRecordWithListAndSameKindOfSubclassWithEqualsOverrides(
            1,
            "Test",
            new List<SubRecordWithListWithOverridenEquals>
            {
                new(1, "Test", new List<int> { 1, 2, 3 }),
                new(2, "Test", new List<int> { 1, 2, 3 })
            });

        Assert.True(record1 == record2);
        Assert.True(record1.Equals(record2));
        Assert.False(record1 != record2);
        Assert.False(!record1.Equals(record2));
        Assert.Equal(record1, record2);
    }
}
