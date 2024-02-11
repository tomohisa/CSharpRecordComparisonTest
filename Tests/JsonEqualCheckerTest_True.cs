using CSharpRecordComparisonTest.TargetClasses;
using System.Collections.Immutable;
namespace CSharpRecordComparisonTest.Tests;

public class JsonEqualCheckerTest_Spec
{
    [Fact]
    public void BothNullWillBeTrue()
    {
        object? simpleClass1 = null;
        object? simpleClass2 = null;

        Assert.True(JsonEqualChecker.JsonSerializableAndEqual(simpleClass1, simpleClass2));
    }
    [Fact]
    public void OneNullWillBeFalse()
    {
        var simpleClass1 = new SimpleClass(1, "Test");
        object? simpleClass2 = null;

        Assert.False(JsonEqualChecker.JsonSerializableAndEqual(simpleClass1, simpleClass2));
    }
    [Fact]
    public void OneNullWillBeFalse2()
    {
        var simpleClass1 = new SimpleClass(1, "Test");
        object? simpleClass2 = null;

        Assert.False(JsonEqualChecker.JsonSerializableAndEqual(simpleClass2, simpleClass1));
    }
}
public class JsonEqualCheckerTest_True
{
    [Fact]
    public void SimpleClass()
    {
        var simpleClass1 = new SimpleClass(1, "Test");
        var simpleClass2 = new SimpleClass(1, "Test");

        Assert.True(JsonEqualChecker.JsonSerializableAndEqual(simpleClass1, simpleClass2));
    }
    [Fact]
    public void SimpleRecordWithList()
    {
        var record1 = new SimpleRecordWithList(1, "Test", new List<int> { 1, 2, 3 });
        var record2 = new SimpleRecordWithList(1, "Test", new List<int> { 1, 2, 3 });
        Assert.True(JsonEqualChecker.JsonSerializableAndEqual(record1, record2));
    }
    [Fact]
    public void SimpleRecordWithImmutableList()
    {
        // ImmutableList and List has same behavior.
        var record1 = new SimpleRecordWithImmutableList(1, "Test", ImmutableList<int>.Empty.Add(1).Add(2).Add(3));
        var record2 = new SimpleRecordWithImmutableList(1, "Test", ImmutableList<int>.Empty.Add(1).Add(2).Add(3));
        Assert.True(JsonEqualChecker.JsonSerializableAndEqual(record1, record2));
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
        Assert.True(JsonEqualChecker.JsonSerializableAndEqual(record1, record2));
    }
    [Fact]
    public void SameRecordTypeThroughInterface()
    {
        IBase record1 = new RecordType1(1, "Test");
        IBase record2 = new RecordType1(1, "Test");
        Assert.True(JsonEqualChecker.JsonSerializableAndEqual(record1, record2));
    }
    [Fact]
    public void SameRecordWithEqualsOverridesTypeThroughInterface()
    {
        IBaseWithArray record1 = new RecordWithArrayWithEqualsOverrides(
            1,
            "Test",
            new List<string>
                { "1", "2", "3" });
        IBaseWithArray record2 = new RecordWithArrayWithEqualsOverrides(
            1,
            "Test",
            new List<string>
                { "1", "2", "3" });
        Assert.True(JsonEqualChecker.JsonSerializableAndEqual(record1, record2));
    }
}
