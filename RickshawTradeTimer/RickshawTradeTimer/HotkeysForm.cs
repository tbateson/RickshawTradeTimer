using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Kennedy.ManagedHooks;

namespace RickshawTradeTimer {
    public partial class HotkeysForm : Form {
        Keys m_phaseHK;
        Keys m_nextStationHK;
        public Keys PhaseHK { get { return m_phaseHK; } set { phaseHKTB.Text = value.ToString(); m_phaseHK = value; } }
        public bool PhaseCtrl { get { return modifiersPhaseCB.GetItemCheckState(0) == CheckState.Checked; }
                                set { modifiersPhaseCB.SetItemChecked(0, value); }}
        public bool PhaseAlt { get { return modifiersPhaseCB.GetItemCheckState(1) == CheckState.Checked; }
                               set { modifiersPhaseCB.SetItemChecked(1, value); }}
        public bool PhaseShift { get { return modifiersPhaseCB.GetItemCheckState(2) == CheckState.Checked; }
                                 set { modifiersPhaseCB.SetItemChecked(2, value); }}
        public Keys NextStationHK { get { return m_nextStationHK; } set { nextStationHKTB.Text = value.ToString(); m_nextStationHK = value; } }
        public bool NextStationCtrl { get { return modifiersNextStationCB.GetItemCheckState(0) == CheckState.Checked; }
                                      set { modifiersNextStationCB.SetItemChecked(0, value); }}
        public bool NextStationAlt { get { return modifiersNextStationCB.GetItemCheckState(1) == CheckState.Checked; }
                                     set { modifiersNextStationCB.SetItemChecked(1, value); }}
        public bool NextStationShift { get { return modifiersNextStationCB.GetItemCheckState(2) == CheckState.Checked; }
                                       set { modifiersNextStationCB.SetItemChecked(2, value); }}
        
        string[] revetToOld = new string[8];

        KeyboardTracking keyboardTracking = null;


        public HotkeysForm() {
            InitializeComponent();
        }
        
        private void HotkeysForm_Load(object sender, EventArgs e) {
            revetToOld[0] = 0.ToString();
            revetToOld[1] = false.ToString();
            revetToOld[2] = false.ToString();
            revetToOld[3] = false.ToString();
            revetToOld[4] = 0.ToString();
            revetToOld[5] = false.ToString();
            revetToOld[6] = false.ToString();
            revetToOld[7] = false.ToString();
        }

        public void SetKeyboardTracking(KeyboardTracking kt) {
            keyboardTracking = kt;
        }

        private void phaseHKTB_Click(object sender, EventArgs e) {
            phaseHKTB.Text = "Press Key";
            if(keyboardTracking != null) { 
                keyboardTracking.KeyDown += new KeyboardHookExt.KeyboardEventHandlerExt(hM_PhaseKeyEvent);
            }
        }

        private void nextStationHKTB_Click(object sender, EventArgs e) {
            nextStationHKTB.Text = "Press Key";
            if(keyboardTracking != null) { 
                keyboardTracking.KeyDown += new KeyboardHookExt.KeyboardEventHandlerExt(hM_NextStationKeyEvent);
            }
        }

        private void hM_PhaseKeyEvent(Keys keys) {
            PhaseHK = keys;
            if(keyboardTracking != null) { 
                keyboardTracking.KeyDown -= new KeyboardHookExt.KeyboardEventHandlerExt(hM_PhaseKeyEvent);
            }
        }

        private void hM_NextStationKeyEvent(Keys keys) {
            NextStationHK = keys;
            if(keyboardTracking != null) { 
                keyboardTracking.KeyDown -= new KeyboardHookExt.KeyboardEventHandlerExt(hM_NextStationKeyEvent);
            }
        }

        private void saveButton_Click(object sender, EventArgs e) {
            string[] settings = new string[] { ((int)PhaseHK).ToString(), PhaseCtrl.ToString(), PhaseAlt.ToString(), PhaseShift.ToString(),
                ((int)NextStationHK).ToString(), NextStationCtrl.ToString(), NextStationAlt.ToString(), NextStationShift.ToString() };
            Settings.SaveSettings("HK_settings.ini", settings);
            this.Visible = false;
        }

        private void cancelButton_Click(object sender, EventArgs e) {
            PhaseHK = (Keys)Int32.Parse(revetToOld[0]);
            PhaseCtrl = Boolean.Parse(revetToOld[1]);
            PhaseAlt = Boolean.Parse(revetToOld[2]);
            PhaseShift = Boolean.Parse(revetToOld[3]);
            NextStationHK = (Keys)Int32.Parse(revetToOld[4]);
            NextStationCtrl = Boolean.Parse(revetToOld[5]);
            NextStationAlt = Boolean.Parse(revetToOld[6]);
            NextStationShift = Boolean.Parse(revetToOld[7]);
            this.Visible = false;
        }

        private void HotkeysForm_VisibleChanged(object sender, EventArgs e) {
            if(this.Visible) {
                try { 
                    revetToOld = Settings.LoadSettings("HK_settings.ini");
                } catch(Exception) { }
            }
        }

    }
}
