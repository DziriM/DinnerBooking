using BuberDinner.Domain.Common.Models;
using BuberDinner.Domain.Common.ValueObjects;
using BuberDinner.Domain.DinnerAggregate.ValueObjects;
using BuberDinner.Domain.GuestAggregate.ValueObjects;
using BuberDinner.Domain.HostAggregate.ValueObjects;
using BuberDinner.Domain.MenuAggregate.ValueObjects;
using BuberDinner.Domain.MenuReviewAggregate.ValueObjects;

namespace BuberDinner.Domain.MenuReviewAggregate;

public sealed class MenuReview : AggregateRoot<MenuReviewId, Guid>
{
    public Rating? Rating { get; private set;}

    public string Comment { get; private set;}
    public HostId HostId { get; private set;}
    public MenuId MenuId { get; private set;}

    public GuestId GuestId { get; private set;}

    public DinnerId DinnerId { get; private set;}

    public DateTime CreatedDateTime { get; private set;}

    public DateTime UpdatedDateTime { get; private set;}

    private MenuReview(
        MenuReviewId menuReviewId,
        string comment,
        HostId hostId,
        MenuId menuId,
        GuestId guestId,
        DinnerId dinnerId,
        Rating? rating,
        DateTime createdDateTime,
        DateTime updatedDateTime)
        : base(menuReviewId)
    {
        Comment = comment;
        HostId = hostId;
        MenuId = menuId;
        GuestId = guestId;
        DinnerId = dinnerId;
        Rating = rating;
        CreatedDateTime = createdDateTime;
        UpdatedDateTime = updatedDateTime;
    }

    public static MenuReview Create(
        string comment,
        HostId hostId,
        MenuId menuId,
        GuestId guestId,
        DinnerId dinnerId,
        Rating? rating)
    {
        return new MenuReview(
            MenuReviewId.CreateUnique(),
            comment,
            hostId,
            menuId,
            guestId,
            dinnerId,
            rating,
            DateTime.UtcNow,
            DateTime.UtcNow);
    }
    
#pragma warning disable CS8618
    private MenuReview() { }
#pragma warning restore CS8618
}