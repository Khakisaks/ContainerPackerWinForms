using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContainerPackerWinForms
{
    public class Package
    {
        #region Properties

        // Unique package ID
        public string PackageID { get; private set; }

        // Package description
        public string PackageDescription { get; set; }

        // Dimensional length of package
        public double PackageLength { get; set; }

        // Dimensional depth of package
        public double PackageDepth { get; set; }

        // Dimensional height of package
        public double PackageHeight { get; set; }

        // Dimensional weight of package
        public double PackageWeight { get; set; }

        // Calculated package cube
        public double PackageCube { get; set; }

        #endregion

        #region Constructor

        // Default constructor
        public Package()
        {
            PackageID = NewPackageID();
        }

        #endregion

        #region Helper Methods

        // Generates a new package ID
        private string NewPackageID()
        {
            return Guid.NewGuid().ToString().Replace("-", string.Empty).Replace("=", string.Empty).Replace("+", string.Empty).Substring(0, 6);
        }

        #endregion
    }
}
