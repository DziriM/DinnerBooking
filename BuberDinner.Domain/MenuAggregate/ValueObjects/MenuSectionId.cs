using BuberDinner.Domain.Models;

namespace BuberDinner.Domain.MenuAggregate.ValueObjects;

public sealed class MenuSectionId : ValueObject
{
    public Guid Value { get; private set;}

    private MenuSectionId(Guid value)
    {
        Value = value;
    }

    public static MenuSectionId CreateUnique()
    {
        return new MenuSectionId(Guid.NewGuid());
    }
    
    public static MenuSectionId Create(Guid value)
    {
        return new MenuSectionId(Guid.NewGuid());
    }
    
    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    
}