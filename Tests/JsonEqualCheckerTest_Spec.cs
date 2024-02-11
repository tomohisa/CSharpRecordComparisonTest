using CSharpRecordComparisonTest.TargetClasses;
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