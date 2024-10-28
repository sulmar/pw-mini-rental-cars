namespace Vehicles.Domain.Models;

public interface IVehicleRepository
{
    IEnumerable<Vehicle> GetAll();    
}