using CarRentalApplication.Server.Data;
using CarRentalApplication.Shared.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CarRentalApplication.Server.Configurations.Entities
{
    public class MakesSeedConfiguration : IEntityTypeConfiguration<Make>
    {
        public void Configure(EntityTypeBuilder<Make> builder)
        {
           builder.HasData(

                new Make
                {
                    ID = 1,
                    CreatedBy = "System",
                    UpdatedBy = "System",
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    Brand = "BMW"

                },
                new Make {
                    ID = 2,
                    CreatedBy ="System",
                    UpdatedBy = "System",
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    Brand = "Toyota"
                }, 
                new Make
                {
                    ID= 3,
                    CreatedBy="System",
                    UpdatedBy = "System",
                    DateCreated= DateTime.Now,
                    DateUpdated= DateTime.Now,
                    Brand = "Hyundai"
                }
                );
        }
    }
}
