// ReSharper disable InconsistentNaming

namespace race.model;

internal interface VehicleType
{
    string name { get; set; }
    int speed { get; set; }
}

internal class AirVehicleType : VehicleType
{
    public string name { get; set; }
    public int speed { get; set; }
}

public class RoadVehicleType : VehicleType
{
    public string name { get; set; }
    public int speed { get; set; }
    public int timeBeforeRest { get; set; }
    public int restTime { get; set; }
}