public class VehiclePricingService : IVehiclePricing
{
    public decimal CalculateRentalCost(Vehicle vehicle, int days)
    {
        switch (vehicle.Type)
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
}
