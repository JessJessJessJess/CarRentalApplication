using CarRentalApplication.Server.Data;
using CarRentalApplication.Server.IRepository;
using CarRentalApplication.Shared.Domain;
using IdentityModel;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.IdentityModel.Protocols.OpenIdConnect;

namespace CarRentalApplication.Server.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _context;
        private IGenericRepository<Make> _makes;
        private IGenericRepository<Model> _models;
        private IGenericRepository<Color> _colors;
        private IGenericRepository<Booking> _bookings;
        private IGenericRepository<Customer> _customers;
        private IGenericRepository<Vehicle> _vehicles;
        public UnitOfWork(ApplicationDbContext context)
        {
            _context = context;
        }
        public IGenericRepository<Make> Makes
            => _makes ??= new GenericRepository<Make>(_context);


        public IGenericRepository<Model> Models
            => _models ??= new GenericRepository<Model>(_context);

        public IGenericRepository<Color> Colors 
            => _colors ??= new GenericRepository<Color>(_context);

        public IGenericRepository<Booking> Bookings 
            => _bookings ??=  new GenericRepository<Booking>(_context);

        public IGenericRepository<Customer> Customers
            => _customers ??= new GenericRepository<Customer>(_context);

        public IGenericRepository<Vehicle> Vehicles 
            => _vehicles ??= new GenericRepository<Vehicle>(_context);
        
        public void Dispose()
        {
            _context.Dispose();
            GC.SuppressFinalize(this);
        }

        public async Task Save(HttpContext httpContext)
        {
            var user = httpContext.User.Identity.Name;
            
            var entries = _context.ChangeTracker.Entries()
                .Where(p => p.State == EntityState.Modified
                || p.State == EntityState.Added);

            


            foreach (var entry in entries)
            {

                ((BaseDomainModel)entry.Entity).DateUpdated = DateTime.Now;
                ((BaseDomainModel)entry.Entity).UpdatedBy = user;



                if (entry.State == EntityState.Added)
                {
                    ((BaseDomainModel)entry.Entity).DateCreated = DateTime.Now;
                    ((BaseDomainModel)entry.Entity).CreatedBy = user;
                }
                //((BaseDomainModel).entry.Entity).DateUpdated = DateTime.Now;
            }

            await _context.SaveChangesAsync();
        }

  
    }
}
