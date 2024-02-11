namespace CSharpRecordComparisonTest.TargetClasses;

public class SimpleClassWithEquatable : IEquatable<SimpleClassWithEquatable>
{
    public SimpleClassWithEquatable(int id, string name)
    {
        Id = id;
        Name = name;
    }
    public int Id { get; set; }
    public string Name { get; set; }
    public bool Equals(SimpleClassWithEquatable? other)
    {
        if (ReferenceEquals(null, other))
        {
            return false;
        }
        if (ReferenceEquals(this, other))
        {
            return true;
        }
        return Id == other.Id && Name == other.Name;
    }
    public override bool Equals(object? obj)
    {
        if (ReferenceEquals(null, obj))
        {
            return false;
        }
        if (ReferenceEquals(this, obj))
        {
            return true;
        }
        if (obj.GetType() != GetType())
        {
            return false;
        }
        return Equals((SimpleClassWithEquatable)obj);
    }
    public override int GetHashCode()
    {
        unchecked
        {
            return (Id * 397) ^ Name.GetHashCode();
        }
    }
    public static bool operator ==(SimpleClassWithEquatable? left, SimpleClassWithEquatable? right) => Equals(left, right);
    public static bool operator !=(SimpleClassWithEquatable? left, SimpleClassWithEquatable? right) => !Equals(left, right);
}