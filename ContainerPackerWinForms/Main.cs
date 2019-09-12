using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.ComponentModel;
using System.Linq;
using System.Drawing;

namespace ContainerPackerWinForms
{
    public partial class Main : Form
    {
        // Initialize shipment & shipment container objects
        Shipment Shipment = new Shipment();
        ShipmentContainer ShipmentContainer = new ShipmentContainer();

        // Create an initial arbitrary list of containers to choose from
        BindingList<Container> Containers = new BindingList<Container>();

        public Main()
        {
            InitializeComponent();
            // DUMMY TEXT FOR TESTING
            this.txtShipmentName.Text = "DEL RIO IMPORTS - ARGENTINA";                        
        }
        
        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void BtnQuit_Click(object sender, EventArgs e)
        {
            // Close form
            Application.Exit();
        }

        #region Shipment

        // Create shipment
        private void BtnCreateShipment_Click(object sender, EventArgs e)
        {
            // Check for existing shipment
            if (Shipment != null)
            {
                // Validate shipment name entry
                if (!IsEmpty(txtShipmentName.Text))
                {
                    // Create new shipment and initialize shipment detail section
                    Shipment.ShipmentName = Convert.ToString(txtShipmentName.Text).ToUpper();
                    txtShipmentName.Text = Shipment.ShipmentName;

                    // Create initial empty container list for shipment usage
                    // Initialize container section
                    initContainers();
                    dgvContainer.DataSource = Containers;
                    initContainerDGV();
                    dgvContainer.ClearSelection();
                    initContainerSection();

                    // Assign binding datasource to shipment container datagridview
                    // and initialize the datagridview with custom properties and formatting                    
                    dgvShipmentContainer.DataSource = Shipment.Containers;
                    initShipmentContainerDGV();
                    initShipmentContainerSection();

                    // Assign binding datasource to container packing datagridview
                    // and initialize the datagridview with custom properties and formatting
                    dgvShipmentContainerPacking.DataSource = ShipmentContainer.Packages;
                    initContainerPackingDGV();
                    initContainerPackingSection(2);

                    // Update stats
                    updateShipmentStats();
                    updateContainerStats();

                    // Hide the create shipment button
                    this.btnCreateShipment.Visible = false;
                }
                else
                {
                    // Prompt user to provide a shipment name
                    MessageBox.Show("Error! Please enter a valid shipment name.");
                    this.txtShipmentName.Focus();
                }
            }            
        }

        // Update shipment name
        private void TxtShipmentName_TextChanged(object sender, EventArgs e)
        {
            // Check if shipment exists and update the button caption
            Shipment.ShipmentName = txtShipmentName.Text.ToString();
        }

        // Update shipment stats
        private void updateShipmentStats()
        {
            // Validate objects
            if (Shipment != null && ShipmentContainer != null)
            {
                // NOTES: String Format Guidelines
                // String.Format("{0:n2}" will format the number to two decimal places with tousands seperator
                // String.Format("{0:n0}" will format the number to zero decimal places with tousands seperator                
                lblShipmentPackageLines.Text = string.Format("{0:n0}", ShipmentContainer.ContainerPackageLineCount);
                lblShipmentPackages.Text = string.Format("{0:n0}", ShipmentContainer.ContainerPackages);
                lblShipmentContainers.Text = string.Format("{0:n0}", Shipment.ContainerCount);
                lblShipmentWeight.Text = string.Format("{0:n2}", Shipment.TotalWeight);
                lblShipmentCube.Text = string.Format("{0:n2}", Shipment.TotalCube);
            }  
        }

        #endregion 

        #region Container

        // Initializes a list of containers
        private void initContainers()
        {
            // Add some containers to the container list
            Containers.Add(new Container() { Description = "20FT GENERAL PURPOSE", CapacityWeight = 23.4, CapacityCube = 30 });
            Containers.Add(new Container() { Description = "40FT GENERAL PURPOSE", CapacityWeight = 24.5, CapacityCube = 60 });
            Containers.Add(new Container() { Description = "40FT GENERAL PURPOSE - HIGH CUBE", CapacityWeight = 25.0, CapacityCube = 70 });
            Containers.Add(new Container() { Description = "US CHEP TWO-WAY PALLET", CapacityWeight = 1.524, CapacityCube = 1.8 });
        }
        
        // Initializes container section
        private void initContainerSection()
        {
            if (this.dgvContainer.Rows.Count > 0)
            {
                clearContainerFields();
                this.dgvContainer.Enabled = true;
                this.txtContainerDescription.Enabled = true;
                this.txtContainerCapacityWeight.Enabled = true;
                this.txtContainerCapacityCube.Enabled = true;
                this.btnAddUpdateContainer.Text = "Add New Container";
                this.btnAddUpdateContainer.Enabled = true;                
            }
            else
            {
                clearContainerFields();
                this.dgvContainer.Enabled = false;
                this.txtContainerDescription.Enabled = false;
                this.txtContainerCapacityWeight.Enabled = false;
                this.txtContainerCapacityCube.Enabled = false;
                this.btnAddUpdateContainer.Text = "Add New Container";
                this.btnAddUpdateContainer.Enabled = true;
            }
        }

        // Clears container entry fields
        private void clearContainerFields()
        {
            this.txtContainerCapacityCube.Text = null;
            this.txtContainerCapacityWeight.Text = null;
            this.txtContainerDescription.Text = null;
        }

