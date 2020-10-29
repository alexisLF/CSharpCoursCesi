namespace FuelStation
{
    partial class FuelControl
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

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.removeCardBtn = new System.Windows.Forms.Button();
            this.putPumpAwayBtn = new System.Windows.Forms.Button();
            this.releaseTriggerBtn = new System.Windows.Forms.Button();
            this.pullTriggerBtn = new System.Windows.Forms.Button();
            this.pump3Btn = new System.Windows.Forms.Button();
            this.pump2Btn = new System.Windows.Forms.Button();
            this.pump1Btn = new System.Windows.Forms.Button();
            this.insertCardBtn = new System.Windows.Forms.Button();
            this.touchScreenBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // removeCardBtn
            // 
            this.removeCardBtn.Location = new System.Drawing.Point(76, 111);
            this.removeCardBtn.Name = "removeCardBtn";
            this.removeCardBtn.Size = new System.Drawing.Size(195, 23);
            this.removeCardBtn.TabIndex = 17;
            this.removeCardBtn.Text = "Remove your card";
            this.removeCardBtn.UseVisualStyleBackColor = true;
            this.removeCardBtn.Click += new System.EventHandler(this.removeCardBtn_Click);
            // 
            // putPumpAwayBtn
            // 
            this.putPumpAwayBtn.Location = new System.Drawing.Point(76, 346);
            this.putPumpAwayBtn.Name = "putPumpAwayBtn";
            this.putPumpAwayBtn.Size = new System.Drawing.Size(195, 25);
            this.putPumpAwayBtn.TabIndex = 16;
            this.putPumpAwayBtn.Text = "Put Pump Back";
            this.putPumpAwayBtn.UseVisualStyleBackColor = true;
            this.putPumpAwayBtn.Click += new System.EventHandler(this.putPumpAwayBtn_Click);
            // 
            // releaseTriggerBtn
            // 
            this.releaseTriggerBtn.Location = new System.Drawing.Point(76, 306);
            this.releaseTriggerBtn.Name = "releaseTriggerBtn";
            this.releaseTriggerBtn.Size = new System.Drawing.Size(195, 25);
            this.releaseTriggerBtn.TabIndex = 15;
            this.releaseTriggerBtn.Text = "Release Pump Trigger";
            this.releaseTriggerBtn.UseVisualStyleBackColor = true;
            this.releaseTriggerBtn.Click += new System.EventHandler(this.ReleaseTriggerBtn_Click);
            // 
            // pullTriggerBtn
            // 
            this.pullTriggerBtn.Location = new System.Drawing.Point(76, 265);
            this.pullTriggerBtn.Name = "pullTriggerBtn";
            this.pullTriggerBtn.Size = new System.Drawing.Size(195, 20);
            this.pullTriggerBtn.TabIndex = 14;
            this.pullTriggerBtn.Text = "Pull Pump Trigger";
            this.pullTriggerBtn.UseVisualStyleBackColor = true;
            this.pullTriggerBtn.Click += new System.EventHandler(this.pullTriggerBtn_Click);
            // 
            // pump3Btn
            // 
            this.pump3Btn.Location = new System.Drawing.Point(76, 236);
            this.pump3Btn.Name = "pump3Btn";
            this.pump3Btn.Size = new System.Drawing.Size(195, 23);
            this.pump3Btn.TabIndex = 13;
            this.pump3Btn.Text = "PU95 pump";
            this.pump3Btn.UseVisualStyleBackColor = true;
            this.pump3Btn.Click += new System.EventHandler(this.pump3Btn_Click);
            // 
            // pump2Btn
            // 
            this.pump2Btn.Location = new System.Drawing.Point(76, 193);
            this.pump2Btn.Name = "pump2Btn";
            this.pump2Btn.Size = new System.Drawing.Size(195, 23);
            this.pump2Btn.TabIndex = 12;
            this.pump2Btn.Text = "SU98 pump";
            this.pump2Btn.UseVisualStyleBackColor = true;
            this.pump2Btn.Click += new System.EventHandler(this.pump2Btn_Click);
            // 
            // pump1Btn
            // 
            this.pump1Btn.Location = new System.Drawing.Point(76, 152);
            this.pump1Btn.Name = "pump1Btn";
            this.pump1Btn.Size = new System.Drawing.Size(195, 23);
            this.pump1Btn.TabIndex = 11;
            this.pump1Btn.Text = "Gasole Pump";
            this.pump1Btn.UseVisualStyleBackColor = true;
            this.pump1Btn.Click += new System.EventHandler(this.pump1Btn_Click);
            // 
            // insertCardBtn
            // 
            this.insertCardBtn.Location = new System.Drawing.Point(76, 72);
            this.insertCardBtn.Name = "insertCardBtn";
            this.insertCardBtn.Size = new System.Drawing.Size(195, 33);
            this.insertCardBtn.TabIndex = 10;
            this.insertCardBtn.Text = "Insert your card";
            this.insertCardBtn.UseVisualStyleBackColor = true;
            this.insertCardBtn.Click += new System.EventHandler(this.insertCardBtn_Click);
            // 
            // touchScreenBtn
            // 
            this.touchScreenBtn.Location = new System.Drawing.Point(76, 27);
            this.touchScreenBtn.Name = "touchScreenBtn";
            this.touchScreenBtn.Size = new System.Drawing.Size(195, 30);
            this.touchScreenBtn.TabIndex = 9;
            this.touchScreenBtn.Text = "Touch Screen";
            this.touchScreenBtn.UseVisualStyleBackColor = true;
            this.touchScreenBtn.Click += new System.EventHandler(this.touchScreenBtn_Click);
            // 
            // FuelControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 448);
            this.Controls.Add(this.removeCardBtn);
            this.Controls.Add(this.putPumpAwayBtn);
            this.Controls.Add(this.releaseTriggerBtn);
            this.Controls.Add(this.pullTriggerBtn);
            this.Controls.Add(this.pump3Btn);
            this.Controls.Add(this.pump2Btn);
            this.Controls.Add(this.pump1Btn);
            this.Controls.Add(this.insertCardBtn);
            this.Controls.Add(this.touchScreenBtn);
            this.Name = "FuelControl";
            this.Text = "FuelControl";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button removeCardBtn;
        private System.Windows.Forms.Button putPumpAwayBtn;
        private System.Windows.Forms.Button releaseTriggerBtn;
        private System.Windows.Forms.Button pullTriggerBtn;
        private System.Windows.Forms.Button pump3Btn;
        private System.Windows.Forms.Button pump2Btn;
        private System.Windows.Forms.Button pump1Btn;
        private System.Windows.Forms.Button insertCardBtn;
        private System.Windows.Forms.Button touchScreenBtn;
    }
}

