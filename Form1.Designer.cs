namespace Sample_References
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
            this.lbl_DeviceNameBlock = new System.Windows.Forms.Label();
            this.txt_ReturnCode = new System.Windows.Forms.TextBox();
            this.btn_EntryDeviceStatus = new System.Windows.Forms.Button();
            this.grp_Output = new System.Windows.Forms.GroupBox();
            this.lbl_RetrunCode = new System.Windows.Forms.Label();
            this.lbl_Data = new System.Windows.Forms.Label();
            this.txt_Data = new System.Windows.Forms.TextBox();
            this.btn_ReadDeviceBlock2 = new System.Windows.Forms.Button();
            this.btn_FreeDeviceStatus = new System.Windows.Forms.Button();
            this.btn_Open = new System.Windows.Forms.Button();
            this.btn_Close = new System.Windows.Forms.Button();
            this.txt_DeviceSizeStatus = new System.Windows.Forms.TextBox();
            this.txt_DeviceDataStatus = new System.Windows.Forms.TextBox();
            this.txt_LogicalStationNumber = new System.Windows.Forms.TextBox();
            this.lbl_DeviceSizeStatus = new System.Windows.Forms.Label();
            this.txt_DeviceSizeBlock = new System.Windows.Forms.TextBox();
            this.txt_DeviceDataBlock = new System.Windows.Forms.TextBox();
            this.lbl_DeviceSizeBlock = new System.Windows.Forms.Label();
            this.txt_Password = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.rad_ActUtlType = new System.Windows.Forms.RadioButton();
            this.lbl_DeviceDataBlock = new System.Windows.Forms.Label();
            this.lbl_MonitorCycleStatus = new System.Windows.Forms.Label();
            this.txt_DeviceNameStatus = new System.Windows.Forms.TextBox();
            this.txt_MonitorCycleStatus = new System.Windows.Forms.TextBox();
            this.rad_ActProgType = new System.Windows.Forms.RadioButton();
            this.grp_Control = new System.Windows.Forms.GroupBox();
            this.lbl_LogicalStationNumber = new System.Windows.Forms.Label();
            this.lbl_DeviceNameStatus = new System.Windows.Forms.Label();
            this.lbl_DeviceNameRandom = new System.Windows.Forms.Label();
            this.btn_WriteDeviceBlock2 = new System.Windows.Forms.Button();
            this.btn_ReadDeviceRandom2 = new System.Windows.Forms.Button();
            this.btn_WriteDeviceRandom2 = new System.Windows.Forms.Button();
            this.txt_DeviceNameRandom = new System.Windows.Forms.TextBox();
            this.grp_Random = new System.Windows.Forms.GroupBox();
            this.txt_DeviceSizeRandom = new System.Windows.Forms.TextBox();
            this.txt_DeviceDataRandom = new System.Windows.Forms.TextBox();
            this.lbl_DeviceSizeRandom = new System.Windows.Forms.Label();
            this.lbl_DeviceDataRandom = new System.Windows.Forms.Label();
            this.txt_DeviceNameBlock = new System.Windows.Forms.TextBox();
            this.lbl_DeviceDataStatus = new System.Windows.Forms.Label();
            this.grp_Status = new System.Windows.Forms.GroupBox();
            this.grp_Block = new System.Windows.Forms.GroupBox();
            this.grp_Output.SuspendLayout();
            this.grp_Control.SuspendLayout();
            this.grp_Random.SuspendLayout();
            this.grp_Status.SuspendLayout();
            this.grp_Block.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_DeviceNameBlock
            // 
            this.lbl_DeviceNameBlock.Location = new System.Drawing.Point(24, 16);
            this.lbl_DeviceNameBlock.Name = "lbl_DeviceNameBlock";
            this.lbl_DeviceNameBlock.Size = new System.Drawing.Size(88, 16);
            this.lbl_DeviceNameBlock.TabIndex = 30;
            this.lbl_DeviceNameBlock.Text = "DevicelName:";
            // 
            // txt_ReturnCode
            // 
            this.txt_ReturnCode.Location = new System.Drawing.Point(104, 16);
            this.txt_ReturnCode.Name = "txt_ReturnCode";
            this.txt_ReturnCode.ReadOnly = true;
            this.txt_ReturnCode.Size = new System.Drawing.Size(128, 21);
            this.txt_ReturnCode.TabIndex = 50;
            this.txt_ReturnCode.TabStop = false;
            // 
            // btn_EntryDeviceStatus
            // 
            this.btn_EntryDeviceStatus.Location = new System.Drawing.Point(352, 24);
            this.btn_EntryDeviceStatus.Name = "btn_EntryDeviceStatus";
            this.btn_EntryDeviceStatus.Size = new System.Drawing.Size(128, 32);
            this.btn_EntryDeviceStatus.TabIndex = 45;
            this.btn_EntryDeviceStatus.Text = "EntryDeviceStatus";
            this.btn_EntryDeviceStatus.Click += new System.EventHandler(this.btn_EntryDeviceStatus_Click);
            // 
            // grp_Output
            // 
            this.grp_Output.Controls.Add(this.txt_ReturnCode);
            this.grp_Output.Controls.Add(this.lbl_RetrunCode);
            this.grp_Output.Controls.Add(this.lbl_Data);
            this.grp_Output.Controls.Add(this.txt_Data);
            this.grp_Output.Location = new System.Drawing.Point(24, 496);
            this.grp_Output.Name = "grp_Output";
            this.grp_Output.Size = new System.Drawing.Size(496, 152);
            this.grp_Output.TabIndex = 78;
            this.grp_Output.TabStop = false;
            this.grp_Output.Text = "Output";
            // 
            // lbl_RetrunCode
            // 
            this.lbl_RetrunCode.Location = new System.Drawing.Point(24, 16);
            this.lbl_RetrunCode.Name = "lbl_RetrunCode";
            this.lbl_RetrunCode.Size = new System.Drawing.Size(72, 16);
            this.lbl_RetrunCode.TabIndex = 50;
            this.lbl_RetrunCode.Text = "Return Code:";
            // 
            // lbl_Data
            // 
            this.lbl_Data.Location = new System.Drawing.Point(24, 40);
            this.lbl_Data.Name = "lbl_Data";
            this.lbl_Data.Size = new System.Drawing.Size(72, 16);
            this.lbl_Data.TabIndex = 50;
            this.lbl_Data.Text = "Data:";
            // 
            // txt_Data
            // 
            this.txt_Data.AcceptsReturn = true;
            this.txt_Data.Location = new System.Drawing.Point(24, 56);
            this.txt_Data.Multiline = true;
            this.txt_Data.Name = "txt_Data";
            this.txt_Data.ReadOnly = true;
            this.txt_Data.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_Data.Size = new System.Drawing.Size(456, 80);
            this.txt_Data.TabIndex = 50;
            this.txt_Data.TabStop = false;
            // 
            // btn_ReadDeviceBlock2
            // 
            this.btn_ReadDeviceBlock2.Location = new System.Drawing.Point(352, 24);
            this.btn_ReadDeviceBlock2.Name = "btn_ReadDeviceBlock2";
            this.btn_ReadDeviceBlock2.Size = new System.Drawing.Size(128, 32);
            this.btn_ReadDeviceBlock2.TabIndex = 34;
            this.btn_ReadDeviceBlock2.Text = "ReadDeviceBlock2";
            this.btn_ReadDeviceBlock2.Click += new System.EventHandler(this.btn_ReadDeviceBlock2_Click);
            // 
            // btn_FreeDeviceStatus
            // 
            this.btn_FreeDeviceStatus.Location = new System.Drawing.Point(352, 72);
            this.btn_FreeDeviceStatus.Name = "btn_FreeDeviceStatus";
            this.btn_FreeDeviceStatus.Size = new System.Drawing.Size(128, 32);
            this.btn_FreeDeviceStatus.TabIndex = 46;
            this.btn_FreeDeviceStatus.Text = "FreeDeviceStatus";
            this.btn_FreeDeviceStatus.Click += new System.EventHandler(this.btn_FreeDeviceStatus_Click);
            // 
            // btn_Open
            // 
            this.btn_Open.Location = new System.Drawing.Point(376, 23);
            this.btn_Open.Name = "btn_Open";
            this.btn_Open.Size = new System.Drawing.Size(128, 32);
            this.btn_Open.TabIndex = 73;
            this.btn_Open.Text = "Open";
            this.btn_Open.Click += new System.EventHandler(this.btn_Open_Click);
            // 
            // btn_Close
            // 
            this.btn_Close.Location = new System.Drawing.Point(376, 71);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(128, 32);
            this.btn_Close.TabIndex = 74;
            this.btn_Close.Text = "Close";
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // txt_DeviceSizeStatus
            // 
            this.txt_DeviceSizeStatus.Location = new System.Drawing.Point(136, 32);
            this.txt_DeviceSizeStatus.Name = "txt_DeviceSizeStatus";
            this.txt_DeviceSizeStatus.Size = new System.Drawing.Size(72, 21);
            this.txt_DeviceSizeStatus.TabIndex = 42;
            // 
            // txt_DeviceDataStatus
            // 
            this.txt_DeviceDataStatus.AcceptsReturn = true;
            this.txt_DeviceDataStatus.Location = new System.Drawing.Point(224, 32);
            this.txt_DeviceDataStatus.Multiline = true;
            this.txt_DeviceDataStatus.Name = "txt_DeviceDataStatus";
            this.txt_DeviceDataStatus.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_DeviceDataStatus.Size = new System.Drawing.Size(96, 72);
            this.txt_DeviceDataStatus.TabIndex = 44;
            // 
            // txt_LogicalStationNumber
            // 
            this.txt_LogicalStationNumber.Location = new System.Drawing.Point(272, 16);
            this.txt_LogicalStationNumber.Name = "txt_LogicalStationNumber";
            this.txt_LogicalStationNumber.Size = new System.Drawing.Size(40, 21);
            this.txt_LogicalStationNumber.TabIndex = 2;
            // 
            // lbl_DeviceSizeStatus
            // 
            this.lbl_DeviceSizeStatus.Location = new System.Drawing.Point(136, 16);
            this.lbl_DeviceSizeStatus.Name = "lbl_DeviceSizeStatus";
            this.lbl_DeviceSizeStatus.Size = new System.Drawing.Size(88, 16);
            this.lbl_DeviceSizeStatus.TabIndex = 40;
            this.lbl_DeviceSizeStatus.Text = "DataSize:";
            // 
            // txt_DeviceSizeBlock
            // 
            this.txt_DeviceSizeBlock.Location = new System.Drawing.Point(136, 32);
            this.txt_DeviceSizeBlock.Name = "txt_DeviceSizeBlock";
            this.txt_DeviceSizeBlock.Size = new System.Drawing.Size(72, 21);
            this.txt_DeviceSizeBlock.TabIndex = 32;
            // 
            // txt_DeviceDataBlock
            // 
            this.txt_DeviceDataBlock.AcceptsReturn = true;
            this.txt_DeviceDataBlock.Location = new System.Drawing.Point(224, 35);
            this.txt_DeviceDataBlock.Multiline = true;
            this.txt_DeviceDataBlock.Name = "txt_DeviceDataBlock";
            this.txt_DeviceDataBlock.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_DeviceDataBlock.Size = new System.Drawing.Size(96, 72);
            this.txt_DeviceDataBlock.TabIndex = 33;
            // 
            // lbl_DeviceSizeBlock
            // 
            this.lbl_DeviceSizeBlock.Location = new System.Drawing.Point(136, 16);
            this.lbl_DeviceSizeBlock.Name = "lbl_DeviceSizeBlock";
            this.lbl_DeviceSizeBlock.Size = new System.Drawing.Size(88, 16);
            this.lbl_DeviceSizeBlock.TabIndex = 30;
            this.lbl_DeviceSizeBlock.Text = "DataSize:";
            // 
            // txt_Password
            // 
            this.txt_Password.Location = new System.Drawing.Point(272, 39);
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.PasswordChar = '*';
            this.txt_Password.Size = new System.Drawing.Size(40, 21);
            this.txt_Password.TabIndex = 6;
            // 
            // label16
            // 
            this.label16.Location = new System.Drawing.Point(136, 39);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(67, 16);
            this.label16.TabIndex = 5;
            this.label16.Text = "Password:";
            // 
            // rad_ActUtlType
            // 
            this.rad_ActUtlType.Location = new System.Drawing.Point(16, 16);
            this.rad_ActUtlType.Name = "rad_ActUtlType";
            this.rad_ActUtlType.Size = new System.Drawing.Size(104, 20);
            this.rad_ActUtlType.TabIndex = 4;
            this.rad_ActUtlType.TabStop = true;
            this.rad_ActUtlType.Text = "ActUtlType";
            // 
            // lbl_DeviceDataBlock
            // 
            this.lbl_DeviceDataBlock.Location = new System.Drawing.Point(224, 16);
            this.lbl_DeviceDataBlock.Name = "lbl_DeviceDataBlock";
            this.lbl_DeviceDataBlock.Size = new System.Drawing.Size(88, 16);
            this.lbl_DeviceDataBlock.TabIndex = 30;
            this.lbl_DeviceDataBlock.Text = "DeviceData:";
            // 
            // lbl_MonitorCycleStatus
            // 
            this.lbl_MonitorCycleStatus.Location = new System.Drawing.Point(136, 64);
            this.lbl_MonitorCycleStatus.Name = "lbl_MonitorCycleStatus";
            this.lbl_MonitorCycleStatus.Size = new System.Drawing.Size(88, 16);
            this.lbl_MonitorCycleStatus.TabIndex = 40;
            this.lbl_MonitorCycleStatus.Text = "MonitorCycle:";
            // 
            // txt_DeviceNameStatus
            // 
            this.txt_DeviceNameStatus.AcceptsReturn = true;
            this.txt_DeviceNameStatus.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_DeviceNameStatus.Location = new System.Drawing.Point(24, 32);
            this.txt_DeviceNameStatus.Multiline = true;
            this.txt_DeviceNameStatus.Name = "txt_DeviceNameStatus";
            this.txt_DeviceNameStatus.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_DeviceNameStatus.Size = new System.Drawing.Size(96, 72);
            this.txt_DeviceNameStatus.TabIndex = 41;
            // 
            // txt_MonitorCycleStatus
            // 
            this.txt_MonitorCycleStatus.Location = new System.Drawing.Point(136, 80);
            this.txt_MonitorCycleStatus.Name = "txt_MonitorCycleStatus";
            this.txt_MonitorCycleStatus.Size = new System.Drawing.Size(72, 21);
            this.txt_MonitorCycleStatus.TabIndex = 43;
            // 
            // rad_ActProgType
            // 
            this.rad_ActProgType.Location = new System.Drawing.Point(16, 40);
            this.rad_ActProgType.Name = "rad_ActProgType";
            this.rad_ActProgType.Size = new System.Drawing.Size(104, 20);
            this.rad_ActProgType.TabIndex = 3;
            this.rad_ActProgType.Text = "ActProgType";
            // 
            // grp_Control
            // 
            this.grp_Control.Controls.Add(this.txt_Password);
            this.grp_Control.Controls.Add(this.label16);
            this.grp_Control.Controls.Add(this.rad_ActUtlType);
            this.grp_Control.Controls.Add(this.rad_ActProgType);
            this.grp_Control.Controls.Add(this.txt_LogicalStationNumber);
            this.grp_Control.Controls.Add(this.lbl_LogicalStationNumber);
            this.grp_Control.Location = new System.Drawing.Point(16, 15);
            this.grp_Control.Name = "grp_Control";
            this.grp_Control.Size = new System.Drawing.Size(344, 64);
            this.grp_Control.TabIndex = 72;
            this.grp_Control.TabStop = false;
            this.grp_Control.Text = "Control";
            // 
            // lbl_LogicalStationNumber
            // 
            this.lbl_LogicalStationNumber.Location = new System.Drawing.Point(136, 16);
            this.lbl_LogicalStationNumber.Name = "lbl_LogicalStationNumber";
            this.lbl_LogicalStationNumber.Size = new System.Drawing.Size(120, 16);
            this.lbl_LogicalStationNumber.TabIndex = 0;
            this.lbl_LogicalStationNumber.Text = "LogicalStationNumber:";
            // 
            // lbl_DeviceNameStatus
            // 
            this.lbl_DeviceNameStatus.Location = new System.Drawing.Point(24, 16);
            this.lbl_DeviceNameStatus.Name = "lbl_DeviceNameStatus";
            this.lbl_DeviceNameStatus.Size = new System.Drawing.Size(88, 16);
            this.lbl_DeviceNameStatus.TabIndex = 40;
            this.lbl_DeviceNameStatus.Text = "DevicelName:";
            // 
            // lbl_DeviceNameRandom
            // 
            this.lbl_DeviceNameRandom.Location = new System.Drawing.Point(24, 16);
            this.lbl_DeviceNameRandom.Name = "lbl_DeviceNameRandom";
            this.lbl_DeviceNameRandom.Size = new System.Drawing.Size(88, 16);
            this.lbl_DeviceNameRandom.TabIndex = 20;
            this.lbl_DeviceNameRandom.Text = "DevicelName:";
            // 
            // btn_WriteDeviceBlock2
            // 
            this.btn_WriteDeviceBlock2.Location = new System.Drawing.Point(352, 72);
            this.btn_WriteDeviceBlock2.Name = "btn_WriteDeviceBlock2";
            this.btn_WriteDeviceBlock2.Size = new System.Drawing.Size(128, 32);
            this.btn_WriteDeviceBlock2.TabIndex = 35;
            this.btn_WriteDeviceBlock2.Text = "WriteDeviceBlock2";
            this.btn_WriteDeviceBlock2.Click += new System.EventHandler(this.btn_WriteDeviceBlock2_Click);
            // 
            // btn_ReadDeviceRandom2
            // 
            this.btn_ReadDeviceRandom2.Location = new System.Drawing.Point(352, 24);
            this.btn_ReadDeviceRandom2.Name = "btn_ReadDeviceRandom2";
            this.btn_ReadDeviceRandom2.Size = new System.Drawing.Size(128, 32);
            this.btn_ReadDeviceRandom2.TabIndex = 24;
            this.btn_ReadDeviceRandom2.Text = "ReadDeviceRandom2";
            this.btn_ReadDeviceRandom2.Click += new System.EventHandler(this.btn_ReadDeviceRandom2_Click);
            // 
            // btn_WriteDeviceRandom2
            // 
            this.btn_WriteDeviceRandom2.Location = new System.Drawing.Point(352, 72);
            this.btn_WriteDeviceRandom2.Name = "btn_WriteDeviceRandom2";
            this.btn_WriteDeviceRandom2.Size = new System.Drawing.Size(128, 32);
            this.btn_WriteDeviceRandom2.TabIndex = 25;
            this.btn_WriteDeviceRandom2.Text = "WriteDeviceRandom2";
            this.btn_WriteDeviceRandom2.Click += new System.EventHandler(this.btn_WriteDeviceRandom2_Click);
            // 
            // txt_DeviceNameRandom
            // 
            this.txt_DeviceNameRandom.AcceptsReturn = true;
            this.txt_DeviceNameRandom.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_DeviceNameRandom.Location = new System.Drawing.Point(24, 32);
            this.txt_DeviceNameRandom.Multiline = true;
            this.txt_DeviceNameRandom.Name = "txt_DeviceNameRandom";
            this.txt_DeviceNameRandom.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_DeviceNameRandom.Size = new System.Drawing.Size(96, 72);
            this.txt_DeviceNameRandom.TabIndex = 21;
            // 
            // grp_Random
            // 
            this.grp_Random.Controls.Add(this.txt_DeviceNameRandom);
            this.grp_Random.Controls.Add(this.lbl_DeviceNameRandom);
            this.grp_Random.Controls.Add(this.btn_ReadDeviceRandom2);
            this.grp_Random.Controls.Add(this.btn_WriteDeviceRandom2);
            this.grp_Random.Controls.Add(this.txt_DeviceSizeRandom);
            this.grp_Random.Controls.Add(this.txt_DeviceDataRandom);
            this.grp_Random.Controls.Add(this.lbl_DeviceSizeRandom);
            this.grp_Random.Controls.Add(this.lbl_DeviceDataRandom);
            this.grp_Random.Location = new System.Drawing.Point(24, 111);
            this.grp_Random.Name = "grp_Random";
            this.grp_Random.Size = new System.Drawing.Size(496, 120);
            this.grp_Random.TabIndex = 75;
            this.grp_Random.TabStop = false;
            this.grp_Random.Text = "Random Read/Write";
            // 
            // txt_DeviceSizeRandom
            // 
            this.txt_DeviceSizeRandom.Location = new System.Drawing.Point(136, 32);
            this.txt_DeviceSizeRandom.Name = "txt_DeviceSizeRandom";
            this.txt_DeviceSizeRandom.Size = new System.Drawing.Size(72, 21);
            this.txt_DeviceSizeRandom.TabIndex = 22;
            // 
            // txt_DeviceDataRandom
            // 
            this.txt_DeviceDataRandom.AcceptsReturn = true;
            this.txt_DeviceDataRandom.Location = new System.Drawing.Point(224, 32);
            this.txt_DeviceDataRandom.Multiline = true;
            this.txt_DeviceDataRandom.Name = "txt_DeviceDataRandom";
            this.txt_DeviceDataRandom.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_DeviceDataRandom.Size = new System.Drawing.Size(96, 72);
            this.txt_DeviceDataRandom.TabIndex = 23;
            // 
            // lbl_DeviceSizeRandom
            // 
            this.lbl_DeviceSizeRandom.Location = new System.Drawing.Point(136, 16);
            this.lbl_DeviceSizeRandom.Name = "lbl_DeviceSizeRandom";
            this.lbl_DeviceSizeRandom.Size = new System.Drawing.Size(88, 16);
            this.lbl_DeviceSizeRandom.TabIndex = 20;
            this.lbl_DeviceSizeRandom.Text = "DataSize:";
            // 
            // lbl_DeviceDataRandom
            // 
            this.lbl_DeviceDataRandom.Location = new System.Drawing.Point(224, 16);
            this.lbl_DeviceDataRandom.Name = "lbl_DeviceDataRandom";
            this.lbl_DeviceDataRandom.Size = new System.Drawing.Size(88, 16);
            this.lbl_DeviceDataRandom.TabIndex = 20;
            this.lbl_DeviceDataRandom.Text = "DeviceData:";
            // 
            // txt_DeviceNameBlock
            // 
            this.txt_DeviceNameBlock.AcceptsReturn = true;
            this.txt_DeviceNameBlock.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_DeviceNameBlock.Location = new System.Drawing.Point(24, 32);
            this.txt_DeviceNameBlock.Name = "txt_DeviceNameBlock";
            this.txt_DeviceNameBlock.Size = new System.Drawing.Size(96, 21);
            this.txt_DeviceNameBlock.TabIndex = 31;
            // 
            // lbl_DeviceDataStatus
            // 
            this.lbl_DeviceDataStatus.Location = new System.Drawing.Point(224, 16);
            this.lbl_DeviceDataStatus.Name = "lbl_DeviceDataStatus";
            this.lbl_DeviceDataStatus.Size = new System.Drawing.Size(88, 16);
            this.lbl_DeviceDataStatus.TabIndex = 40;
            this.lbl_DeviceDataStatus.Text = "DeviceData:";
            // 
            // grp_Status
            // 
            this.grp_Status.Controls.Add(this.txt_MonitorCycleStatus);
            this.grp_Status.Controls.Add(this.lbl_MonitorCycleStatus);
            this.grp_Status.Controls.Add(this.txt_DeviceNameStatus);
            this.grp_Status.Controls.Add(this.lbl_DeviceNameStatus);
            this.grp_Status.Controls.Add(this.btn_EntryDeviceStatus);
            this.grp_Status.Controls.Add(this.btn_FreeDeviceStatus);
            this.grp_Status.Controls.Add(this.txt_DeviceSizeStatus);
            this.grp_Status.Controls.Add(this.txt_DeviceDataStatus);
            this.grp_Status.Controls.Add(this.lbl_DeviceSizeStatus);
            this.grp_Status.Controls.Add(this.lbl_DeviceDataStatus);
            this.grp_Status.Location = new System.Drawing.Point(24, 368);
            this.grp_Status.Name = "grp_Status";
            this.grp_Status.Size = new System.Drawing.Size(496, 120);
            this.grp_Status.TabIndex = 77;
            this.grp_Status.TabStop = false;
            this.grp_Status.Text = "Status Entry/Free";
            // 
            // grp_Block
            // 
            this.grp_Block.Controls.Add(this.txt_DeviceNameBlock);
            this.grp_Block.Controls.Add(this.lbl_DeviceNameBlock);
            this.grp_Block.Controls.Add(this.btn_ReadDeviceBlock2);
            this.grp_Block.Controls.Add(this.btn_WriteDeviceBlock2);
            this.grp_Block.Controls.Add(this.txt_DeviceSizeBlock);
            this.grp_Block.Controls.Add(this.txt_DeviceDataBlock);
            this.grp_Block.Controls.Add(this.lbl_DeviceSizeBlock);
            this.grp_Block.Controls.Add(this.lbl_DeviceDataBlock);
            this.grp_Block.Location = new System.Drawing.Point(24, 239);
            this.grp_Block.Name = "grp_Block";
            this.grp_Block.Size = new System.Drawing.Size(496, 120);
            this.grp_Block.TabIndex = 76;
            this.grp_Block.TabStop = false;
            this.grp_Block.Text = "Block Read/Write";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 662);
            this.Controls.Add(this.grp_Output);
            this.Controls.Add(this.btn_Open);
            this.Controls.Add(this.btn_Close);
            this.Controls.Add(this.grp_Control);
            this.Controls.Add(this.grp_Random);
            this.Controls.Add(this.grp_Status);
            this.Controls.Add(this.grp_Block);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grp_Output.ResumeLayout(false);
            this.grp_Output.PerformLayout();
            this.grp_Control.ResumeLayout(false);
            this.grp_Control.PerformLayout();
            this.grp_Random.ResumeLayout(false);
            this.grp_Random.PerformLayout();
            this.grp_Status.ResumeLayout(false);
            this.grp_Status.PerformLayout();
            this.grp_Block.ResumeLayout(false);
            this.grp_Block.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Label lbl_DeviceNameBlock;
        internal System.Windows.Forms.TextBox txt_ReturnCode;
        internal System.Windows.Forms.Button btn_EntryDeviceStatus;
        internal System.Windows.Forms.GroupBox grp_Output;
        internal System.Windows.Forms.Label lbl_RetrunCode;
        internal System.Windows.Forms.Label lbl_Data;
        internal System.Windows.Forms.TextBox txt_Data;
        internal System.Windows.Forms.Button btn_ReadDeviceBlock2;
        internal System.Windows.Forms.Button btn_FreeDeviceStatus;
        internal System.Windows.Forms.Button btn_Open;
        internal System.Windows.Forms.Button btn_Close;
        internal System.Windows.Forms.TextBox txt_DeviceSizeStatus;
        internal System.Windows.Forms.TextBox txt_DeviceDataStatus;
        internal System.Windows.Forms.TextBox txt_LogicalStationNumber;
        internal System.Windows.Forms.Label lbl_DeviceSizeStatus;
        internal System.Windows.Forms.TextBox txt_DeviceSizeBlock;
        internal System.Windows.Forms.TextBox txt_DeviceDataBlock;
        internal System.Windows.Forms.Label lbl_DeviceSizeBlock;
        internal System.Windows.Forms.TextBox txt_Password;
        internal System.Windows.Forms.Label label16;
        internal System.Windows.Forms.RadioButton rad_ActUtlType;
        internal System.Windows.Forms.Label lbl_DeviceDataBlock;
        internal System.Windows.Forms.Label lbl_MonitorCycleStatus;
        internal System.Windows.Forms.TextBox txt_DeviceNameStatus;
        internal System.Windows.Forms.TextBox txt_MonitorCycleStatus;
        internal System.Windows.Forms.RadioButton rad_ActProgType;
        internal System.Windows.Forms.GroupBox grp_Control;
        internal System.Windows.Forms.Label lbl_LogicalStationNumber;
        internal System.Windows.Forms.Label lbl_DeviceNameStatus;
        internal System.Windows.Forms.Label lbl_DeviceNameRandom;
        internal System.Windows.Forms.Button btn_WriteDeviceBlock2;
        internal System.Windows.Forms.Button btn_ReadDeviceRandom2;
        internal System.Windows.Forms.Button btn_WriteDeviceRandom2;
        internal System.Windows.Forms.TextBox txt_DeviceNameRandom;
        internal System.Windows.Forms.GroupBox grp_Random;
        internal System.Windows.Forms.TextBox txt_DeviceSizeRandom;
        internal System.Windows.Forms.TextBox txt_DeviceDataRandom;
        internal System.Windows.Forms.Label lbl_DeviceSizeRandom;
        internal System.Windows.Forms.Label lbl_DeviceDataRandom;
        internal System.Windows.Forms.TextBox txt_DeviceNameBlock;
        internal System.Windows.Forms.Label lbl_DeviceDataStatus;
        internal System.Windows.Forms.GroupBox grp_Status;
        internal System.Windows.Forms.GroupBox grp_Block;
    }
}

