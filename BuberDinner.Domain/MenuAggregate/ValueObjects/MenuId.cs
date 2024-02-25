using BuberDinner.Domain.Common.Models;

namespace BuberDinner.Domain.MenuAggregate.ValueObjects;

public sealed class MenuId : AggregateRootId<Guid>
{
    public override Guid Value { get; protected set;}

    private MenuId(Guid value)
    {
        Value = value;
    }

    public static MenuId Create(Guid value)
    {
        // TODO: Enforce Invariants
        return new MenuId(Guid.NewGuid());
    }

    public static MenuId CreateUnique()
    {
        // TODO: Enforce Invariants
        return new MenuId(Guid.NewGuid());
    }
    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }
}