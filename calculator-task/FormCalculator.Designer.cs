namespace calculator_task
{
    partial class FormCalculator
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
            this.txtNumbers = new System.Windows.Forms.TextBox();
            this.BoxKeys = new System.Windows.Forms.GroupBox();
            this.SuspendLayout();
            // 
            // txtNumbers
            // 
            this.txtNumbers.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtNumbers.Location = new System.Drawing.Point(13, 13);
            this.txtNumbers.MaxLength = 3276;
            this.txtNumbers.Name = "txtNumbers";
            this.txtNumbers.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtNumbers.Size = new System.Drawing.Size(208, 22);
            this.txtNumbers.TabIndex = 1;
            // 
            // BoxKeys
            // 
            this.BoxKeys.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BoxKeys.Location = new System.Drawing.Point(13, 41);
            this.BoxKeys.Name = "BoxKeys";
            this.BoxKeys.Size = new System.Drawing.Size(208, 212);
            this.BoxKeys.TabIndex = 2;
            this.BoxKeys.TabStop = false;
            // 
            // FormCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(225, 257);
            this.Controls.Add(this.BoxKeys);
            this.Controls.Add(this.txtNumbers);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormCalculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hesap Makinesi";
            this.Load += new System.EventHandler(this.FormCalculator_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox BoxKeys;
        public System.Windows.Forms.TextBox txtNumbers;
    }
}

