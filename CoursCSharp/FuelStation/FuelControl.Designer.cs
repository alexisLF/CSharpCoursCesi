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
            this.removeCardBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.removeCardBtn.Location = new System.Drawing.Point(64, 111);
            this.removeCardBtn.Name = "removeCardBtn";
            this.removeCardBtn.Size = new System.Drawing.Size(195, 35);
            this.removeCardBtn.TabIndex = 17;
            this.removeCardBtn.Text = "Remove your card";
            this.removeCardBtn.UseVisualStyleBackColor = true;
            this.removeCardBtn.Click += new System.EventHandler(this.RemoveCardBtn_Click);
            // 
            // putPumpAwayBtn
            // 
            this.putPumpAwayBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.putPumpAwayBtn.Location = new System.Drawing.Point(64, 361);
            this.putPumpAwayBtn.Name = "putPumpAwayBtn";
            this.putPumpAwayBtn.Size = new System.Drawing.Size(195, 32);
            this.putPumpAwayBtn.TabIndex = 16;
            this.putPumpAwayBtn.Text = "Put Pump Back";
            this.putPumpAwayBtn.UseVisualStyleBackColor = true;
            this.putPumpAwayBtn.Click += new System.EventHandler(this.PutPumpAwayBtn_Click);
            // 
            // releaseTriggerBtn
            // 
            this.releaseTriggerBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.releaseTriggerBtn.Location = new System.Drawing.Point(64, 321);
            this.releaseTriggerBtn.Name = "releaseTriggerBtn";
            this.releaseTriggerBtn.Size = new System.Drawing.Size(195, 34);
            this.releaseTriggerBtn.TabIndex = 15;
            this.releaseTriggerBtn.Text = "Release Pump Trigger";
            this.releaseTriggerBtn.UseVisualStyleBackColor = true;
            this.releaseTriggerBtn.Click += new System.EventHandler(this.ReleaseTriggerBtn_Click);
            // 
            // pullTriggerBtn
            // 
            this.pullTriggerBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pullTriggerBtn.Location = new System.Drawing.Point(64, 280);
            this.pullTriggerBtn.Name = "pullTriggerBtn";
            this.pullTriggerBtn.Size = new System.Drawing.Size(195, 35);
            this.pullTriggerBtn.TabIndex = 14;
            this.pullTriggerBtn.Text = "Pull Pump Trigger";
            this.pullTriggerBtn.UseVisualStyleBackColor = true;
            this.pullTriggerBtn.Click += new System.EventHandler(this.PullTriggerBtn_Click);
            // 
            // pump3Btn
            // 
            this.pump3Btn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pump3Btn.Location = new System.Drawing.Point(64, 236);
            this.pump3Btn.Name = "pump3Btn";
            this.pump3Btn.Size = new System.Drawing.Size(195, 38);
            this.pump3Btn.TabIndex = 13;
            this.pump3Btn.Text = "SP95 Pump";
            this.pump3Btn.UseVisualStyleBackColor = true;
            this.pump3Btn.Click += new System.EventHandler(this.Pump3Btn_Click);
            // 
            // pump2Btn
            // 
            this.pump2Btn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pump2Btn.Location = new System.Drawing.Point(64, 193);
            this.pump2Btn.Name = "pump2Btn";
            this.pump2Btn.Size = new System.Drawing.Size(195, 37);
            this.pump2Btn.TabIndex = 12;
            this.pump2Btn.Text = "SP98 Pump";
            this.pump2Btn.UseVisualStyleBackColor = true;
            this.pump2Btn.Click += new System.EventHandler(this.Pump2Btn_Click);
            // 
            // pump1Btn
            // 
            this.pump1Btn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pump1Btn.Location = new System.Drawing.Point(64, 152);
            this.pump1Btn.Name = "pump1Btn";
            this.pump1Btn.Size = new System.Drawing.Size(195, 35);
            this.pump1Btn.TabIndex = 11;
            this.pump1Btn.Text = "Gasole Pump";
            this.pump1Btn.UseVisualStyleBackColor = true;
            this.pump1Btn.Click += new System.EventHandler(this.Pump1Btn_Click);
            // 
            // insertCardBtn
            // 
            this.insertCardBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.insertCardBtn.Location = new System.Drawing.Point(64, 72);
            this.insertCardBtn.Name = "insertCardBtn";
            this.insertCardBtn.Size = new System.Drawing.Size(195, 33);
            this.insertCardBtn.TabIndex = 10;
            this.insertCardBtn.Text = "Insert your card";
            this.insertCardBtn.UseVisualStyleBackColor = true;
            this.insertCardBtn.Click += new System.EventHandler(this.InsertCardBtn_Click);
            // 
            // touchScreenBtn
            // 
            this.touchScreenBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.touchScreenBtn.Location = new System.Drawing.Point(64, 27);
            this.touchScreenBtn.Name = "touchScreenBtn";
            this.touchScreenBtn.Size = new System.Drawing.Size(195, 39);
            this.touchScreenBtn.TabIndex = 9;
            this.touchScreenBtn.Text = "Touch Screen";
            this.touchScreenBtn.UseVisualStyleBackColor = true;
            this.touchScreenBtn.Click += new System.EventHandler(this.TouchScreenBtn_Click);
            // 
            // FuelControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(303, 418);
            this.Controls.Add(this.removeCardBtn);
            this.Controls.Add(this.putPumpAwayBtn);
            this.Controls.Add(this.releaseTriggerBtn);
            this.Controls.Add(this.pullTriggerBtn);
            this.Controls.Add(this.pump3Btn);
            this.Controls.Add(this.pump2Btn);
            this.Controls.Add(this.pump1Btn);
            this.Controls.Add(this.insertCardBtn);
            this.Controls.Add(this.touchScreenBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FuelControl";
            this.Text = "FuelControl";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FuelControl_FormClosed);
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

