// ReSharper disable InconsistentNaming

using race.controller;

namespace race;

internal class Program
{
    private readonly RaceController raceController = new RaceController();

    public static void Main()
    {
        new Program().run();
    }

    private void run()
    {
        raceController.run();
    }
}