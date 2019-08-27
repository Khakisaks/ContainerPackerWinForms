using System.ComponentModel;

namespace ContainerPackerWinForms
{
    // Weight units    
    public enum WeightUnit
    {
        // Imperial units
        [Description("Ounces")]
        Ounces = 1,
        [Description("Pounds")]
        Pounds = 2,
        [Description("Hundred Weight")]
        HundredWeight = 3,
        [Description("US Short Tons")]
        ShortTonsUS = 4,

        // Metric units
        [Description("Grams")]
        Grams = 5,
        [Description("Kilograms")]
        Kilograms = 6,
        [Description("Metric Tonnes")]
        MetricTonnes = 7
    }

    // Length units    
    public enum LengthUnit
    {
        // Imperial units
        [Description("Inch")]
        Inch = 1,
        [Description("Feet")]
        Feet = 2,
        [Description("Mile")]
        Mile = 3,

        // Metric units
        [Description("Centimeter")]
        Centimeter = 4,
        [Description("Meter")]
        Meter = 5,
        [Description("Kilometer")]
        Kilometer = 6,
        [Description("Millimeter")]
        Millimeter = 7
    }
}
