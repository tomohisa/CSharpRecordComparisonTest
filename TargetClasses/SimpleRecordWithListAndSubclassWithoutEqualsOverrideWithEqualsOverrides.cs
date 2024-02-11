namespace CSharpRecordComparisonTest.TargetClasses;

public record SimpleRecordWithListAndSubclassWithoutEqualsOverrideWithEqualsOverrides(int Id, string Name, List<SubRecordWithList> Subclasses)
{
    public virtual bool Equals(SimpleRecordWithListAndSubclassWithoutEqualsOverrideWithEqualsOverrides? other)
    {
        if (ReferenceEquals(null, other))
        {
            return false;
        }
        if (ReferenceEquals(this, other))
        {
            return true;
        }
        return Id == other.Id && Name == other.Name && Subclasses.SequenceEqual(other.Subclasses);
    }
    public override int GetHashCode()
    {
        unchecked
        {
            var hashCode = Id;
            hashCode = (hashCode * 397) ^ Name.GetHashCode();
            hashCode = (hashCode * 397) ^ Subclasses.GetHashCode();
            return hashCode;
        }
    }
}
