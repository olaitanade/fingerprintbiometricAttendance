namespace UI_Support
{
    partial class V_Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(V_Home));
            this.registration_btn = new System.Windows.Forms.Button();
            this.verification_btn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // registration_btn
            // 
            this.registration_btn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.registration_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registration_btn.Location = new System.Drawing.Point(123, 63);
            this.registration_btn.Name = "registration_btn";
            this.registration_btn.Size = new System.Drawing.Size(144, 43);
            this.registration_btn.TabIndex = 0;
            this.registration_btn.Text = "Registration";
            this.registration_btn.UseVisualStyleBackColor = true;
            this.registration_btn.Click += new System.EventHandler(this.registration_Click);
            // 
            // verification_btn
            // 
            this.verification_btn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.verification_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.verification_btn.Location = new System.Drawing.Point(123, 189);
            this.verification_btn.Name = "verification_btn";
            this.verification_btn.Size = new System.Drawing.Size(144, 42);
            this.verification_btn.TabIndex = 1;
            this.verification_btn.Text = "Verification";
            this.verification_btn.UseVisualStyleBackColor = true;
            this.verification_btn.Click += new System.EventHandler(this.verification_Click);
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.verification_btn);
            this.panel1.Controls.Add(this.registration_btn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(402, 358);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(172, 335);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "@2019";
            // 
            // V_Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 358);
            this.Controls.Add(this.panel1);
            this.Name = "V_Home";
            this.Text = "BIOMETRIC FINGERPRINT VERIFICATION";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button registration_btn;
        private System.Windows.Forms.Button verification_btn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;

    }
}