// ReSharper disable InconsistentNaming

using race.model;
using race.service;

namespace race.controller;

internal class RaceController
{
    private readonly RaceService raceService = new RaceService();
    private readonly RaceTypeService raceTypeService = new RaceTypeService();
    private readonly VehicleTypeService vehicleTypeService = new VehicleTypeService();

    public void run()
    {
        Console.WriteLine("Hello, lets some race!");

        RaceType raceType = selectRaceType();
        // IList<Vehicle> vehicles = selectVehicles();
        // Whether whether = selectWhether();

        // var race = new Race() { raceType = raceType, vehicles = vehicles, whether = whether };
        
        Console.WriteLine("You selected:");
        Console.WriteLine("Race Type: {0}", raceType.name);
    }

    private RaceType selectRaceType()
    {
        Console.WriteLine("Select race type one of:");
        var raceTypes = raceTypeService.findAll();
        foreach (var raceType in raceTypes)
        {
            Console.WriteLine("  {0}", raceType.name);
        }

        RaceType? result = null;
        do
        {
            Console.WriteLine("Race type:");
            var input = Console.ReadLine();

            if (input == null)
            {
                continue;
            }

            foreach (var raceType in raceTypes)
            {
                if (raceType.name.ToLowerInvariant().StartsWith(input.ToLowerInvariant()))
                {
                    result = raceType;
                    break;
                }
            }
        } while (result is null);

        return result;
    }
}