        // Initializes container datagrid
        private void initContainerDGV()
        {
            // Set control properties            
            this.dgvContainer.AutoGenerateColumns = false;
            this.dgvContainer.MultiSelect = false;
            this.dgvContainer.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dgvContainer.RowHeadersVisible = false;
            this.dgvContainer.RowsDefaultCellStyle.BackColor = Color.White;
            this.dgvContainer.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(240, 244, 244);
            this.dgvContainer.ScrollBars = ScrollBars.Vertical;

            // Set column definitions
            this.dgvContainer.Columns[0].HeaderText = "Container ID";
            this.dgvContainer.Columns[0].DataPropertyName = "ContainerID";
            this.dgvContainer.Columns[0].MinimumWidth = 85;
            this.dgvContainer.Columns[0].Width = 90;
            this.dgvContainer.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            this.dgvContainer.Columns[1].HeaderText = "Container Description";
            this.dgvContainer.Columns[1].DataPropertyName = "Description";
            this.dgvContainer.Columns[1].MinimumWidth = 220;
            this.dgvContainer.Columns[1].Width = 230;
            this.dgvContainer.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            this.dgvContainer.Columns[2].HeaderText = "Weight Capacity (MT)";
            this.dgvContainer.Columns[2].DataPropertyName = "CapacityWeight";
            this.dgvContainer.Columns[2].MinimumWidth = 130;
            this.dgvContainer.Columns[2].Width = 135;
            this.dgvContainer.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            this.dgvContainer.Columns[2].DefaultCellStyle.Format = "0.00";

            this.dgvContainer.Columns[3].HeaderText = "Cube Capacity (CBM)";
            this.dgvContainer.Columns[3].DataPropertyName = "CapacityCube";
            this.dgvContainer.Columns[3].MinimumWidth = 130;
            this.dgvContainer.Columns[3].Width = 135;
            this.dgvContainer.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            this.dgvContainer.Columns[3].DefaultCellStyle.Format = "0.00";

            // Edit container button column
            DataGridViewButtonColumn modifyContainerButtonColumn = new DataGridViewButtonColumn();
            modifyContainerButtonColumn.Name = "modify_container_button_column";
            modifyContainerButtonColumn.HeaderText = "Modify";
            modifyContainerButtonColumn.Text = "Modify";
            modifyContainerButtonColumn.UseColumnTextForButtonValue = true;
            int columnIndex1 = 4;
            if (this.dgvContainer.Columns["modify_container_button_column"] == null)
            {
                this.dgvContainer.Columns.Insert(columnIndex1, modifyContainerButtonColumn);
            }
            
            // Add container to shipment button column
            DataGridViewButtonColumn addContainerToShipmentButtonColumn = new DataGridViewButtonColumn();
            addContainerToShipmentButtonColumn.Name = "add_container_to_shipment_button_column";
            addContainerToShipmentButtonColumn.HeaderText = "Add";
            addContainerToShipmentButtonColumn.Text = "Add";
            addContainerToShipmentButtonColumn.UseColumnTextForButtonValue = true;
            int columnIndex2 = 5;
            if (this.dgvContainer.Columns["add_container_to_shipment_button_column"] == null)
            {
                this.dgvContainer.Columns.Insert(columnIndex2, addContainerToShipmentButtonColumn);
            }

            // Remove container button column
            DataGridViewButtonColumn removeContainerButtonColumn = new DataGridViewButtonColumn();
            removeContainerButtonColumn.Name = "remove_container_button_column";
            removeContainerButtonColumn.HeaderText = "Remove";
            removeContainerButtonColumn.Text = "Remove";
            removeContainerButtonColumn.UseColumnTextForButtonValue = true;
            int columnIndex3 = 6;
            if (this.dgvContainer.Columns["remove_container_button_column"] == null)
            {
                this.dgvContainer.Columns.Insert(columnIndex3, removeContainerButtonColumn);
            }
        }
        
        // Datagrid click event
        private void DgvContainer_Click(object sender, EventArgs e)
        {
            // Validate container + packings
            // Clear shipment container + container packing sections
            if (this.dgvShipmentContainer.SelectedRows.Count > 0)
            {
                this.dgvShipmentContainer.ClearSelection();
                initShipmentContainerSection();

                if (this.dgvShipmentContainerPacking.Rows.Count > 0)
                {
                    this.dgvShipmentContainerPacking.ClearSelection();
                    this.dgvShipmentContainerPacking.DataSource = null;
                    initContainerPackingSection(2);
                    this.txtShipmentContainerID.Text = null;
                    this.txtShipmentContainerDescription.Text = null;
                }
            }
        }

