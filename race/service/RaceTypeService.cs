// ReSharper disable InconsistentNaming

using race.model;
using race.repository;

namespace race.service;

internal class RaceTypeService
{
    private readonly RaceTypeRepository raceTypeRepository = new RaceTypeRepository();

    public IList<RaceType> findAll()
    {
        return raceTypeRepository.findAll();
    }
}