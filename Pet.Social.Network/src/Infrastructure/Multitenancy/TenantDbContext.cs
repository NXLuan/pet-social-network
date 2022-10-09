using Finbuckle.MultiTenant.Stores;
using Pet.Social.Network.Infrastructure.Persistence.Configuration;
using Microsoft.EntityFrameworkCore;

namespace Pet.Social.Network.Infrastructure.Multitenancy;

public class TenantDbContext : EFCoreStoreDbContext<FSHTenantInfo>
{
    public TenantDbContext(DbContextOptions<TenantDbContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<FSHTenantInfo>().ToTable("Tenants", SchemaNames.MultiTenancy);
    }
}