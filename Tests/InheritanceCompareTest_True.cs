using CSharpRecordComparisonTest.TargetClasses;
namespace CSharpRecordComparisonTest.Tests;

public class InheritanceCompareTest_True
{
    [Fact]
    public void SameRecordTypeThroughDynamic()
    {
        dynamic record1 = new RecordType1(1, "Test");
        dynamic record2 = new RecordType1(1, "Test");

        Assert.True(record1 == record2);
        Assert.True(record1.Equals(record2));

        Assert.False(record1 != record2);
        Assert.False(!record1.Equals(record2));

        Assert.Equal(record1, record2);
    }
    [Fact]
    public void SameRecordTypeThroughVar()
    {
        var record1 = new RecordType1(1, "Test");
        var record2 = new RecordType1(1, "Test");

        Assert.True(record1 == record2);
        Assert.True(record1.Equals(record2));

        Assert.False(record1 != record2);
        Assert.False(!record1.Equals(record2));

        Assert.Equal(record1, record2);
    }
    [Fact]
    public void SameRecordWithEqualsOverridesTypeThroughDynamic()
    {
        dynamic record1 = new RecordWithArrayWithEqualsOverrides(
            1,
            "Test",
            new List<string>
                { "1", "2", "3" });
        dynamic record2 = new RecordWithArrayWithEqualsOverrides(
            1,
            "Test",
            new List<string>
                { "1", "2", "3" });
        Assert.True(record1 == record2);
        Assert.True(record1.Equals(record2));

        Assert.False(record1 != record2);
        Assert.False(!record1.Equals(record2));

        Assert.Equal(record1, record2);
    }
    [Fact]
    public void SameRecordWithEqualsOverridesTypeThroughVar()
    {
        var record1 = new RecordWithArrayWithEqualsOverrides(
            1,
            "Test",
            new List<string>
                { "1", "2", "3" });
        var record2 = new RecordWithArrayWithEqualsOverrides(
            1,
            "Test",
            new List<string>
                { "1", "2", "3" });
        Assert.True(record1 == record2);
        Assert.True(record1.Equals(record2));

        Assert.False(record1 != record2);
        Assert.False(!record1.Equals(record2));

        Assert.Equal(record1, record2);
    }
}
