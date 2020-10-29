namespace FuelStation
{
    partial class FuelPrice
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
            this.FuelLitreLabel = new System.Windows.Forms.Label();
            this.PriceBoxLabel = new System.Windows.Forms.Label();
            this.UnitPriceLabel = new System.Windows.Forms.Label();
            this.UnitPriceBox = new System.Windows.Forms.TextBox();
            this.PriceBox = new System.Windows.Forms.TextBox();
            this.FuelLiterBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // FuelLitreLabel
            // 
            this.FuelLitreLabel.AutoSize = true;
            this.FuelLitreLabel.Location = new System.Drawing.Point(43, 28);
            this.FuelLitreLabel.Name = "FuelLitreLabel";
            this.FuelLitreLabel.Size = new System.Drawing.Size(70, 13);
            this.FuelLitreLabel.TabIndex = 1;
            this.FuelLitreLabel.Text = "fuelLitreLabel";
            // 
            // PriceBoxLabel
            // 
            this.PriceBoxLabel.AutoSize = true;
            this.PriceBoxLabel.Location = new System.Drawing.Point(43, 65);
            this.PriceBoxLabel.Name = "PriceBoxLabel";
            this.PriceBoxLabel.Size = new System.Drawing.Size(74, 13);
            this.PriceBoxLabel.TabIndex = 3;
            this.PriceBoxLabel.Text = "priceBoxLabel";
            // 
            // UnitPriceLabel
            // 
            this.UnitPriceLabel.AutoSize = true;
            this.UnitPriceLabel.Location = new System.Drawing.Point(43, 100);
            this.UnitPriceLabel.Name = "UnitPriceLabel";
            this.UnitPriceLabel.Size = new System.Drawing.Size(74, 13);
            this.UnitPriceLabel.TabIndex = 5;
            this.UnitPriceLabel.Text = "unitPriceLabel";
            // 
            // UnitPriceBox
            // 
            this.UnitPriceBox.Location = new System.Drawing.Point(123, 97);
            this.UnitPriceBox.Name = "UnitPriceBox";
            this.UnitPriceBox.ReadOnly = true;
            this.UnitPriceBox.Size = new System.Drawing.Size(161, 20);
            this.UnitPriceBox.TabIndex = 4;
            // 
            // PriceBox
            // 
            this.PriceBox.Location = new System.Drawing.Point(123, 62);
            this.PriceBox.Name = "PriceBox";
            this.PriceBox.ReadOnly = true;
            this.PriceBox.Size = new System.Drawing.Size(161, 20);
            this.PriceBox.TabIndex = 2;
            // 
            // FuelLiterBox
            // 
            this.FuelLiterBox.Location = new System.Drawing.Point(123, 25);
            this.FuelLiterBox.Name = "FuelLiterBox";
            this.FuelLiterBox.ReadOnly = true;
            this.FuelLiterBox.Size = new System.Drawing.Size(161, 20);
            this.FuelLiterBox.TabIndex = 0;
            // 
            // FuelPrice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 170);
            this.Controls.Add(this.UnitPriceLabel);
            this.Controls.Add(this.UnitPriceBox);
            this.Controls.Add(this.PriceBoxLabel);
            this.Controls.Add(this.PriceBox);
            this.Controls.Add(this.FuelLitreLabel);
            this.Controls.Add(this.FuelLiterBox);
            this.Name = "FuelPrice";
            this.Text = "FuelPrice";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label FuelLitreLabel;
        private System.Windows.Forms.Label PriceBoxLabel;
        private System.Windows.Forms.Label UnitPriceLabel;
        private System.Windows.Forms.TextBox UnitPriceBox;
        private System.Windows.Forms.TextBox PriceBox;
        private System.Windows.Forms.TextBox FuelLiterBox;
    }
}