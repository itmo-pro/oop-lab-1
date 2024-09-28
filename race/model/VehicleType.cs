// ReSharper disable InconsistentNaming

namespace race.model;

internal interface VehicleType
{
    string name { get; set; }
    int speed { get; set; }
    int performTimeTick(int position, int time, RaceType raceRaceType, Whether whether);
}

internal class AirVehicleType : VehicleType
{
    public string name { get; set; } = "undefined";
    public int speed { get; set; }

    public Func<int, int> accelerator { get; init; } = _ => 1;

    public int performTimeTick(int position, int time, RaceType raceRaceType, Whether whether)
    {
        var isBad = whether.condition is Whether.Condition.RAIN or Whether.Condition.RAIN;
        return speed * (1 + accelerator.Invoke(position)) / (isBad ? 2 : 1);
    }
}

internal class RoadVehicleType : VehicleType
{
    public string name { get; set; } = "undefined";
    public int speed { get; set; }
    public int timeBeforeRest { get; set; }
    public int restTime { get; set; }

    public int performTimeTick(int position, int time, RaceType raceRaceType, Whether whether)
    {
        if (timeBeforeRest > 0 && restTime > 0)
        {
            var t = time % (timeBeforeRest + restTime);
            if (t <= timeBeforeRest)
            {
                return speed;
            }
            else
            {
                return 0;
            }
        }
        else
        {
            return speed;
        }
    }
}