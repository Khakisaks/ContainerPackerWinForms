namespace ContainerPackerWinForms
{
    public class Conversion
    {
        public double ConvertWeight(WeightUnit InputWeightUnit, WeightUnit OutputWeightUnit, double ValueToConvert)
        {
            // Declarations
            double dblConversionFactor;
            double dblReturn;

            // Evaluate the weight unit to convert from
            switch (InputWeightUnit)
            {
                #region Imperial Units

                case WeightUnit.Ounces:

                    switch (OutputWeightUnit)
                    {
                        case WeightUnit.Ounces:
                            // convert Ounces to ounces
                            dblConversionFactor = 1;
                            break;
                        case WeightUnit.Pounds:
                            // convert Ounces to pounds
                            dblConversionFactor = 0.0625;
                            break;
                        case WeightUnit.HundredWeight:
                            // convert Ounces to HundredWeight
                            dblConversionFactor = 0.000625;
                            break;
                        case WeightUnit.ShortTonsUS:
                            // convert Ounces to ShortTons
                            dblConversionFactor = 0.00003124999;
                            break;
                        case WeightUnit.Grams:
                            // convert Ounces to Grams
                            dblConversionFactor = 28.34952;
                            break;
                        case WeightUnit.Kilograms:
                            // convert Ounces to kilograms
                            dblConversionFactor = 0.02834952;
                            break;
                        case WeightUnit.MetricTonnes:
                            // convert Ounces to tonnes
                            dblConversionFactor = 0.00002834952;
                            break;
                        default:
                            // default to zero value
                            dblConversionFactor = 0;
                            break;
                    }
                    break;

                case WeightUnit.Pounds:

                    switch (OutputWeightUnit)
                    {
                        case WeightUnit.Ounces:
                            // convert Pounds to ounces
                            dblConversionFactor = 16;
                            break;
                        case WeightUnit.Pounds:
                            // convert Pounds to pounds
                            dblConversionFactor = 1;
                            break;
                        case WeightUnit.HundredWeight:
                            // convert Pounds to HundredWeight
                            dblConversionFactor = 0.01;
                            break;
                        case WeightUnit.ShortTonsUS:
                            // convert Pounds to ShortTons
                            dblConversionFactor = 0.0004999999;
                            break;
                        case WeightUnit.Grams:
                            // convert Pounds to Grams
                            dblConversionFactor = 453.5924;
                            break;
                        case WeightUnit.Kilograms:
                            // convert Pounds to kilograms
                            dblConversionFactor = 0.4535924;
                            break;
                        case WeightUnit.MetricTonnes:
                            // convert Pounds to tonnes
                            dblConversionFactor = 0.0004535924;
                            break;
                        default:
                            // default to zero value
                            dblConversionFactor = 0;
                            break;
                    }
                    break;

                case WeightUnit.HundredWeight:

                    switch (OutputWeightUnit)
                    {
                        case WeightUnit.Ounces:
                            // convert HundredWeight to ounces
                            dblConversionFactor = 1600;
                            break;
                        case WeightUnit.Pounds:
                            // convert HundredWeight to pounds
                            dblConversionFactor = 100;
                            break;
                        case WeightUnit.HundredWeight:
                            // convert HundredWeight to HundredWeight
                            dblConversionFactor = 1;
                            break;
                        case WeightUnit.ShortTonsUS:
                            // convert HundredWeight to ShortTons
                            dblConversionFactor = 0.04999999;
                            break;
                        case WeightUnit.Grams:
                            // convert HundredWeight to Grams
                            dblConversionFactor = 45359.24;
                            break;
                        case WeightUnit.Kilograms:
                            // convert HundredWeight to kilograms
                            dblConversionFactor = 45.35924;
                            break;
                        case WeightUnit.MetricTonnes:
                            // convert HundredWeight to tonnes
                            dblConversionFactor = 0.04535924;
                            break;
                        default:
                            // default to zero value
                            dblConversionFactor = 0;
                            break;
                    }
                    break;

                case WeightUnit.ShortTonsUS:

                    switch (OutputWeightUnit)
                    {
                        case WeightUnit.Ounces:
                            // convert ShortTonsUS to ounces
                            dblConversionFactor = 32000.01;
                            break;
                        case WeightUnit.Pounds:
                            // convert ShortTonsUS to pounds
                            dblConversionFactor = 2000.001;
                            break;
                        case WeightUnit.HundredWeight:
                            // convert ShortTonsUS to HundredWeight
                            dblConversionFactor = 20.00001;
                            break;
                        case WeightUnit.ShortTonsUS:
                            // convert ShortTonsUS to ShortTons
                            dblConversionFactor = 1;
                            break;
                        case WeightUnit.Grams:
                            // convert ShortTonsUS to Grams
                            dblConversionFactor = 907184.7;
                            break;
                        case WeightUnit.Kilograms:
                            // convert ShortTonsUS to kilograms
                            dblConversionFactor = 907.1847;
                            break;
                        case WeightUnit.MetricTonnes:
                            // convert ShortTonsUS to tonnes
                            dblConversionFactor = 0.907185;
                            break;
                        default:
                            // default to zero value
                            dblConversionFactor = 0;
                            break;
                    }
                    break;

                #endregion

                #region Metric Units

                case WeightUnit.Grams:
                    switch (OutputWeightUnit)
                    {
                        case WeightUnit.Ounces:
                            // convert Grams to ounces
                            dblConversionFactor = 0.035274;
                            break;
                        case WeightUnit.Pounds:
                            // convert Grams to pounds
                            dblConversionFactor = 0.002205;
                            break;
                        case WeightUnit.HundredWeight:
                            // convert Grams to HundredWeight
                            dblConversionFactor = 0.00002204623;
                            break;
                        case WeightUnit.ShortTonsUS:
                            // convert Grams to ShortTons
                            dblConversionFactor = 0.000001;
                            break;
                        case WeightUnit.Grams:
                            // convert Grams to Grams
                            dblConversionFactor = 1;
                            break;
                        case WeightUnit.Kilograms:
                            // convert Grams to kilograms
                            dblConversionFactor = 0.001;
                            break;
                        case WeightUnit.MetricTonnes:
                            // convert Grams to tonnes
                            dblConversionFactor = 0.000001;
                            break;
                        default:
                            // default to zero value
                            dblConversionFactor = 0;
                            break;
                    }
                    break;

                case WeightUnit.Kilograms:
                    switch (OutputWeightUnit)
                    {
                        case WeightUnit.Ounces:
                            // convert Kilograms to ounces
                            dblConversionFactor = 35.27396;
                            break;
                        case WeightUnit.Pounds:
                            // convert Kilograms to pounds
                            dblConversionFactor = 2.204623;
                            break;
                        case WeightUnit.HundredWeight:
                            // convert Kilograms to HundredWeight
                            dblConversionFactor = 0.02204623;
                            break;
                        case WeightUnit.ShortTonsUS:
                            // convert Kilograms to ShortTons
                            dblConversionFactor = 0.001102;
                            break;
                        case WeightUnit.Grams:
                            // convert Kilograms to Grams
                            dblConversionFactor = 1000;
                            break;
                        case WeightUnit.Kilograms:
                            // convert Kilograms to kilograms
                            dblConversionFactor = 1;
                            break;
                        case WeightUnit.MetricTonnes:
                            // convert Kilograms to tonnes
                            dblConversionFactor = 0.001;
                            break;
                        default:
                            // default to zero value
                            dblConversionFactor = 0;
                            break;
                    }
                    break;

                case WeightUnit.MetricTonnes:
                    switch (OutputWeightUnit)
                    {
                        case WeightUnit.Ounces:
                            // convert MetricTonnes to ounces
                            dblConversionFactor = 35273.96;
                            break;
                        case WeightUnit.Pounds:
                            // convert MetricTonnes to pounds
                            dblConversionFactor = 2204.623;
                            break;
                        case WeightUnit.HundredWeight:
                            // convert MetricTonnes to HundredWeight
                            dblConversionFactor = 22.04623;
                            break;
                        case WeightUnit.ShortTonsUS:
                            // convert MetricTonnes to ShortTons
                            dblConversionFactor = 1.102311;
                            break;
                        case WeightUnit.Grams:
                            // convert MetricTonnes to Grams
                            dblConversionFactor = 1000000;
                            break;
                        case WeightUnit.Kilograms:
                            // convert MetricTonnes to kilograms
                            dblConversionFactor = 1000;
                            break;
                        case WeightUnit.MetricTonnes:
                            // convert MetricTonnes to tonnes
                            dblConversionFactor = 1;
                            break;
                        default:
                            // default to zero value
                            dblConversionFactor = 0;
                            break;
                    }
                    break;

                default:
                    dblConversionFactor = 0;
                    break;

                    #endregion
            }
            dblReturn = ValueToConvert* dblConversionFactor;
            return dblReturn;
        }

        public double ConvertLength(LengthUnit InputLengthUnit, LengthUnit OutputLengthUnit, double ValueToConvert)
        {
            // Declarations
            double dblConversionFactor;
            double dblReturn;

            // Evaluate the length unit to convert from
            switch (InputLengthUnit)
            {
                #region Imperial Units

                case LengthUnit.Inch:
                    // evaluate the length unit to convert to
                    switch (OutputLengthUnit)
                    {
                        case LengthUnit.Inch:
                            // convert Inch to in
                            dblConversionFactor = 1;
                            break;
                        case LengthUnit.Feet:
                            // convert Inch to ft
                            dblConversionFactor = 0.08333333;
                            break;
                        case LengthUnit.Mile:
                            // convert Inch to mile
                            dblConversionFactor = 0.00001578;
                            break;
                        case LengthUnit.Centimeter:
                            // convert Inch to cm
                            dblConversionFactor = 2.54;
                            break;
                        case LengthUnit.Meter:
                            // convert Inch to meter
                            dblConversionFactor = 0.0254;
                            break;
                        case LengthUnit.Kilometer:
                            // convert Inch to km
                            dblConversionFactor = 0.0000254;
                            break;
                        case LengthUnit.Millimeter:
                            // convert Inch to mm
                            dblConversionFactor = 25.4;
                            break;
                        default:
                            // default to zero value
                            dblConversionFactor = 0;
                            break;
                    }
                    break;

                case LengthUnit.Feet:

                    switch (OutputLengthUnit)
                    {
                        case LengthUnit.Inch:
                            // convert Feet to in
                            dblConversionFactor = 12;
                            break;
                        case LengthUnit.Feet:
                            // convert Feet to ft
                            dblConversionFactor = 1;
                            break;
                        case LengthUnit.Mile:
                            // convert Feet to mile
                            dblConversionFactor = 0.00018939;
                            break;
                        case LengthUnit.Centimeter:
                            // convert Feet to cm
                            dblConversionFactor = 30.48;
                            break;
                        case LengthUnit.Meter:
                            // convert Feet to meter
                            dblConversionFactor = 0.3048;
                            break;
                        case LengthUnit.Kilometer:
                            // convert Feet to km
                            dblConversionFactor = 0.0003048;
                            break;
                        case LengthUnit.Millimeter:
                            // convert Feet to mm
                            dblConversionFactor = 304.8;
                            break;
                        default:
                            // default to zero value
                            dblConversionFactor = 0;
                            break;
                    }
                    break;

                case LengthUnit.Mile:

                    switch (OutputLengthUnit)
                    {
                        case LengthUnit.Inch:
                            // convert Mile to in
                            dblConversionFactor = 63360;
                            break;
                        case LengthUnit.Feet:
                            // convert Mile to ft
                            dblConversionFactor = 5280;
                            break;
                        case LengthUnit.Mile:
                            // convert Mile to mile
                            dblConversionFactor = 1;
                            break;
                        case LengthUnit.Centimeter:
                            // convert Mile to cm
                            dblConversionFactor = 160934.4;
                            break;
                        case LengthUnit.Meter:
                            // convert Mile to meter
                            dblConversionFactor = 1609.344;
                            break;
                        case LengthUnit.Kilometer:
                            // convert Mile to km
                            dblConversionFactor = 1.609344;
                            break;
                        case LengthUnit.Millimeter:
                            // convert Mile to mm
                            dblConversionFactor = 1609344;
                            break;
                        default:
                            // default to zero value
                            dblConversionFactor = 0;
                            break;
                    }
                    break;

                #endregion

                #region Metric Units                

                case LengthUnit.Centimeter:

                    switch (OutputLengthUnit)
                    {
                        case LengthUnit.Inch:
                            // convert Centimeter to in
                            dblConversionFactor = 0.3937008;
                            break;
                        case LengthUnit.Feet:
                            // convert Centimeter to ft
                            dblConversionFactor = 0.0328084;
                            break;
                        case LengthUnit.Mile:
                            // convert Centimeter to mile
                            dblConversionFactor = 0.000006213712;
                            break;
                        case LengthUnit.Centimeter:
                            // convert Centimeter to cm
                            dblConversionFactor = 1;
                            break;
                        case LengthUnit.Meter:
                            // convert Centimeter to meter
                            dblConversionFactor = 0.01;
                            break;
                        case LengthUnit.Kilometer:
                            // convert Centimeter to km
                            dblConversionFactor = 0.00001;
                            break;
                        case LengthUnit.Millimeter:
                            // convert Centimeter to mm
                            dblConversionFactor = 10;
                            break;
                        default:
                            // default to zero value
                            dblConversionFactor = 0;
                            break;
                    }
                    break;

                case LengthUnit.Meter:

                    switch (OutputLengthUnit)
                    {
                        case LengthUnit.Inch:
                            // convert Meter to in
                            dblConversionFactor = 39.37008;
                            break;
                        case LengthUnit.Feet:
                            // convert Meter to ft
                            dblConversionFactor = 3.28084;
                            break;
                        case LengthUnit.Mile:
                            // convert Meter to mile
                            dblConversionFactor = 0.0006213712;
                            break;
                        case LengthUnit.Centimeter:
                            // convert Meter to cm
                            dblConversionFactor = 100;
                            break;
                        case LengthUnit.Meter:
                            // convert Meter to meter
                            dblConversionFactor = 1;
                            break;
                        case LengthUnit.Kilometer:
                            // convert Meter to km
                            dblConversionFactor = 0.001;
                            break;
                        case LengthUnit.Millimeter:
                            // convert Meter to mm
                            dblConversionFactor = 1000;
                            break;
                        default:
                            // default to zero value
                            dblConversionFactor = 0;
                            break;
                    }
                    break;

                case LengthUnit.Kilometer:

                    switch (OutputLengthUnit)
                    {
                        case LengthUnit.Inch:
                            // convert Kilometer to in
                            dblConversionFactor = 39370.08;
                            break;
                        case LengthUnit.Feet:
                            // convert Kilometer to ft
                            dblConversionFactor = 3280.84;
                            break;
                        case LengthUnit.Mile:
                            // convert Kilometer to mile
                            dblConversionFactor = 0.6213712;
                            break;
                        case LengthUnit.Centimeter:
                            // convert Kilometer to cm
                            dblConversionFactor = 100000;
                            break;
                        case LengthUnit.Meter:
                            // convert Kilometer to meter
                            dblConversionFactor = 1000;
                            break;
                        case LengthUnit.Kilometer:
                            // convert Kilometer to km
                            dblConversionFactor = 1;
                            break;
                        case LengthUnit.Millimeter:
                            // convert Kilometer to mm
                            dblConversionFactor = 1000000;
                            break;
                        default:
                            // default to zero value
                            dblConversionFactor = 0;
                            break;
                    }
                    break;

                case LengthUnit.Millimeter:

                    switch (OutputLengthUnit)
                    {
                        case LengthUnit.Inch:
                            // convert Millimeter to in
                            dblConversionFactor = 0.03937;
                            break;
                        case LengthUnit.Feet:
                            // convert Millimeter to ft
                            dblConversionFactor = 0.003281;
                            break;
                        case LengthUnit.Mile:
                            // convert Millimeter to mile
                            dblConversionFactor = 0.00000062137119;
                            break;
                        case LengthUnit.Centimeter:
                            // convert Millimeter to cm
                            dblConversionFactor = 0.1;
                            break;
                        case LengthUnit.Meter:
                            // convert Millimeter to meter
                            dblConversionFactor = 0.001;
                            break;
                        case LengthUnit.Kilometer:
                            // convert Millimeter to km
                            dblConversionFactor = 0.000001;
                            break;
                        case LengthUnit.Millimeter:
                            // convert Millimeter to mm
                            dblConversionFactor = 1;
                            break;
                        default:
                            // default to zero value
                            dblConversionFactor = 0;
                            break;
                    }
                    break;

                default:
                    // default to zero value
                    dblConversionFactor = 0;
                    break;

                    #endregion
            }
            dblReturn = ValueToConvert * dblConversionFactor;
            return dblReturn;
        }
    }
}
