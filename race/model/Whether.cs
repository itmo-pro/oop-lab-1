// ReSharper disable InconsistentNaming

namespace race.model;

internal class Whether
{
    public int temperature { get; set; }
    public Condition condition { get; set; }

    public enum Condition
    {
        VERDE,
        RAIN,
        SNOW,
        ICE
    }
}