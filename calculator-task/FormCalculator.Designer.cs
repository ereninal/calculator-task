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
            this.button16 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.BoxKeys.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNumbers
            // 
            this.txtNumbers.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtNumbers.Location = new System.Drawing.Point(12, 44);
            this.txtNumbers.MaxLength = 3276;
            this.txtNumbers.Name = "txtNumbers";
            this.txtNumbers.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtNumbers.Size = new System.Drawing.Size(222, 22);
            this.txtNumbers.TabIndex = 1;
            this.txtNumbers.Text = "0";
            this.txtNumbers.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNumbers_KeyPress);
            // 
            // BoxKeys
            // 
            this.BoxKeys.Controls.Add(this.button16);
            this.BoxKeys.Controls.Add(this.button12);
            this.BoxKeys.Controls.Add(this.button18);
            this.BoxKeys.Controls.Add(this.button8);
            this.BoxKeys.Controls.Add(this.button17);
            this.BoxKeys.Controls.Add(this.button4);
            this.BoxKeys.Controls.Add(this.button15);
            this.BoxKeys.Controls.Add(this.button11);
            this.BoxKeys.Controls.Add(this.button7);
            this.BoxKeys.Controls.Add(this.button3);
            this.BoxKeys.Controls.Add(this.button14);
            this.BoxKeys.Controls.Add(this.button10);
            this.BoxKeys.Controls.Add(this.button6);
            this.BoxKeys.Controls.Add(this.button2);
            this.BoxKeys.Controls.Add(this.button13);
            this.BoxKeys.Controls.Add(this.button9);
            this.BoxKeys.Controls.Add(this.button5);
            this.BoxKeys.Controls.Add(this.button1);
            this.BoxKeys.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BoxKeys.Location = new System.Drawing.Point(12, 72);
            this.BoxKeys.Name = "BoxKeys";
            this.BoxKeys.Size = new System.Drawing.Size(222, 182);
            this.BoxKeys.TabIndex = 2;
            this.BoxKeys.TabStop = false;
            // 
            // button16
            // 
            this.button16.Location = new System.Drawing.Point(180, 96);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(36, 72);
            this.button16.TabIndex = 0;
            this.button16.Text = "=";
            this.button16.UseVisualStyleBackColor = true;
            this.button16.Click += new System.EventHandler(this.Operator_Click);
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(136, 96);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(36, 33);
            this.button12.TabIndex = 0;
            this.button12.Text = "-";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.Operator_Click);
            // 
            // button18
            // 
            this.button18.Location = new System.Drawing.Point(178, 57);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(36, 33);
            this.button18.TabIndex = 0;
            this.button18.Text = "AC";
            this.button18.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(136, 57);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(36, 33);
            this.button8.TabIndex = 0;
            this.button8.Text = "/";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.Operator_Click);
            // 
            // button17
            // 
            this.button17.Location = new System.Drawing.Point(178, 18);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(36, 33);
            this.button17.TabIndex = 0;
            this.button17.Text = "C";
            this.button17.UseVisualStyleBackColor = true;
            this.button17.Click += new System.EventHandler(this.Clear_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(136, 18);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(36, 33);
            this.button4.TabIndex = 0;
            this.button4.Text = "X";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Operator_Click);
            // 
            // button15
            // 
            this.button15.Location = new System.Drawing.Point(136, 135);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(36, 33);
            this.button15.TabIndex = 0;
            this.button15.Text = "+";
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.Operator_Click);
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(94, 96);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(36, 33);
            this.button11.TabIndex = 0;
            this.button11.Text = "3";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.Numbers_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(94, 57);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(36, 33);
            this.button7.TabIndex = 0;
            this.button7.Text = "6";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.Numbers_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(94, 18);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(36, 33);
            this.button3.TabIndex = 0;
            this.button3.Text = "9";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Numbers_Click);
            // 
            // button14
            // 
            this.button14.Location = new System.Drawing.Point(94, 135);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(36, 33);
            this.button14.TabIndex = 0;
            this.button14.Text = ".";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.Numbers_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(52, 96);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(36, 33);
            this.button10.TabIndex = 0;
            this.button10.Text = "2";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.Numbers_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(52, 57);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(36, 33);
            this.button6.TabIndex = 0;
            this.button6.Text = "5";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.Numbers_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(52, 18);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(36, 33);
            this.button2.TabIndex = 0;
            this.button2.Text = "8";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Numbers_Click);
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(10, 135);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(78, 33);
            this.button13.TabIndex = 0;
            this.button13.Text = "0";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.Numbers_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(10, 96);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(36, 33);
            this.button9.TabIndex = 0;
            this.button9.Text = "1";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.Numbers_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(10, 57);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(36, 33);
            this.button5.TabIndex = 0;
            this.button5.Text = "4";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.Numbers_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(10, 18);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(36, 33);
            this.button1.TabIndex = 0;
            this.button1.Text = "7";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Numbers_Click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblResult.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblResult.Location = new System.Drawing.Point(13, 13);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 16);
            this.lblResult.TabIndex = 3;
            // 
            // FormCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(246, 269);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.BoxKeys);
            this.Controls.Add(this.txtNumbers);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormCalculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hesap Makinesi";
            this.Load += new System.EventHandler(this.FormCalculator_Load);
            this.BoxKeys.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox BoxKeys;
        public System.Windows.Forms.TextBox txtNumbers;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Label lblResult;
    }
}

