// ReSharper disable InconsistentNaming

using race.model;

namespace race.view;

internal static class ResultsView
{
    public static void display(IList<Tuple<Vehicle, int>> results)
    {
        Console.WriteLine("=============================");
        Console.WriteLine("       R E S U L T S         ");
        Console.WriteLine("=============================");

        var place = 0;
        foreach (var (vehicle, time) in results)
        {
            Console.WriteLine($"{++place}) {vehicle} \t {time}");
        }
    }
}