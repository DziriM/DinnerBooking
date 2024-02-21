using BuberDinner.Domain.Common.Models;
using BuberDinner.Domain.GuestAggregate.ValueObjects;

namespace BuberDinner.Domain.GuestAggregate;

public sealed class Guest : AggregateRoot<GuestId>
{
    public Guest(GuestId id) : base(id)
    {
    }
}