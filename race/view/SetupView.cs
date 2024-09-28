// ReSharper disable InconsistentNaming

using race.controller;
using race.model;

namespace race.view;

internal static class SetupView
{
    public static void greetings()
    {
        Console.WriteLine("Hello, lets do some race!");
    }

    public static void gameOver()
    {
        Console.WriteLine("      --== GAME OVER ==--");
    }

    public static int selectDistance(int distanceMax)
    {
        return readInt($"Enter race distance [0...{distanceMax}]: ", 0, distanceMax + 1);
    }

    public static RaceType selectRaceType(IList<RaceType> raceTypes)
    {
        Console.WriteLine("What kind of race you wanna ride ?");
        for (var i = 0; i < raceTypes.Count; i++)
        {
            Console.WriteLine($"[{i}] {raceTypes[i].name}");
        }

        var index = readInt($"Enter race type number [0...{raceTypes.Count - 1}]: ", 0, raceTypes.Count);
        return raceTypes[index];
    }

    public static IList<Vehicle> selectVehicles(IList<VehicleType> vehicleTypes, RaceController raceController)
    {
        var vehicleCount = readInt("Enter number of racers: ", 2, 13);
        var result = new List<Vehicle>(vehicleCount);
        displayVehicleTypes(vehicleTypes);
        for (var i = 0; i < vehicleCount; i++)
        {
            var vehicle = selectVehicle(vehicleTypes, i);
            result.Add(vehicle);
        }

        return result;
    }

    private static void displayVehicleTypes(IList<VehicleType> vehicleTypes)
    {
        Console.WriteLine("Today, Gods is giving us the next types of vehicles:");
        for (var i = 0; i < vehicleTypes.Count; i++)
        {
            Console.WriteLine($"[{i}]  {vehicleTypes[i]}");
        }
    }

    private static Vehicle selectVehicle(IList<VehicleType> vehicleTypes, int racerIndex)
    {
        var racerName = $"Racer #{racerIndex + 1}";
        var index = readInt($"Select vehicle type for {racerName} [0...{vehicleTypes.Count - 1}]: ",
            0, vehicleTypes.Count);
        return new Vehicle
        {
            vehicleType = vehicleTypes[index],
            racerName = racerName,
        };
    }

    public static Whether selectWhether()
    {
        // todo
        return new Whether()
        {
            temperature = 24,
            condition = Whether.Condition.VERDE
        };
    }

    private static int readInt(string prompt, int? leftBoundInclusive = null, int? rightBoundExclusive = null)
    {
        Console.Write(prompt);
        for (;;)
        {
            var input = Console.ReadLine();
            if (int.TryParse(input!, out var result))
            {
                if (result < leftBoundInclusive || rightBoundExclusive <= result)
                {
                    Console.Write($"Hm...., that's joke, are you kidding? " +
                                  $"Enter correct number [{leftBoundInclusive}...{rightBoundExclusive - 1}]: ");
                    continue;
                }

                return result;
            }
        }
    }
}