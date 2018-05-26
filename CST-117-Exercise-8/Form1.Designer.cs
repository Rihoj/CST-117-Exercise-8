namespace CST_117_Exercise_8
{
    partial class caloriesCalcForm
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
            this.fatGramLabel = new System.Windows.Forms.Label();
            this.carbGramLabel = new System.Windows.Forms.Label();
            this.fatGramTextBox = new System.Windows.Forms.TextBox();
            this.carbGramTextBox = new System.Windows.Forms.TextBox();
            this.fatCaloriesOutputLabel = new System.Windows.Forms.Label();
            this.carbCaloriesOutputLabel = new System.Windows.Forms.Label();
            this.totalCaloriesLabel = new System.Windows.Forms.Label();
            this.calcButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // fatGramLabel
            // 
            this.fatGramLabel.AutoSize = true;
            this.fatGramLabel.Location = new System.Drawing.Point(12, 31);
            this.fatGramLabel.Name = "fatGramLabel";
            this.fatGramLabel.Size = new System.Drawing.Size(58, 13);
            this.fatGramLabel.TabIndex = 0;
            this.fatGramLabel.Text = "Fat Grams:";
            // 
            // carbGramLabel
            // 
            this.carbGramLabel.AutoSize = true;
            this.carbGramLabel.Location = new System.Drawing.Point(12, 57);
            this.carbGramLabel.Name = "carbGramLabel";
            this.carbGramLabel.Size = new System.Drawing.Size(65, 13);
            this.carbGramLabel.TabIndex = 1;
            this.carbGramLabel.Text = "Carb Grams:";
            // 
            // fatGramTextBox
            // 
            this.fatGramTextBox.Location = new System.Drawing.Point(92, 28);
            this.fatGramTextBox.Name = "fatGramTextBox";
            this.fatGramTextBox.Size = new System.Drawing.Size(100, 20);
            this.fatGramTextBox.TabIndex = 2;
            // 
            // carbGramTextBox
            // 
            this.carbGramTextBox.Location = new System.Drawing.Point(92, 54);
            this.carbGramTextBox.Name = "carbGramTextBox";
            this.carbGramTextBox.Size = new System.Drawing.Size(100, 20);
            this.carbGramTextBox.TabIndex = 3;
            // 
            // fatCaloriesOutputLabel
            // 
            this.fatCaloriesOutputLabel.AutoSize = true;
            this.fatCaloriesOutputLabel.Location = new System.Drawing.Point(13, 107);
            this.fatCaloriesOutputLabel.Name = "fatCaloriesOutputLabel";
            this.fatCaloriesOutputLabel.Size = new System.Drawing.Size(0, 13);
            this.fatCaloriesOutputLabel.TabIndex = 4;
            // 
            // carbCaloriesOutputLabel
            // 
            this.carbCaloriesOutputLabel.AutoSize = true;
            this.carbCaloriesOutputLabel.Location = new System.Drawing.Point(13, 142);
            this.carbCaloriesOutputLabel.Name = "carbCaloriesOutputLabel";
            this.carbCaloriesOutputLabel.Size = new System.Drawing.Size(0, 13);
            this.carbCaloriesOutputLabel.TabIndex = 5;
            // 
            // totalCaloriesLabel
            // 
            this.totalCaloriesLabel.AutoSize = true;
            this.totalCaloriesLabel.Location = new System.Drawing.Point(13, 178);
            this.totalCaloriesLabel.Name = "totalCaloriesLabel";
            this.totalCaloriesLabel.Size = new System.Drawing.Size(0, 13);
            this.totalCaloriesLabel.TabIndex = 6;
            // 
            // calcButton
            // 
            this.calcButton.Location = new System.Drawing.Point(16, 231);
            this.calcButton.Name = "calcButton";
            this.calcButton.Size = new System.Drawing.Size(75, 23);
            this.calcButton.TabIndex = 7;
            this.calcButton.Text = "Calculate";
            this.calcButton.UseVisualStyleBackColor = true;
            this.calcButton.Click += new System.EventHandler(this.calcButton_Click);
            // 
            // caloriesCalcForm
            // 
            this.AcceptButton = this.calcButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(271, 267);
            this.Controls.Add(this.calcButton);
            this.Controls.Add(this.totalCaloriesLabel);
            this.Controls.Add(this.carbCaloriesOutputLabel);
            this.Controls.Add(this.fatCaloriesOutputLabel);
            this.Controls.Add(this.carbGramTextBox);
            this.Controls.Add(this.fatGramTextBox);
            this.Controls.Add(this.carbGramLabel);
            this.Controls.Add(this.fatGramLabel);
            this.Name = "caloriesCalcForm";
            this.Text = "Calories Caluclator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label fatGramLabel;
        private System.Windows.Forms.Label carbGramLabel;
        private System.Windows.Forms.TextBox fatGramTextBox;
        private System.Windows.Forms.TextBox carbGramTextBox;
        private System.Windows.Forms.Label fatCaloriesOutputLabel;
        private System.Windows.Forms.Label carbCaloriesOutputLabel;
        private System.Windows.Forms.Label totalCaloriesLabel;
        private System.Windows.Forms.Button calcButton;
    }
}

