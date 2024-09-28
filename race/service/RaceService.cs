// ReSharper disable InconsistentNaming

using System.Diagnostics.CodeAnalysis;
using race.config;
using race.model;

namespace race.service;

internal class RaceService
{
    // ReSharper disable once MemberCanBeMadeStatic.Global
    [SuppressMessage("Performance", "CA1822")]
    public void perform(Race race)
    {
        var time = 0;
        var vehiclePositions = race.vehicles.ToDictionary(v => v, _ => 0);
        var vehicleTimes = race.vehicles.ToDictionary(v => v, _ => 0);

        while (vehiclePositions.Values.Min() < race.distance)
        {
            foreach (var (vehicle, position) in vehiclePositions)
            {
                if (position < race.distance)
                {
                    var nextPosition = position + vehicle.performTimeTick(position, time, race.raceType, race.whether);
                    vehiclePositions[vehicle] = nextPosition;
                    if (nextPosition >= race.distance)
                    {
                        vehicleTimes[vehicle] = time;
                    }
                }
            }

            if (++time > AppConfig.RACE_TIME_MAX)
            {
                break;
            }
        }

        race.results = vehicleTimes
            .Select(it => new Tuple<Vehicle, int>(it.Key, it.Value))
            .OrderBy(it => it.Item2)
            .ToList();
    }
}