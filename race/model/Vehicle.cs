// ReSharper disable InconsistentNaming

namespace race.model;

internal class Vehicle
{
    public VehicleType vehicleType { get; init; }
    public string racerName { get; init; }

    public int performTimeTick(int position, int time, RaceType raceRaceType, Whether whether)
    {
        return vehicleType.performTimeTick(position, time, raceRaceType, whether);
    }

    public override string ToString()
    {
        return $"{vehicleType.name} ({racerName})";
    }
}