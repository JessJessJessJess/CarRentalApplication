using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CarRentalApplication.Server.Configurations.Entities
{
    public class RolesSeedConfiguration : IEntityTypeConfiguration<IdentityRole>
    {
        public void Configure(EntityTypeBuilder<IdentityRole> builder)
        {
          builder.HasData(

                new IdentityRole
                {
                    Id = "57947f0f-0a23-41c2-9d68-b8380997be21",
                    Name = "Administrator",
                    NormalizedName = "ADMINISTRATOR"
                },

                new IdentityRole
                {
                    Id = "67947f1f-1a34-42c2-9e68-b8380997be22",
                    Name = "User",
                    NormalizedName = "USER"
                }

                );
        }
    }
}
