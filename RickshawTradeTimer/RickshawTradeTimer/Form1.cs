using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using Kennedy.ManagedHooks;
using System.Diagnostics;
using System.Threading;

namespace RickshawTradeTimer {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        public string Title;

        string lastSessionCsv = null;

        Dictionary<object, string> defaultStates = new Dictionary<object, string>();
        Dictionary<object, string> toolTips = new Dictionary<object,string>();
        
        ActionBuilder actionBuilder = new ActionBuilder();
        Route route = new Route();
        CsvExporter exporter = new CsvExporter();

        KeyboardTracking keyboardTracking = new KeyboardTracking();
                
        HotkeysForm hotkeysForm = new HotkeysForm();
        SettingsForm settingsForm = new SettingsForm();
        NewRouteForm newRouteForm = new NewRouteForm();
        
        ToolTip toolTip = new ToolTip();
        
        NotifyIcon trayIcon = new NotifyIcon();

        List<TextBox> stationTBs = new List<TextBox>();
        List<TextBox> systemTBs = new List<TextBox>();
        List<ComboBox> commCBs = new List<ComboBox>();
        List<TextBox> buyTBs = new List<TextBox>();
        List<TextBox> sellTBs = new List<TextBox>();
        //List<Button> removeBTNs = new List<Button>();

        private void Form1_Load_1(object sender, System.EventArgs e)
	    {
            systemTBs.Add(system1TB);
            stationTBs.Add(station1TB);
            commCBs.Add(commodityStation1);
            buyTBs.Add(buyStation1TB);
            sellTBs.Add(sellStation1TB);
            //removeBTNs.Add(removeBtn);
            
            route.Stations.Add(String.Empty);
            route.Systems.Add(String.Empty);
            route.Commodities.Add(String.Empty);
            route.BuyPrices.Add(0);
            route.SellPrices.Add(0);

            defaultStates[commodityStation1] = "Commodity";
            defaultStates[buyStation1TB] = "Buy for";
            defaultStates[sellStation1TB] = "Sell for";
            defaultStates[system1TB] = "System";
            defaultStates[station1TB] = "Station";
            defaultStates[tonsTB] = "Number of Tons";

            toolTips[commodityStation1] = "Commodity";
            toolTips[buyStation1TB] = "Commodity Buy Price";
            toolTips[sellStation1TB] = "Commodity Sell Price";
            toolTips[system1TB] = "System";
            toolTips[station1TB] = "Station";
            toolTips[tonsTB] = "Number of Tons";

            trayIcon.BalloonTipIcon = ToolTipIcon.Info;
            trayIcon.Icon = this.Icon;
            trayIcon.BalloonTipText = this.Text + " has been minimized, double click to reopen";
            trayIcon.BalloonTipTitle = this.Text;
            trayIcon.DoubleClick += new EventHandler(trayIcon_DoubleClick);

            try {

            } catch(FileNotFoundException) {
                MessageBox.Show("No .csv file found for last session, starting new session.");
            }


            this.ActiveControl = swLabel;
            this.Title = Text;
            
            keyboardTracking.KeyDown += new KeyboardHookExt.KeyboardEventHandlerExt(hM_KeyEvent);
            keyboardTracking.InstallHook();

            try { 
                string[] HK_settings = Settings.LoadSettings("HK_settings.ini");
                hotkeysForm.PhaseHK = (Keys)Int32.Parse(HK_settings[0]);
                hotkeysForm.PhaseCtrl = Boolean.Parse(HK_settings[1]);
                hotkeysForm.PhaseAlt = Boolean.Parse(HK_settings[2]);
                hotkeysForm.PhaseShift = Boolean.Parse(HK_settings[3]);
                hotkeysForm.NextStationHK = (Keys)Int32.Parse(HK_settings[4]);
                hotkeysForm.NextStationCtrl = Boolean.Parse(HK_settings[5]);
                hotkeysForm.NextStationAlt = Boolean.Parse(HK_settings[6]);
                hotkeysForm.NextStationShift = Boolean.Parse(HK_settings[7]);
            } catch(FileNotFoundException) {}
            catch(Exception) {
                MessageBox.Show("Error in parsing hotkey settings file");
            }

            try {
                string[] DATA_settings = Settings.LoadSettings("DATA_settings.ini");
                /*for(int i=0;i<DATA_settings.Length-5;i+=5) {
                    if(i > 0) {
                        AddNewRouteRow();
                    }
                    systemTBs[systemTBs.Count-1].Text = DATA_settings[i];
                    stationTBs[stationTBs.Count-1].Text = DATA_settings[i+1];
                    commCBs[commCBs.Count-1].Text = DATA_settings[i+2];
                    buyTBs[buyTBs.Count-1].Text = DATA_settings[i+3];
                    sellTBs[sellTBs.Count-1].Text = DATA_settings[i+4];
                }
                tonsTB.Text = DATA_settings[DATA_settings.Length-3];*/
                lastSessionCsv = DATA_settings[0];
                if(lastSessionCsv != string.Empty) {
                    LoadCsvFile(new StreamReader(lastSessionCsv).BaseStream);
                }
            } catch(FileNotFoundException) {}
            catch(Exception ex) {
                MessageBox.Show("Error in parsing data settings file:\n\n" + ex.Message + "\n" + ex.StackTrace);
            }

            try {
                settingsForm.FromFile("GEN_settings.ini");
            } catch(FileNotFoundException) {}
            catch(Exception) {
                MessageBox.Show("Error in parsing settings file");
            } finally {                
                settingsForm.SetSettings(actionBuilder);
            }
        }