        // Add / edit / remove container
        private void DgvContainer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Validate row selection
            if (this.dgvContainer.CurrentRow != null)
            {
                // Validate modify container button click
                if (e.ColumnIndex == this.dgvContainer.Columns["modify_container_button_column"].Index)
                {
                    // Perform a second validation of container selection            
                    if (this.dgvContainer.CurrentRow != null && this.dgvContainer.SelectedRows.Count > 0)
                    {
                        // Transfer selected cell bindings to UI controls
                        this.txtContainerDescription.Text = this.dgvContainer.SelectedCells[1].Value.ToString();
                        this.txtContainerCapacityWeight.Text = this.dgvContainer.SelectedCells[2].Value.ToString();
                        this.txtContainerCapacityCube.Text = this.dgvContainer.SelectedCells[3].Value.ToString();

                        // Change button caption and set focus to description field
                        this.btnAddUpdateContainer.Text = "Save Changes";                        
                        this.txtContainerDescription.Focus();
                    }                    
                }                
                // Validate remove container button click
                else if (e.ColumnIndex == this.dgvContainer.Columns["remove_container_button_column"].Index)
                {
                    // Perform a second validation of container selection            
                    if (this.dgvContainer.CurrentRow != null && this.dgvContainer.SelectedRows.Count > 0)
                    {
                        // TO DO: 
                        // ADD FUNCTIONALITY TO REMOVE ALL EXISTING SHIPMENT CONTAINERS AND PACKING DETAILS
                        
                        // Remove the selected container from the container list
                        Containers.RemoveAt(this.dgvContainer.CurrentRow.Index);

                        // Initialize the container section                        
                        initContainerSection();
                        this.txtShipmentName.Focus();
                    }
                }
                // Validate add container to shipment button click
                else if (e.ColumnIndex == this.dgvContainer.Columns["add_container_to_shipment_button_column"].Index)
                {
                    // Perform a second validation of container selection            
                    if (this.dgvContainer.CurrentRow != null && this.dgvContainer.SelectedRows.Count > 0)
                    {
                        //MessageBox.Show(dgvContainer.SelectedCells[1].Value.ToString());
                        Shipment.Containers.Add(new ShipmentContainer()
                        {
                            ShipmentID = Shipment.ShipmentID.ToString(),
                            ContainerID = this.dgvContainer.SelectedCells[0].Value.ToString(),
                            ContainerDescription = this.dgvContainer.SelectedCells[1].Value.ToString(),
                            CapacityWeight = Convert.ToDouble(this.dgvContainer.SelectedCells[2].Value),
                            CapacityCube = Convert.ToDouble(this.dgvContainer.SelectedCells[3].Value)
                        });

                        // Display no data in container packing grid and reset packing section
                        //// Assign binding datasource to container packing datagridview
                        //// and initialize the datagridview with custom properties and formatting
                        //dgvShipmentContainerPacking.DataSource = ShipmentContainer.Packages;
                        //initContainerPackingDGV();

                        // Clear container datagrid selection
                        this.dgvContainer.ClearSelection();
                        this.dgvShipmentContainer.ClearSelection();

                        // Inititialize UI sections                    
                        initContainerSection();
                        initShipmentContainerSection();                        

                        // Update stats
                        updateShipmentStats();
                        updateContainerStats();
                    }
                }
            }
            else
            {
                // Prompt user to select a container
                MessageBox.Show("Error! Please select a container from the list.");                
            }
        }

        // Add / update container
        private void BtnAddUpdateContainer_Click(object sender, EventArgs e)
        {
            // Validate add container mode
            if (this.btnAddUpdateContainer.Text == "Add New Container")
            {
                // Validate form fields
                if (!IsEmpty(this.txtContainerDescription.Text, this.txtContainerCapacityWeight.Text, this.txtContainerCapacityCube.Text))
                {
                    // Add container to list
                    Containers.Add(new Container()
                    {
                        Description = this.txtContainerDescription.Text,
                        CapacityWeight = Convert.ToDouble(this.txtContainerCapacityWeight.Text),
                        CapacityCube = Convert.ToDouble(this.txtContainerCapacityCube.Text)
                    });

                    // Clear and initialize the container section                
                    this.dgvContainer.ClearSelection();
                    initContainerSection();
                    this.txtShipmentName.Focus();

                    // Update stats                
                    updateShipmentStats();
                    updateContainerStats();
                }
                else
                {
                    // Prompt user to provide required values
                    MessageBox.Show("Error! Please provide values for all data entry fields.");
                    initContainerSection();
                    this.txtContainerDescription.Focus();
                }
            }
            // Validate update container mode
            else if (this.btnAddUpdateContainer.Text == "Save Changes")
            {
                if (this.dgvContainer.CurrentRow != null && this.dgvContainer.SelectedRows.Count > 0)
                {
                    // Update the container
                    //CarMovement carMovement = Movement.Find(item => item.SourceCtrl.Equals(txt.Name, StringComparison.CurrentCultureIgnoreCase));
                    //if (carMovement != null)
                    //{
                    //    carMovement.CarName = @"Old Banger";
                    //}

                    //var obj = myList.FirstOrDefault(x => x.MyProperty == myValue);
                    //if (obj != null) obj.OtherProperty = newValue;

                    //But in this case you might want to save the List into a Dictionary and use this instead:

                    //// ... define after getting the List/Enumerable/whatever
                    //var dict = myList.ToDictionary(x => x.MyProperty);
                    //// ... somewhere in code
                    //MyObject found;
                    //if (dict.TryGetValue(myValue, out found)) found.OtherProperty = newValue;

                    //foreach (MyObject obj in myList)
                    //{
                    //    if (obj.prop == someValue)
                    //    {
                    //        obj.otherProp = newValue;
                    //        break;
                    //    }
                    //}

                    // Clear and initialize the container section                
                    this.dgvContainer.ClearSelection();
                    initContainerSection();
                    this.txtShipmentName.Focus();

                    // Update stats
                    updateShipmentStats();
                    updateContainerStats();

                }
            }
        }
        
        #endregion

        #region Shipment Container

        // Method to initialize shipment container section
        private void initShipmentContainerSection()
        {
            if (this.dgvShipmentContainer.Rows.Count > 0)
            {
                this.dgvShipmentContainer.Enabled = true;
            }
            else
            {
                this.dgvShipmentContainer.Enabled = false;
            }
        }

