// ReSharper disable InconsistentNaming

using System.Collections.Immutable;
using race.model;

namespace race.repository;

internal interface VehicleTypeRepository
{
    IList<VehicleType> findAll();
}

internal class VehicleTypeRepositoryImpl : VehicleTypeRepository
{
    private readonly List<VehicleType> list = new()
    {
        new RoadVehicleType() { name = "Some RR", speed = 1, restTime = 1, timeBeforeRest = 1},
        new AirVehicleType() { name = "Гуси-Лебеди", speed = 1 },
        new AirVehicleType() { name = "Избушка на курьих ножках", speed = 2 },
    };

    public IList<VehicleType> findAll()
    {
        return list.ToImmutableList();
    }
}