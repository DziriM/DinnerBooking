using BuberDinner.Domain.Common.Models;
using BuberDinner.Domain.Models;

namespace BuberDinner.Domain.DinnerAggregate.ValueObjects;

public class DinnerId : AggregateRootId<Guid>
{
    public override Guid Value { get; protected set; }

    private DinnerId(Guid value)
    {
        Value = value;
    }

    public static DinnerId CreateUnique()
    {
        return new DinnerId(Guid.NewGuid());
    }
    
    public static DinnerId Create(Guid value)
    {
        return new(value);
    }


    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }
    
    private DinnerId() { }
}