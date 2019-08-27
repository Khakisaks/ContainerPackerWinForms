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

            List<Container> ContainerList = new List<Container>();
            ContainerList.Add

        }
    }
}
