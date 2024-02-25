using BuberDinner.Domain.Common.Models;
using BuberDinner.Domain.DinnerAggregate;
using BuberDinner.Domain.GuestAggregate;
using BuberDinner.Domain.HostAggregate;
using BuberDinner.Domain.MenuAggregate;
using BuberDinner.Domain.MenuReviewAggregate;
using BuberDinner.Domain.UserAggregate;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;

namespace BuberDinner.Infrastructure.Persistence;

public class BuberDinnerDbContext : DbContext
{
    private readonly IEnumerable<IInterceptor> _publishDomainEventsInterceptor;

    public BuberDinnerDbContext(DbContextOptions<BuberDinnerDbContext> options, IEnumerable<IInterceptor> publishDomainEventsInterceptor) : base(options)
    {
        _publishDomainEventsInterceptor = publishDomainEventsInterceptor;
    }
    
    public DbSet<Dinner> Dinners { get; set; } = null!;
    public DbSet<Guest> Guests { get; set; } = null!;
    public DbSet<Host> Hosts { get; set; } = null!;
    public DbSet<Menu> Menus { get; set; } = null!;
    public DbSet<MenuReview> MenuReviews { get; set; } = null!;
    public DbSet<User> Users { get; set; } = null!;

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder
            .Ignore<List<IDomainEvent>>()
            .ApplyConfigurationsFromAssembly(typeof(BuberDinnerDbContext).Assembly);

        base.OnModelCreating(modelBuilder);
    }
    
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder
            .AddInterceptors(_publishDomainEventsInterceptor);

        base.OnConfiguring(optionsBuilder);
    }
}