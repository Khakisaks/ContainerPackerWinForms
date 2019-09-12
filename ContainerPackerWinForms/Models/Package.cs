using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExtensionMethods;

namespace ContainerPackerWinForms
{
    public class Package
    {
        #region Properties

        // Unique package ID
        public string PackageID { get; private set; }

        // Package description
        public string Description { get; set; }

        // Dimensional length of package
        public double Length { get; set; }

        // Dimensional depth of package
        public double Depth { get; set; }

        // Dimensional height of package
        public double Height { get; set; }

        // Dimensional weight of package
        public double Weight { get; set; }

        // The calculated cubic volume of the package based on the dimensional inputs (Length x Depth x Height)
        //private double _Cube;
        public double Cube
        {
            get
            {
                // Note: Base system units CM/KG
                return (Length / 1000) * (Depth / 1000) * (Height / 1000);
            }
        }

        #endregion

        #region Constructor

        // Default constructor
        public Package()
        {
            PackageID = Extension.NewID();
        }

        #endregion

        #region Helper Methods


        #endregion
    }
}
