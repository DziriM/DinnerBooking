using BuberDinner.Domain.BillAggregate.ValueObjects;
using BuberDinner.Domain.Common.Models;
using BuberDinner.Domain.DinnerAggregate.ValueObjects;
using BuberDinner.Domain.GuestAggregate.ValueObjects;
using BuberDinner.Domain.HostAggregate.ValueObjects;

namespace BuberDinner.Domain.BillAggregate;

public sealed class Bill : AggregateRoot<BillId, Guid>
{
    public DinnerId DinnerId { get; private set;}
    public GuestId GuestId { get; private set;}
    public HostId HostId { get; private set;}
    public Price Price { get; private set;}
    public DateTime CreatedDateTime { get; private set;}
    public DateTime UpdatedDateTime { get; private set;}

    private Bill(
        BillId id,
        GuestId guestId,
        HostId hostId,
        Price price,
        DinnerId dinnerId,
        DateTime createdDateTime,
        DateTime updatedDateTime)
        : base(id)
    {
        GuestId = guestId;
        HostId = hostId;
        Price = price;
        DinnerId = dinnerId;
        CreatedDateTime = createdDateTime;
        UpdatedDateTime = updatedDateTime;
    }

    public static Bill Create(
        GuestId guestId,
        HostId hostId,
        Price price,
        DinnerId dinnerId)
    {
        return new(
            BillId.CreateUnique(),
            guestId,
            hostId,
            price,
            dinnerId,
            DateTime.UtcNow,
            DateTime.UtcNow);
    }
    
#pragma warning disable CS8618
    private Bill() { }
#pragma warning restore CS8618
}