        // Method to initialize shipment container datagrid
        private void initShipmentContainerDGV()
        {
            // Set control properties
            this.dgvShipmentContainer.AutoGenerateColumns = false;
            this.dgvShipmentContainer.MultiSelect = false;
            this.dgvShipmentContainer.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dgvShipmentContainer.RowHeadersVisible = false;
            this.dgvShipmentContainer.RowsDefaultCellStyle.BackColor = Color.White;
            this.dgvShipmentContainer.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(240, 244, 244);
            this.dgvShipmentContainer.ScrollBars = ScrollBars.Both;

            // Set column definitions
            this.dgvShipmentContainer.Columns[0].HeaderText = "Shipment ID";
            this.dgvShipmentContainer.Columns[0].DataPropertyName = "ShipmentID";
            this.dgvShipmentContainer.Columns[0].MinimumWidth = 80;
            this.dgvShipmentContainer.Columns[0].Width = 80;
            this.dgvShipmentContainer.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            this.dgvShipmentContainer.Columns[1].HeaderText = "Container ID";
            this.dgvShipmentContainer.Columns[1].DataPropertyName = "ContainerID";
            this.dgvShipmentContainer.Columns[1].MinimumWidth = 80;
            this.dgvShipmentContainer.Columns[1].Width = 80;
            this.dgvShipmentContainer.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            this.dgvShipmentContainer.Columns[2].HeaderText = "Shipment Container ID";
            this.dgvShipmentContainer.Columns[2].DataPropertyName = "ShipmentContainerID";
            this.dgvShipmentContainer.Columns[2].MinimumWidth = 80;
            this.dgvShipmentContainer.Columns[2].Width = 80;
            this.dgvShipmentContainer.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            this.dgvShipmentContainer.Columns[3].HeaderText = "Description";
            this.dgvShipmentContainer.Columns[3].DataPropertyName = "ContainerDescription";
            this.dgvShipmentContainer.Columns[3].MinimumWidth = 210;
            this.dgvShipmentContainer.Columns[3].Width = 230;
            this.dgvShipmentContainer.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            this.dgvShipmentContainer.Columns[4].HeaderText = "Package Lines";
            this.dgvShipmentContainer.Columns[4].DataPropertyName = "ContainerPackageLineCount";
            this.dgvShipmentContainer.Columns[4].MinimumWidth = 80;
            this.dgvShipmentContainer.Columns[4].Width = 80;
            this.dgvShipmentContainer.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            this.dgvShipmentContainer.Columns[4].DefaultCellStyle.Format = "0";

            this.dgvShipmentContainer.Columns[5].HeaderText = "Total Packages";
            this.dgvShipmentContainer.Columns[5].DataPropertyName = "ContainerPackages";
            this.dgvShipmentContainer.Columns[5].MinimumWidth = 80;
            this.dgvShipmentContainer.Columns[5].Width = 80;
            this.dgvShipmentContainer.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            this.dgvShipmentContainer.Columns[5].DefaultCellStyle.Format = "0";

            this.dgvShipmentContainer.Columns[6].HeaderText = "Weight Capacity (MT)";
            this.dgvShipmentContainer.Columns[6].DataPropertyName = "CapacityWeight";
            this.dgvShipmentContainer.Columns[6].MinimumWidth = 80;
            this.dgvShipmentContainer.Columns[6].Width = 80;
            this.dgvShipmentContainer.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            this.dgvShipmentContainer.Columns[6].DefaultCellStyle.Format = "0.00";

            this.dgvShipmentContainer.Columns[7].HeaderText = "Load Weight (MT)";
            this.dgvShipmentContainer.Columns[7].DataPropertyName = "ContainerWeight";
            this.dgvShipmentContainer.Columns[7].MinimumWidth = 80;
            this.dgvShipmentContainer.Columns[7].Width = 80;
            this.dgvShipmentContainer.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            this.dgvShipmentContainer.Columns[7].DefaultCellStyle.Format = "0.00";

            this.dgvShipmentContainer.Columns[8].HeaderText = "Weight Util. (MT/%)";
            this.dgvShipmentContainer.Columns[8].DataPropertyName = "WeightUtilization";
            this.dgvShipmentContainer.Columns[8].MinimumWidth = 80;
            this.dgvShipmentContainer.Columns[8].Width = 80;
            this.dgvShipmentContainer.Columns[8].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            this.dgvShipmentContainer.Columns[8].DefaultCellStyle.Format = "0.00\\%";

            this.dgvShipmentContainer.Columns[9].HeaderText = "Cube Capacity (CBM)";
            this.dgvShipmentContainer.Columns[9].DataPropertyName = "CapacityCube";
            this.dgvShipmentContainer.Columns[9].MinimumWidth = 80;
            this.dgvShipmentContainer.Columns[9].Width = 80;
            this.dgvShipmentContainer.Columns[9].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            this.dgvShipmentContainer.Columns[9].DefaultCellStyle.Format = "0.00";

            this.dgvShipmentContainer.Columns[10].HeaderText = "Load Cube (CBM)";
            this.dgvShipmentContainer.Columns[10].DataPropertyName = "ContainerCube";
            this.dgvShipmentContainer.Columns[10].MinimumWidth = 80;
            this.dgvShipmentContainer.Columns[10].Width = 80;
            this.dgvShipmentContainer.Columns[10].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            this.dgvShipmentContainer.Columns[10].DefaultCellStyle.Format = "0.00";

            this.dgvShipmentContainer.Columns[11].HeaderText = "Cube Util. (CBM/%)";
            this.dgvShipmentContainer.Columns[11].DataPropertyName = "CubeUtilization";
            this.dgvShipmentContainer.Columns[11].MinimumWidth = 80;
            this.dgvShipmentContainer.Columns[11].Width = 80;
            this.dgvShipmentContainer.Columns[11].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            this.dgvShipmentContainer.Columns[11].DefaultCellStyle.Format = "0.00\\%";
            
            // Add column for packing button
            DataGridViewButtonColumn containerPackingButtonColumn = new DataGridViewButtonColumn();
            containerPackingButtonColumn.Name = "container_packing_button_column";
            containerPackingButtonColumn.HeaderText = "Packing";
            containerPackingButtonColumn.Text = "Packing";
            containerPackingButtonColumn.UseColumnTextForButtonValue = true;
            int columnIndex1 = 6;
            if (this.dgvShipmentContainer.Columns["container_packing_button_column"] == null)
            {
                this.dgvShipmentContainer.Columns.Insert(columnIndex1, containerPackingButtonColumn);
            }

            // Add column for container removal button
            DataGridViewButtonColumn removeContainerFromShipmentColumn = new DataGridViewButtonColumn();
            removeContainerFromShipmentColumn.Name = "remove_container_from_shipment_column";
            removeContainerFromShipmentColumn.HeaderText = "Remove";
            removeContainerFromShipmentColumn.Text = "Remove";
            removeContainerFromShipmentColumn.UseColumnTextForButtonValue = true;
            int columnIndex2 = 13;
            if (this.dgvShipmentContainer.Columns["remove_container_from_shipment_column"] == null)
            {
                this.dgvShipmentContainer.Columns.Insert(columnIndex2, removeContainerFromShipmentColumn);
            }
        }
        
