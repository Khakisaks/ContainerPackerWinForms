using System;

namespace ContainerPackerWinForms
{
    public class Container
    {
        #region Properties

        // Unique container ID
        public string ContainerID { get; set; }

        // Container description
        public string ContainerDescription { get; set; }

        // Container payload capacity - weight
        public double ContainerCapacityWeight { get; set; }

        // Container payload capacity - cube
        public double ContainerCapacityCube { get; set; }

        #endregion  

        #region Constructor

        // Default constructor
        public Container()
        {
            ContainerID = NewContainerID();            
        }

        #endregion

        #region Helper Methods

        // Generates a new container ID
        private string NewContainerID()
        {
            return Guid.NewGuid().ToString().Replace("-", string.Empty).Replace("=", string.Empty).Replace("+", string.Empty).Substring(0, 6);
        }

        #endregion
    }
}