        private void trayIcon_DoubleClick(object sender, EventArgs e) {
            this.Show();
            this.WindowState = FormWindowState.Normal;
        }

        private void hM_KeyEvent(Keys keys) {
            if(hotkeysForm.PhaseHK == keys) /*&&
                hotkeysForm.PhaseCtrl == k.Control &&
                hotkeysForm.PhaseAlt == k.Alt &&
                hotkeysForm.PhaseShift == k.Shift)*/
            {
                route.NumberOfStations = systemTBs.Count;
                actionBuilder.Commit(route.NextAction(), route, exporter, swLabel);
                exporter.LoadDataGridView(dataGridView);
                if(exporter.NeedToSave) {
                    string[] fileName = lastSessionCsv.Split('\\');
                    if(fileName.Length > 0)
                        this.Text = this.Title + " - " + fileName[fileName.Length-1] + "*";
                }
                phaseLabel.Text = /*((float)route.Phase()/2f).ToString();*/route.Transit();
            } else if(hotkeysForm.NextStationHK == keys) /* &&
                hotkeysForm.NextStationCtrl == k.Control &&
                hotkeysForm.NextStationAlt == k.Alt &&
                hotkeysForm.NextStationShift == k.Shift)*/
            {                   
                actionBuilder.Commit(BaseAction.TypeNextStation, route, exporter, swLabel);
            }
            /*Log._(DateTime.Now.ToString() + ": " + k.KeyCode.ToString() 
                + "[" + k.Control + "," + k.Alt + "," + k.Shift + "]");*/
        }
        
        private void newRouteButton_Click(object sender, EventArgs e) {
            newRouteForm.SetCallback(this);
            newRouteForm.Show();
        }

        public void newRouteButton_Callback(object sender) {            
            newRouteForm.Hide();
            DialogResult result = newRouteForm.Result.Value;
            if(result == DialogResult.OK) {
                int value = newRouteForm.Value.Value;

                route = new Route();
                actionBuilder = new ActionBuilder();

                routePanel.Controls.Clear();
                                        
                systemTBs.Clear();
                stationTBs.Clear();
                commCBs.Clear();
                buyTBs.Clear();
                sellTBs.Clear();
            
                dataGridView.Columns.Clear();
                dataGridView.Rows.Clear();

                panelY = 0;
                for(int i=0;i<value;i++) {
                    AddNewRouteRow();
                }

                exporter = new CsvExporter(route);
            }
            newRouteForm.Reset();
        }
        
        private void buyStation1TB_TextChanged(object sender, EventArgs e) {
            try {
                if(buyTBs.IndexOf((TextBox)sender) != -1) { 
                    route.BuyPrices[buyTBs.IndexOf((TextBox)sender)] = Int32.Parse(((Control)sender).Text);
                    ((TextBox)sender).ForeColor = Color.Black;
                }
            } catch(FormatException) {
                ((TextBox)sender).ForeColor = Color.Red;
            }
        }

        private void sellStation1TB_TextChanged(object sender, EventArgs e) {
            try {
                if(sellTBs.IndexOf((TextBox)sender) != -1) { 
                    route.SellPrices[sellTBs.IndexOf((TextBox)sender)] = Int32.Parse(((Control)sender).Text);
                    ((TextBox)sender).ForeColor = Color.Black;
                }
            } catch(FormatException) {
                ((TextBox)sender).ForeColor = Color.Red;
            }
        }

