using System.Text.Json;
namespace CSharpRecordComparisonTest;

public static class JsonEqualChecker
{
    public static bool JsonSerializableAndEqual(object? d1, object? d2)
    {
        if (ReferenceEquals(d1, d2))
        {
            return true;
        }
        if (ReferenceEquals(null, d1))
        {
            return false;
        }
        if (ReferenceEquals(null, d2))
        {
            return false;
        }
        var json1 = JsonSerializer.Serialize(d1);
        var obj1 = JsonSerializer.Deserialize(json1, d1.GetType());
        var json1_1 = JsonSerializer.Serialize(obj1);
        if (json1 != json1_1) { return false; }
        var json2 = JsonSerializer.Serialize(d2);
        var obj2 = JsonSerializer.Deserialize(json2, d2.GetType());
        var json2_1 = JsonSerializer.Serialize(obj2);
        if (json2 != json2_1) { return false; }
        return json1 == json2;
    }
}
