namespace RickshawTradeTimer {
    partial class SettingsForm {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            this.pauseOnCheckpointCB = new System.Windows.Forms.CheckBox();
            this.pauseOnEndCB = new System.Windows.Forms.CheckBox();
            this.cancelButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.enableAnnoucerCB = new System.Windows.Forms.CheckBox();
            this.annoucerVolumeTB = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.annoucerVolumeTB)).BeginInit();
            this.SuspendLayout();
            // 
            // pauseOnCheckpointCB
            // 
            this.pauseOnCheckpointCB.AutoSize = true;
            this.pauseOnCheckpointCB.Checked = true;
            this.pauseOnCheckpointCB.CheckState = System.Windows.Forms.CheckState.Checked;
            this.pauseOnCheckpointCB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pauseOnCheckpointCB.Location = new System.Drawing.Point(12, 12);
            this.pauseOnCheckpointCB.Name = "pauseOnCheckpointCB";
            this.pauseOnCheckpointCB.Size = new System.Drawing.Size(131, 17);
            this.pauseOnCheckpointCB.TabIndex = 0;
            this.pauseOnCheckpointCB.Text = "Pause on Checkpoint?";
            this.pauseOnCheckpointCB.UseVisualStyleBackColor = true;
            // 
            // pauseOnEndCB
            // 
            this.pauseOnEndCB.AutoSize = true;
            this.pauseOnEndCB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pauseOnEndCB.Location = new System.Drawing.Point(12, 35);
            this.pauseOnEndCB.Name = "pauseOnEndCB";
            this.pauseOnEndCB.Size = new System.Drawing.Size(119, 17);
            this.pauseOnEndCB.TabIndex = 1;
            this.pauseOnEndCB.Text = "Continuous Routes?";
            this.pauseOnEndCB.UseVisualStyleBackColor = true;
            // 
            // cancelButton
            // 
            this.cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelButton.Location = new System.Drawing.Point(253, 245);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 3;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveButton.Location = new System.Drawing.Point(68, 245);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 2;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // enableAnnoucerCB
            // 
            this.enableAnnoucerCB.AutoSize = true;
            this.enableAnnoucerCB.Checked = true;
            this.enableAnnoucerCB.CheckState = System.Windows.Forms.CheckState.Checked;
            this.enableAnnoucerCB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.enableAnnoucerCB.Location = new System.Drawing.Point(12, 58);
            this.enableAnnoucerCB.Name = "enableAnnoucerCB";
            this.enableAnnoucerCB.Size = new System.Drawing.Size(105, 17);
            this.enableAnnoucerCB.TabIndex = 4;
            this.enableAnnoucerCB.Text = "Enable Annoucer";
            this.enableAnnoucerCB.UseVisualStyleBackColor = true;
            this.enableAnnoucerCB.CheckedChanged += new System.EventHandler(this.enableAnnoucerCB_CheckedChanged);
            // 
            // annoucerVolumeTB
            // 
            this.annoucerVolumeTB.Location = new System.Drawing.Point(253, 58);
            this.annoucerVolumeTB.Name = "annoucerVolumeTB";
            this.annoucerVolumeTB.Size = new System.Drawing.Size(104, 45);
            this.annoucerVolumeTB.TabIndex = 5;
            this.annoucerVolumeTB.Value = 5;
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 280);
            this.Controls.Add(this.annoucerVolumeTB);
            this.Controls.Add(this.enableAnnoucerCB);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.pauseOnEndCB);
            this.Controls.Add(this.pauseOnCheckpointCB);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SettingsForm";
            this.Text = "SettingsForm";
            this.VisibleChanged += new System.EventHandler(this.SettingsForm_VisibleChanged);
            ((System.ComponentModel.ISupportInitialize)(this.annoucerVolumeTB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox pauseOnCheckpointCB;
        private System.Windows.Forms.CheckBox pauseOnEndCB;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.CheckBox enableAnnoucerCB;
        private System.Windows.Forms.TrackBar annoucerVolumeTB;
    }
}