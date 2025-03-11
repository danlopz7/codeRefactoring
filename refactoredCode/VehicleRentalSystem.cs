public class VehicleRentalSystem
{
    public List<Vehicle> Vehicles { get; set; } = new List<Vehicle>();
    private readonly IVehicleDatabase _vehicleDatabase;
    private readonly IVehiclePricing _vehiclePricing;

    public VehicleRentalSystem(IVehicleDatabase vehicleDatabase, IVehiclePricing vehiclePricing)
    {
        _vehicleDatabase = vehicleDatabase;
        _vehiclePricing = vehiclePricing;
    }

    public void AddVehicle(Vehicle vehicle)
    {
        Vehicles.Add(vehicle);
        _vehicleDatabase.SaveToDatabase(vehicle);
        _vehicleDatabase.LogVehicleInfo(vehicle);
    }

    public decimal RentVehicle(string model, int days)
    {
        var vehicle = Vehicles.FirstOrDefault(v => v.Model == model);
        if (vehicle == null)
            throw new ArgumentException("Vehicle not found");
        return _vehiclePricing.CalculateRentalCost(vehicle, days);
    }

    public void PrintVehicleInfo()
    {
        foreach (var vehicle in Vehicles)
        {
            Console.WriteLine($"Vehicle: {vehicle.Model}, Efficiency: {vehicle.FuelEfficiency}");
        }
    }
}
