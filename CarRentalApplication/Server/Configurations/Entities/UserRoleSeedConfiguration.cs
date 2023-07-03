using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CarRentalApplication.Server.Configurations.Entities
{
    public class UserRoleSeedConfiguration : IEntityTypeConfiguration<IdentityUserRole<string>>
    {
        public void Configure(EntityTypeBuilder<IdentityUserRole<string>> builder)
        {
            builder.HasData(
                new IdentityUserRole<string>
                {
                    RoleId = "57947f0f-0a23-41c2-9d68-b8380997be21",
                    UserId = "0b844869-f724-4dbf-9b5a-3d25e9a369ec"
                },

                new IdentityUserRole<string>
                {
                    RoleId = "67947f1f-1a34-42c2-9e68-b8380997be22",
                    UserId = "1b844869-f734-5dbf-ab5a-4d25e9a369ec"
                }



                );
        }
    }
}
