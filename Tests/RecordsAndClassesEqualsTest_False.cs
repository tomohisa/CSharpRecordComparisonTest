using CSharpRecordComparisonTest.TargetClasses;
using System.Collections.Immutable;
namespace CSharpRecordComparisonTest.Tests;

public class RecordsAndClassesEqualsTest_False
{
    [Fact]
    public void SimpleClass()
    {
        var simpleClass1 = new SimpleClass(1, "Test");
        var simpleClass2 = new SimpleClass(1, "Test");

        Assert.False(simpleClass1 == simpleClass2);
        Assert.False(simpleClass1.Equals(simpleClass2));

        Assert.True(simpleClass1 != simpleClass2);
        Assert.True(!simpleClass1.Equals(simpleClass2));
        Assert.NotEqual(simpleClass1, simpleClass2);
    }
    [Fact]
    public void SimpleRecordWithList()
    {
        var record1 = new SimpleRecordWithList(1, "Test", new List<int> { 1, 2, 3 });
        var record2 = new SimpleRecordWithList(1, "Test", new List<int> { 1, 2, 3 });
        Assert.False(record1 == record2);
        Assert.False(record1.Equals(record2));
        Assert.True(record1 != record2);
        Assert.True(!record1.Equals(record2));
        Assert.NotEqual(record1, record2);
    }

    [Fact]
    public void SimpleRecordWithImmutableList()
    {
        // ImmutableList and List has same behavior.
        var record1 = new SimpleRecordWithImmutableList(1, "Test", ImmutableList<int>.Empty.Add(1).Add(2).Add(3));
        var record2 = new SimpleRecordWithImmutableList(1, "Test", ImmutableList<int>.Empty.Add(1).Add(2).Add(3));
        Assert.False(record1 == record2);
        Assert.False(record1.Equals(record2));
        Assert.True(record1 != record2);
        Assert.True(!record1.Equals(record2));
        Assert.NotEqual(record1, record2);
    }
    [Fact]
    public void SimpleRecordWithListAndSubclassWithoutEqualsOverrideWithEqualsOverrides()
    {
        var record1 = new SimpleRecordWithListAndSubclassWithoutEqualsOverrideWithEqualsOverrides(
            1,
            "Test",
            new List<SubRecordWithList>
            {
                new(1, "Test", new List<int> { 1, 2, 3 }),
                new(2, "Test", new List<int> { 1, 2, 3 })
            });
        var record2 = new SimpleRecordWithListAndSubclassWithoutEqualsOverrideWithEqualsOverrides(
            1,
            "Test",
            new List<SubRecordWithList>
            {
                new(1, "Test", new List<int> { 1, 2, 3 }),
                new(2, "Test", new List<int> { 1, 2, 3 })
            });

        Assert.False(record1 == record2);
        Assert.False(record1.Equals(record2));
        Assert.True(record1 != record2);
        Assert.True(!record1.Equals(record2));
        Assert.NotEqual(record1, record2);
    }
}
