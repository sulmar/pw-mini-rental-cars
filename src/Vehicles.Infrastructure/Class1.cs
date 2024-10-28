using Vehicles.Domain.Models;

namespace Vehicles.Infrastructure;

public class DbVehicleRepository : IVehicleRepository
{
    public IEnumerable<Vehicle> GetAll()
    {
        throw new NotImplementedException();
    }
}
