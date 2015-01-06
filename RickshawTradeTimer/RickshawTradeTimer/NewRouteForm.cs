using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace RickshawTradeTimer {
    public partial class NewRouteForm : Form {
        public DialogResult? Result { get; set; }
        public int? Value { get; set; }
        Form1 callback;

        public NewRouteForm() {
            InitializeComponent();
        }

        public void SetCallback(Form1 form) {
            callback = form;
        }

        private void confirmBtn_Click(object sender, EventArgs e) {
            DialogResult result = MessageBox.Show("Before proceeding, make sure your current route has been saved.\n\nContinue?", "Save Old Route", MessageBoxButtons.YesNo);
            if(result == DialogResult.Yes) {
                Result = DialogResult.OK;
                try {
                    Value = Int32.Parse(valueTB.Text);
                } catch(FormatException) {
                    MessageBox.Show("Enter a valid number");
                }
            } else {
                Result = DialogResult.Cancel;
            }
            callback.newRouteButton_Callback(this);
        }

        private void cancelBtn_Click(object sender, EventArgs e) {
            Result = DialogResult.Cancel;
            /*try {
                Value = Int32.Parse(valueTB.Text);*/
                callback.newRouteButton_Callback(this);
            /*} catch(FormatException) {
                MessageBox.Show("Enter a valid number");
            }*/
        }

        public void Reset() {
            Result = null;
            Value = null;
            valueTB.Text = String.Empty;
        }
    }
}
