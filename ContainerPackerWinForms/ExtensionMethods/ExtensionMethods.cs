using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods
{
    public static class Extension
    {
        public static string NewID()
        {
            return Guid.NewGuid().ToString().Replace("-", string.Empty).Replace("=", string.Empty).Replace("+", string.Empty).Substring(0, 6);
        }


        public enum VolumeType
        {
            Litre = 0,
            Pint = 1,
            Gallon = 2
        }

        public static double ConvertUnits(int units, VolumeType from, VolumeType to)
        {
            double[][] factor =
                {
                new double[] {1, 2, 0.25},
                new double[] {0.5, 1, 0.125},
                new double[] {4, 8, 1}
            };
            return units * factor[(int)from][(int)to];
        }

        public static void ShowConversion(int oldUnits, VolumeType from, VolumeType to)
        {
            double newUnits = ConvertUnits(oldUnits, from, to);
            Console.WriteLine("{0} {1} = {2} {3}", oldUnits, from.ToString(), newUnits, to.ToString());
        }


        //static void Main(string[] args)
        //{
        //    ShowConversion(1, VolumeType.Litre, VolumeType.Litre);  // = 1
        //    ShowConversion(1, VolumeType.Litre, VolumeType.Pint);   // = 2
        //    ShowConversion(1, VolumeType.Litre, VolumeType.Gallon); // = 4
        //    ShowConversion(1, VolumeType.Pint, VolumeType.Pint);    // = 1
        //    ShowConversion(1, VolumeType.Pint, VolumeType.Litre);   // = 0.5
        //    ShowConversion(1, VolumeType.Pint, VolumeType.Gallon);  // = 0.125
        //    ShowConversion(1, VolumeType.Gallon, VolumeType.Gallon);// = 1
        //    ShowConversion(1, VolumeType.Gallon, VolumeType.Pint);  // = 8
        //    ShowConversion(1, VolumeType.Gallon, VolumeType.Litre); // = 4
        //    ShowConversion(10, VolumeType.Litre, VolumeType.Pint);  // = 20
        //    ShowConversion(20, VolumeType.Gallon, VolumeType.Pint); // = 160
        //}

        interface IEnglishDimensions
        {
            float Length();
            float Width();
        }
        // Declare the metric units interface:
        interface IMetricDimensions
        {
            float Length();
            float Width();
        }

        // Declare the "Box" class that implements the two interfaces:
        // IEnglishDimensions and IMetricDimensions:
        class Box : IEnglishDimensions, IMetricDimensions
        {
            float lengthInches;
            float widthInches;
            public Box(float length, float width)
            {
                lengthInches = length;
                widthInches = width;
            }
            // Explicitly implement the members of IEnglishDimensions:
            float IEnglishDimensions.Length()
            {
                return lengthInches;
            }
            float IEnglishDimensions.Width()
            {
                return widthInches;
            }
            // Explicitly implement the members of IMetricDimensions:
            float IMetricDimensions.Length()
            {
                return lengthInches * 2.54f;
            }
            float IMetricDimensions.Width()
            {
                return widthInches * 2.54f;
            }
            //public static void Main()
            //{
            //    // Declare a class instance "myBox":
            //    Box myBox = new Box(30.0f, 20.0f);
            //    // Declare an instance of the English units interface:
            //    IEnglishDimensions eDimensions = (IEnglishDimensions)myBox;
            //    // Declare an instance of the metric units interface:
            //    IMetricDimensions mDimensions = (IMetricDimensions)myBox;
            //    // Print dimensions in English units:
            //    System.Console.WriteLine("Length(in): {0}", eDimensions.Length());
            //    System.Console.WriteLine("Width (in): {0}", eDimensions.Width());
            //    // Print dimensions in metric units:
            //    System.Console.WriteLine("Length(cm): {0}", mDimensions.Length());
            //    System.Console.WriteLine("Width (cm): {0}", mDimensions.Width());
            //}
        }
    }



}
