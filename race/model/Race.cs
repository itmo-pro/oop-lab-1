// ReSharper disable InconsistentNaming

namespace race.model;

internal class Race
{
    public RaceType raceType { get; set; }
    public IList<Vehicle> vehicles { get; set; }
    public Whether whether { get; set; }
    public int distance { get; set; }

    public IList<Tuple<Vehicle, int>> getResults()
    {
        return new List<Tuple<Vehicle, int>>();
    }
}