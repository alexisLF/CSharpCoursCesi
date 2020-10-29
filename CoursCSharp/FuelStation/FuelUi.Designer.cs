namespace FuelStation
{
    partial class FuelUi
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
            this.tabControl1 = new FuelStation.WizardPages();
            this.welcomePage = new System.Windows.Forms.TabPage();
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.insertCardPage = new System.Windows.Forms.TabPage();
            this.InsertCardLabel = new System.Windows.Forms.Label();
            this.codePage = new System.Windows.Forms.TabPage();
            this.numPad1 = new FuelStation.NumPad();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.putCodeLabel = new System.Windows.Forms.Label();
            this.fuelTypePage = new System.Windows.Forms.TabPage();
            this.fuelTypeLabel = new System.Windows.Forms.Label();
            this.pumpPage = new System.Windows.Forms.TabPage();
            this.takePumpLabel = new System.Windows.Forms.Label();
            this.takeFuelPage = new System.Windows.Forms.TabPage();
            this.takeFuelLabel = new System.Windows.Forms.Label();
            this.inProgressPage = new System.Windows.Forms.TabPage();
            this.inProgressLabel = new System.Windows.Forms.Label();
            this.thanksPage = new System.Windows.Forms.TabPage();
            this.thanksLabel = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.welcomePage.SuspendLayout();
            this.insertCardPage.SuspendLayout();
            this.codePage.SuspendLayout();
            this.fuelTypePage.SuspendLayout();
            this.pumpPage.SuspendLayout();
            this.takeFuelPage.SuspendLayout();
            this.inProgressPage.SuspendLayout();
            this.thanksPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.welcomePage);
            this.tabControl1.Controls.Add(this.insertCardPage);
            this.tabControl1.Controls.Add(this.codePage);
            this.tabControl1.Controls.Add(this.fuelTypePage);
            this.tabControl1.Controls.Add(this.pumpPage);
            this.tabControl1.Controls.Add(this.takeFuelPage);
            this.tabControl1.Controls.Add(this.inProgressPage);
            this.tabControl1.Controls.Add(this.thanksPage);
            this.tabControl1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(616, 571);
            this.tabControl1.TabIndex = 0;
            // 
            // welcomePage
            // 
            this.welcomePage.BackColor = System.Drawing.Color.Black;
            this.welcomePage.Controls.Add(this.welcomeLabel);
            this.welcomePage.Location = new System.Drawing.Point(4, 22);
            this.welcomePage.Name = "welcomePage";
            this.welcomePage.Padding = new System.Windows.Forms.Padding(3);
            this.welcomePage.Size = new System.Drawing.Size(608, 545);
            this.welcomePage.TabIndex = 0;
            this.welcomePage.Text = "Welcome";
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.welcomeLabel.AutoSize = true;
            this.welcomeLabel.BackColor = System.Drawing.Color.Transparent;
            this.welcomeLabel.Font = new System.Drawing.Font("Algerian", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeLabel.ForeColor = System.Drawing.Color.Gold;
            this.welcomeLabel.Location = new System.Drawing.Point(184, 245);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(240, 54);
            this.welcomeLabel.TabIndex = 1;
            this.welcomeLabel.Text = "Welcome";
            this.welcomeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // insertCardPage
            // 
            this.insertCardPage.BackColor = System.Drawing.Color.Black;
            this.insertCardPage.Controls.Add(this.InsertCardLabel);
            this.insertCardPage.Location = new System.Drawing.Point(4, 22);
            this.insertCardPage.Name = "insertCardPage";
            this.insertCardPage.Padding = new System.Windows.Forms.Padding(3);
            this.insertCardPage.Size = new System.Drawing.Size(608, 545);
            this.insertCardPage.TabIndex = 1;
            this.insertCardPage.Text = "InsertCard";
            // 
            // InsertCardLabel
            // 
            this.InsertCardLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.InsertCardLabel.AutoSize = true;
            this.InsertCardLabel.BackColor = System.Drawing.Color.Transparent;
            this.InsertCardLabel.Font = new System.Drawing.Font("Algerian", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InsertCardLabel.ForeColor = System.Drawing.Color.Gold;
            this.InsertCardLabel.Location = new System.Drawing.Point(89, 248);
            this.InsertCardLabel.Name = "InsertCardLabel";
            this.InsertCardLabel.Size = new System.Drawing.Size(449, 54);
            this.InsertCardLabel.TabIndex = 2;
            this.InsertCardLabel.Text = "Insert your card";
            this.InsertCardLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // codePage
            // 
            this.codePage.BackColor = System.Drawing.Color.Black;
            this.codePage.Controls.Add(this.numPad1);
            this.codePage.Controls.Add(this.textBox1);
            this.codePage.Controls.Add(this.putCodeLabel);
            this.codePage.Location = new System.Drawing.Point(4, 22);
            this.codePage.Name = "codePage";
            this.codePage.Size = new System.Drawing.Size(608, 545);
            this.codePage.TabIndex = 2;
            this.codePage.Text = "Code";
            // 
            // numPad1
            // 
            this.numPad1.Font = new System.Drawing.Font("Algerian", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numPad1.Location = new System.Drawing.Point(123, 159);
            this.numPad1.Name = "numPad1";
            this.numPad1.Size = new System.Drawing.Size(359, 483);
            this.numPad1.TabIndex = 6;
            this.numPad1.Value = null;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(177, 120);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(209, 20);
            this.textBox1.TabIndex = 5;
            // 
            // putCodeLabel
            // 
            this.putCodeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.putCodeLabel.AutoSize = true;
            this.putCodeLabel.BackColor = System.Drawing.Color.Transparent;
            this.putCodeLabel.Font = new System.Drawing.Font("Algerian", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.putCodeLabel.ForeColor = System.Drawing.Color.Gold;
            this.putCodeLabel.Location = new System.Drawing.Point(106, 50);
            this.putCodeLabel.Name = "putCodeLabel";
            this.putCodeLabel.Size = new System.Drawing.Size(376, 54);
            this.putCodeLabel.TabIndex = 3;
            this.putCodeLabel.Text = "Tap your code";
            this.putCodeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // fuelTypePage
            // 
            this.fuelTypePage.BackColor = System.Drawing.Color.Black;
            this.fuelTypePage.Controls.Add(this.fuelTypeLabel);
            this.fuelTypePage.Location = new System.Drawing.Point(4, 22);
            this.fuelTypePage.Name = "fuelTypePage";
            this.fuelTypePage.Size = new System.Drawing.Size(608, 545);
            this.fuelTypePage.TabIndex = 3;
            this.fuelTypePage.Text = "FuelType";
            // 
            // fuelTypeLabel
            // 
            this.fuelTypeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fuelTypeLabel.AutoSize = true;
            this.fuelTypeLabel.BackColor = System.Drawing.Color.Transparent;
            this.fuelTypeLabel.Font = new System.Drawing.Font("Algerian", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fuelTypeLabel.ForeColor = System.Drawing.Color.Gold;
            this.fuelTypeLabel.Location = new System.Drawing.Point(35, 45);
            this.fuelTypeLabel.Name = "fuelTypeLabel";
            this.fuelTypeLabel.Size = new System.Drawing.Size(550, 54);
            this.fuelTypeLabel.TabIndex = 4;
            this.fuelTypeLabel.Text = "Choose the fuel type";
            this.fuelTypeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pumpPage
            // 
            this.pumpPage.BackColor = System.Drawing.Color.Black;
            this.pumpPage.Controls.Add(this.takePumpLabel);
            this.pumpPage.Location = new System.Drawing.Point(4, 22);
            this.pumpPage.Name = "pumpPage";
            this.pumpPage.Size = new System.Drawing.Size(608, 545);
            this.pumpPage.TabIndex = 4;
            this.pumpPage.Text = "Pump";
            // 
            // takePumpLabel
            // 
            this.takePumpLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.takePumpLabel.AutoSize = true;
            this.takePumpLabel.BackColor = System.Drawing.Color.Transparent;
            this.takePumpLabel.Font = new System.Drawing.Font("Algerian", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.takePumpLabel.ForeColor = System.Drawing.Color.Gold;
            this.takePumpLabel.Location = new System.Drawing.Point(105, 51);
            this.takePumpLabel.Name = "takePumpLabel";
            this.takePumpLabel.Size = new System.Drawing.Size(364, 54);
            this.takePumpLabel.TabIndex = 5;
            this.takePumpLabel.Text = "Pull the pump";
            this.takePumpLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // takeFuelPage
            // 
            this.takeFuelPage.BackColor = System.Drawing.Color.Black;
            this.takeFuelPage.Controls.Add(this.takeFuelLabel);
            this.takeFuelPage.Location = new System.Drawing.Point(4, 22);
            this.takeFuelPage.Name = "takeFuelPage";
            this.takeFuelPage.Size = new System.Drawing.Size(608, 545);
            this.takeFuelPage.TabIndex = 5;
            this.takeFuelPage.Text = "TakeFuel";
            // 
            // takeFuelLabel
            // 
            this.takeFuelLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.takeFuelLabel.AutoSize = true;
            this.takeFuelLabel.BackColor = System.Drawing.Color.Transparent;
            this.takeFuelLabel.Font = new System.Drawing.Font("Algerian", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.takeFuelLabel.ForeColor = System.Drawing.Color.Gold;
            this.takeFuelLabel.Location = new System.Drawing.Point(122, 245);
            this.takeFuelLabel.Name = "takeFuelLabel";
            this.takeFuelLabel.Size = new System.Drawing.Size(272, 54);
            this.takeFuelLabel.TabIndex = 6;
            this.takeFuelLabel.Text = "Take fuel";
            this.takeFuelLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // inProgressPage
            // 
            this.inProgressPage.BackColor = System.Drawing.Color.Black;
            this.inProgressPage.Controls.Add(this.inProgressLabel);
            this.inProgressPage.Location = new System.Drawing.Point(4, 22);
            this.inProgressPage.Name = "inProgressPage";
            this.inProgressPage.Size = new System.Drawing.Size(608, 545);
            this.inProgressPage.TabIndex = 6;
            this.inProgressPage.Text = "InProgress";
            // 
            // inProgressLabel
            // 
            this.inProgressLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.inProgressLabel.AutoSize = true;
            this.inProgressLabel.BackColor = System.Drawing.Color.Transparent;
            this.inProgressLabel.Font = new System.Drawing.Font("Algerian", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inProgressLabel.ForeColor = System.Drawing.Color.Gold;
            this.inProgressLabel.Location = new System.Drawing.Point(168, 245);
            this.inProgressLabel.Name = "inProgressLabel";
            this.inProgressLabel.Size = new System.Drawing.Size(314, 54);
            this.inProgressLabel.TabIndex = 7;
            this.inProgressLabel.Text = "In Progress";
            this.inProgressLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // thanksPage
            // 
            this.thanksPage.BackColor = System.Drawing.Color.Black;
            this.thanksPage.Controls.Add(this.thanksLabel);
            this.thanksPage.Location = new System.Drawing.Point(4, 22);
            this.thanksPage.Name = "thanksPage";
            this.thanksPage.Size = new System.Drawing.Size(608, 545);
            this.thanksPage.TabIndex = 7;
            this.thanksPage.Text = "Thanks";
            // 
            // thanksLabel
            // 
            this.thanksLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.thanksLabel.AutoSize = true;
            this.thanksLabel.BackColor = System.Drawing.Color.Transparent;
            this.thanksLabel.Font = new System.Drawing.Font("Algerian", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thanksLabel.ForeColor = System.Drawing.Color.Gold;
            this.thanksLabel.Location = new System.Drawing.Point(168, 245);
            this.thanksLabel.Name = "thanksLabel";
            this.thanksLabel.Size = new System.Drawing.Size(205, 54);
            this.thanksLabel.TabIndex = 7;
            this.thanksLabel.Text = "Thanks";
            this.thanksLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FuelUi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 676);
            this.Controls.Add(this.tabControl1);
            this.Name = "FuelUi";
            this.Text = "FuelPriceUi";
            this.tabControl1.ResumeLayout(false);
            this.welcomePage.ResumeLayout(false);
            this.welcomePage.PerformLayout();
            this.insertCardPage.ResumeLayout(false);
            this.insertCardPage.PerformLayout();
            this.codePage.ResumeLayout(false);
            this.codePage.PerformLayout();
            this.fuelTypePage.ResumeLayout(false);
            this.fuelTypePage.PerformLayout();
            this.pumpPage.ResumeLayout(false);
            this.pumpPage.PerformLayout();
            this.takeFuelPage.ResumeLayout(false);
            this.takeFuelPage.PerformLayout();
            this.inProgressPage.ResumeLayout(false);
            this.inProgressPage.PerformLayout();
            this.thanksPage.ResumeLayout(false);
            this.thanksPage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private WizardPages tabControl1;
        private System.Windows.Forms.TabPage welcomePage;
        private System.Windows.Forms.TabPage insertCardPage;
        private System.Windows.Forms.TabPage codePage;
        private System.Windows.Forms.TabPage fuelTypePage;
        private System.Windows.Forms.TabPage pumpPage;
        private System.Windows.Forms.TabPage takeFuelPage;
        private System.Windows.Forms.TabPage inProgressPage;
        private System.Windows.Forms.TabPage thanksPage;
        private System.Windows.Forms.Label welcomeLabel;
        private System.Windows.Forms.Label InsertCardLabel;
        private System.Windows.Forms.Label putCodeLabel;
        private System.Windows.Forms.Label fuelTypeLabel;
        private System.Windows.Forms.Label takePumpLabel;
        private System.Windows.Forms.Label takeFuelLabel;
        private System.Windows.Forms.Label inProgressLabel;
        private System.Windows.Forms.Label thanksLabel;
        private System.Windows.Forms.TextBox textBox1;
        private NumPad numPad1;
    }
}