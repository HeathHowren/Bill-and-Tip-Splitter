namespace Bill_and_Tip_Splitter
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
            this.AmountOfPeople = new System.Windows.Forms.NumericUpDown();
            this.AmountOfPeopleLabel = new System.Windows.Forms.Label();
            this.Cost = new System.Windows.Forms.NumericUpDown();
            this.TotalCostLabel = new System.Windows.Forms.Label();
            this.TipAmountLabel = new System.Windows.Forms.Label();
            this.TipAmount = new System.Windows.Forms.NumericUpDown();
            this.CalculateButton = new System.Windows.Forms.Button();
            this.ResultLabel = new System.Windows.Forms.Label();
            this.ResultTextLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.AmountOfPeople)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TipAmount)).BeginInit();
            this.SuspendLayout();
            // 
            // AmountOfPeople
            // 
            this.AmountOfPeople.Location = new System.Drawing.Point(102, 11);
            this.AmountOfPeople.Name = "AmountOfPeople";
            this.AmountOfPeople.Size = new System.Drawing.Size(48, 20);
            this.AmountOfPeople.TabIndex = 1;
            this.AmountOfPeople.ValueChanged += new System.EventHandler(this.AmountOfPeople_ValueChanged);
            // 
            // AmountOfPeopleLabel
            // 
            this.AmountOfPeopleLabel.AutoSize = true;
            this.AmountOfPeopleLabel.Location = new System.Drawing.Point(6, 15);
            this.AmountOfPeopleLabel.Name = "AmountOfPeopleLabel";
            this.AmountOfPeopleLabel.Size = new System.Drawing.Size(90, 13);
            this.AmountOfPeopleLabel.TabIndex = 2;
            this.AmountOfPeopleLabel.Text = "Amount of people";
            // 
            // Cost
            // 
            this.Cost.DecimalPlaces = 2;
            this.Cost.Location = new System.Drawing.Point(102, 50);
            this.Cost.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.Cost.Name = "Cost";
            this.Cost.Size = new System.Drawing.Size(47, 20);
            this.Cost.TabIndex = 3;
            this.Cost.ValueChanged += new System.EventHandler(this.TotalCost_ValueChanged);
            // 
            // TotalCostLabel
            // 
            this.TotalCostLabel.AutoSize = true;
            this.TotalCostLabel.Location = new System.Drawing.Point(6, 52);
            this.TotalCostLabel.Name = "TotalCostLabel";
            this.TotalCostLabel.Size = new System.Drawing.Size(31, 13);
            this.TotalCostLabel.TabIndex = 4;
            this.TotalCostLabel.Text = "Cost:";
            // 
            // TipAmountLabel
            // 
            this.TipAmountLabel.AutoSize = true;
            this.TipAmountLabel.Location = new System.Drawing.Point(6, 88);
            this.TipAmountLabel.Name = "TipAmountLabel";
            this.TipAmountLabel.Size = new System.Drawing.Size(25, 13);
            this.TipAmountLabel.TabIndex = 5;
            this.TipAmountLabel.Text = "Tip:";
            this.TipAmountLabel.Click += new System.EventHandler(this.TipAmountLabel_Click);
            // 
            // TipAmount
            // 
            this.TipAmount.DecimalPlaces = 2;
            this.TipAmount.Location = new System.Drawing.Point(102, 86);
            this.TipAmount.Name = "TipAmount";
            this.TipAmount.Size = new System.Drawing.Size(48, 20);
            this.TipAmount.TabIndex = 6;
            // 
            // CalculateButton
            // 
            this.CalculateButton.Location = new System.Drawing.Point(12, 112);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(153, 38);
            this.CalculateButton.TabIndex = 7;
            this.CalculateButton.Text = "Calculate";
            this.CalculateButton.UseVisualStyleBackColor = true;
            this.CalculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // ResultLabel
            // 
            this.ResultLabel.AutoSize = true;
            this.ResultLabel.Location = new System.Drawing.Point(6, 181);
            this.ResultLabel.Name = "ResultLabel";
            this.ResultLabel.Size = new System.Drawing.Size(10, 13);
            this.ResultLabel.TabIndex = 8;
            this.ResultLabel.Text = " ";
            // 
            // ResultTextLabel
            // 
            this.ResultTextLabel.AutoSize = true;
            this.ResultTextLabel.Location = new System.Drawing.Point(6, 168);
            this.ResultTextLabel.Name = "ResultTextLabel";
            this.ResultTextLabel.Size = new System.Drawing.Size(118, 13);
            this.ResultTextLabel.TabIndex = 9;
            this.ResultTextLabel.Text = "Each person must pay: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(172, 208);
            this.Controls.Add(this.ResultTextLabel);
            this.Controls.Add(this.ResultLabel);
            this.Controls.Add(this.CalculateButton);
            this.Controls.Add(this.TipAmount);
            this.Controls.Add(this.TipAmountLabel);
            this.Controls.Add(this.TotalCostLabel);
            this.Controls.Add(this.Cost);
            this.Controls.Add(this.AmountOfPeopleLabel);
            this.Controls.Add(this.AmountOfPeople);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Calculate";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AmountOfPeople)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TipAmount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.NumericUpDown AmountOfPeople;
        private System.Windows.Forms.Label AmountOfPeopleLabel;
        private System.Windows.Forms.NumericUpDown Cost;
        private System.Windows.Forms.Label TotalCostLabel;
        private System.Windows.Forms.Label TipAmountLabel;
        private System.Windows.Forms.NumericUpDown TipAmount;
        private System.Windows.Forms.Button CalculateButton;
        private System.Windows.Forms.Label ResultLabel;
        private System.Windows.Forms.Label ResultTextLabel;
    }
}

