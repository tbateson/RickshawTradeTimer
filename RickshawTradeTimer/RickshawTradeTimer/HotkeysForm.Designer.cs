namespace RickshawTradeTimer {
    partial class HotkeysForm {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HotkeysForm));
            this.saveButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.nextStationHKTB = new System.Windows.Forms.TextBox();
            this.typenextstationLabel = new System.Windows.Forms.Label();
            this.modifiersNextStationCB = new System.Windows.Forms.CheckedListBox();
            this.modifiersPhaseCB = new System.Windows.Forms.CheckedListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.phaseHKTB = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // saveButton
            // 
            this.saveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveButton.Location = new System.Drawing.Point(12, 227);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 0;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelButton.Location = new System.Drawing.Point(197, 227);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 1;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // nextStationHKTB
            // 
            this.nextStationHKTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nextStationHKTB.Location = new System.Drawing.Point(193, 131);
            this.nextStationHKTB.Name = "nextStationHKTB";
            this.nextStationHKTB.ReadOnly = true;
            this.nextStationHKTB.Size = new System.Drawing.Size(75, 20);
            this.nextStationHKTB.TabIndex = 2;
            this.nextStationHKTB.Click += new System.EventHandler(this.nextStationHKTB_Click);
            // 
            // typenextstationLabel
            // 
            this.typenextstationLabel.AutoSize = true;
            this.typenextstationLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.typenextstationLabel.Location = new System.Drawing.Point(8, 134);
            this.typenextstationLabel.Name = "typenextstationLabel";
            this.typenextstationLabel.Size = new System.Drawing.Size(95, 13);
            this.typenextstationLabel.TabIndex = 3;
            this.typenextstationLabel.Text = "Type Next Station:";
            // 
            // modifiersNextStationCB
            // 
            this.modifiersNextStationCB.FormattingEnabled = true;
            this.modifiersNextStationCB.Items.AddRange(new object[] {
            "Ctrl",
            "Alt",
            "Shift"});
            this.modifiersNextStationCB.Location = new System.Drawing.Point(112, 117);
            this.modifiersNextStationCB.Name = "modifiersNextStationCB";
            this.modifiersNextStationCB.Size = new System.Drawing.Size(75, 49);
            this.modifiersNextStationCB.TabIndex = 4;
            this.modifiersNextStationCB.Visible = false;
            // 
            // modifiersPhaseCB
            // 
            this.modifiersPhaseCB.FormattingEnabled = true;
            this.modifiersPhaseCB.Items.AddRange(new object[] {
            "Ctrl",
            "Alt",
            "Shift"});
            this.modifiersPhaseCB.Location = new System.Drawing.Point(112, 43);
            this.modifiersPhaseCB.Name = "modifiersPhaseCB";
            this.modifiersPhaseCB.Size = new System.Drawing.Size(75, 49);
            this.modifiersPhaseCB.TabIndex = 7;
            this.modifiersPhaseCB.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Location = new System.Drawing.Point(8, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Next Phase:";
            // 
            // phaseHKTB
            // 
            this.phaseHKTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.phaseHKTB.Location = new System.Drawing.Point(193, 57);
            this.phaseHKTB.Name = "phaseHKTB";
            this.phaseHKTB.ReadOnly = true;
            this.phaseHKTB.Size = new System.Drawing.Size(75, 20);
            this.phaseHKTB.TabIndex = 5;
            this.phaseHKTB.Click += new System.EventHandler(this.phaseHKTB_Click);
            // 
            // HotkeysForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.modifiersPhaseCB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.phaseHKTB);
            this.Controls.Add(this.modifiersNextStationCB);
            this.Controls.Add(this.typenextstationLabel);
            this.Controls.Add(this.nextStationHKTB);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.saveButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "HotkeysForm";
            this.Text = "HotkeysForm";
            this.Load += new System.EventHandler(this.HotkeysForm_Load);
            this.VisibleChanged += new System.EventHandler(this.HotkeysForm_VisibleChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.TextBox nextStationHKTB;
        private System.Windows.Forms.Label typenextstationLabel;
        private System.Windows.Forms.CheckedListBox modifiersNextStationCB;
        private System.Windows.Forms.CheckedListBox modifiersPhaseCB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox phaseHKTB;
    }
}