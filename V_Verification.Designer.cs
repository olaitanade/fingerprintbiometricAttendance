namespace UI_Support
{
    partial class V_Verification
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(V_Verification));
            this.VerificationControl = new DPFP.Gui.Verification.VerificationControl();
            this.verificationControl1 = new DPFP.Gui.Verification.VerificationControl();
            this.label1 = new System.Windows.Forms.Label();
            this.verification_status_lbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // VerificationControl
            // 
            this.VerificationControl.Active = true;
            this.VerificationControl.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.VerificationControl.Location = new System.Drawing.Point(-198, 104);
            this.VerificationControl.Name = "VerificationControl";
            this.VerificationControl.ReaderSerialNumber = "00000000-0000-0000-0000-000000000000";
            this.VerificationControl.Size = new System.Drawing.Size(52, 52);
            this.VerificationControl.TabIndex = 7;
            // 
            // verificationControl1
            // 
            this.verificationControl1.Active = true;
            this.verificationControl1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.verificationControl1.Location = new System.Drawing.Point(229, 78);
            this.verificationControl1.Name = "verificationControl1";
            this.verificationControl1.ReaderSerialNumber = "00000000-0000-0000-0000-000000000000";
            this.verificationControl1.Size = new System.Drawing.Size(52, 52);
            this.verificationControl1.TabIndex = 8;
            this.verificationControl1.OnComplete += new DPFP.Gui.Verification.VerificationControl._OnComplete(this.OnComplete);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(44, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(414, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "TOUCH THE FINGERPRINT READER TO VERIFY";
            // 
            // verification_status_lbl
            // 
            this.verification_status_lbl.AutoSize = true;
            this.verification_status_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.verification_status_lbl.Location = new System.Drawing.Point(109, 133);
            this.verification_status_lbl.Name = "verification_status_lbl";
            this.verification_status_lbl.Size = new System.Drawing.Size(0, 76);
            this.verification_status_lbl.TabIndex = 10;
            // 
            // V_Verification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(494, 261);
            this.Controls.Add(this.verification_status_lbl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.verificationControl1);
            this.Controls.Add(this.VerificationControl);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Name = "V_Verification";
            this.Text = "VERIFICATION";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DPFP.Gui.Verification.VerificationControl VerificationControl;
        private DPFP.Gui.Verification.VerificationControl verificationControl1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label verification_status_lbl;
    }
}