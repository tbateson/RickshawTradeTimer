namespace RickshawTradeTimer {
    partial class NewRouteForm {
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
            this.cancelBtn = new System.Windows.Forms.Button();
            this.valueTB = new System.Windows.Forms.TextBox();
            this.confirmBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(158, 49);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(101, 23);
            this.cancelBtn.TabIndex = 1;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // valueTB
            // 
            this.valueTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.valueTB.Location = new System.Drawing.Point(80, 15);
            this.valueTB.Name = "valueTB";
            this.valueTB.Size = new System.Drawing.Size(100, 20);
            this.valueTB.TabIndex = 3;
            // 
            // confirmBtn
            // 
            this.confirmBtn.Location = new System.Drawing.Point(3, 49);
            this.confirmBtn.Name = "confirmBtn";
            this.confirmBtn.Size = new System.Drawing.Size(101, 23);
            this.confirmBtn.TabIndex = 4;
            this.confirmBtn.Text = "Confirm";
            this.confirmBtn.UseVisualStyleBackColor = true;
            this.confirmBtn.Click += new System.EventHandler(this.confirmBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Enter the number of stations in the new route:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.valueTB);
            this.panel1.Controls.Add(this.confirmBtn);
            this.panel1.Controls.Add(this.cancelBtn);
            this.panel1.Location = new System.Drawing.Point(1, 66);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(262, 75);
            this.panel1.TabIndex = 6;
            // 
            // NewRouteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(262, 141);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NewRouteForm";
            this.Text = "New Route Confirmation";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.TextBox valueTB;
        private System.Windows.Forms.Button confirmBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
    }
}