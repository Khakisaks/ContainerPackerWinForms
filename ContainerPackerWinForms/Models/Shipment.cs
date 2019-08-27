using System;

namespace ContainerPackerWinForms
{
    public class Shipment
    {

        string ShipmentID { get; set; }
        string ShipmentDescription { get; set; }

        // Generates a new shipment ID
        private string NewShipmentID()
        {
            return Guid.NewGuid().ToString().Replace("-", string.Empty).Replace("=", string.Empty).Replace("+", string.Empty).Substring(0, 6);
        }



    }


}
