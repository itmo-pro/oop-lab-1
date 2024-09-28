// ReSharper disable InconsistentNaming

using race.model;

namespace race.service;

internal class WhetherService
{
    private readonly Random random = new Random();
    private const int TEMPERATURE_MIN = 0;
    private const int TEMPERATURE_MAX = 45;
    private readonly int CONDITION_SIZE = Enum.GetNames(typeof(Whether.Condition)).Length;

    public Whether craftWhether()
    {
        return new Whether()
        {
            temperature = TEMPERATURE_MIN + random.Next(TEMPERATURE_MAX - TEMPERATURE_MIN),
            condition = (Whether.Condition)random.Next(CONDITION_SIZE),
        };
    }
}