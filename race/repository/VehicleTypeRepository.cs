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
        new AirVehicleType() { name = "Ступа Бабы Яги", speed = 10 },
        new AirVehicleType() { name = "Метла", speed = 50 },
        new RoadVehicleType() { name = "Сапоги-скороходы", speed = 15 },
        new RoadVehicleType() { name = "Карета-тыква", speed = 5 },
        new AirVehicleType() { name = "Ковер-самолет", speed = 40 },
        new RoadVehicleType() { name = "Избушка на курьих ножках", speed = 4 },
        new RoadVehicleType() { name = "Кентавр", speed = 17 },
        new AirVehicleType() { name = "Летучий корабль", speed = 18 },
    };

    public IList<VehicleType> findAll()
    {
        return list.ToImmutableList();
    }
}