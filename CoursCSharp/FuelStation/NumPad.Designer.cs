namespace FuelStation
{
    partial class NumPad
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.digit1 = new System.Windows.Forms.Button();
            this.digit2 = new System.Windows.Forms.Button();
            this.digit3 = new System.Windows.Forms.Button();
            this.digit6 = new System.Windows.Forms.Button();
            this.digit5 = new System.Windows.Forms.Button();
            this.digit4 = new System.Windows.Forms.Button();
            this.digit7 = new System.Windows.Forms.Button();
            this.digit8 = new System.Windows.Forms.Button();
            this.digit9 = new System.Windows.Forms.Button();
            this.digit0 = new System.Windows.Forms.Button();
            this.delBtn = new System.Windows.Forms.Button();
            this.okBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // digit1
            // 
            this.digit1.Location = new System.Drawing.Point(15, 13);
            this.digit1.Name = "digit1";
            this.digit1.Size = new System.Drawing.Size(48, 43);
            this.digit1.TabIndex = 0;
            this.digit1.Text = "1";
            this.digit1.UseVisualStyleBackColor = true;
            this.digit1.Click += new System.EventHandler(this.buttonPressed);
            // 
            // digit2
            // 
            this.digit2.Location = new System.Drawing.Point(79, 13);
            this.digit2.Name = "digit2";
            this.digit2.Size = new System.Drawing.Size(48, 43);
            this.digit2.TabIndex = 1;
            this.digit2.Text = "2";
            this.digit2.UseVisualStyleBackColor = true;
            this.digit2.Click += new System.EventHandler(this.buttonPressed);
            // 
            // digit3
            // 
            this.digit3.Location = new System.Drawing.Point(146, 13);
            this.digit3.Name = "digit3";
            this.digit3.Size = new System.Drawing.Size(48, 43);
            this.digit3.TabIndex = 2;
            this.digit3.Text = "3";
            this.digit3.UseVisualStyleBackColor = true;
            this.digit3.Click += new System.EventHandler(this.buttonPressed);
            // 
            // digit6
            // 
            this.digit6.Location = new System.Drawing.Point(146, 74);
            this.digit6.Name = "digit6";
            this.digit6.Size = new System.Drawing.Size(48, 43);
            this.digit6.TabIndex = 3;
            this.digit6.Text = "6";
            this.digit6.UseVisualStyleBackColor = true;
            this.digit6.Click += new System.EventHandler(this.buttonPressed);
            // 
            // digit5
            // 
            this.digit5.Location = new System.Drawing.Point(79, 74);
            this.digit5.Name = "digit5";
            this.digit5.Size = new System.Drawing.Size(48, 43);
            this.digit5.TabIndex = 4;
            this.digit5.Text = "5";
            this.digit5.UseVisualStyleBackColor = true;
            this.digit5.Click += new System.EventHandler(this.buttonPressed);
            // 
            // digit4
            // 
            this.digit4.Location = new System.Drawing.Point(15, 74);
            this.digit4.Name = "digit4";
            this.digit4.Size = new System.Drawing.Size(48, 43);
            this.digit4.TabIndex = 5;
            this.digit4.Text = "4";
            this.digit4.UseVisualStyleBackColor = true;
            this.digit4.Click += new System.EventHandler(this.buttonPressed);
            // 
            // digit7
            // 
            this.digit7.Location = new System.Drawing.Point(15, 135);
            this.digit7.Name = "digit7";
            this.digit7.Size = new System.Drawing.Size(48, 43);
            this.digit7.TabIndex = 6;
            this.digit7.Text = "7";
            this.digit7.UseVisualStyleBackColor = true;
            this.digit7.Click += new System.EventHandler(this.buttonPressed);
            // 
            // digit8
            // 
            this.digit8.Font = new System.Drawing.Font("Algerian", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.digit8.Location = new System.Drawing.Point(79, 135);
            this.digit8.Name = "digit8";
            this.digit8.Size = new System.Drawing.Size(48, 43);
            this.digit8.TabIndex = 7;
            this.digit8.Text = "8";
            this.digit8.UseVisualStyleBackColor = true;
            this.digit8.Click += new System.EventHandler(this.buttonPressed);
            // 
            // digit9
            // 
            this.digit9.Font = new System.Drawing.Font("Algerian", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.digit9.Location = new System.Drawing.Point(146, 135);
            this.digit9.Name = "digit9";
            this.digit9.Size = new System.Drawing.Size(48, 43);
            this.digit9.TabIndex = 8;
            this.digit9.Text = "9";
            this.digit9.UseVisualStyleBackColor = true;
            this.digit9.Click += new System.EventHandler(this.buttonPressed);
            // 
            // digit0
            // 
            this.digit0.Font = new System.Drawing.Font("Algerian", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.digit0.Location = new System.Drawing.Point(79, 196);
            this.digit0.Name = "digit0";
            this.digit0.Size = new System.Drawing.Size(48, 43);
            this.digit0.TabIndex = 9;
            this.digit0.Text = "0";
            this.digit0.UseVisualStyleBackColor = true;
            this.digit0.Click += new System.EventHandler(this.buttonPressed);
            // 
            // delBtn
            // 
            this.delBtn.BackColor = System.Drawing.Color.Red;
            this.delBtn.Font = new System.Drawing.Font("Algerian", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delBtn.Location = new System.Drawing.Point(15, 196);
            this.delBtn.Name = "delBtn";
            this.delBtn.Size = new System.Drawing.Size(48, 43);
            this.delBtn.TabIndex = 10;
            this.delBtn.Text = "X";
            this.delBtn.UseVisualStyleBackColor = false;
            this.delBtn.Click += new System.EventHandler(this.buttonPressed);
            // 
            // okBtn
            // 
            this.okBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.okBtn.Font = new System.Drawing.Font("Algerian", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.okBtn.Location = new System.Drawing.Point(146, 196);
            this.okBtn.Name = "okBtn";
            this.okBtn.Size = new System.Drawing.Size(48, 43);
            this.okBtn.TabIndex = 11;
            this.okBtn.Text = "O";
            this.okBtn.UseVisualStyleBackColor = false;
            this.okBtn.Click += new System.EventHandler(this.buttonPressed);
            // 
            // NumPad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.okBtn);
            this.Controls.Add(this.delBtn);
            this.Controls.Add(this.digit0);
            this.Controls.Add(this.digit9);
            this.Controls.Add(this.digit8);
            this.Controls.Add(this.digit7);
            this.Controls.Add(this.digit4);
            this.Controls.Add(this.digit5);
            this.Controls.Add(this.digit6);
            this.Controls.Add(this.digit3);
            this.Controls.Add(this.digit2);
            this.Controls.Add(this.digit1);
            this.Font = new System.Drawing.Font("Algerian", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "NumPad";
            this.Size = new System.Drawing.Size(211, 256);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button digit1;
        private System.Windows.Forms.Button digit2;
        private System.Windows.Forms.Button digit3;
        private System.Windows.Forms.Button digit6;
        private System.Windows.Forms.Button digit5;
        private System.Windows.Forms.Button digit4;
        private System.Windows.Forms.Button digit7;
        private System.Windows.Forms.Button digit8;
        private System.Windows.Forms.Button digit9;
        private System.Windows.Forms.Button digit0;
        private System.Windows.Forms.Button delBtn;
        private System.Windows.Forms.Button okBtn;
    }
}
