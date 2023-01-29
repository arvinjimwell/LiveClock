namespace LiveClock
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.HourBox = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.MinuteBox = new System.Windows.Forms.Label();
            this.MeridiemBox = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // HourBox
            // 
            this.HourBox.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.HourBox.Font = new System.Drawing.Font("Segoe UI", 120F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.HourBox.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.HourBox.Location = new System.Drawing.Point(12, 24);
            this.HourBox.MaximumSize = new System.Drawing.Size(400, 250);
            this.HourBox.MinimumSize = new System.Drawing.Size(100, 100);
            this.HourBox.Name = "HourBox";
            this.HourBox.Size = new System.Drawing.Size(346, 250);
            this.HourBox.TabIndex = 0;
            this.HourBox.Text = "12";
            this.HourBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(2, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1066, 10);
            this.label1.TabIndex = 1;
            // 
            // MinuteBox
            // 
            this.MinuteBox.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.MinuteBox.Font = new System.Drawing.Font("Segoe UI", 120F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.MinuteBox.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.MinuteBox.Location = new System.Drawing.Point(364, 24);
            this.MinuteBox.MaximumSize = new System.Drawing.Size(400, 250);
            this.MinuteBox.MinimumSize = new System.Drawing.Size(100, 100);
            this.MinuteBox.Name = "MinuteBox";
            this.MinuteBox.Size = new System.Drawing.Size(346, 250);
            this.MinuteBox.TabIndex = 2;
            this.MinuteBox.Text = "12";
            this.MinuteBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MeridiemBox
            // 
            this.MeridiemBox.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.MeridiemBox.Font = new System.Drawing.Font("Segoe UI", 120F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.MeridiemBox.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.MeridiemBox.Location = new System.Drawing.Point(716, 24);
            this.MeridiemBox.MaximumSize = new System.Drawing.Size(400, 250);
            this.MeridiemBox.MinimumSize = new System.Drawing.Size(100, 100);
            this.MeridiemBox.Name = "MeridiemBox";
            this.MeridiemBox.Size = new System.Drawing.Size(346, 250);
            this.MeridiemBox.TabIndex = 3;
            this.MeridiemBox.Text = "12";
            this.MeridiemBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1068, 298);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MeridiemBox);
            this.Controls.Add(this.MinuteBox);
            this.Controls.Add(this.HourBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Label HourBox;
        private Label label1;
        private Label MinuteBox;
        private Label MeridiemBox;
    }
}