// ReSharper disable InconsistentNaming


namespace race.model;

internal interface RaceType
{
    bool canRace(VehicleType vehicleType);

    string name { get; }
}

internal class AirRaceType : RaceType
{
    public string name => "Air Race";

    public bool canRace(VehicleType vehicleType)
    {
        return vehicleType is AirVehicleType;
    }
}

internal class RoadRaceType : RaceType
{
    public string name => "Road Race";

    public bool canRace(VehicleType vehicleType)
    {
        return vehicleType is RoadVehicleType;
    }
}

internal class FreeRaceType : RaceType
{
    public string name => "Free Race";

    public bool canRace(VehicleType vehicleType)
    {
        return true;
    }
}