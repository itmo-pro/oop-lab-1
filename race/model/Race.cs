// ReSharper disable InconsistentNaming

namespace race.model;

internal class Race
{
    public Race(RaceType raceType, int distance, IList<Vehicle> vehicles, Whether whether)
    {
        this.raceType = raceType;
        this.distance = distance;
        this.vehicles = vehicles;
        this.whether = whether;
    }

    public RaceType raceType { get; }
    public IList<Vehicle> vehicles { get; }
    public Whether whether { get; }
    public int distance { get; }
    public IList<Tuple<Vehicle, int>> results { get; set; } = new List<Tuple<Vehicle, int>>();
}