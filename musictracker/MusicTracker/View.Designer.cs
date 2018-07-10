namespace MusicTracker
{
    partial class View
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importWaveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToWaveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.playToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backgroundColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.defaultToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.darkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.whiteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.blueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resourcesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.instrumentsListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importInstrumentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteInstrumentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.documentationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tutorialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.teamMembersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bjornMathisenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.andyChristensonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.matthewChristensonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.projectGoalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.m_lbl_BPM = new System.Windows.Forms.Label();
            this.m_txt_BPMText = new System.Windows.Forms.TextBox();
            this.m_lbl_StatusLabel = new System.Windows.Forms.Label();
            this.m_lbl_Amplitude = new System.Windows.Forms.Label();
            this.m_bar_Amplitude = new System.Windows.Forms.TrackBar();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.but_load_file = new System.Windows.Forms.Button();
            this.but_generate_file = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.fileSystemWatcherNotif = new System.IO.FileSystemWatcher();
            this.ChangeFont = new System.Windows.Forms.FontDialog();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.m_btn_GenerateWav = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_bar_Amplitude)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcherNotif)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(16, 284);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1019, 478);
            this.dataGridView1.TabIndex = 0;
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadToolStripMenuItem,
            this.playToolStripMenuItem,
            this.resourcesToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip.Size = new System.Drawing.Size(1049, 28);
            this.menuStrip.TabIndex = 1;
            this.menuStrip.Text = "menuStrip1";
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openProjectToolStripMenuItem,
            this.saveProjectToolStripMenuItem,
            this.importWaveToolStripMenuItem,
            this.exportToWaveToolStripMenuItem});
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.loadToolStripMenuItem.Text = "File";
            // 
            // openProjectToolStripMenuItem
            // 
            this.openProjectToolStripMenuItem.Name = "openProjectToolStripMenuItem";
            this.openProjectToolStripMenuItem.Size = new System.Drawing.Size(185, 26);
            this.openProjectToolStripMenuItem.Text = "Open Project";
            // 
            // saveProjectToolStripMenuItem
            // 
            this.saveProjectToolStripMenuItem.Name = "saveProjectToolStripMenuItem";
            this.saveProjectToolStripMenuItem.Size = new System.Drawing.Size(185, 26);
            this.saveProjectToolStripMenuItem.Text = "Save Project";
            // 
            // importWaveToolStripMenuItem
            // 
            this.importWaveToolStripMenuItem.Name = "importWaveToolStripMenuItem";
            this.importWaveToolStripMenuItem.Size = new System.Drawing.Size(185, 26);
            this.importWaveToolStripMenuItem.Text = "Import Wave";
            // 
            // exportToWaveToolStripMenuItem
            // 
            this.exportToWaveToolStripMenuItem.Name = "exportToWaveToolStripMenuItem";
            this.exportToWaveToolStripMenuItem.Size = new System.Drawing.Size(185, 26);
            this.exportToWaveToolStripMenuItem.Text = "Export to Wave";
            this.exportToWaveToolStripMenuItem.Click += new System.EventHandler(this.exportToWaveToolStripMenuItem_Click);
            // 
            // playToolStripMenuItem
            // 
            this.playToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fontToolStripMenuItem,
            this.backgroundColorToolStripMenuItem});
            this.playToolStripMenuItem.Name = "playToolStripMenuItem";
            this.playToolStripMenuItem.Size = new System.Drawing.Size(74, 24);
            this.playToolStripMenuItem.Text = "Settings";
            // 
            // fontToolStripMenuItem
            // 
            this.fontToolStripMenuItem.Name = "fontToolStripMenuItem";
            this.fontToolStripMenuItem.Size = new System.Drawing.Size(135, 26);
            this.fontToolStripMenuItem.Text = "Font";
            // 
            // backgroundColorToolStripMenuItem
            // 
            this.backgroundColorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.defaultToolStripMenuItem,
            this.darkToolStripMenuItem,
            this.whiteToolStripMenuItem,
            this.blueToolStripMenuItem});
            this.backgroundColorToolStripMenuItem.Name = "backgroundColorToolStripMenuItem";
            this.backgroundColorToolStripMenuItem.Size = new System.Drawing.Size(135, 26);
            this.backgroundColorToolStripMenuItem.Text = "Themes";
            // 
            // defaultToolStripMenuItem
            // 
            this.defaultToolStripMenuItem.Name = "defaultToolStripMenuItem";
            this.defaultToolStripMenuItem.Size = new System.Drawing.Size(133, 26);
            this.defaultToolStripMenuItem.Text = "Default";
            this.defaultToolStripMenuItem.Click += new System.EventHandler(this.defaultToolStripMenuItem_Click);
            // 
            // darkToolStripMenuItem
            // 
            this.darkToolStripMenuItem.Name = "darkToolStripMenuItem";
            this.darkToolStripMenuItem.Size = new System.Drawing.Size(133, 26);
            this.darkToolStripMenuItem.Text = "Dark";
            this.darkToolStripMenuItem.Click += new System.EventHandler(this.darkToolStripMenuItem_Click);
            // 
            // whiteToolStripMenuItem
            // 
            this.whiteToolStripMenuItem.Name = "whiteToolStripMenuItem";
            this.whiteToolStripMenuItem.Size = new System.Drawing.Size(133, 26);
            this.whiteToolStripMenuItem.Text = "White";
            this.whiteToolStripMenuItem.Click += new System.EventHandler(this.whiteToolStripMenuItem_Click);
            // 
            // blueToolStripMenuItem
            // 
            this.blueToolStripMenuItem.Name = "blueToolStripMenuItem";
            this.blueToolStripMenuItem.Size = new System.Drawing.Size(133, 26);
            this.blueToolStripMenuItem.Text = "Blue";
            this.blueToolStripMenuItem.Click += new System.EventHandler(this.blueToolStripMenuItem_Click);
            // 
            // resourcesToolStripMenuItem
            // 
            this.resourcesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.instrumentsListToolStripMenuItem,
            this.importInstrumentToolStripMenuItem,
            this.deleteInstrumentToolStripMenuItem});
            this.resourcesToolStripMenuItem.Name = "resourcesToolStripMenuItem";
            this.resourcesToolStripMenuItem.Size = new System.Drawing.Size(87, 24);
            this.resourcesToolStripMenuItem.Text = "Resources";
            // 
            // instrumentsListToolStripMenuItem
            // 
            this.instrumentsListToolStripMenuItem.Name = "instrumentsListToolStripMenuItem";
            this.instrumentsListToolStripMenuItem.Size = new System.Drawing.Size(203, 26);
            this.instrumentsListToolStripMenuItem.Text = "Instruments List";
            // 
            // importInstrumentToolStripMenuItem
            // 
            this.importInstrumentToolStripMenuItem.Name = "importInstrumentToolStripMenuItem";
            this.importInstrumentToolStripMenuItem.Size = new System.Drawing.Size(203, 26);
            this.importInstrumentToolStripMenuItem.Text = "Import Instrument";
            // 
            // deleteInstrumentToolStripMenuItem
            // 
            this.deleteInstrumentToolStripMenuItem.Name = "deleteInstrumentToolStripMenuItem";
            this.deleteInstrumentToolStripMenuItem.Size = new System.Drawing.Size(203, 26);
            this.deleteInstrumentToolStripMenuItem.Text = "Delete Instrument";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.documentationToolStripMenuItem,
            this.tutorialToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // documentationToolStripMenuItem
            // 
            this.documentationToolStripMenuItem.Name = "documentationToolStripMenuItem";
            this.documentationToolStripMenuItem.Size = new System.Drawing.Size(141, 26);
            this.documentationToolStripMenuItem.Text = "Help";
            this.documentationToolStripMenuItem.Click += new System.EventHandler(this.documentationToolStripMenuItem_Click);
            // 
            // tutorialToolStripMenuItem
            // 
            this.tutorialToolStripMenuItem.Name = "tutorialToolStripMenuItem";
            this.tutorialToolStripMenuItem.Size = new System.Drawing.Size(141, 26);
            this.tutorialToolStripMenuItem.Text = "Tutorials";
            this.tutorialToolStripMenuItem.Click += new System.EventHandler(this.tutorialToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.teamMembersToolStripMenuItem,
            this.projectGoalToolStripMenuItem});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(62, 24);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // teamMembersToolStripMenuItem
            // 
            this.teamMembersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bjornMathisenToolStripMenuItem,
            this.andyChristensonToolStripMenuItem,
            this.matthewChristensonToolStripMenuItem});
            this.teamMembersToolStripMenuItem.Name = "teamMembersToolStripMenuItem";
            this.teamMembersToolStripMenuItem.Size = new System.Drawing.Size(186, 26);
            this.teamMembersToolStripMenuItem.Text = "Team Members";
            // 
            // bjornMathisenToolStripMenuItem
            // 
            this.bjornMathisenToolStripMenuItem.Name = "bjornMathisenToolStripMenuItem";
            this.bjornMathisenToolStripMenuItem.Size = new System.Drawing.Size(222, 26);
            this.bjornMathisenToolStripMenuItem.Text = "Bjorn Mathisen";
            // 
            // andyChristensonToolStripMenuItem
            // 
            this.andyChristensonToolStripMenuItem.Name = "andyChristensonToolStripMenuItem";
            this.andyChristensonToolStripMenuItem.Size = new System.Drawing.Size(222, 26);
            this.andyChristensonToolStripMenuItem.Text = "Andrew Christenson";
            // 
            // matthewChristensonToolStripMenuItem
            // 
            this.matthewChristensonToolStripMenuItem.Name = "matthewChristensonToolStripMenuItem";
            this.matthewChristensonToolStripMenuItem.Size = new System.Drawing.Size(222, 26);
            this.matthewChristensonToolStripMenuItem.Text = "Matthew Christenson";
            // 
            // projectGoalToolStripMenuItem
            // 
            this.projectGoalToolStripMenuItem.Name = "projectGoalToolStripMenuItem";
            this.projectGoalToolStripMenuItem.Size = new System.Drawing.Size(186, 26);
            this.projectGoalToolStripMenuItem.Text = "Project Goal";
            this.projectGoalToolStripMenuItem.Click += new System.EventHandler(this.projectGoalToolStripMenuItem_Click);
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.DefaultExt = "sbird";
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.m_lbl_BPM);
            this.groupBox1.Controls.Add(this.m_txt_BPMText);
            this.groupBox1.Controls.Add(this.m_lbl_StatusLabel);
            this.groupBox1.Controls.Add(this.m_lbl_Amplitude);
            this.groupBox1.Controls.Add(this.m_bar_Amplitude);
            this.groupBox1.Location = new System.Drawing.Point(16, 52);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(487, 210);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Controls";
            // 
            // m_lbl_BPM
            // 
            this.m_lbl_BPM.AutoSize = true;
            this.m_lbl_BPM.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_lbl_BPM.Location = new System.Drawing.Point(9, 41);
            this.m_lbl_BPM.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.m_lbl_BPM.Name = "m_lbl_BPM";
            this.m_lbl_BPM.Size = new System.Drawing.Size(186, 17);
            this.m_lbl_BPM.TabIndex = 9;
            this.m_lbl_BPM.Text = "Beats Per Minute (BPM):";
            // 
            // m_txt_BPMText
            // 
            this.m_txt_BPMText.Location = new System.Drawing.Point(212, 37);
            this.m_txt_BPMText.Margin = new System.Windows.Forms.Padding(4);
            this.m_txt_BPMText.Name = "m_txt_BPMText";
            this.m_txt_BPMText.Size = new System.Drawing.Size(76, 22);
            this.m_txt_BPMText.TabIndex = 8;
            this.m_txt_BPMText.Text = "120";
            this.m_txt_BPMText.Validating += new System.ComponentModel.CancelEventHandler(this.m_txt_BPMText_Validating);
            // 
            // m_lbl_StatusLabel
            // 
            this.m_lbl_StatusLabel.AutoSize = true;
            this.m_lbl_StatusLabel.BackColor = System.Drawing.SystemColors.Control;
            this.m_lbl_StatusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_lbl_StatusLabel.Location = new System.Drawing.Point(275, 124);
            this.m_lbl_StatusLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.m_lbl_StatusLabel.Name = "m_lbl_StatusLabel";
            this.m_lbl_StatusLabel.Size = new System.Drawing.Size(20, 24);
            this.m_lbl_StatusLabel.TabIndex = 7;
            this.m_lbl_StatusLabel.Text = "0";
            // 
            // m_lbl_Amplitude
            // 
            this.m_lbl_Amplitude.AutoSize = true;
            this.m_lbl_Amplitude.Location = new System.Drawing.Point(21, 124);
            this.m_lbl_Amplitude.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.m_lbl_Amplitude.Name = "m_lbl_Amplitude";
            this.m_lbl_Amplitude.Size = new System.Drawing.Size(100, 17);
            this.m_lbl_Amplitude.TabIndex = 5;
            this.m_lbl_Amplitude.Text = "Global Volume";
            // 
            // m_bar_Amplitude
            // 
            this.m_bar_Amplitude.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.m_bar_Amplitude.Location = new System.Drawing.Point(9, 148);
            this.m_bar_Amplitude.Margin = new System.Windows.Forms.Padding(4);
            this.m_bar_Amplitude.Name = "m_bar_Amplitude";
            this.m_bar_Amplitude.RightToLeftLayout = true;
            this.m_bar_Amplitude.Size = new System.Drawing.Size(280, 56);
            this.m_bar_Amplitude.TabIndex = 4;
            this.m_bar_Amplitude.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.m_bar_Amplitude.Scroll += new System.EventHandler(this.m_bar_Amplitude_Scroll);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.but_load_file);
            this.groupBox2.Controls.Add(this.but_generate_file);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(511, 52);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(524, 209);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Resources";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.comboBox4);
            this.groupBox3.Controls.Add(this.comboBox3);
            this.groupBox3.Controls.Add(this.comboBox2);
            this.groupBox3.Location = new System.Drawing.Point(272, 37);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(223, 155);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Edit Mode Options";
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04"});
            this.comboBox4.Location = new System.Drawing.Point(144, 46);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(49, 24);
            this.comboBox4.TabIndex = 2;
            this.comboBox4.Text = "01";
            this.comboBox4.SelectedIndexChanged += new System.EventHandler(this.comboBox4_SelectedIndexChanged);
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.comboBox3.Location = new System.Drawing.Point(6, 100);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(50, 24);
            this.comboBox3.TabIndex = 1;
            this.comboBox3.Text = "1";
            this.comboBox3.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "C-7",
            "C-6",
            "C-5",
            "C-4",
            "C-3",
            "C-2",
            "C-1",
            "C-0"});
            this.comboBox2.Location = new System.Drawing.Point(6, 47);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(52, 24);
            this.comboBox2.TabIndex = 0;
            this.comboBox2.Tag = "Octave";
            this.comboBox2.Text = "C-4";
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // but_load_file
            // 
            this.but_load_file.Location = new System.Drawing.Point(24, 97);
            this.but_load_file.Margin = new System.Windows.Forms.Padding(4);
            this.but_load_file.Name = "but_load_file";
            this.but_load_file.Size = new System.Drawing.Size(149, 28);
            this.but_load_file.TabIndex = 2;
            this.but_load_file.Text = "Load File";
            this.but_load_file.UseVisualStyleBackColor = true;
            this.but_load_file.Click += new System.EventHandler(this.but_load_file_Click);
            // 
            // but_generate_file
            // 
            this.but_generate_file.Location = new System.Drawing.Point(24, 62);
            this.but_generate_file.Margin = new System.Windows.Forms.Padding(4);
            this.but_generate_file.Name = "but_generate_file";
            this.but_generate_file.Size = new System.Drawing.Size(149, 28);
            this.but_generate_file.TabIndex = 1;
            this.but_generate_file.Text = "Generate File";
            this.but_generate_file.UseVisualStyleBackColor = true;
            this.but_generate_file.Click += new System.EventHandler(this.but_generate_file_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 175);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(220, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Status: Wav File non-existant";
            // 
            // fileSystemWatcherNotif
            // 
            this.fileSystemWatcherNotif.EnableRaisingEvents = true;
            this.fileSystemWatcherNotif.SynchronizingObject = this;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flowLayoutPanel1.Location = new System.Drawing.Point(41, 340);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(955, 379);
            this.flowLayoutPanel1.TabIndex = 0;
            this.flowLayoutPanel1.WrapContents = false;
            this.flowLayoutPanel1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.flowLayoutPanel1_MouseClick);
            this.flowLayoutPanel1.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.flowLayoutPanel1_PreviewKeyDown);
            this.flowLayoutPanel1.Validating += new System.ComponentModel.CancelEventHandler(this.flowLayoutPanel1_Validating);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "1 Second",
            "10 Second",
            "30 Second",
            "1 Minute",
            "5 Minute",
            "10 Minute"});
            this.comboBox1.Location = new System.Drawing.Point(41, 304);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(123, 24);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.Text = "(Select Time)";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(373, 305);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Play All";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(511, 305);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 5;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // m_btn_GenerateWav
            // 
            this.m_btn_GenerateWav.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.m_btn_GenerateWav.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_btn_GenerateWav.Location = new System.Drawing.Point(783, 295);
            this.m_btn_GenerateWav.Margin = new System.Windows.Forms.Padding(4);
            this.m_btn_GenerateWav.Name = "m_btn_GenerateWav";
            this.m_btn_GenerateWav.Size = new System.Drawing.Size(184, 41);
            this.m_btn_GenerateWav.TabIndex = 6;
            this.m_btn_GenerateWav.Text = "Generate WAV file";
            this.m_btn_GenerateWav.UseVisualStyleBackColor = false;
            this.m_btn_GenerateWav.Click += new System.EventHandler(this.m_btn_GenerateWav_Click);
            // 
            // View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1049, 733);
            this.Controls.Add(this.m_btn_GenerateWav);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "View";
            this.Text = "Music Tracker";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_bar_Amplitude)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcherNotif)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openProjectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveProjectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importWaveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportToWaveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem playToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fontToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem backgroundColorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resourcesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem instrumentsListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importInstrumentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteInstrumentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem documentationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tutorialToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem teamMembersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bjornMathisenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem andyChristensonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem matthewChristensonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem projectGoalToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.IO.FileSystemWatcher fileSystemWatcherNotif;
        private System.Windows.Forms.FontDialog ChangeFont;
        private System.Windows.Forms.TrackBar m_bar_Amplitude;
        private System.Windows.Forms.Label m_lbl_Amplitude;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ToolStripMenuItem defaultToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem darkToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem whiteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem blueToolStripMenuItem;
        private System.Windows.Forms.Button m_btn_GenerateWav;
        private System.Windows.Forms.Label m_lbl_StatusLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label m_lbl_BPM;
        private System.Windows.Forms.TextBox m_txt_BPMText;
        private System.Windows.Forms.Button but_generate_file;
        private System.Windows.Forms.Button but_load_file;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox4;
    }
}

