// ReSharper disable InconsistentNaming

using System.Collections.Immutable;
using race.model;

namespace race.repository;

internal class RaceTypeRepository
{
    private readonly List<RaceType> list = new()
    {
        new RoadRaceType(),
        new AirRaceType(),
        new FreeRaceType(),
    };

    public IList<RaceType> findAll()
    {
        return list.ToImmutableList();
    }
}