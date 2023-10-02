namespace Domain;

public abstract class Entity
{
    protected Entity(Guid id)
    {
        Id = id;
    }

    protected Entity()
    {
        Id = Guid.NewGuid();
    }

    public Guid Id { get; }

    public override bool Equals(object? other)
    {
        if (other is null || GetType() != other.GetType())
            return false;

        return Equals((Entity) other);
    }

    public bool Equals(Entity other) => Id == other.Id;

    public override int GetHashCode() => Id.GetHashCode();

    public static bool operator ==(Entity? a, Entity? b)
    {
        if (a is null)
            return b is null;

        return a.Equals(b);
    }

    public static bool operator !=(Entity? a, Entity? b)
    {
        return !(a == b);
    }
}