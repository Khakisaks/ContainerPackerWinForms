using System;

namespace ContainerPackerWinForms
{
    // Shipment class
    public class Shipment
    {
        #region Properties

        // Unique Shipment ID
        public string ShipmentID { get; private set; }

        // Shipment name
        public string ShipmentName { get; set; }

        // Count of containers in shipment
        public int ShipmentContainerCount { get; set; }

        // Count of individual line items in shipment
        public static int ShipmentLineCount { get; set; }

        // Count of all packages in shipment
        public static int ShipmentPackageCount { get; set; }

        // Calculated weight of entire shipment
        public static double ShipmentWeight { get; set; }

        // Calculated cube of entire shipment
        public static double ShipmentCube { get; set; }
               
        #endregion

        #region Constructor

        // Default constructor
        public Shipment()
        {
            ShipmentID = NewShipmentID();            
        }

        #endregion

        #region Helper Methods
       
        // Generates a new shipment ID
        private string NewShipmentID()
        {
            return Guid.NewGuid().ToString().Replace("-", string.Empty).Replace("=", string.Empty).Replace("+", string.Empty).Substring(0, 6);
        }

        #endregion
    }

    // Shipment container class
    public class ShipmentContainer
    {
        #region Properties

        // ShipmentID
        public string ShipmentID { get; set; }

        // ContainerID
        public string ContainerID { get; set; }

        // Shipment container ID 
        public string ShipmentContainerID { get; private set; }

        // Shipment container description
        public string ShipmentContainerDescription { get; set; }

        // Count of individual line items in the container
        public int ShipmentContainerLineCount { get; set; }

        // Count of packages in container
        public int ShipmentContainerPackageCount { get; set; }

        // Calculated weight based on individual packing quantities
        public double ShipmentContainerWeight { get; set; }

        // Calculated container utilization in weight
        public double ShipmentContainerUtilizationWeight { get; set; }

        // Calculated cube based on individual packing quantities
        public double ShipmentContainerCube { get; set; }

        // Calculated container utilization in cube
        public double ShipmentContainerUtilizationCube { get; set; }
        
        #endregion

        #region Constructor

        // Default constructor to create shipment container object with set values for shipmentID
        // and chosen containerID
        public ShipmentContainer(string shipmentID, string containerID)
        {
            ShipmentID = shipmentID;
            ShipmentContainerID = NewShipmentContainerID();
            
        }

        #endregion

        #region Helper Methods

        // Generates a new shipment container ID
        private string NewShipmentContainerID()
        {
            return Guid.NewGuid().ToString().Replace("-", string.Empty).Replace("=", string.Empty).Replace("+", string.Empty).Substring(0, 6);
        }

        #endregion  
    }

}
