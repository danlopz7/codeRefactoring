public class VehicleDatabaseService : IVehicleDatabase
{
    public void SaveToDatabase(Vehicle vehicle)
    {
        // Code to save vehicle to database
        Console.WriteLine($"Saving {vehicle.Model} to database");
    }

    public void LogVehicleInfo(Vehicle vehicle)
    {
        // Code to log vehicle information
        Console.WriteLine($"Logging: Added {vehicle.Model} to fleet");
    }
}
