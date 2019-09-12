using System.ComponentModel;
using ExtensionMethods;

namespace ContainerPackerWinForms
{
    public class ContainerPackage
    {
        #region Properties

        public string ShipmentContainerID { get; set; }
        public string PackingID { get; private set; }
        public string PackageDescription { get; set; }
        public double PackageLength { get; set; }
        public double PackageDepth { get; set; }
        public double PackageHeight { get; set; }
        public int PackingQty { get; set; }
        public double PackageCube { get { return (PackageLength / 100) * (PackageDepth / 100) * (PackageHeight / 100); } }
        public double PackingCube { get { return PackageCube * PackingQty; } }
        public double PackageWeight { get; set; }
        public double PackingWeight { get { return ((PackageWeight * PackingQty) * 0.001); } }
        
        #endregion

        #region Constructor

        public ContainerPackage()
        {
            PackingID = Extension.NewID();
        }

        #endregion

        #region Helper Methods

        public override string ToString()
        {
            return string.Format("Shipment container ID: {0}, Packing ID: {1}, Packing description: {2}", ShipmentContainerID, PackingID, PackageDescription);
        }

        private double PackagePackingCube;
        public double GetPackingCube()
        {
            PackagePackingCube = (double)PackageCube * PackingQty;
            return PackagePackingCube;
        }

        private double PackagePackingWeight;
        public double GetPackingWeight()
        {
            PackagePackingWeight = (double)PackageWeight * PackingQty;
            return PackagePackingWeight;
        }

        #endregion
    }
}
