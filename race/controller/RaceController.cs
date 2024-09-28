// ReSharper disable InconsistentNaming

using race.config;
using race.model;
using race.service;
using race.view;
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
        var vehicles = selectVehicles(vehicleTypeService.findAll(), this);
        var whether = selectWhether();

        var race = new Race
        {
            raceType = raceType,
            distance = distance,
            vehicles = vehicles,
            whether = whether,
        };

        raceService.perform(race);

        var results = race.getResults();

        display(results);

        gameOver();
    }
}