        private void commodityStation1_SelectedValueChanged(object sender, EventArgs e) {
            if(commCBs.IndexOf((ComboBox)sender) != -1) {
                route.Commodities[commCBs.IndexOf((ComboBox)sender)] = ((Control)sender).Text;
                ((ComboBox)sender).ForeColor = Color.Black;
            }
        }

        private void station1TB_TextChanged(object sender, EventArgs e) {
            if(stationTBs.IndexOf((TextBox)sender) != -1) {
                route.Stations[stationTBs.IndexOf((TextBox)sender)] = ((Control)sender).Text;
                ((TextBox)sender).ForeColor = Color.Black;
            }
        }
        
        private void system1TB_TextChanged(object sender, EventArgs e) {
            if(systemTBs.IndexOf((TextBox)sender) != -1) {
                route.Systems[systemTBs.IndexOf((TextBox)sender)] = ((Control)sender).Text;
                ((TextBox)sender).ForeColor = Color.Black;
            }
        }

        private void tonsTB_TextChanged(object sender, EventArgs e) {
            try {
                if(tonsTB.Text != defaultStates[tonsTB]) {
                    route.Tons = Int32.Parse(tonsTB.Text);
                    tonsTB.ForeColor = Color.Black;
                }
            } catch(FormatException) {
                tonsTB.ForeColor = Color.Red;
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e) {
            Stream s;
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.Filter = "csv files (*.csv)|*.csv";
            openFileDialog1.FilterIndex = 1 ;
            openFileDialog1.RestoreDirectory = true ;

            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if((s = openFileDialog1.OpenFile()) != null)
                {
                    lastSessionCsv = openFileDialog1.FileName;
                    LoadCsvFile(s);
                    s.Close();
                }
            }
        }

