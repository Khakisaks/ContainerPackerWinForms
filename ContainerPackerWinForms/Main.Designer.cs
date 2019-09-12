namespace ContainerPackerWinForms
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtShipmentName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPackingQty = new System.Windows.Forms.TextBox();
            this.txtPackageLength = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.txtPackageDescription = new System.Windows.Forms.TextBox();
            this.btnAddPackingToContainer = new System.Windows.Forms.Button();
            this.txtPackageHeight = new System.Windows.Forms.TextBox();
            this.label31 = new System.Windows.Forms.Label();
            this.txtPackageDepth = new System.Windows.Forms.TextBox();
            this.label35 = new System.Windows.Forms.Label();
            this.txtPackageWeight = new System.Windows.Forms.TextBox();
            this.label36 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label39 = new System.Windows.Forms.Label();
            this.lblShipmentContainers = new System.Windows.Forms.Label();
            this.lblShipmentPackageLines = new System.Windows.Forms.Label();
            this.btnCreateShipment = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label38 = new System.Windows.Forms.Label();
            this.lblShipmentCube = new System.Windows.Forms.Label();
            this.label40 = new System.Windows.Forms.Label();
            this.lblShipmentPackages = new System.Windows.Forms.Label();
            this.lblShipmentWeight = new System.Windows.Forms.Label();
            this.label41 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label37 = new System.Windows.Forms.Label();
            this.dgvShipmentContainer = new System.Windows.Forms.DataGridView();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnCloseContainer = new System.Windows.Forms.Button();
            this.txtShipmentContainerDescription = new System.Windows.Forms.TextBox();
            this.txtShipmentContainerID = new System.Windows.Forms.TextBox();
            this.btnGenerateTestPackingData = new System.Windows.Forms.Button();
            this.lblContainerPackageLines = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblContainerCube = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblContainerWeight = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dgvShipmentContainerPacking = new System.Windows.Forms.DataGridView();
            this.lblContainerPackages = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.grpPacking = new System.Windows.Forms.GroupBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtContainerCapacityCube = new System.Windows.Forms.TextBox();
            this.txtContainerCapacityWeight = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtContainerDescription = new System.Windows.Forms.TextBox();
            this.btnAddUpdateContainer = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvContainer = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnQuit = new System.Windows.Forms.Button();
            this.btnMessage = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCalculator = new System.Windows.Forms.Button();
            this.btnUpdateShipmentStats = new System.Windows.Forms.Button();
            this.btnUpdateContainerStats = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtListDisplay = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShipmentContainer)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShipmentContainerPacking)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContainer)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtShipmentName
            // 
            this.txtShipmentName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtShipmentName.Location = new System.Drawing.Point(12, 54);
            this.txtShipmentName.Name = "txtShipmentName";
            this.txtShipmentName.Size = new System.Drawing.Size(415, 22);
            this.txtShipmentName.TabIndex = 4;
            this.txtShipmentName.TextChanged += new System.EventHandler(this.TxtShipmentName_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Shipment name :";
            // 
            // txtPackingQty
            // 
            this.txtPackingQty.Enabled = false;
            this.txtPackingQty.Location = new System.Drawing.Point(884, 405);
            this.txtPackingQty.Name = "txtPackingQty";
            this.txtPackingQty.Size = new System.Drawing.Size(79, 22);
            this.txtPackingQty.TabIndex = 14;
            this.txtPackingQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtPackageLength
            // 
            this.txtPackageLength.Enabled = false;
            this.txtPackageLength.Location = new System.Drawing.Point(432, 405);
            this.txtPackageLength.Name = "txtPackageLength";
            this.txtPackageLength.Size = new System.Drawing.Size(79, 22);
            this.txtPackageLength.TabIndex = 6;
            this.txtPackageLength.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(432, 384);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(86, 17);
            this.label24.TabIndex = 5;
            this.label24.Text = "Length (CM)";
            this.label24.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(884, 384);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(88, 17);
            this.label25.TabIndex = 13;
            this.label25.Text = "Packing Qty.";
            this.label25.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.Location = new System.Drawing.Point(18, 384);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(144, 17);
            this.label26.TabIndex = 3;
            this.label26.Text = "Package description :";
            // 
            // txtPackageDescription
            // 
            this.txtPackageDescription.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPackageDescription.Enabled = false;
            this.txtPackageDescription.Location = new System.Drawing.Point(18, 405);
            this.txtPackageDescription.Name = "txtPackageDescription";
            this.txtPackageDescription.Size = new System.Drawing.Size(371, 22);
            this.txtPackageDescription.TabIndex = 4;
            // 
            // btnAddPackingToContainer
            // 
            this.btnAddPackingToContainer.Enabled = false;
            this.btnAddPackingToContainer.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddPackingToContainer.Location = new System.Drawing.Point(994, 403);
            this.btnAddPackingToContainer.Name = "btnAddPackingToContainer";
            this.btnAddPackingToContainer.Size = new System.Drawing.Size(204, 26);
            this.btnAddPackingToContainer.TabIndex = 15;
            this.btnAddPackingToContainer.Text = "Add to Container";
            this.btnAddPackingToContainer.UseVisualStyleBackColor = true;
            this.btnAddPackingToContainer.Click += new System.EventHandler(this.BtnAddPackingToContainer_Click);
            // 
            // txtPackageHeight
            // 
            this.txtPackageHeight.Enabled = false;
            this.txtPackageHeight.Location = new System.Drawing.Point(630, 405);
            this.txtPackageHeight.Name = "txtPackageHeight";
            this.txtPackageHeight.Size = new System.Drawing.Size(79, 22);
            this.txtPackageHeight.TabIndex = 10;
            this.txtPackageHeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label31.Location = new System.Drawing.Point(628, 384);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(83, 17);
            this.label31.TabIndex = 9;
            this.label31.Text = "Height (CM)";
            this.label31.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtPackageDepth
            // 
            this.txtPackageDepth.Enabled = false;
            this.txtPackageDepth.Location = new System.Drawing.Point(535, 405);
            this.txtPackageDepth.Name = "txtPackageDepth";
            this.txtPackageDepth.Size = new System.Drawing.Size(79, 22);
            this.txtPackageDepth.TabIndex = 8;
            this.txtPackageDepth.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label35.Location = new System.Drawing.Point(536, 384);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(80, 17);
            this.label35.TabIndex = 7;
            this.label35.Text = "Depth (CM)";
            this.label35.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtPackageWeight
            // 
            this.txtPackageWeight.Enabled = false;
            this.txtPackageWeight.Location = new System.Drawing.Point(756, 405);
            this.txtPackageWeight.Name = "txtPackageWeight";
            this.txtPackageWeight.Size = new System.Drawing.Size(79, 22);
            this.txtPackageWeight.TabIndex = 12;
            this.txtPackageWeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label36.Location = new System.Drawing.Point(754, 384);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(86, 17);
            this.label36.TabIndex = 11;
            this.label36.Text = "Weight (KG)";
            this.label36.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label39);
            this.groupBox1.Controls.Add(this.lblShipmentContainers);
            this.groupBox1.Controls.Add(this.lblShipmentPackageLines);
            this.groupBox1.Controls.Add(this.btnCreateShipment);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label38);
            this.groupBox1.Controls.Add(this.txtShipmentName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lblShipmentCube);
            this.groupBox1.Controls.Add(this.label40);
            this.groupBox1.Controls.Add(this.lblShipmentPackages);
            this.groupBox1.Controls.Add(this.lblShipmentWeight);
            this.groupBox1.Controls.Add(this.label41);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1637, 96);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(11, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(151, 22);
            this.label11.TabIndex = 0;
            this.label11.Text = "Shipment Details :";
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Location = new System.Drawing.Point(991, 18);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(84, 17);
            this.label39.TabIndex = 9;
            this.label39.Text = "Containers :";
            // 
            // lblShipmentContainers
            // 
            this.lblShipmentContainers.Location = new System.Drawing.Point(1006, 42);
            this.lblShipmentContainers.Name = "lblShipmentContainers";
            this.lblShipmentContainers.Size = new System.Drawing.Size(69, 17);
            this.lblShipmentContainers.TabIndex = 10;
            this.lblShipmentContainers.Text = "0";
            this.lblShipmentContainers.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblShipmentPackageLines
            // 
            this.lblShipmentPackageLines.Location = new System.Drawing.Point(1483, 42);
            this.lblShipmentPackageLines.Name = "lblShipmentPackageLines";
            this.lblShipmentPackageLines.Size = new System.Drawing.Size(69, 17);
            this.lblShipmentPackageLines.TabIndex = 16;
            this.lblShipmentPackageLines.Text = "0";
            this.lblShipmentPackageLines.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnCreateShipment
            // 
            this.btnCreateShipment.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCreateShipment.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateShipment.Location = new System.Drawing.Point(435, 53);
            this.btnCreateShipment.Name = "btnCreateShipment";
            this.btnCreateShipment.Size = new System.Drawing.Size(163, 26);
            this.btnCreateShipment.TabIndex = 6;
            this.btnCreateShipment.Text = "Create Shipment";
            this.btnCreateShipment.UseVisualStyleBackColor = true;
            this.btnCreateShipment.Click += new System.EventHandler(this.BtnCreateShipment_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(1453, 18);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(104, 17);
            this.label10.TabIndex = 15;
            this.label10.Text = "Packing Lines :";
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Location = new System.Drawing.Point(874, 19);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(78, 17);
            this.label38.TabIndex = 7;
            this.label38.Text = "Packages :";
            // 
            // lblShipmentCube
            // 
            this.lblShipmentCube.Location = new System.Drawing.Point(1326, 42);
            this.lblShipmentCube.Name = "lblShipmentCube";
            this.lblShipmentCube.Size = new System.Drawing.Size(69, 17);
            this.lblShipmentCube.TabIndex = 14;
            this.lblShipmentCube.Text = "0.00";
            this.lblShipmentCube.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Location = new System.Drawing.Point(1166, 19);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(90, 17);
            this.label40.TabIndex = 11;
            this.label40.Text = "Weight (MT):";
            // 
            // lblShipmentPackages
            // 
            this.lblShipmentPackages.Location = new System.Drawing.Point(874, 41);
            this.lblShipmentPackages.Name = "lblShipmentPackages";
            this.lblShipmentPackages.Size = new System.Drawing.Size(69, 17);
            this.lblShipmentPackages.TabIndex = 8;
            this.lblShipmentPackages.Text = "0";
            this.lblShipmentPackages.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblShipmentWeight
            // 
            this.lblShipmentWeight.Location = new System.Drawing.Point(1180, 42);
            this.lblShipmentWeight.Name = "lblShipmentWeight";
            this.lblShipmentWeight.Size = new System.Drawing.Size(69, 17);
            this.lblShipmentWeight.TabIndex = 12;
            this.lblShipmentWeight.Text = "0.00";
            this.lblShipmentWeight.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Location = new System.Drawing.Point(1315, 18);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(92, 17);
            this.label41.TabIndex = 13;
            this.label41.Text = "Cube  (CBM):";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label37);
            this.groupBox4.Controls.Add(this.dgvShipmentContainer);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(12, 358);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(1818, 279);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label37.Location = new System.Drawing.Point(10, 1);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(186, 17);
            this.label37.TabIndex = 0;
            this.label37.Text = "Containers in Shipment :";
            // 
            // dgvShipmentContainer
            // 
            this.dgvShipmentContainer.AllowUserToAddRows = false;
            this.dgvShipmentContainer.AllowUserToDeleteRows = false;
            this.dgvShipmentContainer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvShipmentContainer.Location = new System.Drawing.Point(13, 34);
            this.dgvShipmentContainer.Name = "dgvShipmentContainer";
            this.dgvShipmentContainer.ReadOnly = true;
            this.dgvShipmentContainer.RowHeadersWidth = 51;
            this.dgvShipmentContainer.RowTemplate.Height = 24;
            this.dgvShipmentContainer.Size = new System.Drawing.Size(1786, 221);
            this.dgvShipmentContainer.TabIndex = 1;
            this.dgvShipmentContainer.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvShipmentContainer_CellContentClick);
            this.dgvShipmentContainer.Click += new System.EventHandler(this.DgvShipmentContainer_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label5);
            this.groupBox5.Controls.Add(this.label2);
            this.groupBox5.Controls.Add(this.btnCloseContainer);
            this.groupBox5.Controls.Add(this.txtShipmentContainerDescription);
            this.groupBox5.Controls.Add(this.txtShipmentContainerID);
            this.groupBox5.Controls.Add(this.btnGenerateTestPackingData);
            this.groupBox5.Controls.Add(this.lblContainerPackageLines);
            this.groupBox5.Controls.Add(this.label8);
            this.groupBox5.Controls.Add(this.lblContainerCube);
            this.groupBox5.Controls.Add(this.label9);
            this.groupBox5.Controls.Add(this.lblContainerWeight);
            this.groupBox5.Controls.Add(this.label12);
            this.groupBox5.Controls.Add(this.label6);
            this.groupBox5.Controls.Add(this.dgvShipmentContainerPacking);
            this.groupBox5.Controls.Add(this.txtPackageWeight);
            this.groupBox5.Controls.Add(this.lblContainerPackages);
            this.groupBox5.Controls.Add(this.label36);
            this.groupBox5.Controls.Add(this.label4);
            this.groupBox5.Controls.Add(this.txtPackageDepth);
            this.groupBox5.Controls.Add(this.txtPackageDescription);
            this.groupBox5.Controls.Add(this.label35);
            this.groupBox5.Controls.Add(this.btnAddPackingToContainer);
            this.groupBox5.Controls.Add(this.txtPackageHeight);
            this.groupBox5.Controls.Add(this.label26);
            this.groupBox5.Controls.Add(this.label31);
            this.groupBox5.Controls.Add(this.label25);
            this.groupBox5.Controls.Add(this.label24);
            this.groupBox5.Controls.Add(this.txtPackageLength);
            this.groupBox5.Controls.Add(this.txtPackingQty);
            this.groupBox5.Controls.Add(this.grpPacking);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(12, 655);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(1818, 460);
            this.groupBox5.TabIndex = 3;
            this.groupBox5.TabStop = false;
            // 
            // btnCloseContainer
            // 
            this.btnCloseContainer.Enabled = false;
            this.btnCloseContainer.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCloseContainer.Location = new System.Drawing.Point(1244, 403);
            this.btnCloseContainer.Name = "btnCloseContainer";
            this.btnCloseContainer.Size = new System.Drawing.Size(204, 26);
            this.btnCloseContainer.TabIndex = 24;
            this.btnCloseContainer.Text = "Close Container";
            this.btnCloseContainer.UseVisualStyleBackColor = true;
            // 
            // txtShipmentContainerDescription
            // 
            this.txtShipmentContainerDescription.Location = new System.Drawing.Point(178, 54);
            this.txtShipmentContainerDescription.Name = "txtShipmentContainerDescription";
            this.txtShipmentContainerDescription.Size = new System.Drawing.Size(543, 22);
            this.txtShipmentContainerDescription.TabIndex = 23;
            // 
            // txtShipmentContainerID
            // 
            this.txtShipmentContainerID.Location = new System.Drawing.Point(14, 54);
            this.txtShipmentContainerID.Name = "txtShipmentContainerID";
            this.txtShipmentContainerID.Size = new System.Drawing.Size(146, 22);
            this.txtShipmentContainerID.TabIndex = 22;
            // 
            // btnGenerateTestPackingData
            // 
            this.btnGenerateTestPackingData.Enabled = false;
            this.btnGenerateTestPackingData.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerateTestPackingData.Location = new System.Drawing.Point(13, 330);
            this.btnGenerateTestPackingData.Name = "btnGenerateTestPackingData";
            this.btnGenerateTestPackingData.Size = new System.Drawing.Size(1185, 26);
            this.btnGenerateTestPackingData.TabIndex = 19;
            this.btnGenerateTestPackingData.Text = "Generate Test Data";
            this.btnGenerateTestPackingData.UseVisualStyleBackColor = true;
            this.btnGenerateTestPackingData.Click += new System.EventHandler(this.BtnGenerateTestPackingData_Click);
            // 
            // lblContainerPackageLines
            // 
            this.lblContainerPackageLines.Location = new System.Drawing.Point(1312, 353);
            this.lblContainerPackageLines.Name = "lblContainerPackageLines";
            this.lblContainerPackageLines.Size = new System.Drawing.Size(69, 17);
            this.lblContainerPackageLines.TabIndex = 17;
            this.lblContainerPackageLines.Text = "0";
            this.lblContainerPackageLines.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1219, 334);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 17);
            this.label8.TabIndex = 16;
            this.label8.Text = "Packages :";
            // 
            // lblContainerCube
            // 
            this.lblContainerCube.Location = new System.Drawing.Point(1537, 353);
            this.lblContainerCube.Name = "lblContainerCube";
            this.lblContainerCube.Size = new System.Drawing.Size(69, 17);
            this.lblContainerCube.TabIndex = 12;
            this.lblContainerCube.Text = "0";
            this.lblContainerCube.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(1525, 334);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(92, 17);
            this.label9.TabIndex = 11;
            this.label9.Text = "Cube (CBM) :";
            // 
            // lblContainerWeight
            // 
            this.lblContainerWeight.Location = new System.Drawing.Point(1423, 353);
            this.lblContainerWeight.Name = "lblContainerWeight";
            this.lblContainerWeight.Size = new System.Drawing.Size(69, 17);
            this.lblContainerWeight.TabIndex = 10;
            this.lblContainerWeight.Text = "0";
            this.lblContainerWeight.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(10, 2);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(150, 17);
            this.label12.TabIndex = 0;
            this.label12.Text = "Container Packing :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1417, 334);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 17);
            this.label6.TabIndex = 9;
            this.label6.Text = "Weight (MT):";
            // 
            // dgvShipmentContainerPacking
            // 
            this.dgvShipmentContainerPacking.AllowUserToAddRows = false;
            this.dgvShipmentContainerPacking.AllowUserToDeleteRows = false;
            this.dgvShipmentContainerPacking.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvShipmentContainerPacking.Enabled = false;
            this.dgvShipmentContainerPacking.Location = new System.Drawing.Point(13, 94);
            this.dgvShipmentContainerPacking.Name = "dgvShipmentContainerPacking";
            this.dgvShipmentContainerPacking.ReadOnly = true;
            this.dgvShipmentContainerPacking.RowHeadersWidth = 51;
            this.dgvShipmentContainerPacking.RowTemplate.Height = 24;
            this.dgvShipmentContainerPacking.Size = new System.Drawing.Size(1786, 222);
            this.dgvShipmentContainerPacking.TabIndex = 1;
            this.dgvShipmentContainerPacking.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvShipmentContainerPacking_CellContentClick);
            this.dgvShipmentContainerPacking.Click += new System.EventHandler(this.DgvShipmentContainerPacking_Click);
            // 
            // lblContainerPackages
            // 
            this.lblContainerPackages.Location = new System.Drawing.Point(1219, 353);
            this.lblContainerPackages.Name = "lblContainerPackages";
            this.lblContainerPackages.Size = new System.Drawing.Size(69, 17);
            this.lblContainerPackages.TabIndex = 5;
            this.lblContainerPackages.Text = "0";
            this.lblContainerPackages.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1321, 334);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Packing Lines :";
            // 
            // grpPacking
            // 
            this.grpPacking.Location = new System.Drawing.Point(6, 362);
            this.grpPacking.Name = "grpPacking";
            this.grpPacking.Size = new System.Drawing.Size(1211, 79);
            this.grpPacking.TabIndex = 19;
            this.grpPacking.TabStop = false;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(193, 78);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(148, 17);
            this.label15.TabIndex = 8;
            this.label15.Text = "Cube capacity (CBM) :";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(5, 78);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(150, 17);
            this.label14.TabIndex = 6;
            this.label14.Text = "Weight capacity (MT) :";
            // 
            // txtContainerCapacityCube
            // 
            this.txtContainerCapacityCube.Enabled = false;
            this.txtContainerCapacityCube.Location = new System.Drawing.Point(257, 100);
            this.txtContainerCapacityCube.Name = "txtContainerCapacityCube";
            this.txtContainerCapacityCube.Size = new System.Drawing.Size(84, 22);
            this.txtContainerCapacityCube.TabIndex = 9;
            this.txtContainerCapacityCube.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtContainerCapacityWeight
            // 
            this.txtContainerCapacityWeight.Enabled = false;
            this.txtContainerCapacityWeight.Location = new System.Drawing.Point(76, 100);
            this.txtContainerCapacityWeight.Name = "txtContainerCapacityWeight";
            this.txtContainerCapacityWeight.Size = new System.Drawing.Size(79, 22);
            this.txtContainerCapacityWeight.TabIndex = 7;
            this.txtContainerCapacityWeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(1270, 40);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(150, 17);
            this.label13.TabIndex = 4;
            this.label13.Text = "Container description :";
            // 
            // txtContainerDescription
            // 
            this.txtContainerDescription.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtContainerDescription.Enabled = false;
            this.txtContainerDescription.Location = new System.Drawing.Point(1271, 61);
            this.txtContainerDescription.Name = "txtContainerDescription";
            this.txtContainerDescription.Size = new System.Drawing.Size(331, 22);
            this.txtContainerDescription.TabIndex = 5;
            // 
            // btnAddUpdateContainer
            // 
            this.btnAddUpdateContainer.Enabled = false;
            this.btnAddUpdateContainer.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddUpdateContainer.Location = new System.Drawing.Point(1260, 170);
            this.btnAddUpdateContainer.Name = "btnAddUpdateContainer";
            this.btnAddUpdateContainer.Size = new System.Drawing.Size(361, 26);
            this.btnAddUpdateContainer.TabIndex = 10;
            this.btnAddUpdateContainer.Text = "Add New Container";
            this.btnAddUpdateContainer.UseVisualStyleBackColor = true;
            this.btnAddUpdateContainer.Click += new System.EventHandler(this.BtnAddUpdateContainer_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgvContainer);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.btnAddUpdateContainer);
            this.groupBox3.Controls.Add(this.txtContainerDescription);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.groupBox2);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(12, 140);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1637, 202);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            // 
            // dgvContainer
            // 
            this.dgvContainer.AllowUserToAddRows = false;
            this.dgvContainer.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvContainer.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvContainer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvContainer.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvContainer.Location = new System.Drawing.Point(13, 33);
            this.dgvContainer.Name = "dgvContainer";
            this.dgvContainer.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvContainer.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvContainer.RowHeadersWidth = 51;
            this.dgvContainer.RowTemplate.Height = 24;
            this.dgvContainer.Size = new System.Drawing.Size(1232, 147);
            this.dgvContainer.TabIndex = 1;
            this.dgvContainer.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvContainer_CellContentClick);
            this.dgvContainer.Click += new System.EventHandler(this.DgvContainer_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(10, 1);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(160, 17);
            this.label7.TabIndex = 0;
            this.label7.Text = "Container Selection :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtContainerCapacityWeight);
            this.groupBox2.Controls.Add(this.txtContainerCapacityCube);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Location = new System.Drawing.Point(1260, 25);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(361, 140);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            // 
            // btnQuit
            // 
            this.btnQuit.Location = new System.Drawing.Point(1625, 1169);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(170, 27);
            this.btnQuit.TabIndex = 7;
            this.btnQuit.Text = "Quit";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.BtnQuit_Click);
            // 
            // btnMessage
            // 
            this.btnMessage.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMessage.Location = new System.Drawing.Point(1436, 1171);
            this.btnMessage.Name = "btnMessage";
            this.btnMessage.Size = new System.Drawing.Size(170, 25);
            this.btnMessage.TabIndex = 6;
            this.btnMessage.Text = "Message";
            this.btnMessage.UseVisualStyleBackColor = true;
            this.btnMessage.Click += new System.EventHandler(this.BtnMessage_Click);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(1726, 1199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 17);
            this.label3.TabIndex = 8;
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnCalculator
            // 
            this.btnCalculator.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculator.Location = new System.Drawing.Point(1280, 1165);
            this.btnCalculator.Name = "btnCalculator";
            this.btnCalculator.Size = new System.Drawing.Size(147, 45);
            this.btnCalculator.TabIndex = 18;
            this.btnCalculator.Text = "Clear All Grid Selections";
            this.btnCalculator.UseVisualStyleBackColor = true;
            this.btnCalculator.Click += new System.EventHandler(this.BtnCalculator_Click);
            // 
            // btnUpdateShipmentStats
            // 
            this.btnUpdateShipmentStats.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateShipmentStats.Location = new System.Drawing.Point(12, 1153);
            this.btnUpdateShipmentStats.Name = "btnUpdateShipmentStats";
            this.btnUpdateShipmentStats.Size = new System.Drawing.Size(204, 26);
            this.btnUpdateShipmentStats.TabIndex = 19;
            this.btnUpdateShipmentStats.Text = "Update Shipment Stats";
            this.btnUpdateShipmentStats.UseVisualStyleBackColor = true;
            this.btnUpdateShipmentStats.Click += new System.EventHandler(this.BtnUpdateShipmentStats_Click);
            // 
            // btnUpdateContainerStats
            // 
            this.btnUpdateContainerStats.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateContainerStats.Location = new System.Drawing.Point(12, 1185);
            this.btnUpdateContainerStats.Name = "btnUpdateContainerStats";
            this.btnUpdateContainerStats.Size = new System.Drawing.Size(204, 26);
            this.btnUpdateContainerStats.TabIndex = 20;
            this.btnUpdateContainerStats.Text = "Update Container Stats";
            this.btnUpdateContainerStats.UseVisualStyleBackColor = true;
            this.btnUpdateContainerStats.Click += new System.EventHandler(this.BtnUpdateContainerStats_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 17);
            this.label2.TabIndex = 17;
            this.label2.Text = "Shipment container ID :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(176, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(150, 17);
            this.label5.TabIndex = 25;
            this.label5.Text = "Container description :";
            // 
            // txtListDisplay
            // 
            this.txtListDisplay.Location = new System.Drawing.Point(425, 1121);
            this.txtListDisplay.Multiline = true;
            this.txtListDisplay.Name = "txtListDisplay";
            this.txtListDisplay.Size = new System.Drawing.Size(680, 101);
            this.txtListDisplay.TabIndex = 21;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1122, 1121);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(146, 30);
            this.button1.TabIndex = 22;
            this.button1.Text = "Print container list";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1122, 1157);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(146, 30);
            this.button2.TabIndex = 23;
            this.button2.Text = "Print packing list";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1855, 1230);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtListDisplay);
            this.Controls.Add(this.btnUpdateContainerStats);
            this.Controls.Add(this.btnUpdateShipmentStats);
            this.Controls.Add(this.btnCalculator);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnMessage);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox3);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Container Packer";
            this.Load += new System.EventHandler(this.Main_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShipmentContainer)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShipmentContainerPacking)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContainer)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtShipmentName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPackingQty;
        private System.Windows.Forms.TextBox txtPackageLength;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.TextBox txtPackageDescription;
        private System.Windows.Forms.Button btnAddPackingToContainer;
        private System.Windows.Forms.TextBox txtPackageHeight;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.TextBox txtPackageDepth;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.TextBox txtPackageWeight;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtContainerCapacityCube;
        private System.Windows.Forms.TextBox txtContainerCapacityWeight;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtContainerDescription;
        private System.Windows.Forms.Button btnAddUpdateContainer;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dgvShipmentContainer;
        private System.Windows.Forms.DataGridView dgvContainer;
        private System.Windows.Forms.DataGridView dgvShipmentContainerPacking;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.Label lblShipmentCube;
        private System.Windows.Forms.Label lblShipmentWeight;
        private System.Windows.Forms.Label lblShipmentContainers;
        private System.Windows.Forms.Label lblShipmentPackages;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.Button btnCreateShipment;
        private System.Windows.Forms.Button btnMessage;
        private System.Windows.Forms.Label lblContainerPackages;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblContainerCube;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblContainerWeight;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblContainerPackageLines;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnCalculator;
        private System.Windows.Forms.GroupBox grpPacking;
        private System.Windows.Forms.Button btnGenerateTestPackingData;
        private System.Windows.Forms.Label lblShipmentPackageLines;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnUpdateShipmentStats;
        private System.Windows.Forms.Button btnUpdateContainerStats;
        private System.Windows.Forms.TextBox txtShipmentContainerID;
        private System.Windows.Forms.TextBox txtShipmentContainerDescription;
        private System.Windows.Forms.Button btnCloseContainer;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtListDisplay;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

