namespace CarRentalApplication.Shared.Domain
{
    public class Booking :BaseDomainModel
    {
        public int VehicleId { get; set; }
        public virtual Vehicle Vehicle { get; set; }
        public DateTime DateIn { get; set; }    
        public DateTime DateOut { get; set; }
        public virtual Customer Customer { get; set; }  
        public int CustomerID { get; set; }



    }
}