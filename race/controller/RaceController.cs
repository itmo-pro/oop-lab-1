// ReSharper disable InconsistentNaming

using race.config;
using race.model;
using race.service;
using static race.view.ResultsView;
using static race.view.SetupView;

namespace race.controller;

internal class RaceController
{
    private readonly RaceService raceService = new RaceService();
    private readonly RaceTypeService raceTypeService = new RaceTypeService();
    private readonly VehicleTypeService vehicleTypeService = new VehicleTypeService();

    public void run()
    {
        greetings();

        var raceType = selectRaceType(raceTypeService.findAll());
        var distance = selectDistance(AppConfig.RACE_DISTANCE_MAX);
        var vehicles = selectVehicles(vehicleTypeService.findByRaceType(raceType), this);
        var whether = selectWhether();

        var race = new Race(raceType, distance, vehicles, whether);

        raceService.perform(race);

        display(race.results);

        gameOver();
    }
}