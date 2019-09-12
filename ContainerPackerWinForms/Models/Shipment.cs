using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using ExtensionMethods;

namespace ContainerPackerWinForms
{   
    public class Shipment 
    {
        #region Properties

        public string ShipmentID { get; private set; }
        public string ShipmentName { get; set; }
        public double TotalWeight { get { return Containers.Sum(i => i.ContainerWeight); } }
        public double TotalCube { get { return Containers.Sum(i => i.ContainerCube); } } 
        public int ContainerCount { get { return Containers.Count; } }
        public BindingList<ShipmentContainer> Containers { get; private set; }
        
        #endregion

        #region Constructor

        public Shipment()
        {
            ShipmentID = Extension.NewID();            
            Containers = new BindingList<ShipmentContainer>();            
        }

        #endregion
    }
}
