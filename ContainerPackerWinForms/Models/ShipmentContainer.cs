using System.ComponentModel;
using System.Linq;
using ExtensionMethods;
 
namespace ContainerPackerWinForms
{
    public class ShipmentContainer
    {
        #region Properties

        public string ShipmentID { get; set; }
        public string ContainerID { get; set; }
        public string ShipmentContainerID { get; set; }
        public string ContainerDescription { get; set; }
        public int ContainerPackageLineCount { get { return Packages.Count; } }
        public int ContainerPackages { get { return Packages.Sum(i => i.PackingQty); } }        
        public double CapacityWeight { get; set; }
        public double ContainerWeight { get { return Packages.Sum(i => i.PackingWeight); } }
        public double WeightUtilization { get { return (double)(ContainerWeight / CapacityWeight) * 100; } }
        public double CapacityCube { get; set; }
        public double ContainerCube { get { return Packages.Sum(i => i.PackingCube); } }
        public double CubeUtilization { get { return (double)(ContainerCube / CapacityCube) * 100; } }
        public BindingList<ContainerPackage> Packages { get; private set; }
        
        #endregion

        #region Constructor

        public ShipmentContainer()
        {
            ShipmentContainerID = Extension.NewID();
            Packages = new BindingList<ContainerPackage>();
        }

        #endregion

        #region Helper Methods

        public override string ToString()
        {
            return string.Format("Shipment container ID: {0}, Container description: {1}", ShipmentContainerID, ContainerDescription);
        }
        
        #endregion
    }
}
