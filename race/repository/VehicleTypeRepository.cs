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
        new AirVehicleType() { name = "Ступа Бабы Яги", speed = 10, accelerator = x => x / 2 },
        new AirVehicleType() { name = "Метла", speed = 50, accelerator = x => x / 3 },
        new RoadVehicleType() { name = "Сапоги-скороходы", speed = 15 },
        new RoadVehicleType() { name = "Карета-тыква", speed = 5 },
        new AirVehicleType() { name = "Ковер-самолет", speed = 40},
        new RoadVehicleType() { name = "Избушка на курьих ножках", speed = 4, timeBeforeRest = 3, restTime = 10},
        new RoadVehicleType() { name = "Кентавр", speed = 17 },
        new AirVehicleType() { name = "Летучий корабль", speed = 18 },
    };

    public IList<VehicleType> findAll()
    {
        Func<int, int> func = t => t * 2;
        return list.ToImmutableList();
    }
}