using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FuelStation
{
    public partial class FuelControl : Form
    {
        FuelPrice pU { get; set; }
        FuelUi fUi { get; set; }
        public FuelControl()
        {
            InitializeComponent();
            pU = new FuelPrice();
            fUi = new FuelUi();
            pU.Show();
            fUi.Show();
            int screenWidth = Screen.PrimaryScreen.Bounds.Width;
            int screenHeight = Screen.PrimaryScreen.Bounds.Height;
            fUi.ChangeTab += ManageStateApp;
        }

        private void touchScreenBtn_Click(object sender, EventArgs e)
        {
            fUi.SelectTab(1);
        }

        private void insertCardBtn_Click(object sender, EventArgs e)
        {
            fUi.SelectTab(2);

        }

        private void removeCardBtn_Click(object sender, EventArgs e)
        {
            fUi.SelectTab(3);

        }

        private void pump1Btn_Click(object sender, EventArgs e)
        {
            fUi.SelectTab(5);

        }

        private void pump2Btn_Click(object sender, EventArgs e)
        {
            fUi.SelectTab(5);

        }

        private void pump3Btn_Click(object sender, EventArgs e)
        {
            fUi.SelectTab(5);

        }

        private void pullTriggerBtn_Click(object sender, EventArgs e)
        {
            fUi.SelectTab(6);

        }

        private void releaseTriggerBtn_Click(object sender, EventArgs e)
        {
           

        }

        private void putPumpAwayBtn_Click(object sender, EventArgs e)
        {
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
