using BuberDinner.Domain.Models;

namespace BuberDinner.Domain.DinnerAggregate.ValueObjects;

public class ReservationId  : ValueObject
{
    public Guid Value { get; }

    private ReservationId (Guid value)
    {
        Value = value;
    }

    public static ReservationId  CreateUnique()
    {
        return new ReservationId (Guid.NewGuid());
    }
    
    public static ReservationId Create(Guid value)
    {
        return new(value);
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }
}