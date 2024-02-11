using CSharpRecordComparisonTest.TargetClasses;
namespace CSharpRecordComparisonTest.Tests;

public class InheritanceCompareTest_Mixed
{
    [Fact]
    public void SameRecordTypeThroughInterface()
    {
        IBase record1 = new RecordType1(1, "Test");
        IBase record2 = new RecordType1(1, "Test");

        Assert.False(record1 == record2);
        Assert.True(record1.Equals(record2));

        Assert.True(record1 != record2);
        Assert.False(!record1.Equals(record2));

        Assert.Equal(record1, record2);
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
        Assert.False(record1 == record2);
        Assert.True(record1.Equals(record2));

        Assert.True(record1 != record2);
        Assert.False(!record1.Equals(record2));

        Assert.Equal(record1, record2);
    }


    [Fact]
    public void SameRecordTypeThroughObject()
    {
        object record1 = new RecordType1(1, "Test");
        object record2 = new RecordType1(1, "Test");

        Assert.False(record1 == record2);
        Assert.True(record1.Equals(record2));

        Assert.True(record1 != record2);
        Assert.False(!record1.Equals(record2));

        Assert.Equal(record1, record2);
    }
}
