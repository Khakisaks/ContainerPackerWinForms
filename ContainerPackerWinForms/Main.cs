using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ContainerPackerWinForms
{
    public partial class Main : Form
    {
        // Variables
        const double TargetUtilizationWeight = 0.90;
        const double TargetUtilizationCube = 0.85;
        const double CostCoefficientWeight = 0.60;      
        const double CostCoefficientCube = 0.40;



        public Main()
        {
            InitializeComponent();

        }

        private void BtnAddContainerToShipment_Click(object sender, EventArgs e)
        {

        }

        private void Main_Load(object sender, EventArgs e)
        {
            // Initialize form
            txtTargetUtilizationCube.Text = TargetUtilizationCube.ToString();
            txtTargetUtilizationWeight.Text = TargetUtilizationWeight.ToString();
            txtCostingCoefficientCube.Text = CostCoefficientCube.ToString();
            txtCostingCoefficientWeight.Text = CostCoefficientWeight.ToString();

            Container c1 = new Container("20ft General Purpose", 23400, 30);
            Container c2 = new Container("40ft General Purpose", 24900, 60);
            Container c3 = new Container("40ft General Purpose - High Cube", 24900, 70);

            List<Container> ContainerList = new List<Container>();
            ContainerList.Add(c1);
            ContainerList.Add(c2);
            ContainerList.Add(c3);

            lstContainer.View = View.Details;
            lstContainer.Columns.Add("ContainerID");
            lstContainer.Columns.Add("Description");
            lstContainer.Columns.Add("Capacity - Weight");
            lstContainer.Columns.Add("Capacity - Cube");
            
        }
    }
}
