namespace MistPositioningSystem
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
            this.components = new System.ComponentModel.Container();
            this.txtMistsTrackingCode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tmrAutoReport = new System.Windows.Forms.Timer(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.chkSendMyPosition = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtMistsTrackingCode
            // 
            this.txtMistsTrackingCode.Location = new System.Drawing.Point(12, 27);
            this.txtMistsTrackingCode.Name = "txtMistsTrackingCode";
            this.txtMistsTrackingCode.Size = new System.Drawing.Size(205, 20);
            this.txtMistsTrackingCode.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "MPS Password";
            // 
            // tmrAutoReport
            // 
            this.tmrAutoReport.Enabled = true;
            this.tmrAutoReport.Interval = 10000;
            this.tmrAutoReport.Tick += new System.EventHandler(this.tmrAutoReport_Tick);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 53);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(205, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Report Few (CTRL + F9)";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 82);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(205, 23);
            this.button3.TabIndex = 4;
            this.button3.Text = "Report Many  (CTRL + F10)";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(12, 111);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(205, 23);
            this.button4.TabIndex = 5;
            this.button4.Text = "Report Zerg (CTRL + F11)";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // chkSendMyPosition
            // 
            this.chkSendMyPosition.AutoSize = true;
            this.chkSendMyPosition.Location = new System.Drawing.Point(12, 140);
            this.chkSendMyPosition.Name = "chkSendMyPosition";
            this.chkSendMyPosition.Size = new System.Drawing.Size(205, 17);
            this.chkSendMyPosition.TabIndex = 6;
            this.chkSendMyPosition.Text = "Report My Position Every 10 Seconds";
            this.chkSendMyPosition.UseVisualStyleBackColor = true;
            this.chkSendMyPosition.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(234, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 109);
            this.label2.TabIndex = 7;
            this.label2.Text = "Note: The hotkeys listed for the report buttons are global hotkeys that will work" +
    " within GW2.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 167);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.chkSendMyPosition);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMistsTrackingCode);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Mist Positioning System";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMistsTrackingCode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer tmrAutoReport;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.CheckBox chkSendMyPosition;
        private System.Windows.Forms.Label label2;
    }
}

