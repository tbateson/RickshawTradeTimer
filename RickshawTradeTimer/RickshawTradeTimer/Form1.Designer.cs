namespace RickshawTradeTimer {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.system1TB = new System.Windows.Forms.TextBox();
            this.newRouteButton = new System.Windows.Forms.Button();
            this.commodityStation1 = new System.Windows.Forms.ComboBox();
            this.buyStation1TB = new System.Windows.Forms.TextBox();
            this.sellStation1TB = new System.Windows.Forms.TextBox();
            this.tonsTB = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadCSVMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveCSVMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hotkeysToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.swLabel = new System.Windows.Forms.Label();
            this.dataCollTab = new System.Windows.Forms.TabControl();
            this.dataTabPage = new System.Windows.Forms.TabPage();
            this.routePanel = new System.Windows.Forms.Panel();
            this.station1TB = new System.Windows.Forms.TextBox();
            this.phaseLabel = new System.Windows.Forms.Label();
            this.abandonBtn = new System.Windows.Forms.Button();
            this.dataShowTabPage = new System.Windows.Forms.TabPage();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.dateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.systemColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.station1Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.commodity1Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buy1Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sell1Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.checkpointColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.time2Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tonsColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.profitColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.profitPerHourColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            this.dataCollTab.SuspendLayout();
            this.dataTabPage.SuspendLayout();
            this.routePanel.SuspendLayout();
            this.dataShowTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // system1TB
            // 
            this.system1TB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.system1TB.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.system1TB.Location = new System.Drawing.Point(0, 0);
            this.system1TB.Name = "system1TB";
            this.system1TB.Size = new System.Drawing.Size(121, 20);
            this.system1TB.TabIndex = 0;
            this.system1TB.Text = "System 1";
            this.system1TB.Click += new System.EventHandler(this.tb_Click);
            this.system1TB.TextChanged += new System.EventHandler(this.system1TB_TextChanged);
            this.system1TB.Leave += new System.EventHandler(this.tb_Leave);
            this.system1TB.MouseEnter += new System.EventHandler(this.tb_MouseEnter);
            this.system1TB.MouseLeave += new System.EventHandler(this.tb_MouseLeave);
            // 
            // newRouteButton
            // 
            this.newRouteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newRouteButton.Location = new System.Drawing.Point(506, 302);
            this.newRouteButton.Name = "newRouteButton";
            this.newRouteButton.Size = new System.Drawing.Size(137, 28);
            this.newRouteButton.TabIndex = 1;
            this.newRouteButton.Text = "New Route";
            this.newRouteButton.UseVisualStyleBackColor = true;
            this.newRouteButton.Click += new System.EventHandler(this.newRouteButton_Click);
            // 
            // commodityStation1
            // 
            this.commodityStation1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.commodityStation1.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.commodityStation1.FormattingEnabled = true;
            this.commodityStation1.Items.AddRange(new object[] {
            "Advanced Catalysers",
            "Agri-Medicines",
            "Algae",
            "Alloys",
            "Aluminium",
            "Animal Meat",
            "Animal Monitors",
            "Aquaponic Systems",
            "Artificial Habitat Modules",
            "Atmospheric Processors",
            "Auto Fabricators",
            "Basic Medicines",
            "Bauxite",
            "Beer",
            "Bertrandite",
            "Beryllium",
            "Bioreducing Lichen",
            "Biowaste",
            "Chemical Drugs",
            "Chemical Waste",
            "Clothing",
            "Cobalt",
            "Coffee",
            "Coltan",
            "Combat Stabilisers",
            "Computer Components",
            "Consumer Technology",
            "Copper",
            "Cotton",
            "Crop Harvesters",
            "Domestic Appliances",
            "Explosives",
            "Fish",
            "Food Cartridges",
            "Fruit and Vegetables",
            "Gallite",
            "Gallium",
            "Gold",
            "Grain",
            "H.E. Suits",
            "Heliostatic Furnaces",
            "Hydrogen Fuel",
            "Imperial Slaves",
            "Indite",
            "Indium",
            "Land Enrichment Systems",
            "Leather",
            "Lepidolite",
            "Liquor",
            "Lithium",
            "Marine Equipment",
            "Microbial Furnaces",
            "Mineral Extractors",
            "Mineral Oil",
            "Narcotics",
            "Natural Fabrics",
            "Non Lethal Weapons",
            "Palladium",
            "Performance Enhancers",
            "Personal Weapons",
            "Pesticides",
            "Plastics",
            "Platinum",
            "Polymers",
            "Power Generators",
            "Progenitor Cells",
            "Reactive Armour",
            "Resonating Separators",
            "Robotics",
            "Rutile",
            "Scrap",
            "Semiconductors",
            "Silver",
            "Slaves",
            "Superconductors",
            "Synthetic Fabrics",
            "Synthetic Meat",
            "Tantalum",
            "Tea",
            "Titanium",
            "Tobacco",
            "Uraninite",
            "Uranium",
            "Water Purifiers",
            "Wine"});
            this.commodityStation1.Location = new System.Drawing.Point(0, 26);
            this.commodityStation1.Name = "commodityStation1";
            this.commodityStation1.Size = new System.Drawing.Size(121, 21);
            this.commodityStation1.TabIndex = 6;
            this.commodityStation1.Text = "Commodity 1";
            this.commodityStation1.SelectedValueChanged += new System.EventHandler(this.commodityStation1_SelectedValueChanged);
            this.commodityStation1.TextChanged += new System.EventHandler(this.commodityStation1_TextChanged);
            this.commodityStation1.Leave += new System.EventHandler(this.tb_Leave);
            this.commodityStation1.MouseEnter += new System.EventHandler(this.tb_MouseEnter);
            this.commodityStation1.MouseLeave += new System.EventHandler(this.tb_MouseLeave);
            // 
            // buyStation1TB
            // 
            this.buyStation1TB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.buyStation1TB.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.buyStation1TB.Location = new System.Drawing.Point(127, 26);
            this.buyStation1TB.Name = "buyStation1TB";
            this.buyStation1TB.Size = new System.Drawing.Size(100, 20);
            this.buyStation1TB.TabIndex = 8;
            this.buyStation1TB.Text = "Buy for";
            this.buyStation1TB.Click += new System.EventHandler(this.tb_Click);
            this.buyStation1TB.TextChanged += new System.EventHandler(this.buyStation1TB_TextChanged);
            this.buyStation1TB.Leave += new System.EventHandler(this.tb_Leave);
            this.buyStation1TB.MouseEnter += new System.EventHandler(this.tb_MouseEnter);
            this.buyStation1TB.MouseLeave += new System.EventHandler(this.tb_MouseLeave);
            // 
            // sellStation1TB
            // 
            this.sellStation1TB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sellStation1TB.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.sellStation1TB.Location = new System.Drawing.Point(233, 26);
            this.sellStation1TB.Name = "sellStation1TB";
            this.sellStation1TB.Size = new System.Drawing.Size(100, 20);
            this.sellStation1TB.TabIndex = 10;
            this.sellStation1TB.Text = "Sell for";
            this.sellStation1TB.Click += new System.EventHandler(this.tb_Click);
            this.sellStation1TB.TextChanged += new System.EventHandler(this.sellStation1TB_TextChanged);
            this.sellStation1TB.Leave += new System.EventHandler(this.tb_Leave);
            this.sellStation1TB.MouseEnter += new System.EventHandler(this.tb_MouseEnter);
            this.sellStation1TB.MouseLeave += new System.EventHandler(this.tb_MouseLeave);
            // 
            // tonsTB
            // 
            this.tonsTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tonsTB.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.tonsTB.Location = new System.Drawing.Point(239, 26);
            this.tonsTB.Name = "tonsTB";
            this.tonsTB.Size = new System.Drawing.Size(100, 20);
            this.tonsTB.TabIndex = 13;
            this.tonsTB.Text = "Number of Tons";
            this.tonsTB.Click += new System.EventHandler(this.tb_Click);
            this.tonsTB.TextChanged += new System.EventHandler(this.tonsTB_TextChanged);
            this.tonsTB.Leave += new System.EventHandler(this.tb_Leave);
            this.tonsTB.MouseEnter += new System.EventHandler(this.tb_MouseEnter);
            this.tonsTB.MouseLeave += new System.EventHandler(this.tb_MouseLeave);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.optionsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(669, 24);
            this.menuStrip1.TabIndex = 14;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadCSVMenuItem,
            this.saveCSVMenuItem,
            this.saveAsToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // loadCSVMenuItem
            // 
            this.loadCSVMenuItem.Name = "loadCSVMenuItem";
            this.loadCSVMenuItem.Size = new System.Drawing.Size(121, 22);
            this.loadCSVMenuItem.Text = "Open";
            this.loadCSVMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // saveCSVMenuItem
            // 
            this.saveCSVMenuItem.Name = "saveCSVMenuItem";
            this.saveCSVMenuItem.Size = new System.Drawing.Size(121, 22);
            this.saveCSVMenuItem.Text = "Save";
            this.saveCSVMenuItem.Click += new System.EventHandler(this.saveCSVToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.saveAsToolStripMenuItem.Text = "Save as...";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hotkeysToolStripMenuItem,
            this.settingsToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // hotkeysToolStripMenuItem
            // 
            this.hotkeysToolStripMenuItem.Name = "hotkeysToolStripMenuItem";
            this.hotkeysToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.hotkeysToolStripMenuItem.Text = "Hotkeys";
            this.hotkeysToolStripMenuItem.Click += new System.EventHandler(this.hotkeysToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.settingsToolStripMenuItem.Text = "Settings";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // swLabel
            // 
            this.swLabel.AutoSize = true;
            this.swLabel.Location = new System.Drawing.Point(541, 63);
            this.swLabel.Name = "swLabel";
            this.swLabel.Size = new System.Drawing.Size(49, 13);
            this.swLabel.TabIndex = 19;
            this.swLabel.Text = "00:00:00";
            // 
            // dataCollTab
            // 
            this.dataCollTab.Controls.Add(this.dataTabPage);
            this.dataCollTab.Controls.Add(this.dataShowTabPage);
            this.dataCollTab.Location = new System.Drawing.Point(0, 27);
            this.dataCollTab.Name = "dataCollTab";
            this.dataCollTab.SelectedIndex = 0;
            this.dataCollTab.Size = new System.Drawing.Size(669, 364);
            this.dataCollTab.TabIndex = 21;
            // 
            // dataTabPage
            // 
            this.dataTabPage.BackColor = System.Drawing.SystemColors.Control;
            this.dataTabPage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.dataTabPage.Controls.Add(this.routePanel);
            this.dataTabPage.Controls.Add(this.phaseLabel);
            this.dataTabPage.Controls.Add(this.abandonBtn);
            this.dataTabPage.Controls.Add(this.newRouteButton);
            this.dataTabPage.Controls.Add(this.swLabel);
            this.dataTabPage.Controls.Add(this.tonsTB);
            this.dataTabPage.Location = new System.Drawing.Point(4, 22);
            this.dataTabPage.Name = "dataTabPage";
            this.dataTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.dataTabPage.Size = new System.Drawing.Size(661, 338);
            this.dataTabPage.TabIndex = 0;
            this.dataTabPage.Text = "Timer";
            this.dataTabPage.Click += new System.EventHandler(this.dataTabPage_Click);
            // 
            // routePanel
            // 
            this.routePanel.AutoScroll = true;
            this.routePanel.Controls.Add(this.station1TB);
            this.routePanel.Controls.Add(this.sellStation1TB);
            this.routePanel.Controls.Add(this.commodityStation1);
            this.routePanel.Controls.Add(this.system1TB);
            this.routePanel.Controls.Add(this.buyStation1TB);
            this.routePanel.Location = new System.Drawing.Point(6, 52);
            this.routePanel.Name = "routePanel";
            this.routePanel.Size = new System.Drawing.Size(429, 278);
            this.routePanel.TabIndex = 24;
            this.routePanel.Click += new System.EventHandler(this.Form1_Click);
            // 
            // station1TB
            // 
            this.station1TB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.station1TB.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.station1TB.Location = new System.Drawing.Point(127, 0);
            this.station1TB.Name = "station1TB";
            this.station1TB.Size = new System.Drawing.Size(206, 20);
            this.station1TB.TabIndex = 23;
            this.station1TB.Text = "Station 1";
            this.station1TB.TextChanged += new System.EventHandler(this.station1TB_TextChanged);
            this.station1TB.MouseEnter += new System.EventHandler(this.tb_MouseEnter);
            this.station1TB.MouseLeave += new System.EventHandler(this.tb_MouseLeave);
            // 
            // phaseLabel
            // 
            this.phaseLabel.AutoSize = true;
            this.phaseLabel.Location = new System.Drawing.Point(8, 28);
            this.phaseLabel.Name = "phaseLabel";
            this.phaseLabel.Size = new System.Drawing.Size(0, 13);
            this.phaseLabel.TabIndex = 25;
            // 
            // abandonBtn
            // 
            this.abandonBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.abandonBtn.Location = new System.Drawing.Point(506, 94);
            this.abandonBtn.Name = "abandonBtn";
            this.abandonBtn.Size = new System.Drawing.Size(137, 28);
            this.abandonBtn.TabIndex = 21;
            this.abandonBtn.Text = "Abandon Current Run";
            this.abandonBtn.UseVisualStyleBackColor = true;
            this.abandonBtn.Click += new System.EventHandler(this.abandonBtn_Click);
            // 
            // dataShowTabPage
            // 
            this.dataShowTabPage.BackColor = System.Drawing.SystemColors.Control;
            this.dataShowTabPage.Controls.Add(this.dataGridView);
            this.dataShowTabPage.Location = new System.Drawing.Point(4, 22);
            this.dataShowTabPage.Name = "dataShowTabPage";
            this.dataShowTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.dataShowTabPage.Size = new System.Drawing.Size(661, 338);
            this.dataShowTabPage.TabIndex = 1;
            this.dataShowTabPage.Text = "View Data";
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dateColumn,
            this.systemColumn,
            this.station1Column,
            this.commodity1Column,
            this.buy1Column,
            this.sell1Column,
            this.checkpointColumn,
            this.time2Column,
            this.tonsColumn,
            this.profitColumn,
            this.profitPerHourColumn});
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Right;
            this.dataGridView.Location = new System.Drawing.Point(3, 3);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.Size = new System.Drawing.Size(655, 332);
            this.dataGridView.TabIndex = 0;
            // 
            // dateColumn
            // 
            this.dateColumn.HeaderText = "Date";
            this.dateColumn.Name = "dateColumn";
            this.dateColumn.ReadOnly = true;
            this.dateColumn.Width = 125;
            // 
            // systemColumn
            // 
            this.systemColumn.HeaderText = "System";
            this.systemColumn.Name = "systemColumn";
            this.systemColumn.ReadOnly = true;
            // 
            // station1Column
            // 
            this.station1Column.HeaderText = "Station";
            this.station1Column.Name = "station1Column";
            this.station1Column.ReadOnly = true;
            // 
            // commodity1Column
            // 
            this.commodity1Column.HeaderText = "Commodity";
            this.commodity1Column.Name = "commodity1Column";
            this.commodity1Column.ReadOnly = true;
            // 
            // buy1Column
            // 
            this.buy1Column.HeaderText = "Buy";
            this.buy1Column.Name = "buy1Column";
            this.buy1Column.ReadOnly = true;
            // 
            // sell1Column
            // 
            this.sell1Column.HeaderText = "Sell";
            this.sell1Column.Name = "sell1Column";
            this.sell1Column.ReadOnly = true;
            // 
            // checkpointColumn
            // 
            this.checkpointColumn.HeaderText = "Checkpoint";
            this.checkpointColumn.Name = "checkpointColumn";
            this.checkpointColumn.ReadOnly = true;
            // 
            // time2Column
            // 
            this.time2Column.HeaderText = "Time";
            this.time2Column.Name = "time2Column";
            this.time2Column.ReadOnly = true;
            // 
            // tonsColumn
            // 
            this.tonsColumn.HeaderText = "Tons";
            this.tonsColumn.Name = "tonsColumn";
            this.tonsColumn.ReadOnly = true;
            // 
            // profitColumn
            // 
            this.profitColumn.HeaderText = "Profit";
            this.profitColumn.Name = "profitColumn";
            this.profitColumn.ReadOnly = true;
            // 
            // profitPerHourColumn
            // 
            this.profitPerHourColumn.HeaderText = "Profit/Hour";
            this.profitPerHourColumn.Name = "profitPerHourColumn";
            this.profitPerHourColumn.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 391);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.dataCollTab);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Rickshaw Trade Timer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.ResizeEnd += new System.EventHandler(this.Form1_ResizeEnd);
            this.Click += new System.EventHandler(this.Form1_Click);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.dataCollTab.ResumeLayout(false);
            this.dataTabPage.ResumeLayout(false);
            this.dataTabPage.PerformLayout();
            this.routePanel.ResumeLayout(false);
            this.routePanel.PerformLayout();
            this.dataShowTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox system1TB;
        private System.Windows.Forms.Button newRouteButton;
        private System.Windows.Forms.ComboBox commodityStation1;
        private System.Windows.Forms.TextBox buyStation1TB;
        private System.Windows.Forms.TextBox sellStation1TB;
        private System.Windows.Forms.TextBox tonsTB;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadCSVMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveCSVMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hotkeysToolStripMenuItem;
        private System.Windows.Forms.Label swLabel;
        private System.Windows.Forms.TabControl dataCollTab;
        private System.Windows.Forms.TabPage dataTabPage;
        private System.Windows.Forms.TabPage dataShowTabPage;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button abandonBtn;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.TextBox station1TB;
        private System.Windows.Forms.Panel routePanel;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn systemColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn station1Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn commodity1Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn buy1Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn sell1Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn checkpointColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn time2Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn tonsColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn profitColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn profitPerHourColumn;
        private System.Windows.Forms.Label phaseLabel;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;

        //private KeyHandler ghk;
    }
}

