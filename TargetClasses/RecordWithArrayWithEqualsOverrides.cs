namespace CSharpRecordComparisonTest.TargetClasses;

public record RecordWithArrayWithEqualsOverrides(int Id, string Name, List<string> Values) : IBaseWithArray
{
    public string GetKey() => $"{Id}";
    public List<string> GetValues() => Values;
    public virtual bool Equals(RecordWithArrayWithEqualsOverrides? obj) =>
        obj is not null && Id == obj.Id && Name == obj.Name && Values.SequenceEqual(obj.Values);
    public override int GetHashCode() => HashCode.Combine(Id, Name, Values);
}