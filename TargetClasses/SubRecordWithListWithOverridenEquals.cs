namespace CSharpRecordComparisonTest.TargetClasses;

public record SubRecordWithListWithOverridenEquals(int Id, string Name, List<int> Numbers)
{
    public virtual bool Equals(SubRecordWithListWithOverridenEquals? other)
    {
        if (ReferenceEquals(null, other))
        {
            return false;
        }
        if (ReferenceEquals(this, other))
        {
            return true;
        }
        return Id == other.Id && Name == other.Name && Numbers.SequenceEqual(other.Numbers);
    }
    public override int GetHashCode()
    {
        unchecked
        {
            var hashCode = Id;
            hashCode = (hashCode * 397) ^ Name.GetHashCode();
            hashCode = (hashCode * 397) ^ Numbers.GetHashCode();
            return hashCode;
        }
    }
}
