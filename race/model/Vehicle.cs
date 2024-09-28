// ReSharper disable InconsistentNaming

namespace race.model;

internal class Vehicle
{
    public VehicleType vehicleType { get; set; }
    public string racerName { get; set; }

    public int performTimeTick(RaceType raceRaceType, Whether raceWhether)
    {
        return vehicleType.speed;
    }

    public override string ToString()
    {
        return $"{vehicleType.name} ({racerName})";
    }
}