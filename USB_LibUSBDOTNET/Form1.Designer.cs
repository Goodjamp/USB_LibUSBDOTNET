namespace USB_LibUSBDOTNET
{
    partial class Form1
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
            this.buttonTakeUSBDev = new System.Windows.Forms.Button();
            this.groupBoxDeviceDescription = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lableSerial = new System.Windows.Forms.Label();
            this.lableProducte = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lableManufacture = new System.Windows.Forms.Label();
            this.lableDevicePID = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lableDeviceVID = new System.Windows.Forms.Label();
            this.labelNumRegDeviceMarker = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.listBoxDeviceDescription = new System.Windows.Forms.ListBox();
            this.groupBoxConfigurationDescription = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.listBoxRxEP1 = new System.Windows.Forms.ListBox();
            this.button_Open = new System.Windows.Forms.Button();
            this.button_Send = new System.Windows.Forms.Button();
            this.textBoxSend = new System.Windows.Forms.TextBox();
            this.instalDev = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.comboBoxMemTarget = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.comboBoxWR_DevAdres = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.button_WriteRegisters = new System.Windows.Forms.Button();
            this.textBoxWR_Data = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxWR_Num = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxWR_Address = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.comboBoxRR_DevAdres = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.button_ReadRegisters = new System.Windows.Forms.Button();
            this.textBoxRR_Num = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxRR_Reg = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.button_Refresh = new System.Windows.Forms.Button();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.button_UnMute = new System.Windows.Forms.Button();
            this.button_GetMute = new System.Windows.Forms.Button();
            this.button_Mute = new System.Windows.Forms.Button();
            this.button_CloseInterface = new System.Windows.Forms.Button();
            this.groupBoxDeviceDescription.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBoxConfigurationDescription.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonTakeUSBDev
            // 
            this.buttonTakeUSBDev.Location = new System.Drawing.Point(10, 11);
            this.buttonTakeUSBDev.Name = "buttonTakeUSBDev";
            this.buttonTakeUSBDev.Size = new System.Drawing.Size(129, 23);
            this.buttonTakeUSBDev.TabIndex = 0;
            this.buttonTakeUSBDev.Text = "Take list of USB devices";
            this.buttonTakeUSBDev.UseVisualStyleBackColor = true;
            this.buttonTakeUSBDev.Click += new System.EventHandler(this.buttonTakeUSBDev_Click);
            // 
            // groupBoxDeviceDescription
            // 
            this.groupBoxDeviceDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxDeviceDescription.Controls.Add(this.tableLayoutPanel1);
            this.groupBoxDeviceDescription.Controls.Add(this.listBoxDeviceDescription);
            this.groupBoxDeviceDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxDeviceDescription.Location = new System.Drawing.Point(10, 40);
            this.groupBoxDeviceDescription.Name = "groupBoxDeviceDescription";
            this.groupBoxDeviceDescription.Size = new System.Drawing.Size(665, 120);
            this.groupBoxDeviceDescription.TabIndex = 1;
            this.groupBoxDeviceDescription.TabStop = false;
            this.groupBoxDeviceDescription.Text = "List of devices";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.Controls.Add(this.lableSerial, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.lableProducte, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.lableManufacture, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.lableDevicePID, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lableDeviceVID, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelNumRegDeviceMarker, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(134, 10);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.00059F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0006F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0006F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.9986F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.9996F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(522, 105);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // lableSerial
            // 
            this.lableSerial.AutoSize = true;
            this.lableSerial.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lableSerial.Location = new System.Drawing.Point(160, 83);
            this.lableSerial.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lableSerial.Name = "lableSerial";
            this.lableSerial.Size = new System.Drawing.Size(11, 15);
            this.lableSerial.TabIndex = 8;
            this.lableSerial.Text = "-";
            this.lableSerial.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lableProducte
            // 
            this.lableProducte.AutoSize = true;
            this.lableProducte.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lableProducte.Location = new System.Drawing.Point(160, 63);
            this.lableProducte.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lableProducte.Name = "lableProducte";
            this.lableProducte.Size = new System.Drawing.Size(11, 15);
            this.lableProducte.TabIndex = 8;
            this.lableProducte.Text = "-";
            this.lableProducte.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(4, 63);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 15);
            this.label6.TabIndex = 8;
            this.label6.Text = "Producte";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(4, 83);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 15);
            this.label5.TabIndex = 6;
            this.label5.Text = "Serial";
            // 
            // lableManufacture
            // 
            this.lableManufacture.AutoSize = true;
            this.lableManufacture.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lableManufacture.Location = new System.Drawing.Point(160, 42);
            this.lableManufacture.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lableManufacture.Name = "lableManufacture";
            this.lableManufacture.Size = new System.Drawing.Size(11, 15);
            this.lableManufacture.TabIndex = 7;
            this.lableManufacture.Text = "-";
            this.lableManufacture.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lableDevicePID
            // 
            this.lableDevicePID.AutoSize = true;
            this.lableDevicePID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lableDevicePID.Location = new System.Drawing.Point(160, 21);
            this.lableDevicePID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lableDevicePID.Name = "lableDevicePID";
            this.lableDevicePID.Size = new System.Drawing.Size(11, 15);
            this.lableDevicePID.TabIndex = 6;
            this.lableDevicePID.Text = "-";
            this.lableDevicePID.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(4, 42);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Manufacture";
            // 
            // lableDeviceVID
            // 
            this.lableDeviceVID.AutoSize = true;
            this.lableDeviceVID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lableDeviceVID.Location = new System.Drawing.Point(160, 0);
            this.lableDeviceVID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lableDeviceVID.Name = "lableDeviceVID";
            this.lableDeviceVID.Size = new System.Drawing.Size(11, 15);
            this.lableDeviceVID.TabIndex = 5;
            this.lableDeviceVID.Text = "-";
            this.lableDeviceVID.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelNumRegDeviceMarker
            // 
            this.labelNumRegDeviceMarker.AutoSize = true;
            this.labelNumRegDeviceMarker.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelNumRegDeviceMarker.Location = new System.Drawing.Point(4, 4);
            this.labelNumRegDeviceMarker.Margin = new System.Windows.Forms.Padding(4);
            this.labelNumRegDeviceMarker.Name = "labelNumRegDeviceMarker";
            this.labelNumRegDeviceMarker.Size = new System.Drawing.Size(70, 13);
            this.labelNumRegDeviceMarker.TabIndex = 1;
            this.labelNumRegDeviceMarker.Text = "device VID: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(4, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "device PID: ";
            // 
            // listBoxDeviceDescription
            // 
            this.listBoxDeviceDescription.FormattingEnabled = true;
            this.listBoxDeviceDescription.ItemHeight = 16;
            this.listBoxDeviceDescription.Items.AddRange(new object[] {
            "NuN"});
            this.listBoxDeviceDescription.Location = new System.Drawing.Point(6, 19);
            this.listBoxDeviceDescription.Name = "listBoxDeviceDescription";
            this.listBoxDeviceDescription.Size = new System.Drawing.Size(123, 84);
            this.listBoxDeviceDescription.TabIndex = 0;
            this.listBoxDeviceDescription.SelectedIndexChanged += new System.EventHandler(this.listBoxDeviceDescription_SelectedIndexChanged);
            // 
            // groupBoxConfigurationDescription
            // 
            this.groupBoxConfigurationDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxConfigurationDescription.Controls.Add(this.button1);
            this.groupBoxConfigurationDescription.Controls.Add(this.listBoxRxEP1);
            this.groupBoxConfigurationDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxConfigurationDescription.Location = new System.Drawing.Point(10, 365);
            this.groupBoxConfigurationDescription.Name = "groupBoxConfigurationDescription";
            this.groupBoxConfigurationDescription.Size = new System.Drawing.Size(665, 178);
            this.groupBoxConfigurationDescription.TabIndex = 3;
            this.groupBoxConfigurationDescription.TabStop = false;
            this.groupBoxConfigurationDescription.Text = "EndPoint 1 Rx data";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(6, 143);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(650, 26);
            this.button1.TabIndex = 1;
            this.button1.Text = "CLEAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBoxRxEP1
            // 
            this.listBoxRxEP1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxRxEP1.FormattingEnabled = true;
            this.listBoxRxEP1.HorizontalScrollbar = true;
            this.listBoxRxEP1.ItemHeight = 16;
            this.listBoxRxEP1.Location = new System.Drawing.Point(6, 22);
            this.listBoxRxEP1.Name = "listBoxRxEP1";
            this.listBoxRxEP1.Size = new System.Drawing.Size(650, 116);
            this.listBoxRxEP1.TabIndex = 0;
            // 
            // button_Open
            // 
            this.button_Open.Enabled = false;
            this.button_Open.Location = new System.Drawing.Point(144, 11);
            this.button_Open.Name = "button_Open";
            this.button_Open.Size = new System.Drawing.Size(86, 23);
            this.button_Open.TabIndex = 4;
            this.button_Open.Text = "OPEN";
            this.button_Open.UseVisualStyleBackColor = true;
            this.button_Open.Click += new System.EventHandler(this.buttonOpen_Click);
            // 
            // button_Send
            // 
            this.button_Send.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Send.Location = new System.Drawing.Point(5, 41);
            this.button_Send.Margin = new System.Windows.Forms.Padding(2);
            this.button_Send.Name = "button_Send";
            this.button_Send.Size = new System.Drawing.Size(133, 32);
            this.button_Send.TabIndex = 5;
            this.button_Send.Text = "SEND";
            this.button_Send.UseVisualStyleBackColor = true;
            this.button_Send.Click += new System.EventHandler(this.buttonSend_Click);
            // 
            // textBoxSend
            // 
            this.textBoxSend.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxSend.Location = new System.Drawing.Point(5, 5);
            this.textBoxSend.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxSend.Name = "textBoxSend";
            this.textBoxSend.Size = new System.Drawing.Size(641, 23);
            this.textBoxSend.TabIndex = 6;
            // 
            // instalDev
            // 
            this.instalDev.Location = new System.Drawing.Point(533, 11);
            this.instalDev.Name = "instalDev";
            this.instalDev.Size = new System.Drawing.Size(142, 23);
            this.instalDev.TabIndex = 14;
            this.instalDev.Text = "instal Dev";
            this.instalDev.UseVisualStyleBackColor = true;
            this.instalDev.Click += new System.EventHandler(this.instalDev_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Location = new System.Drawing.Point(10, 166);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(665, 193);
            this.tabControl1.TabIndex = 15;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.textBoxSend);
            this.tabPage1.Controls.Add(this.button_Send);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(657, 167);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Send RawData";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.comboBoxMemTarget);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.comboBoxWR_DevAdres);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.button_WriteRegisters);
            this.tabPage2.Controls.Add(this.textBoxWR_Data);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.textBoxWR_Num);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.textBoxWR_Address);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(657, 167);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Write Register";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // comboBoxMemTarget
            // 
            this.comboBoxMemTarget.FormattingEnabled = true;
            this.comboBoxMemTarget.Items.AddRange(new object[] {
            "INT",
            "DEVICE",
            "INT_DEVICE"});
            this.comboBoxMemTarget.Location = new System.Drawing.Point(279, 15);
            this.comboBoxMemTarget.Name = "comboBoxMemTarget";
            this.comboBoxMemTarget.Size = new System.Drawing.Size(92, 21);
            this.comboBoxMemTarget.TabIndex = 17;
            this.comboBoxMemTarget.Text = "INT_DEVICE";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(176, 15);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(97, 18);
            this.label12.TabIndex = 16;
            this.label12.Text = "Address Reg:";
            // 
            // comboBoxWR_DevAdres
            // 
            this.comboBoxWR_DevAdres.FormattingEnabled = true;
            this.comboBoxWR_DevAdres.Items.AddRange(new object[] {
            "20",
            "21",
            "22",
            "23"});
            this.comboBoxWR_DevAdres.Location = new System.Drawing.Point(111, 67);
            this.comboBoxWR_DevAdres.Name = "comboBoxWR_DevAdres";
            this.comboBoxWR_DevAdres.Size = new System.Drawing.Size(47, 21);
            this.comboBoxWR_DevAdres.TabIndex = 15;
            this.comboBoxWR_DevAdres.Text = "20";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(7, 67);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(104, 18);
            this.label11.TabIndex = 14;
            this.label11.Text = "Dev Addresss:";
            // 
            // button_WriteRegisters
            // 
            this.button_WriteRegisters.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_WriteRegisters.Location = new System.Drawing.Point(10, 129);
            this.button_WriteRegisters.Margin = new System.Windows.Forms.Padding(2);
            this.button_WriteRegisters.Name = "button_WriteRegisters";
            this.button_WriteRegisters.Size = new System.Drawing.Size(133, 32);
            this.button_WriteRegisters.TabIndex = 6;
            this.button_WriteRegisters.Text = "Write Registers";
            this.button_WriteRegisters.UseVisualStyleBackColor = true;
            this.button_WriteRegisters.Click += new System.EventHandler(this.buttonWR_Send_Click);
            // 
            // textBoxWR_Data
            // 
            this.textBoxWR_Data.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxWR_Data.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxWR_Data.Location = new System.Drawing.Point(111, 94);
            this.textBoxWR_Data.Name = "textBoxWR_Data";
            this.textBoxWR_Data.Size = new System.Drawing.Size(519, 21);
            this.textBoxWR_Data.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(7, 94);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 18);
            this.label7.TabIndex = 4;
            this.label7.Text = "Data:";
            // 
            // textBoxWR_Num
            // 
            this.textBoxWR_Num.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxWR_Num.Location = new System.Drawing.Point(111, 42);
            this.textBoxWR_Num.Name = "textBoxWR_Num";
            this.textBoxWR_Num.Size = new System.Drawing.Size(47, 21);
            this.textBoxWR_Num.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(6, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 18);
            this.label4.TabIndex = 2;
            this.label4.Text = "Number Reg:";
            // 
            // textBoxWR_Address
            // 
            this.textBoxWR_Address.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxWR_Address.Location = new System.Drawing.Point(111, 15);
            this.textBoxWR_Address.Name = "textBoxWR_Address";
            this.textBoxWR_Address.Size = new System.Drawing.Size(46, 21);
            this.textBoxWR_Address.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(7, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Address Reg:";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.comboBoxRR_DevAdres);
            this.tabPage3.Controls.Add(this.label10);
            this.tabPage3.Controls.Add(this.button_ReadRegisters);
            this.tabPage3.Controls.Add(this.textBoxRR_Num);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Controls.Add(this.textBoxRR_Reg);
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(657, 167);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Read Register";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // comboBoxRR_DevAdres
            // 
            this.comboBoxRR_DevAdres.FormattingEnabled = true;
            this.comboBoxRR_DevAdres.Items.AddRange(new object[] {
            "20",
            "21",
            "22",
            "23"});
            this.comboBoxRR_DevAdres.Location = new System.Drawing.Point(109, 58);
            this.comboBoxRR_DevAdres.Name = "comboBoxRR_DevAdres";
            this.comboBoxRR_DevAdres.Size = new System.Drawing.Size(47, 21);
            this.comboBoxRR_DevAdres.TabIndex = 13;
            this.comboBoxRR_DevAdres.Text = "20";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(5, 58);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(104, 18);
            this.label10.TabIndex = 12;
            this.label10.Text = "Dev Addresss:";
            // 
            // button_ReadRegisters
            // 
            this.button_ReadRegisters.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_ReadRegisters.Location = new System.Drawing.Point(5, 84);
            this.button_ReadRegisters.Margin = new System.Windows.Forms.Padding(2);
            this.button_ReadRegisters.Name = "button_ReadRegisters";
            this.button_ReadRegisters.Size = new System.Drawing.Size(133, 32);
            this.button_ReadRegisters.TabIndex = 11;
            this.button_ReadRegisters.Text = "Read Registers";
            this.button_ReadRegisters.UseVisualStyleBackColor = true;
            this.button_ReadRegisters.Click += new System.EventHandler(this.buttonRR_Send_Click);
            // 
            // textBoxRR_Num
            // 
            this.textBoxRR_Num.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxRR_Num.Location = new System.Drawing.Point(109, 30);
            this.textBoxRR_Num.Name = "textBoxRR_Num";
            this.textBoxRR_Num.Size = new System.Drawing.Size(47, 21);
            this.textBoxRR_Num.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(5, 30);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 18);
            this.label8.TabIndex = 9;
            this.label8.Text = "Number Reg:";
            // 
            // textBoxRR_Reg
            // 
            this.textBoxRR_Reg.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxRR_Reg.Location = new System.Drawing.Point(109, 3);
            this.textBoxRR_Reg.Name = "textBoxRR_Reg";
            this.textBoxRR_Reg.Size = new System.Drawing.Size(46, 21);
            this.textBoxRR_Reg.TabIndex = 8;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(6, 3);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(97, 18);
            this.label9.TabIndex = 7;
            this.label9.Text = "Address Reg:";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.button_Refresh);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(657, 167);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Refresh";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // button_Refresh
            // 
            this.button_Refresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Refresh.Location = new System.Drawing.Point(5, 5);
            this.button_Refresh.Margin = new System.Windows.Forms.Padding(2);
            this.button_Refresh.Name = "button_Refresh";
            this.button_Refresh.Size = new System.Drawing.Size(133, 32);
            this.button_Refresh.TabIndex = 7;
            this.button_Refresh.Text = "Refresh";
            this.button_Refresh.UseVisualStyleBackColor = true;
            this.button_Refresh.Click += new System.EventHandler(this.buttonRF_Send_Click);
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.button_UnMute);
            this.tabPage5.Controls.Add(this.button_GetMute);
            this.tabPage5.Controls.Add(this.button_Mute);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(657, 167);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Mute";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // button_UnMute
            // 
            this.button_UnMute.Location = new System.Drawing.Point(3, 45);
            this.button_UnMute.Name = "button_UnMute";
            this.button_UnMute.Size = new System.Drawing.Size(95, 35);
            this.button_UnMute.TabIndex = 2;
            this.button_UnMute.Text = "UN MUTE";
            this.button_UnMute.UseVisualStyleBackColor = true;
            this.button_UnMute.Click += new System.EventHandler(this.button_UnMute_Click);
            // 
            // button_GetMute
            // 
            this.button_GetMute.Location = new System.Drawing.Point(115, 4);
            this.button_GetMute.Name = "button_GetMute";
            this.button_GetMute.Size = new System.Drawing.Size(101, 35);
            this.button_GetMute.TabIndex = 1;
            this.button_GetMute.Text = "GET MUTE";
            this.button_GetMute.UseVisualStyleBackColor = true;
            this.button_GetMute.Click += new System.EventHandler(this.button_GetMute_Click);
            // 
            // button_Mute
            // 
            this.button_Mute.Location = new System.Drawing.Point(3, 4);
            this.button_Mute.Name = "button_Mute";
            this.button_Mute.Size = new System.Drawing.Size(95, 35);
            this.button_Mute.TabIndex = 0;
            this.button_Mute.Text = "MUTE";
            this.button_Mute.UseVisualStyleBackColor = true;
            this.button_Mute.Click += new System.EventHandler(this.button_Mute_Click);
            // 
            // button_CloseInterface
            // 
            this.button_CloseInterface.Enabled = false;
            this.button_CloseInterface.Location = new System.Drawing.Point(236, 11);
            this.button_CloseInterface.Name = "button_CloseInterface";
            this.button_CloseInterface.Size = new System.Drawing.Size(86, 23);
            this.button_CloseInterface.TabIndex = 16;
            this.button_CloseInterface.Text = "CLOSE";
            this.button_CloseInterface.UseVisualStyleBackColor = true;
            this.button_CloseInterface.Click += new System.EventHandler(this.buttonCloseInterface_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 548);
            this.Controls.Add(this.button_CloseInterface);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.instalDev);
            this.Controls.Add(this.button_Open);
            this.Controls.Add(this.groupBoxConfigurationDescription);
            this.Controls.Add(this.groupBoxDeviceDescription);
            this.Controls.Add(this.buttonTakeUSBDev);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_CLose);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBoxDeviceDescription.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.groupBoxConfigurationDescription.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonTakeUSBDev;
        private System.Windows.Forms.GroupBox groupBoxDeviceDescription;
        private System.Windows.Forms.ListBox listBoxDeviceDescription;
        private System.Windows.Forms.GroupBox groupBoxConfigurationDescription;
        private System.Windows.Forms.ListBox listBoxRxEP1;
        private System.Windows.Forms.Label labelNumRegDeviceMarker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lableDeviceVID;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lableManufacture;
        private System.Windows.Forms.Label lableDevicePID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lableSerial;
        private System.Windows.Forms.Label lableProducte;
        private System.Windows.Forms.Button button_Open;
        private System.Windows.Forms.Button button_Send;
        private System.Windows.Forms.TextBox textBoxSend;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button instalDev;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_WriteRegisters;
        private System.Windows.Forms.TextBox textBoxWR_Data;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxWR_Num;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxWR_Address;
        private System.Windows.Forms.Button button_ReadRegisters;
        private System.Windows.Forms.TextBox textBoxRR_Num;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxRR_Reg;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button_Refresh;
        private System.Windows.Forms.ComboBox comboBoxWR_DevAdres;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox comboBoxRR_DevAdres;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox comboBoxMemTarget;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button button_UnMute;
        private System.Windows.Forms.Button button_GetMute;
        private System.Windows.Forms.Button button_Mute;
        private System.Windows.Forms.Button button_CloseInterface;

    }
}

