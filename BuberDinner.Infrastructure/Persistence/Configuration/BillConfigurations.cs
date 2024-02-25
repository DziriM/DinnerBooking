using BuberDinner.Domain.BillAggregate;
using BuberDinner.Domain.BillAggregate.ValueObjects;
using BuberDinner.Domain.DinnerAggregate.ValueObjects;
using BuberDinner.Domain.GuestAggregate.ValueObjects;
using BuberDinner.Domain.HostAggregate.ValueObjects;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BuberDinner.Infrastructure.Persistence.Configuration;

public class BillConfigurations : IEntityTypeConfiguration<Bill>
{
    public void Configure(EntityTypeBuilder<Bill> builder)
    {
        ConfigureBillsTable(builder);
    }

    private static void ConfigureBillsTable(EntityTypeBuilder<Bill> builder)
    {
        builder
            .ToTable("Bills");

        builder
            .HasKey(b => b.Id);

        builder
            .Property(b => b.Id)
            .ValueGeneratedNever()
            .HasConversion(
                id => id.Value,
                value => BillId.Create(value));

        builder
            .OwnsOne(b => b.Price);

        builder
            .Property(b => b.DinnerId)
            .HasConversion(
                id => id.Value,
                value => DinnerId.Create(value));

        builder
            .Property(b => b.GuestId)
            .HasConversion(
                id => id.Value,
                value => GuestId.Create(value));

        builder
            .Property(b => b.HostId)
            .HasConversion(
                id => id.Value,
                value => HostId.Create(value));
        
    }
}