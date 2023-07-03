using CarRentalApplication.Server.Configurations.Entities;
using CarRentalApplication.Server.Models;
using CarRentalApplication.Shared.Domain;
using Duende.IdentityServer.EntityFramework.Options;
using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace CarRentalApplication.Server.Data
{
    public class ApplicationDbContext : ApiAuthorizationDbContext<ApplicationUser>
    {
        public ApplicationDbContext(
            DbContextOptions options,
            IOptions<OperationalStoreOptions> operationalStoreOptions) : base(options, operationalStoreOptions)
        {
        }

        public DbSet<Vehicle> Vehicles { get; set; }
        public DbSet<Color> Colors { get; set; }
        public DbSet<Make> Makes { get; set; }
        public DbSet<Model> Models { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Booking> Bookings { get; set; }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ApplyConfiguration(new ColorSeedConfiguration());
            builder.ApplyConfiguration(new ModelSeedConfiguration());
            builder.ApplyConfiguration(new MakesSeedConfiguration());
            builder.ApplyConfiguration(new RolesSeedConfiguration());
            builder.ApplyConfiguration(new DefaultUserSeedConfiguration());
            builder.ApplyConfiguration(new UserRoleSeedConfiguration());
            
        }
    }
}