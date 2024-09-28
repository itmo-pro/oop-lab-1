// ReSharper disable InconsistentNaming

using race.model;
using race.repository;

namespace race.service;

internal class VehicleTypeService
{
    private readonly VehicleTypeRepository vehicleTypeRepository = new VehicleTypeRepositoryImpl();

    // ReSharper disable once UnusedMember.Global
    public IList<VehicleType> findAll()
    {
        return vehicleTypeRepository.findAll();
    }

    public IList<VehicleType> findByRaceType(RaceType raceType)
    {
        return vehicleTypeRepository.findAll().Where(raceType.canRace).ToList();
    }
}