        private void saveCSVToolStripMenuItem_Click(object sender, EventArgs e) {
            try {                
                StreamWriter sw = new StreamWriter(lastSessionCsv);
                exporter.Export(sw.BaseStream);
                sw.Close();
            } catch(Exception) {
                saveAsToolStripMenuItem_Click(sender, e);
            }
        }
        
        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e) {
            Stream s;
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            saveFileDialog1.Filter = "csv files (*.csv)|*.csv";
            saveFileDialog1.FilterIndex = 1 ;
            saveFileDialog1.RestoreDirectory = true ;

            if(saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if((s = saveFileDialog1.OpenFile()) != null)
                {
                    lastSessionCsv = saveFileDialog1.FileName;
                    exporter.Export(s);
                    s.Close();
                }
            }
        }
        
        private void commodityStation1_TextChanged(object sender, EventArgs e) {
            if(commCBs.IndexOf((ComboBox)sender) != -1) {
                route.Commodities[commCBs.IndexOf((ComboBox)sender)] = ((Control)sender).Text;
                commodityStation1.ForeColor = Color.Black;
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e) {
            Log.Dispose();
            settingsForm.SaveFile("GEN_settings.ini");
            /*List<string> settings = new List<string>();
            for(int i=0;i<systemTBs.Count;i++) {
                settings.Add(systemTBs[i].Text);
                settings.Add(stationTBs[i].Text);
                settings.Add(commCBs[i].Text);
                settings.Add(buyTBs[i].Text);
                settings.Add(sellTBs[i].Text);
            }
            settings.Add(tonsTB.Text);
            settings.Add(lastSessionCsv);*/
            Settings.SaveSettings("DATA_settings.ini", new string[] {lastSessionCsv});
            /*if(exporter.NeedToSave) {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.CreatePrompt = true;
                saveFileDialog.ShowDialog();
            }*/
        }

        private void hotkeysToolStripMenuItem_Click(object sender, EventArgs e) {
            hotkeysForm.SetKeyboardTracking(keyboardTracking);
            hotkeysForm.Visible = true;
        }

        private void Form1_Click(object sender, EventArgs e) {
            this.ActiveControl = swLabel;
        }

        private void tb_Click(object sender, EventArgs e) {
            if(sender is Control) {
                Control ctrl = (Control)sender;
                if(ctrl.Text == defaultStates[sender]) {
                    ctrl.Text = string.Empty;
                    ctrl.ForeColor = Color.Black;
                }
            }            
        }

        private void swapStationsBtn_Click(object sender, EventArgs e) {
            /*for(int i=0;i<systemTBs.Count;i++) {

            }*/
            /*string tmpStation = system1TB.Text;
            string tmpBuy = buyStation1TB.Text;
            string tmpSell = sellStation1TB.Text;
            string tmpComm = commodityStation1.Text;

            Color tmpStationColor = system1TB.ForeColor;
            Color tmpBuyColor = buyStation1TB.ForeColor;
            Color tmpSellColor = sellStation1TB.ForeColor;
            Color tmpCommColor = commodityStation1.ForeColor;
                

            system1TB.Text = station2TB.Text;
            buyStation1TB.Text = buyStation2TB.Text;
            sellStation1TB.Text = sellStation2TB.Text;
            commodityStation1.Text = commodityStation2.Text;

            system1TB.ForeColor = station2TB.ForeColor;            
            buyStation1TB.ForeColor = buyStation2TB.ForeColor;
            sellStation1TB.ForeColor = sellStation2TB.ForeColor;
            commodityStation1.ForeColor = commodityStation2.ForeColor;
            
            station2TB.Text = tmpStation;
            buyStation2TB.Text = tmpBuy;
            sellStation2TB.Text = tmpSell;
            commodityStation2.Text = tmpComm; 

            station2TB.ForeColor = tmpStationColor;            
            buyStation2TB.ForeColor = tmpBuyColor;
            sellStation2TB.ForeColor = tmpSellColor;
            commodityStation2.ForeColor = tmpCommColor;*/
        }
        
        private void LoadCsvFile(Stream s) {
            try { 
                CsvImporter importer = new CsvImporter(s);
                exporter = importer.ToCsvExporter();
                exporter.LoadDataGridView(dataGridView);
                for(int i=0;i<importer.Stations.Count;i++) {
                    if(i > 0) {
                        AddNewRouteRow();
                    }
                    systemTBs[i].Text = importer.Systems[i];
                    stationTBs[i].Text = importer.Stations[i];
                    commCBs[i].Text = importer.Commodities[i];
                    buyTBs[i].Text = importer.BuyPrices[i];
                    sellTBs[i].Text = importer.SellPrices[i];
                }
                tonsTB.Text = importer.Tons;
            } catch(Exception) {
                MessageBox.Show("Error in loading the .csv file");
            }
        }

        private void abandonBtn_Click(object sender, EventArgs e) {
            route.End();
        }

        private void SetDefaultState(string text, Control ctrl) {
            ctrl.Text = text;
            ctrl.ForeColor = Color.Gray;
        }

        private void tb_Leave(object sender, EventArgs e) {
            if(sender is Control) {
                Control ctrl = (Control) sender;                
                if(ctrl.Text == string.Empty) {
                    SetDefaultState(defaultStates[ctrl], ctrl);
                }
            }
        }
                
        private void dataTabPage_Click(object sender, EventArgs e) {
            this.ActiveControl = swLabel;
        }
        
        private void ShowToolTip(Control owner) {
        }

        private void tb_MouseLeave(object sender, EventArgs e) { 
            toolTip.Hide((Control)sender);
        }

        private void tb_MouseEnter(object sender, EventArgs e) {
            if(sender is Control) {
                toolTip.Show(toolTips[sender], (Control)sender, 0, ((Control)sender).Height, 3000);
            }
        }

        private void Form1_Resize(object sender, EventArgs e) {
            if (FormWindowState.Minimized == this.WindowState) {
               trayIcon.Visible = true;
               trayIcon.ShowBalloonTip(5000);
               this.Hide();
            } else if (FormWindowState.Normal == this.WindowState) {
               trayIcon.Visible = false;
            }
        }
        
        private void dataCollTab_TabIndexChanged(object sender, EventArgs e) {
            /*if(dataCollTab.SelectedIndex == 1) { //show data
                exporter.LoadDataGridView(dataGridView);
            }*/
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e) {
            settingsForm.Visible = true;
            settingsForm.SetSettings(actionBuilder);
        }
        
        int panelY = 53;
        private void AddNewRouteRow() {
            Button removeBtn = CopyEvents.CopyAttr(this.removeBtn, new Button(), panelY, defaultStates, toolTips);
            TextBox stationTB = CopyEvents.CopyAttr(station1TB, new TextBox(), panelY, defaultStates, toolTips);
            TextBox systemTB = CopyEvents.CopyAttr(system1TB, new TextBox(), panelY, defaultStates, toolTips);
            panelY += 26;

            ComboBox commCB = CopyEvents.CopyAttr(commodityStation1, new ComboBox(), panelY, defaultStates, toolTips);
            TextBox buyTB = CopyEvents.CopyAttr(buyStation1TB, new TextBox(), panelY, defaultStates, toolTips);
            TextBox sellTB = CopyEvents.CopyAttr(sellStation1TB, new TextBox(), panelY, defaultStates, toolTips);
            panelY += 27;

            //routePanel.Controls.Add(removeBtn);
            routePanel.Controls.Add(stationTB);
            routePanel.Controls.Add(systemTB);
            routePanel.Controls.Add(commCB);
            routePanel.Controls.Add(buyTB);
            routePanel.Controls.Add(sellTB);

            //removeBTNs.Add(removeBtn);
            systemTBs.Add(systemTB);
            stationTBs.Add(stationTB);
            commCBs.Add(commCB);
            buyTBs.Add(buyTB);
            sellTBs.Add(sellTB);

            route.Stations.Add(String.Empty);
            route.Systems.Add(String.Empty);
            route.Commodities.Add(String.Empty);
            route.BuyPrices.Add(0);
            route.SellPrices.Add(0);
        }

        private void addNewBtn_Click(object sender, EventArgs e) {
            /*if(dataGridView.Rows.Count > 1) {
                DialogResult dr = MessageBox.Show("Warning: Adding a new row while a spreadsheet already exists will delete your current spreadsheet, do you wish to continue?", 
                    "Add New System Warning", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                switch(dr) {
                    case DialogResult.Yes:
                        dataGridView.Columns.Clear();
                        dataGridView.Rows.Clear();
                        AddNewRouteRow();
                        exporter = new CsvExporter(route);
                        break;
                    case DialogResult.No:
                    case DialogResult.Cancel:
                        return;                
                }
            }*/
        }
        
        private void removeBtn_Click(object sender, EventArgs e) {
            /*for(int i=0;i<removeBTNs.Count;i++) {
                if((Button)sender == removeBTNs[i]) {
                    for(int j=i+1;j<removeBTNs.Count;j++) {
                        systemTBs[j].Location = new Point(systemTBs[j].Location.X, systemTBs[j].Location.Y - 53);
                        stationTBs[j].Location = new Point(stationTBs[j].Location.X, stationTBs[j].Location.Y - 53);
                        commCBs[j].Location = new Point(commCBs[j].Location.X, commCBs[j].Location.Y - 53);
                        buyTBs[j].Location = new Point(buyTBs[j].Location.X, buyTBs[j].Location.Y - 53);
                        sellTBs[j].Location = new Point(sellTBs[j].Location.X, sellTBs[j].Location.Y - 53);
                        removeBTNs[j].Location = new Point(removeBTNs[j].Location.X, removeBTNs[j].Location.Y - 53);
                    }
                    
                    systemTBs[i].Dispose();
                    stationTBs[i].Dispose();
                    commCBs[i].Dispose();
                    buyTBs[i].Dispose();
                    sellTBs[i].Dispose();
                    removeBTNs[i].Dispose();

                    routePanel.Controls.Remove(stationTBs[i]);
                    routePanel.Controls.Remove(systemTBs[i]);
                    routePanel.Controls.Remove(commCBs[i]);
                    routePanel.Controls.Remove(buyTBs[i]);
                    routePanel.Controls.Remove(sellTBs[i]);
                    routePanel.Controls.Remove(removeBTNs[i]);
                                        
                    systemTBs.RemoveAt(i);
                    stationTBs.RemoveAt(i);
                    commCBs.RemoveAt(i);
                    buyTBs.RemoveAt(i);
                    sellTBs.RemoveAt(i);
                    removeBTNs.RemoveAt(i);
                    
                    route.Systems.RemoveAt(i);
                    route.Stations.RemoveAt(i);
                    route.Commodities.RemoveAt(i);
                    route.BuyPrices.RemoveAt(i);
                    route.SellPrices.RemoveAt(i);

                    panelY -= 53;

                    break;
                }
            }*/
        }

        private void Form1_ResizeEnd(object sender, EventArgs e) {            
            int BorderWidth = (this.Width - this.ClientSize.Width);
            int BorderHeight = /*(this.Height - this.ClientSize.Height - 2*/(2 * BorderWidth+10) + menuStrip1.Size.Height;
            dataGridView.Size = new Size(Size.Width - BorderWidth, Size.Height - BorderHeight);
            dataCollTab.Size = new Size(Size.Width - BorderWidth, Size.Height - BorderHeight);
            routePanel.Size = new Size(routePanel.Size.Width, dataCollTab.Size.Height - dataCollTab.Location.Y - BorderHeight);
        }


    }
}
