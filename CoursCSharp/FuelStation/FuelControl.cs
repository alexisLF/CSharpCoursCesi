using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FuelStation
{
    public partial class FuelControl : Form
    {
        public FuelPrice pU { get; set; }
        public FuelUi fUi { get; set; }
        Thread th;
        ErrorManager err { get; set; }
        public bool PumpPulled { get; set; } = false;
        private delegate void TriggerFalseCallback();


        public FuelControl()
        {
            InitializeComponent();
            pU = new FuelPrice();
            fUi = new FuelUi();
            err = new ErrorManager(this);
            fUi.ChangeTab += ManageStateApp;
            fUi.SelectTab((int)State.Welcome);
            pU.MaxPrice += ManageEndPump;
            pU.Show();
            fUi.Show();
            int screenWidth = Screen.PrimaryScreen.Bounds.Width;
            int screenHeight = Screen.PrimaryScreen.Bounds.Height;
        }

        private void ManageEndPump(object sender, EventArgs e)
        {
            TriggerFalse();
            th.Abort();

        }

        private void touchScreenBtn_Click(object sender, EventArgs e)
        {
            if(fUi.State == State.Welcome)
                fUi.SelectTab((int)State.InsertCard);
        }

        private void insertCardBtn_Click(object sender, EventArgs e)
        {
            if(fUi.State == State.Welcome || fUi.State == State.InsertCard)
            {
                fUi.SelectTab((int)State.PutCode);
            }
        }

        private void removeCardBtn_Click(object sender, EventArgs e)
        {
            if(fUi.State == State.PullCard)
                fUi.SelectTab((int)State.ChooseTypeFuel);
            else
                fUi.SelectTab((int)State.Welcome);
        }

        private void pump1Btn_Click(object sender, EventArgs e)
        {
            PumpPulled = true;
            pump2Btn.Enabled = false;
            pump3Btn.Enabled = false;
            if (fUi.State == State.PullPump && fUi.SelectedFuelType == FuelType.Gasole)
            {
                pullTriggerBtn.Enabled = true;
            }
            else
            {
               
                err.ShowPumpError();

            }

        }

        private void pump2Btn_Click(object sender, EventArgs e)
        {
            PumpPulled = true;
            pump1Btn.Enabled = false;
            pump3Btn.Enabled = false;
            if (fUi.State == State.PullPump && fUi.SelectedFuelType == FuelType.SP98)
                pullTriggerBtn.Enabled = true;
            else
            {
               
                err.ShowPumpError();
            }
        }

        private void pump3Btn_Click(object sender, EventArgs e)
        {
            PumpPulled = true;
            pump1Btn.Enabled = false;
            pump2Btn.Enabled = false;
            if (fUi.State == State.PullPump && fUi.SelectedFuelType == FuelType.SP95)
            {
                pullTriggerBtn.Enabled = true;
            }
            else
            {
                err.ShowPumpError();
            }
        }

        private void pullTriggerBtn_Click(object sender, EventArgs e)
        {
            if(fUi.State == State.PullPump)
            {
                
                fUi.SelectTab((int)State.InProgress);
                if (th == null)
                {
                    th = new Thread(new ThreadStart(pU.IncrementFuel));
                    th.Start();
                    pU.waitThread.Set();
                }
                else
                {
                    pU.waitThread.Set();
                }
            }
        }

        private void ReleaseTriggerBtn_Click(object sender, EventArgs e)
        {
            if (fUi.State == State.InProgress)
            {
                fUi.SelectTab((int)State.PullPump);
                pU.waitThread.Reset();
                pullTriggerBtn.Enabled = true;
                putPumpAwayBtn.Enabled = true;
            }
        }

        private void putPumpAwayBtn_Click(object sender, EventArgs e)
        {
            if (fUi.State == State.ErrorPump)
            {
                fUi.SelectTab((int)fUi.LastStateBeforeError);
            }
            else
            {
                th?.Abort();
                fUi.SelectTab((int)State.Thanks);
            }
        }

        private void ManageStateApp(object sender, State state)
        {
            switch (state)
            {
                case State.Welcome:
                    touchScreenBtn.Enabled = true;
                    insertCardBtn.Enabled = true;
                    removeCardBtn.Enabled = false;
                    pump1Btn.Enabled = true;
                    pump2Btn.Enabled = true;
                    pump3Btn.Enabled = true;
                    pullTriggerBtn.Enabled = false;
                    releaseTriggerBtn.Enabled = false;
                    putPumpAwayBtn.Enabled = true;
                    ResetVariable();

                    break;

                case State.InsertCard:
                    touchScreenBtn.Enabled = false;
                    insertCardBtn.Enabled = true;
                    removeCardBtn.Enabled = false;
                    pump1Btn.Enabled = true;
                    pump2Btn.Enabled = true;
                    pump3Btn.Enabled = true;
                    pullTriggerBtn.Enabled = false;
                    releaseTriggerBtn.Enabled = false;
                    putPumpAwayBtn.Enabled = true;

                    break;

                case State.PutCode:
                    touchScreenBtn.Enabled = false;
                    insertCardBtn.Enabled = false;
                    removeCardBtn.Enabled = true;
                    pump1Btn.Enabled = true;
                    pump2Btn.Enabled = true;
                    pump3Btn.Enabled = true;
                    pullTriggerBtn.Enabled = false;
                    releaseTriggerBtn.Enabled = false;
                    putPumpAwayBtn.Enabled = true;

                    break;

                case State.PullCard:
                    touchScreenBtn.Enabled = false;
                    insertCardBtn.Enabled = false;
                    removeCardBtn.Enabled = true;
                    pump1Btn.Enabled = true;
                    pump2Btn.Enabled = true;
                    pump3Btn.Enabled = true;
                    pullTriggerBtn.Enabled = false;
                    releaseTriggerBtn.Enabled = false;
                    putPumpAwayBtn.Enabled = true;

                    break;

                case State.ChooseTypeFuel:
                    touchScreenBtn.Enabled = false;
                    insertCardBtn.Enabled = false;
                    removeCardBtn.Enabled = false;
                    pump1Btn.Enabled = true;
                    pump2Btn.Enabled = true;
                    pump3Btn.Enabled = true;
                    pullTriggerBtn.Enabled = false;
                    releaseTriggerBtn.Enabled = false;
                    putPumpAwayBtn.Enabled = true;

                    break;

                case State.PullPump:
                    touchScreenBtn.Enabled = false;
                    insertCardBtn.Enabled = false;
                    removeCardBtn.Enabled = false;
                    pump1Btn.Enabled = true;
                    pump2Btn.Enabled = true;
                    pump3Btn.Enabled = true;
                    pullTriggerBtn.Enabled = false;
                    releaseTriggerBtn.Enabled = false;
                    putPumpAwayBtn.Enabled = true;
                    string name = Enum.GetName(typeof(FuelType), (int)fUi.SelectedFuelType);
                    string s = ConfigurationManager.AppSettings[name];
                    pU.UnitPrice = Convert.ToDouble(s);
                    pU.UpdateUnitPrice();
                    break;

                case State.TakeFuel:
                    touchScreenBtn.Enabled = false;
                    insertCardBtn.Enabled = false;
                    removeCardBtn.Enabled = false;
                    pump1Btn.Enabled = true;
                    pump2Btn.Enabled = true;
                    pump3Btn.Enabled = true;
                    pullTriggerBtn.Enabled = false;
                    releaseTriggerBtn.Enabled = false;
                    putPumpAwayBtn.Enabled = true;
                   
                    break;

                case State.InProgress:
                    touchScreenBtn.Enabled = false;
                    insertCardBtn.Enabled = false;
                    removeCardBtn.Enabled = false;
                    pump1Btn.Enabled = false;
                    pump2Btn.Enabled = false;
                    pump3Btn.Enabled = false;
                    pullTriggerBtn.Enabled = false;
                    releaseTriggerBtn.Enabled = true;
                    putPumpAwayBtn.Enabled = false;

                    break;

                case State.ErrorCode:
                    touchScreenBtn.Enabled = false;
                    insertCardBtn.Enabled = false;
                    removeCardBtn.Enabled = false;
                    pump1Btn.Enabled = false;
                    pump2Btn.Enabled = false;
                    pump3Btn.Enabled = false;
                    pullTriggerBtn.Enabled = false;
                    releaseTriggerBtn.Enabled = false;
                    putPumpAwayBtn.Enabled = false;
                    Thread.Sleep(2000);
                    EndProcess();
                    break;

                case State.Thanks:
                    touchScreenBtn.Enabled = true;
                    insertCardBtn.Enabled = true;
                    removeCardBtn.Enabled = false;
                    pump1Btn.Enabled = true;
                    pump2Btn.Enabled = true;
                    pump3Btn.Enabled = true;
                    pullTriggerBtn.Enabled = false;
                    releaseTriggerBtn.Enabled = false;
                    putPumpAwayBtn.Enabled = true;
                    EndProcess();
                    break;

            }
        }

        private void ResetVariable()
        {
            th = null;
            pU.ResetVariable();
            fUi.ResetVariable();
        }

        private void EndProcess()
        {
            fUi.SelectTab((int)State.Welcome);
        }

        private void FuelControl_FormClosed(object sender, FormClosedEventArgs e)
        {
            th?.Abort();
        }

        public void TriggerFalse()
        {
            if (releaseTriggerBtn.InvokeRequired && pullTriggerBtn.InvokeRequired && putPumpAwayBtn.InvokeRequired)
            {
                TriggerFalseCallback d = new TriggerFalseCallback(TriggerFalse);
                this.Invoke(d);
            }
            else
            {
                releaseTriggerBtn.Enabled = false;
                pullTriggerBtn.Enabled = false;
                putPumpAwayBtn.Enabled = true;
            }
        }
    }
}
