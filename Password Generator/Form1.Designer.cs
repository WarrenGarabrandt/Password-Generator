namespace Password_Generator
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
            this.lblPassword = new System.Windows.Forms.Label();
            this.cmdGenerate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.nudNumbers = new System.Windows.Forms.NumericUpDown();
            this.nudSymbols = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumbers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSymbols)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPassword
            // 
            this.lblPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPassword.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPassword.Location = new System.Drawing.Point(12, 9);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(560, 88);
            this.lblPassword.TabIndex = 0;
            this.lblPassword.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblPassword.Click += new System.EventHandler(this.lblPassword_Click);
            // 
            // cmdGenerate
            // 
            this.cmdGenerate.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.cmdGenerate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmdGenerate.Location = new System.Drawing.Point(230, 100);
            this.cmdGenerate.Name = "cmdGenerate";
            this.cmdGenerate.Size = new System.Drawing.Size(124, 64);
            this.cmdGenerate.TabIndex = 1;
            this.cmdGenerate.Text = "Generate\r\nPassword";
            this.cmdGenerate.UseVisualStyleBackColor = true;
            this.cmdGenerate.Click += new System.EventHandler(this.cmdGenerate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Numbers:";
            this.label1.Visible = false;
            // 
            // nudNumbers
            // 
            this.nudNumbers.Location = new System.Drawing.Point(77, 98);
            this.nudNumbers.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.nudNumbers.Name = "nudNumbers";
            this.nudNumbers.Size = new System.Drawing.Size(57, 23);
            this.nudNumbers.TabIndex = 3;
            this.nudNumbers.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nudNumbers.Visible = false;
            // 
            // nudSymbols
            // 
            this.nudSymbols.Location = new System.Drawing.Point(77, 125);
            this.nudSymbols.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.nudSymbols.Name = "nudSymbols";
            this.nudSymbols.Size = new System.Drawing.Size(57, 23);
            this.nudSymbols.TabIndex = 5;
            this.nudSymbols.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nudSymbols.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Symbols:";
            this.label2.Visible = false;
            // 
            // Form1
            // 
            this.AcceptButton = this.cmdGenerate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 176);
            this.Controls.Add(this.nudSymbols);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nudNumbers);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmdGenerate);
            this.Controls.Add(this.lblPassword);
            this.Name = "Form1";
            this.Text = "Random Password Generator";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudNumbers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSymbols)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Button cmdGenerate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudNumbers;
        private System.Windows.Forms.NumericUpDown nudSymbols;
        private System.Windows.Forms.Label label2;
    }
}
