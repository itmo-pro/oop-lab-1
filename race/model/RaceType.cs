// ReSharper disable InconsistentNaming


namespace race.model;

internal interface RaceType
{
    bool canRace(VehicleType vehicleType);

    string name { get; }
}

internal class AirRaceType : RaceType
{
    public string name => "только для воздушного транспорта";

    public bool canRace(VehicleType vehicleType)
    {
        return vehicleType is AirVehicleType;
    }
}

internal class RoadRaceType : RaceType
{
    public string name => "только для наземного транспорта";

    public bool canRace(VehicleType vehicleType)
    {
        return vehicleType is RoadVehicleType;
    }
}

internal class FreeRaceType : RaceType
{
    public string name => "для всех типов транспортных средств";

    public bool canRace(VehicleType vehicleType)
    {
        return true;
    }
}