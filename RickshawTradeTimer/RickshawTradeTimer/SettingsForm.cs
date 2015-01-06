using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace RickshawTradeTimer {
    public partial class SettingsForm : Form {
        public bool PauseOnEnd { get { return pauseOnEndCB.Checked; } 
                                 set { pauseOnEndCB.Checked = value; }}
        public bool PauseOnCheckpoint { get { return pauseOnCheckpointCB.Checked; }
                                        set { pauseOnCheckpointCB.Checked = value; }}
        public bool AnnoucerEnabled { get { return enableAnnoucerCB.Checked; }
                                      set { enableAnnoucerCB.Checked = value; }}

        ActionBuilder actionBuilder = null;

        public object[] oldSettings = new object[4];

        public SettingsForm() {
            InitializeComponent();
        }

        public void SetSettings(ActionBuilder actionBuilder) {
            this.actionBuilder = actionBuilder;
            actionBuilder.PauseOnCheckpoint = PauseOnEnd;
            actionBuilder.PauseOnEnd = PauseOnEnd;
            actionBuilder.AnnoucerEnabled = AnnoucerEnabled;
            actionBuilder.AnnoucerVolume = annoucerVolumeTB.Value;
        }

        private void saveButton_Click(object sender, EventArgs e) {
            this.Visible = false;
            if(actionBuilder != null) {
                actionBuilder.PauseOnCheckpoint = PauseOnEnd;
                actionBuilder.PauseOnEnd = PauseOnEnd;
                actionBuilder.AnnoucerEnabled = AnnoucerEnabled;
                actionBuilder.AnnoucerVolume = annoucerVolumeTB.Value;
            }
            SaveFile("GEN_settings.ini");
        }
        
        private void cancelButton_Click(object sender, EventArgs e) {
            PauseOnEnd = (bool)oldSettings[0];
            PauseOnCheckpoint = (bool)oldSettings[1];
            AnnoucerEnabled = (bool)oldSettings[2];
            annoucerVolumeTB.Value = (int)oldSettings[3];
            this.Visible = false;
        }

        private void SettingsForm_VisibleChanged(object sender, EventArgs e) {
            if(this.Visible) {
                oldSettings[0] = PauseOnEnd;
                oldSettings[1] = PauseOnCheckpoint;
                oldSettings[2] = AnnoucerEnabled;
                oldSettings[3] = annoucerVolumeTB.Value;
            }
        }

        private void enableAnnoucerCB_CheckedChanged(object sender, EventArgs e) {
            annoucerVolumeTB.Enabled = enableAnnoucerCB.Checked;
        }

        public void FromFile(string fileName) {
            StreamReader sr = new StreamReader(fileName);
            string[] splitSettings = sr.ReadToEnd().Split(',');
            sr.Close();
            PauseOnEnd = Boolean.Parse(splitSettings[0]);
            PauseOnCheckpoint = Boolean.Parse(splitSettings[1]);
            AnnoucerEnabled = Boolean.Parse(splitSettings[2]);
            int volume = Int32.Parse(splitSettings[3]);
            if(volume <= annoucerVolumeTB.Maximum) {
                annoucerVolumeTB.Value = volume;
            }
        }

        public void SaveFile(string fileName) {
            StreamWriter sw = new StreamWriter(fileName);
            sw.Write(PauseOnEnd + "," + PauseOnCheckpoint + "," + AnnoucerEnabled + "," + annoucerVolumeTB.Value);
            sw.Close();
        }
    }
}
