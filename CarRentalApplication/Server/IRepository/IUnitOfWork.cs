using CarRentalApplication.Server.Controllers;
using CarRentalApplication.Shared.Domain;

namespace CarRentalApplication.Server.IRepository
{
    public interface IUnitOfWork : IDisposable
    {
        Task Save(HttpContext httpContext);
        IGenericRepository<Make> Makes { get;}
        IGenericRepository<Model> Models { get; }
        IGenericRepository<Color> Colors { get; }

        IGenericRepository<Vehicle> Vehicles { get; }
        IGenericRepository<Customer> Customers { get; }
        IGenericRepository<Booking> Bookings { get; }

   
        

    }
}
