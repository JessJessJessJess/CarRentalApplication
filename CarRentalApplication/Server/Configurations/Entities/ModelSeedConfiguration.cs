using CarRentalApplication.Shared.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CarRentalApplication.Server.Configurations.Entities
{
    public class ModelSeedConfiguration : IEntityTypeConfiguration<Model>
    {
        public void Configure(EntityTypeBuilder<Model> builder)
        {
            builder.HasData(
                new Model
                {
                    ID = 1, 
                    UpdatedBy = "System",
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    DateCreated = DateTime.Now,
                    Name = "Model 1"
                },
                new Model
                {
                    ID = 2,
                    UpdatedBy = "System",
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    DateCreated = DateTime.Now,
                    Name = "Model 2"
                }
            );
        }
    }
}
