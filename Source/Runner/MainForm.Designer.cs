namespace Runner
{
    partial class MainForm
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
            this.inputRichTextBox = new System.Windows.Forms.RichTextBox();
            this.sumOfMultiplesButton = new System.Windows.Forms.Button();
            this.sequenceAnalyzerButton = new System.Windows.Forms.Button();
            this.resultLabel = new System.Windows.Forms.Label();
            this.sumOfMultiplesInfoLabel = new System.Windows.Forms.Label();
            this.sequenceAnalyzerInfoLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // inputRichTextBox
            // 
            this.inputRichTextBox.Location = new System.Drawing.Point(12, 12);
            this.inputRichTextBox.Name = "inputRichTextBox";
            this.inputRichTextBox.Size = new System.Drawing.Size(385, 96);
            this.inputRichTextBox.TabIndex = 0;
            this.inputRichTextBox.Text = "Please Enter your input here";
            this.inputRichTextBox.Enter += new System.EventHandler(this.inputRichTextBox_Enter);
            // 
            // sumOfMultiplesButton
            // 
            this.sumOfMultiplesButton.Location = new System.Drawing.Point(49, 166);
            this.sumOfMultiplesButton.Name = "sumOfMultiplesButton";
            this.sumOfMultiplesButton.Size = new System.Drawing.Size(92, 45);
            this.sumOfMultiplesButton.TabIndex = 1;
            this.sumOfMultiplesButton.Text = "Sum of Multiples of 3 and 5";
            this.sumOfMultiplesButton.UseVisualStyleBackColor = true;
            this.sumOfMultiplesButton.Click += new System.EventHandler(this.sumOfMultiplesButton_Click);
            // 
            // sequenceAnalyzerButton
            // 
            this.sequenceAnalyzerButton.Location = new System.Drawing.Point(256, 166);
            this.sequenceAnalyzerButton.Name = "sequenceAnalyzerButton";
            this.sequenceAnalyzerButton.Size = new System.Drawing.Size(106, 45);
            this.sequenceAnalyzerButton.TabIndex = 2;
            this.sequenceAnalyzerButton.Text = "Upper case words analyzer";
            this.sequenceAnalyzerButton.UseVisualStyleBackColor = true;
            this.sequenceAnalyzerButton.Click += new System.EventHandler(this.sequenceAnalyzerButton_Click);
            // 
            // resultLabel
            // 
            this.resultLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultLabel.Location = new System.Drawing.Point(9, 222);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(388, 90);
            this.resultLabel.TabIndex = 3;
            // 
            // sumOfMultiplesInfoLabel
            // 
            this.sumOfMultiplesInfoLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.sumOfMultiplesInfoLabel.Location = new System.Drawing.Point(12, 111);
            this.sumOfMultiplesInfoLabel.Name = "sumOfMultiplesInfoLabel";
            this.sumOfMultiplesInfoLabel.Size = new System.Drawing.Size(385, 23);
            this.sumOfMultiplesInfoLabel.TabIndex = 4;
            this.sumOfMultiplesInfoLabel.Text = "For sum of Multiples: Please enter a number between 4 and 2147483647";
            // 
            // sequenceAnalyzerInfoLabel
            // 
            this.sequenceAnalyzerInfoLabel.Location = new System.Drawing.Point(12, 134);
            this.sequenceAnalyzerInfoLabel.Name = "sequenceAnalyzerInfoLabel";
            this.sequenceAnalyzerInfoLabel.Size = new System.Drawing.Size(385, 23);
            this.sequenceAnalyzerInfoLabel.TabIndex = 5;
            this.sequenceAnalyzerInfoLabel.Text = "For Upper Case words analyzer: Please enter Paragraph you want to analyze";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 321);
            this.Controls.Add(this.sequenceAnalyzerInfoLabel);
            this.Controls.Add(this.sumOfMultiplesInfoLabel);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.sequenceAnalyzerButton);
            this.Controls.Add(this.sumOfMultiplesButton);
            this.Controls.Add(this.inputRichTextBox);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(425, 360);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(425, 360);
            this.Name = "MainForm";
            this.Text = "ASML Task";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox inputRichTextBox;
        private System.Windows.Forms.Button sumOfMultiplesButton;
        private System.Windows.Forms.Button sequenceAnalyzerButton;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.Label sumOfMultiplesInfoLabel;
        private System.Windows.Forms.Label sequenceAnalyzerInfoLabel;
    }
}

