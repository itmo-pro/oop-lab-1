// ReSharper disable InconsistentNaming

using race.model;
using race.repository;

namespace race.service;

internal class VehicleTypeService
{
    private readonly VehicleTypeRepository vehicleTypeRepository = new VehicleTypeRepositoryImpl();

    public IList<VehicleType> findAll()
    {
        return vehicleTypeRepository.findAll();
    }

}