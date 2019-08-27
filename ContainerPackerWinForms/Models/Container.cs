using System;

namespace ContainerPackerWinForms
{
    public class Container
    {
        string ContainerID { get; set; }
        string ContainerDescription { get; set; }
        double CapacityWeight { get; set; }
        double CapacityCube { get; set; }

        public Container(string description, double capacityWeight, double capacityCube)
        {
            ContainerID = NewContainerID();
            ContainerDescription = description;            
            CapacityWeight = capacityWeight;
            CapacityCube = capacityCube;
        }

        // Generates a new container ID
        private string NewContainerID()
        {
            return Guid.NewGuid().ToString().Replace("-", string.Empty).Replace("=", string.Empty).Replace("+", string.Empty).Substring(0, 6);
        }

    }
}
