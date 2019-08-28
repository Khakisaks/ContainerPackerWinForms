using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.ComponentModel;

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
            // Add selected container to shipment
            BindingList<ShipmentContainer> ShipmentContainers = new BindingList<ShipmentContainer>();

        }

        private void Main_Load(object sender, EventArgs e)
        {
            // Initialize settings
            txtTargetUtilizationCube.Text = TargetUtilizationCube.ToString();
            txtTargetUtilizationWeight.Text = TargetUtilizationWeight.ToString();
            txtCostingCoefficientCube.Text = CostCoefficientCube.ToString();
            txtCostingCoefficientWeight.Text = CostCoefficientWeight.ToString();

            // Setup display units
            ComboboxItem item = new ComboboxItem();
            item.Text = "IN/LB";
            item.Value = 1;
            cboDisplayUnits.Items.Add(item);
            item.Text = "CM/KG";
            item.Value = 2;
            cboDisplayUnits.Items.Add(item);
            cboDisplayUnits.SelectedIndex = 0;

            // Create new shipment
            Shipment Shipment = new Shipment();
            Shipment.ShipmentName = "Danang Imports Vietnam";
            txtShipmentID.Text = Shipment.ShipmentID;
            txtShipmentName.Text = Shipment.ShipmentName.ToUpper();
            
            // Create a list of containers
            List<Container> Containers = new List<Container>();
            Containers.Add(new Container() { ContainerDescription = "20ft General Purpose", ContainerCapacityWeight = 23400, ContainerCapacityCube = 30 });
            Containers.Add(new Container() { ContainerDescription = "40ft General Purpose", ContainerCapacityWeight = 24500, ContainerCapacityCube = 60 });
            Containers.Add(new Container() { ContainerDescription = "40ft General Purpose - High Cube", ContainerCapacityWeight = 25000, ContainerCapacityCube = 70 });

            // Setup datagrid properties
            dgvContainer.MultiSelect = false;
            dgvContainer.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvContainer.RowHeadersVisible = false;
            
            // Set datagrid rowsource
            dgvContainer.DataSource = Containers;

            // Setup datagrid column headers 
            // ** TO DO : Link Display Units **
            dgvContainer.Columns[0].HeaderText = "ID";
            dgvContainer.Columns[0].MinimumWidth = 5;
            dgvContainer.Columns[0].Width = 50;
            dgvContainer.Columns[1].HeaderText = "Description";
            dgvContainer.Columns[1].MinimumWidth = 130;
            dgvContainer.Columns[1].Width = 190;
            dgvContainer.Columns[2].HeaderText = "Weight Capacity (MT)";
            dgvContainer.Columns[2].MinimumWidth = 50;
            dgvContainer.Columns[2].Width = 100;
            dgvContainer.Columns[3].HeaderText = "Cube Capacity (M3)";
            dgvContainer.Columns[3].MinimumWidth = 50;
            dgvContainer.Columns[3].Width = 100;

            DataGridViewButtonColumn editButtonColumn = new DataGridViewButtonColumn();
            editButtonColumn.Name = "edit_column";
            editButtonColumn.HeaderText = "Edit";
            editButtonColumn.Text = "Edit";
            editButtonColumn.UseColumnTextForButtonValue = true;
            int columnIndex = 4;
            if (dgvContainer.Columns["edit_column"] == null)
            {
                dgvContainer.Columns.Insert(columnIndex, editButtonColumn);
            }
        }

        private void BtnQuit_Click(object sender, EventArgs e)
        {
            // Close form
            Application.Exit();
        }

        private void DgvContainer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvContainer.Columns["edit_column"].Index)
            {
                txtContainerDescription.Text = dgvContainer.SelectedCells[1].Value.ToString();
                txtContainerCapacityWeight.Text = dgvContainer.SelectedCells[2].Value.ToString();
                txtContainerCapacityCube.Text = dgvContainer.SelectedCells[3].Value.ToString();
                btnCreateNewContainer.Text = "Save Changes";                
            }
        }
    }
}
