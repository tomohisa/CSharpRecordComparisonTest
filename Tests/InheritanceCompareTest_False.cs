using Microsoft.CSharp.RuntimeBinder;
namespace CSharpRecordComparisonTest.Tests;

public class InheritanceCompareTest_False
{
    [Fact]
    public void DifferentRecordTypeThroughInterface()
    {
        IBase record1 = new RecordType1(1, "Test");
        IBase record2 = new RecordType3(1, "Test");

        Assert.False(record1 == record2);
        Assert.False(record1.Equals(record2));

        Assert.True(record1 != record2);
        Assert.True(!record1.Equals(record2));

        Assert.NotEqual(record1, record2);
    }
    [Fact]
    public void DifferentRecordButSameStructureTypeThroughInterface()
    {
        IBase record1 = new RecordType1(1, "Test");
        IBase record2 = new RecordType2(1, "Test");

        Assert.False(record1 == record2);
        Assert.False(record1.Equals(record2));

        Assert.True(record1 != record2);
        Assert.True(!record1.Equals(record2));

        Assert.NotEqual(record1, record2);
    }
    [Fact]
    public void DifferentRecordTypeThroughObject()
    {
        object record1 = new RecordType1(1, "Test");
        object record2 = new RecordType3(1, "Test");

        Assert.False(record1 == record2);
        Assert.False(record1.Equals(record2));

        Assert.True(record1 != record2);
        Assert.True(!record1.Equals(record2));

        Assert.NotEqual(record1, record2);
    }
    [Fact]
    public void DifferentRecordButSameStructureTypeThroughObject()
    {
        object record1 = new RecordType1(1, "Test");
        object record2 = new RecordType2(1, "Test");

        Assert.False(record1 == record2);
        Assert.False(record1.Equals(record2));

        Assert.True(record1 != record2);
        Assert.True(!record1.Equals(record2));

        Assert.NotEqual(record1, record2);
    }

    [Fact]
    public void DifferentRecordTypeThroughDynamic()
    {
        dynamic record1 = new RecordType1(1, "Test");
        dynamic record2 = new RecordType3(1, "Test");

        Assert.Throws<RuntimeBinderException>(() => record1 == record2);
        Assert.False(record1.Equals(record2));

        Assert.Throws<RuntimeBinderException>(() => record1 != record2);
        Assert.True(!record1.Equals(record2));

        // can not do this because of dynamic
        // Assert.NotEqual(record1, record2);
    }
    [Fact]
    public void DifferentRecordButSameStructureTypeThroughDynamic()
    {
        dynamic record1 = new RecordType1(1, "Test");
        dynamic record2 = new RecordType2(1, "Test");

        Assert.Throws<RuntimeBinderException>(() => record1 == record2);
        Assert.False(record1.Equals(record2));

        Assert.Throws<RuntimeBinderException>(() => record1 != record2);
        Assert.True(!record1.Equals(record2));
        // can not do this because of dynamic
        // Assert.NotEqual(record1, record2);
    }
}