namespace ChecksumCalculator
{
    partial class ChecksumCalculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChecksumCalculator));
            this.textBoxInput = new System.Windows.Forms.TextBox();
            this.ButtonGetChecksum = new System.Windows.Forms.Button();
            this.Result = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxInput
            // 
            this.textBoxInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxInput.Location = new System.Drawing.Point(12, 33);
            this.textBoxInput.Name = "textBoxInput";
            this.textBoxInput.Size = new System.Drawing.Size(277, 20);
            this.textBoxInput.TabIndex = 0;
            this.textBoxInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ButtonGetChecksum
            // 
            this.ButtonGetChecksum.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonGetChecksum.Location = new System.Drawing.Point(82, 59);
            this.ButtonGetChecksum.Name = "ButtonGetChecksum";
            this.ButtonGetChecksum.Size = new System.Drawing.Size(137, 23);
            this.ButtonGetChecksum.TabIndex = 1;
            this.ButtonGetChecksum.Text = "Get checksum";
            this.ButtonGetChecksum.UseVisualStyleBackColor = true;
            this.ButtonGetChecksum.Click += new System.EventHandler(this.ButtonGetChecksum_Click);
            // 
            // Result
            // 
            this.Result.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Result.Location = new System.Drawing.Point(12, 85);
            this.Result.MaximumSize = new System.Drawing.Size(277, 99999);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(277, 9999);
            this.Result.TabIndex = 2;
            this.Result.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ChecksumCalculator
            // 
            this.AcceptButton = this.ButtonGetChecksum;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(301, 156);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.ButtonGetChecksum);
            this.Controls.Add(this.textBoxInput);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ChecksumCalculator";
            this.ShowIcon = false;
            this.Text = "Checksum calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxInput;
        private System.Windows.Forms.Button ButtonGetChecksum;
        private System.Windows.Forms.Label Result;
    }
}

