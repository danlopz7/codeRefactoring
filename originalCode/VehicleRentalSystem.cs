public class VehicleRentalSystem 
{
 public List<Vehicle> Vehicles { get; set; } = new List<Vehicle>();

 public void AddVehicle(Vehicle vehicle)
 {
 Vehicles.Add(vehicle);
 vehicle.SaveToDatabase();
 vehicle.LogVehicleInfo();
 }
 public decimal RentVehicle(string model, int days)
 {
 var vehicle = Vehicles.FirstOrDefault(v => v.Model == model);
 if (vehicle == null)
 throw new ArgumentException("Vehicle not found");
 return vehicle.CalculateRentalCost(days);
 }
 public void PrintVehicleInfo()
 {
 foreach (var vehicle in Vehicles)
 {
 Console.WriteLine($"Vehicle: {vehicle.GetVehicleInfo()}, Efficiency:
{vehicle.GetEfficiency()}");
 }
 }
}