        // Gridview click
        private void DgvShipmentContainer_Click(object sender, EventArgs e)
        {
            // Clear container selections
            this.dgvContainer.ClearSelection();

            // Check if a container is currently being edited. 
            if (this.txtShipmentContainerID.Text == null && this.dgvShipmentContainer.SelectedRows.Count == 0)
            {
                // Clear out the packing details
                this.dgvShipmentContainerPacking.DataSource = null;
            }

        }
        
        // Add /modify packing or remove container
        private void DgvShipmentContainer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Validate packing button click
            if (e.ColumnIndex == this.dgvShipmentContainer.Columns["container_packing_button_column"].Index)
            {
                // TO DO: VIEW PACKING FOR SELECTED CONTAINER + IMPLEMENT EDIT LOCKING MODE
                  
                // Transfer the field values from the datagrid to the packing section
                this.txtShipmentContainerID.Text = this.dgvShipmentContainer.SelectedCells[2].Value.ToString();
                this.txtShipmentContainerDescription.Text = this.dgvShipmentContainer.SelectedCells[3].Value.ToString();
                this.btnAddPackingToContainer.Text = "Add To Container";

                // Initialize the packing section
                initContainerPackingSection(1);

                // Display no data in container packing grid and reset packing section
                // Assign binding datasource to container packing datagridview
                // and initialize the datagridview with custom properties and formatting
                this.dgvShipmentContainerPacking.DataSource = ShipmentContainer.Packages;
                
                // NOTE: FILL WITH DUMMY TEST DATA
                createTestPackingData();
                this.txtPackageDescription.Focus();
                                
            }
            // Validate remove shipment container button click
            else if (e.ColumnIndex == this.dgvShipmentContainer.Columns["remove_container_from_shipment_column"].Index)
            {               
                // TO DO
                // Check if there any packing details prompt user
                // to either delete all packing details or reassign them for later

                // Remove the selected container from the shipment
                Shipment.Containers.RemoveAt(dgvShipmentContainer.CurrentRow.Index);

                // Empty the container packing datagrid
                this.dgvShipmentContainerPacking.DataSource = null;

                // Inititialize container section                    
                initShipmentContainerSection();                

                // Update stats
                updateShipmentStats();
                updateContainerStats();
                               
            }
        }
        
        // Method to populate the shipment container totals
        private void updateContainerStats()
        {
            // Validate objects
            if (Shipment != null && ShipmentContainer != null)
            {
                // NOTES: String Format Guidelines
                // String.Format("{0:n2}" will format the number to two decimal places with tousands seperator
                // String.Format("{0:n0}" will format the number to zero decimal places with tousands seperator

                lblContainerPackageLines.Text = string.Format("{0:n0}", ShipmentContainer.ContainerPackageLineCount);
                lblContainerPackages.Text = string.Format("{0:n0}", ShipmentContainer.ContainerPackages);
                lblContainerWeight.Text = string.Format("{0:n2}", ShipmentContainer.ContainerWeight);
                lblContainerCube.Text = string.Format("{0:n2}", ShipmentContainer.ContainerCube);
            }
        }

        #endregion

        #region Container Packing
        
        // Initializes the container packing section
        private void initContainerPackingSection(int editMode)
        {            
            // Initilize packing section
            if (editMode == 1) // Open for packing
            {
                clearPackingFields();
                dgvShipmentContainerPacking.Enabled = true;
                txtPackageDescription.Enabled = true;
                txtPackageLength.Enabled = true;
                txtPackageDepth.Enabled = true;
                txtPackageHeight.Enabled = true;
                txtPackageWeight.Enabled = true;
                txtPackingQty.Enabled = true;
                btnAddPackingToContainer.Text = "Add To Container";
                btnAddPackingToContainer.Enabled = true;
                btnGenerateTestPackingData.Enabled = true;
            }
            else if (editMode == 2) // Closed for packing
            {
                clearPackingFields();
                dgvShipmentContainerPacking.Enabled = false;
                txtPackageDescription.Enabled = false;
                txtPackageLength.Enabled = false;
                txtPackageDepth.Enabled = false;
                txtPackageHeight.Enabled = false;
                txtPackageWeight.Enabled = false;
                txtPackingQty.Enabled = false;
                btnAddPackingToContainer.Text = "Add To Container";
                btnAddPackingToContainer.Enabled = false;
                btnGenerateTestPackingData.Enabled = false;
            }
            else if (editMode == 3)
            {
                clearPackingFields();
                dgvShipmentContainerPacking.Enabled = false;
                txtPackageDescription.Enabled = false;
                txtPackageLength.Enabled = false;
                txtPackageDepth.Enabled = false;
                txtPackageHeight.Enabled = false;
                txtPackageWeight.Enabled = false;
                txtPackingQty.Enabled = false;
                btnAddPackingToContainer.Text = "Add To Container";
                btnAddPackingToContainer.Enabled = false;
                btnGenerateTestPackingData.Enabled = false;
            }
        }

        // Method to initialize container packing datagridview
        private void initContainerPackingDGV()
        {
            // Set control properties                       
            this.dgvShipmentContainerPacking.AutoGenerateColumns = false;
            this.dgvShipmentContainerPacking.MultiSelect = false;
            this.dgvShipmentContainerPacking.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dgvShipmentContainerPacking.RowHeadersVisible = false;
            this.dgvShipmentContainerPacking.RowsDefaultCellStyle.BackColor = Color.White;
            this.dgvShipmentContainerPacking.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(240, 244, 244);
            this.dgvShipmentContainer.ScrollBars = ScrollBars.Both;

            // Set column definitions
            this.dgvShipmentContainerPacking.Columns[0].HeaderText = "Shipment Container ID";
            this.dgvShipmentContainerPacking.Columns[0].DataPropertyName = "ShipmentContainerID";
            this.dgvShipmentContainerPacking.Columns[0].MinimumWidth = 95;
            this.dgvShipmentContainerPacking.Columns[0].Width = 113;
            this.dgvShipmentContainerPacking.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            this.dgvShipmentContainerPacking.Columns[1].HeaderText = "Packing ID";
            this.dgvShipmentContainerPacking.Columns[1].DataPropertyName = "PackingID";
            this.dgvShipmentContainerPacking.Columns[1].MinimumWidth = 95;
            this.dgvShipmentContainerPacking.Columns[1].Width = 100;
            this.dgvShipmentContainerPacking.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            this.dgvShipmentContainerPacking.Columns[2].HeaderText = "Package Description";
            this.dgvShipmentContainerPacking.Columns[2].DataPropertyName = "PackageDescription";
            this.dgvShipmentContainerPacking.Columns[2].MinimumWidth = 170;
            this.dgvShipmentContainerPacking.Columns[2].Width = 175;
            this.dgvShipmentContainerPacking.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            this.dgvShipmentContainerPacking.Columns[3].HeaderText = "Package Length (CM)";
            this.dgvShipmentContainerPacking.Columns[3].DataPropertyName = "PackageLength";
            this.dgvShipmentContainerPacking.Columns[3].MinimumWidth = 120;
            this.dgvShipmentContainerPacking.Columns[3].Width = 125;
            this.dgvShipmentContainerPacking.Columns[3].Visible = false;
            this.dgvShipmentContainerPacking.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            this.dgvShipmentContainerPacking.Columns[4].HeaderText = "Package Depth (CM)";
            this.dgvShipmentContainerPacking.Columns[4].DataPropertyName = "PackageDepth";
            this.dgvShipmentContainerPacking.Columns[4].MinimumWidth = 120;
            this.dgvShipmentContainerPacking.Columns[4].Width = 125;
            this.dgvShipmentContainerPacking.Columns[4].Visible = false;
            this.dgvShipmentContainerPacking.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            this.dgvShipmentContainerPacking.Columns[5].HeaderText = "Package Height (CM)";
            this.dgvShipmentContainerPacking.Columns[5].DataPropertyName = "PackageHeight";
            this.dgvShipmentContainerPacking.Columns[5].MinimumWidth = 120;
            this.dgvShipmentContainerPacking.Columns[5].Width = 125;
            this.dgvShipmentContainerPacking.Columns[5].Visible = false;
            this.dgvShipmentContainerPacking.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            this.dgvShipmentContainerPacking.Columns[6].HeaderText = "Packing Qty";
            this.dgvShipmentContainerPacking.Columns[6].DataPropertyName = "PackingQty";
            this.dgvShipmentContainerPacking.Columns[6].MinimumWidth = 110;
            this.dgvShipmentContainerPacking.Columns[6].Width = 122;
            this.dgvShipmentContainerPacking.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            this.dgvShipmentContainerPacking.Columns[6].DefaultCellStyle.Format = "0";

            this.dgvShipmentContainerPacking.Columns[7].HeaderText = "Package Weight (KG)";
            this.dgvShipmentContainerPacking.Columns[7].DataPropertyName = "PackageWeight";
            this.dgvShipmentContainerPacking.Columns[7].MinimumWidth = 110;
            this.dgvShipmentContainerPacking.Columns[7].Width = 122;
            this.dgvShipmentContainerPacking.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            this.dgvShipmentContainerPacking.Columns[7].DefaultCellStyle.Format = "0.00";

            this.dgvShipmentContainerPacking.Columns[8].HeaderText = "Packing Weight (MT)";
            this.dgvShipmentContainerPacking.Columns[8].DataPropertyName = "PackingWeight";
            this.dgvShipmentContainerPacking.Columns[8].MinimumWidth = 110;
            this.dgvShipmentContainerPacking.Columns[8].Width = 122;
            this.dgvShipmentContainerPacking.Columns[8].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            this.dgvShipmentContainerPacking.Columns[8].DefaultCellStyle.Format = "0.00";

            this.dgvShipmentContainerPacking.Columns[9].HeaderText = "Package Cube (CBM)";
            this.dgvShipmentContainerPacking.Columns[9].DataPropertyName = "PackageCube";
            this.dgvShipmentContainerPacking.Columns[9].MinimumWidth = 110;
            this.dgvShipmentContainerPacking.Columns[9].Width = 122;
            this.dgvShipmentContainerPacking.Columns[9].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            this.dgvShipmentContainerPacking.Columns[9].DefaultCellStyle.Format = "0.0000";

            this.dgvShipmentContainerPacking.Columns[10].HeaderText = "Packing Cube (CBM)";
            this.dgvShipmentContainerPacking.Columns[10].DataPropertyName = "PackingCube";
            this.dgvShipmentContainerPacking.Columns[10].MinimumWidth = 110;
            this.dgvShipmentContainerPacking.Columns[10].Width = 122;
            this.dgvShipmentContainerPacking.Columns[10].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            this.dgvShipmentContainerPacking.Columns[10].DefaultCellStyle.Format = "0.00";
                        
            // Add column for modify packing button
            DataGridViewButtonColumn containerPackingButtonColumn = new DataGridViewButtonColumn();
            containerPackingButtonColumn.Name = "container_packing_button_column";
            containerPackingButtonColumn.HeaderText = "Modify";
            containerPackingButtonColumn.Text = "Modify";
            containerPackingButtonColumn.UseColumnTextForButtonValue = true;
            int columnIndex1 = 7;
            if (this.dgvShipmentContainerPacking.Columns["container_packing_button_column"] == null)
            {
                this.dgvShipmentContainerPacking.Columns.Insert(columnIndex1, containerPackingButtonColumn);
            }

            // Add column for package removal
            DataGridViewButtonColumn removeContainerPackingButtonColumn = new DataGridViewButtonColumn();
            removeContainerPackingButtonColumn.Name = "remove_container_packing_button_column";
            removeContainerPackingButtonColumn.HeaderText = "Remove";
            removeContainerPackingButtonColumn.Text = "Remove";
            removeContainerPackingButtonColumn.UseColumnTextForButtonValue = true;
            int columnIndex2 = 12;
            if (this.dgvShipmentContainerPacking.Columns["remove_container_packing_button_column"] == null)
            {
                this.dgvShipmentContainerPacking.Columns.Insert(columnIndex2, removeContainerPackingButtonColumn);
            }
        }
                        
        // Clears the packing entry fields
        private void clearPackingFields()
        {
            this.txtPackageDescription.Text = null;
            this.txtPackageLength.Text = null;
            this.txtPackageDepth.Text = null;
            this.txtPackageHeight.Text = null;
            this.txtPackageWeight.Text = null;
            this.txtPackingQty.Text = null;
        }
         
        private void DgvShipmentContainerPacking_Click(object sender, EventArgs e)
        {
            // Clear container selections
            //this.dgvContainer.ClearSelection();
        }

        // Modify or remove container packing
        private void DgvShipmentContainerPacking_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Validate shipment container selection
            if (this.dgvShipmentContainer.CurrentRow != null)
            {
                // Validate modify packing button click
                if (e.ColumnIndex == this.dgvShipmentContainerPacking.Columns["container_packing_button_column"].Index)
                {                    
                    // Validate container packing row selection            
                    if (this.dgvShipmentContainerPacking.CurrentRow != null && this.dgvShipmentContainerPacking.SelectedRows.Count > 0)
                    {
                        // Retrieve the bound class field values from the datagrid 
                        this.txtPackageDescription.Text = this.dgvShipmentContainerPacking.SelectedCells[2].Value.ToString();
                        this.txtPackageLength.Text = this.dgvShipmentContainerPacking.SelectedCells[3].Value.ToString();
                        this.txtPackageDepth.Text = this.dgvShipmentContainerPacking.SelectedCells[4].Value.ToString();
                        this.txtPackageHeight.Text = this.dgvShipmentContainerPacking.SelectedCells[5].Value.ToString();
                        this.txtPackageWeight.Text = this.dgvShipmentContainerPacking.SelectedCells[10].Value.ToString();
                        this.txtPackingQty.Text = this.dgvShipmentContainerPacking.SelectedCells[6].Value.ToString();
                        this.btnAddPackingToContainer.Text = "Save Changes";
                        this.txtPackageDescription.Focus();
                    }                    
                }
                // Validate remove container packing button click
                else if (e.ColumnIndex == this.dgvShipmentContainerPacking.Columns["remove_container_packing_button_column"].Index)
                {
                    // Validate container packing selection
                    if (this.dgvShipmentContainerPacking.CurrentRow != null && this.dgvShipmentContainerPacking.SelectedRows.Count > 0)
                    {
                        // TO DO
                        // Check if there any split packing requests and prompt user
                        // to either delete all packing quantities or reassign them for later 

                        // Remove the selected container from the shipment
                        ShipmentContainer.Packages.RemoveAt(this.dgvShipmentContainerPacking.CurrentRow.Index);
                   
                        // Update stats
                        updateShipmentStats();
                        updateContainerStats();
                    }                    
                }
            }
            else
            {
                // Prompt user to select a container
                MessageBox.Show("Error! Please select a shipment container from the list.");
                this.txtShipmentName.Focus();
            }
        }

        // Add / update container packing
        // NOTE : MUST VALIDATE - ** LIST UPDATE VS ADD NEW **
        private void BtnAddPackingToContainer_Click(object sender, EventArgs e)
        {
            // Validate container selection
            
            // Validate form fields
            if (!IsEmpty(this.txtPackageDescription.Text, this.txtPackageLength.Text, this.txtPackageDepth.Text, this.txtPackageHeight.Text,
                this.txtPackageWeight.Text, this.txtPackingQty.Text))
            {
                // Validate modify packing
                if (this.btnAddPackingToContainer.Text == "Save Changes")
                {
                    // Modify packing
                    // Validate selection and process an update of the selected packing
                    
                    // Refresh the datagrids
                    this.dgvShipmentContainer.DataSource = Shipment.Containers;
                    this.dgvShipmentContainerPacking.DataSource = ShipmentContainer.Packages;

                    // Inititialize container packing section
                    initContainerPackingSection(1);

                    this.dgvShipmentContainerPacking.ClearSelection();

                    // Update stats                        
                    updateShipmentStats();
                    updateContainerStats();
                }
                else // Add packing
                {
                    // TO DO: Validate remaining capacity + split packing

                    // Add packing to selected container
                    ShipmentContainer.Packages.Add(new ContainerPackage()
                    {
                        ShipmentContainerID = this.txtShipmentContainerID.Text.ToString(),
                        PackageDescription = this.txtPackageDescription.Text.ToString(),
                        PackageLength = Convert.ToDouble(this.txtPackageLength.Text),
                        PackageDepth = Convert.ToDouble(this.txtPackageDepth.Text),
                        PackageHeight = Convert.ToDouble(this.txtPackageHeight.Text),
                        PackingQty = Convert.ToInt32(this.txtPackingQty.Text),
                        PackageWeight = Convert.ToDouble(this.txtPackageWeight.Text)
                    });

                    // Refresh the datagrids
                    this.dgvShipmentContainer.DataSource = null;
                    this.dgvShipmentContainer.DataSource = Shipment.Containers;

                    this.dgvShipmentContainerPacking.DataSource = ShipmentContainer.Packages;

                    // Inititialize container packing section
                    initContainerPackingSection(1);
                    this.dgvShipmentContainerPacking.ClearSelection();

                    // Update stats
                    updateShipmentStats();
                    updateContainerStats();
                }
            }
            else
            {
                // Prompt user to provide required values
                MessageBox.Show("Error! Please provide values for all package entry fields.");
                this.txtPackageDescription.Focus();
            }
            
        }

        #endregion

        #region Form Helper Methods

        // Function to validate textbox entries
        private static bool IsEmpty(params string[] args)
        {
            if (args.Length == 0) return true;
            return args.Any(p => string.IsNullOrEmpty(p));
        }

        // Function to help with formatting weight and cube values
        private static string FormatValue(double myNumber, bool allowDecimals = false)
        {
            // Preload and format the string
            var s = string.Format("{0:0.00}", myNumber);

            if (s.EndsWith("00"))
            {
                return ((int)myNumber).ToString();
            }
            else
            {
                return s;
            }
        }
        
        private void clearAllGridSelections()
        {
            this.dgvContainer.ClearSelection();
            this.dgvShipmentContainer.ClearSelection();
            this.dgvShipmentContainerPacking.ClearSelection();
        }

        #endregion

        #region Testing

        // FOR TESTING ONLY
        private void BtnMessage_Click(object sender, EventArgs e)
        {
            if (dgvContainer.CurrentRow != null && dgvContainer.SelectedRows.Count > 0)
            {
                MessageBox.Show(dgvContainer.SelectedCells[1].Value.ToString());
            }
                
            //MessageBox.Show("Container weight :" + ShipmentContainer.ContainerWeight);
            //MessageBox.Show("Container dgv :" + ShipmentContainer.ContainerWeight);
        }

        // FOR TESTING ONLY
        private void BtnGenerateTestPackingData_Click(object sender, EventArgs e)
        {
            // Clear first
            clearPackingFields();
            dgvShipmentContainerPacking.ClearSelection();
            createTestPackingData();
        }
        
        // FOR TESTING ONLY
        private void createTestPackingData()
        {
            // Static
            double minWeight = 0.5;
            double maxWeight = 17;

            Random intRnd = new Random();
            txtPackageDescription.Text = "Test Data";
            txtPackageLength.Text = intRnd.Next(1, 40).ToString();
            txtPackageDepth.Text = intRnd.Next(10, 40).ToString();
            txtPackageHeight.Text = intRnd.Next(10, 40).ToString();
            txtPackingQty.Text = intRnd.Next(1, 1300).ToString();

            Random dblRand = new Random();
            double tal = Math.Round(dblRand.NextDouble() * (maxWeight - minWeight) + minWeight, 2);
            txtPackageWeight.Text = tal.ToString();
        }
        
        #endregion
        
        private void BtnUpdateShipmentStats_Click(object sender, EventArgs e)
        {
            updateShipmentStats();
        }

        private void BtnUpdateContainerStats_Click(object sender, EventArgs e)
        {
            updateContainerStats();
        }

        private void BtnCalculator_Click(object sender, EventArgs e)
        {
            clearAllGridSelections();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            // print all container in container list
            this.txtListDisplay.Text = null;

            foreach (var container in Shipment.Containers)
            {
                //txtListDisplay.Text = String.Join(Environment.NewLine, container.ToString());
                txtListDisplay.Text += Environment.NewLine + container.ToString();
                //txtListDisplay.Text = container.ToString();
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            // print all packages in packing list
            this.txtListDisplay.Text = null;

            foreach (var package in ShipmentContainer.Packages)
            {
                //txtListDisplay.Text = String.Join(Environment.NewLine, container.ToString());
                txtListDisplay.Text += Environment.NewLine + package.ToString();
                //txtListDisplay.Text = container.ToString();
            }

        }
    }
}
