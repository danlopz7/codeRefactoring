public class Vehicle
{
    public string Model { get; set; }
    public int Year { get; set; }
    public string Type { get; set; }
    public double FuelEfficiency { get; set; }
    public int ElectricRange { get; set; }

    public void SaveToDatabase()
    {
        // Code to save vehicle to database Console.WriteLine($"Saving {Model} to database");
    }

    public void LogVehicleInfo()
    {
        // Code to log vehicle information Console.WriteLine($"Logging: Added {Model} to fleet");
    }

    public decimal CalculateRentalCost(int days)
    {
        switch (Type)
        {
            case "Car":
                return days * 50;
            case "Truck":
                return days * 100;
            case "Electric":
                return days * 75;
            default:
                throw new ArgumentException("Unknown vehicle type");
        }
    }

    public string GetVehicleInfo()
    {
        return $"{Year} {Model} ({Type})";
    }

    public double GetEfficiency()
    {
        if (Type == "Electric")
            return ElectricRange;
        else
            return FuelEfficiency;
    }
}
