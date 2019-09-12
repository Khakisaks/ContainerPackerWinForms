using System;
using ExtensionMethods;

namespace ContainerPackerWinForms
{
    public class Container
    {
        #region Properties

        // Unique container ID
        public string ContainerID { get; set; }
        // Container description
        public string Description { get; set; }
        // Container payload capacity - weight
        public double CapacityWeight { get; set; }
        // Container payload capacity - cube
        public double CapacityCube { get; set; }
        
        #endregion  

        #region Constructor

        // Default constructor
        public Container()
        {
            ContainerID = Extension.NewID();
        }

        #endregion
    }
}
