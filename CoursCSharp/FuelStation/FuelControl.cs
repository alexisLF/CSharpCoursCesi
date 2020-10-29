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
        private bool IsCardInside { get; set; } = false;

        public FuelControl()
        {
            InitializeComponent();
            pU = new FuelPrice();
            fUi = new FuelUi();
            err = new ErrorManager(this);
            fUi.ChangeTab += ManageStateApp;
            fUi.SelectTab(0);
            pU.Show();
            fUi.Show();
            int screenWidth = Screen.PrimaryScreen.Bounds.Width;
            int screenHeight = Screen.PrimaryScreen.Bounds.Height;
        }

        private void touchScreenBtn_Click(object sender, EventArgs e)
        {
            if(fUi.State == State.Welcome)
                fUi.SelectTab(1);
        }

        private void insertCardBtn_Click(object sender, EventArgs e)
        {
            if(fUi.State == State.Welcome || fUi.State == State.InsertCard)
                fUi.SelectTab(2);
        }

        private void removeCardBtn_Click(object sender, EventArgs e)
        {
            if(IsCardInside)
                fUi.SelectTab(3);
        }

        private void pump1Btn_Click(object sender, EventArgs e)
        {
            if (fUi.State == State.TakeFuel && fUi.SelectedFuelType == FuelType.Gasole)
                pullTriggerBtn.Enabled = true;
            else
                err.ShowPumpError();
        }

        private void pump2Btn_Click(object sender, EventArgs e)
        {
            if (fUi.State == State.TakeFuel && fUi.SelectedFuelType == FuelType.SP98)
                pullTriggerBtn.Enabled = true;
            else
                err.ShowPumpError();
        }

        private void pump3Btn_Click(object sender, EventArgs e)
        {
            if (fUi.State == State.TakeFuel && fUi.SelectedFuelType == FuelType.SP95)
                pullTriggerBtn.Enabled = true;
            else
                err.ShowPumpError();
        }

        private void pullTriggerBtn_Click(object sender, EventArgs e)
        {
            if(fUi.State == State.TakeFuel)
            {
                fUi.SelectTab(6);
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
                fUi.SelectTab(5);
                pU.waitThread.Reset();
            }
        }

        private void putPumpAwayBtn_Click(object sender, EventArgs e)
        {
            if (fUi.State == State.ErrorPump)
                fUi.SelectTab((int)fUi.LastStateBeforeError);
            else
                fUi.SelectTab(7);
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
                    string name = Enum.GetName(typeof(FuelType), (int)fUi.SelectedFuelType);
                    string s = ConfigurationManager.AppSettings[name];
                    pU.UnitPrice = Convert.ToDouble(s);
                    pU.UpdateUnitPrice();
                    break;

                case State.InProgress:
                    touchScreenBtn.Enabled = false;
                    insertCardBtn.Enabled = false;
                    removeCardBtn.Enabled = false;
                    pump1Btn.Enabled = true;
                    pump2Btn.Enabled = true;
                    pump3Btn.Enabled = true;
                    pullTriggerBtn.Enabled = true;
                    releaseTriggerBtn.Enabled = true;
                    putPumpAwayBtn.Enabled = true;

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

                    break;

            }
        }
    }
}
