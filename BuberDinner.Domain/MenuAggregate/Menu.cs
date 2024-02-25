using BuberDinner.Domain.Common.Models;
using BuberDinner.Domain.Common.ValueObjects;
using BuberDinner.Domain.DinnerAggregate.ValueObjects;
using BuberDinner.Domain.HostAggregate.ValueObjects;
using BuberDinner.Domain.MenuAggregate.Entities;
using BuberDinner.Domain.MenuAggregate.Events;
using BuberDinner.Domain.MenuAggregate.ValueObjects;
using BuberDinner.Domain.MenuReviewAggregate.ValueObjects;

namespace BuberDinner.Domain.MenuAggregate;

public sealed class Menu : AggregateRoot<MenuId, Guid>
{
    private readonly List<MenuSection>? _sections = new List<MenuSection>();
    private readonly List<DinnerId> _dinners = new List<DinnerId>();
    private readonly List<MenuReviewId> _menuReviewIds = new List<MenuReviewId>(); 
    public string Name { get; private set;} 
    public string Description { get; private set; }
    public AverageRating AverageRating { get; private set;}

    public IReadOnlyList<MenuSection>? Sections
    {
        get
        {
            if (_sections != null) 
                return _sections.AsReadOnly();
            return null;
        }
    }

    public HostId HostId { get; private set;}
    public IReadOnlyList<DinnerId> DinnerIds => _dinners.AsReadOnly();
    public IReadOnlyList<MenuReviewId> MenuReviewIds => _menuReviewIds.AsReadOnly();
    
    public DateTime CreatedDateTime { get; private set; }
    public DateTime UpdatedDateTime { get; private set; }

    private Menu(
        MenuId menuId,
        HostId hostId,
        string name,
        string description,
        AverageRating averageRating,
        List<MenuSection>? sections)
        : base(menuId)
    {
        HostId = hostId;
        Name = name;
        Description = description;
        _sections = sections;
        AverageRating = averageRating;
    }
    
    
    
    public static Menu Create(
        HostId hostId,
        string name,
        string description,
        List<MenuSection>? sections = null)
    {
        // TODO: Enforce invariants
        var menu = new Menu(
            MenuId.CreateUnique(),
            hostId,
            name,
            description,
            AverageRating.CreateNew(0),
            sections ?? new List<MenuSection>());

        // Adding the domainEvent to the list of events for this Aggregate
        menu.AddDomainEvent(new MenuCreated(menu));

        return menu;
    }
    
#pragma warning disable CS8618
    private Menu()
    {
    }
#pragma warning restore CS8618
}