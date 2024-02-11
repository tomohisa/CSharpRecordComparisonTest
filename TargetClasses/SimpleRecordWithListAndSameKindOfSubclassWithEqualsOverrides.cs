namespace CSharpRecordComparisonTest.TargetClasses;

public record SimpleRecordWithListAndSameKindOfSubclassWithEqualsOverrides(
    int Id,
    string Name,
    List<SubRecordWithListWithOverridenEquals> Subclasses)
{
    public virtual bool Equals(SimpleRecordWithListAndSameKindOfSubclassWithEqualsOverrides? other)
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
