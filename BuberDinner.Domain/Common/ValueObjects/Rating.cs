using BuberDinner.Domain.Models;

namespace BuberDinner.Domain.Common.ValueObjects;

public sealed class Rating : ValueObject
{
    public double Value { get; private set; }
    
    private Rating(double value)
    {
        Value = value;
    }
    
    public static Rating CreateNew(double value)
    {
        return new Rating(value);
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }
    
}