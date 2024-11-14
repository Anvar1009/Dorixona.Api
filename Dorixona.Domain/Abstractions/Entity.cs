namespace Dorixona.Domain.Abstractions;

public abstract class Entity
{
    private readonly List<IDomainEvent> _domainEvents = new();

    protected Entity()
    {

    }
    protected Entity(Guid Id)
    {
        this.Id = Id;
    }
    public Guid Id { get; private set; }

    public IReadOnlyList<IDomainEvent> GetDomainEvents()
    {
        return _domainEvents.ToList();
    }

    public void ClaerDomainEvents()
    {
        _domainEvents.Clear();
    }

    protected void RaiseDamainEvent(IDomainEvent domainEvent)
    {
        _domainEvents.Add(domainEvent);
    }

}
