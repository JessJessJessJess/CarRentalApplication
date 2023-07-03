using CarRentalApplication.Shared.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CarRentalApplication.Server.Configurations.Entities
{
    public class ColorSeedConfiguration : IEntityTypeConfiguration<Color>

    {
        public void Configure(EntityTypeBuilder<Color> builder)
        {
            builder.HasData(

               new Color
               {
                   ID = 1,
                   CreatedBy = "System",
                   DateCreated = DateTime.Now,
                   DateUpdated = DateTime.Now,
                   Name = "Black",
                   UpdatedBy = "System"
               },
                  new Color
                  {
                      ID = 2,
                      CreatedBy = "System",
                      DateCreated = DateTime.Now,
                      DateUpdated = DateTime.Now,
                      Name = "Blue",
                      UpdatedBy = "System"
                  },
                     new Color
                     {
                         ID = 3,
                         CreatedBy = "System",
                         DateCreated = DateTime.Now,
                         DateUpdated = DateTime.Now,
                         Name = "White",
                         UpdatedBy = "System"
                     }
               );
        }
    }
}
