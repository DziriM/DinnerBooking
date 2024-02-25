using BuberDinner.Domain.Common.Models;
using BuberDinner.Domain.GuestAggregate.ValueObjects;

namespace BuberDinner.Domain.GuestAggregate;

public sealed class Guest : AggregateRoot<GuestId, Guid>
{
    public Guest(GuestId id) : base(id)
    {
    }
    
#pragma warning disable CS8618
    private Guest() { }
#pragma warning restore CS8618
}