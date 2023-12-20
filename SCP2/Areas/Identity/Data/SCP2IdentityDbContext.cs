using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace SCP2.Areas.Identity.Data;

public class SCP2IdentityDbContext : IdentityDbContext<IdentityUser>
{
    public SCP2IdentityDbContext(DbContextOptions<SCP2IdentityDbContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        builder.HasDefaultSchema("Authentication");
    }
}
