using System;
using System.Configuration;
using System.Drawing;
using System.Threading;
using System.Timers;
using System.Windows.Forms;

namespace FuelStation
{
    public partial class FuelControl : Form
    {
        #region Properties
        public FuelPrice PriceUi { get; set; }
        public FuelUi FuelScreen { get; set; }
        private Thread WorkingThread;
        private ErrorManager ErrorManager { get; set; }
        public bool PumpPulled { get; set; } = false;
        private delegate void TriggerFalseCallback();
        private static System.Timers.Timer EndTimer;
        #endregion
        #region Ctor
        public FuelControl()
        {
            InitializeComponent();
            int screenWidth = Screen.PrimaryScreen.Bounds.Width;
            int screenHeight = Screen.PrimaryScreen.Bounds.Height;

            PriceUi = new FuelPrice();
            FuelScreen = new FuelUi();

            ErrorManager = new ErrorManager(this);
            FuelScreen.ChangeTab += ManageStateApp;
            FuelScreen.SelectTab((int)State.Welcome);
            PriceUi.MaxPrice += ManageEndPump;

            this.Width = screenWidth / 4;
            this.Height = screenHeight /2;
            PriceUi.Width = screenWidth / 4;
            PriceUi.Height = screenHeight / 3;

            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(0, PriceUi.Height);

            FuelScreen.StartPosition = FormStartPosition.Manual;
            FuelScreen.Location = new Point(this.Width, 0);

            PriceUi.StartPosition = FormStartPosition.Manual;
            PriceUi.Location = new Point(0, 0);

            PriceUi.Show();
            FuelScreen.Show();
        }
        #endregion
        #region Event Methods
        private void TouchScreenBtn_Click(object sender, EventArgs e)
        {
            if (FuelScreen.State == State.Welcome)
                FuelScreen.SelectTab((int)State.InsertCard);
        }

        private void InsertCardBtn_Click(object sender, EventArgs e)
        {
            if (FuelScreen.State == State.Welcome || FuelScreen.State == State.InsertCard)
                FuelScreen.SelectTab((int)State.PutCode);
        }

        private void RemoveCardBtn_Click(object sender, EventArgs e)
        {
            if (FuelScreen.State == State.PullCard)
                FuelScreen.SelectTab((int)State.ChooseTypeFuel);
            else
                FuelScreen.SelectTab((int)State.Welcome);
        }

        private void Pump1Btn_Click(object sender, EventArgs e)
        {
            PumpPulled = true;
            pump2Btn.Enabled = false;
            putPumpAwayBtn.Enabled = true;
            pump3Btn.Enabled = false;
            if (FuelScreen.State == State.PullPump && FuelScreen.SelectedFuelType == FuelType.Gasole)
                FuelScreen.SelectTab((int)State.TakeFuel);
            else
                ErrorManager.ShowPumpError();
        }

        private void Pump2Btn_Click(object sender, EventArgs e)
        {
            PumpPulled = true;
            pump1Btn.Enabled = false;
            pump3Btn.Enabled = false;
            putPumpAwayBtn.Enabled = true;
            if (FuelScreen.State == State.PullPump && FuelScreen.SelectedFuelType == FuelType.SP98)
                FuelScreen.SelectTab((int)State.TakeFuel);
            else
                ErrorManager.ShowPumpError();
        }

        private void Pump3Btn_Click(object sender, EventArgs e)
        {
            PumpPulled = true;
            pump1Btn.Enabled = false;
            pump2Btn.Enabled = false;
            putPumpAwayBtn.Enabled = true;

            if (FuelScreen.State == State.PullPump && FuelScreen.SelectedFuelType == FuelType.SP95)
                FuelScreen.SelectTab((int)State.TakeFuel);
            else
                ErrorManager.ShowPumpError();
        }

        private void PullTriggerBtn_Click(object sender, EventArgs e)
        {
            if (FuelScreen.State == State.TakeFuel)
            {
                FuelScreen.SelectTab((int)State.InProgress);
                if (WorkingThread == null)
                {
                    WorkingThread = new Thread(new ThreadStart(PriceUi.IncrementFuel));
                    WorkingThread.Start();
                    PriceUi.waitThread.Set();
                }
                else
                {
                    PriceUi.waitThread.Set();
                }
            }
        }

        private void ReleaseTriggerBtn_Click(object sender, EventArgs e)
        {
            if (FuelScreen.State == State.InProgress)
            {
                FuelScreen.SelectTab((int)State.TakeFuel);
                PriceUi.waitThread.Reset();
            }
        }

        private void PutPumpAwayBtn_Click(object sender, EventArgs e)
        {
            if (FuelScreen.State == State.ErrorPump)
            {
                FuelScreen.SelectTab((int)FuelScreen.LastStateBeforeError);
            }
            else
            {
                WorkingThread?.Abort();
                FuelScreen.SelectTab((int)State.Thanks);
            }
        }
        #endregion
        #region Others
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
                    putPumpAwayBtn.Enabled = false;
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
                    putPumpAwayBtn.Enabled = false;
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
                    putPumpAwayBtn.Enabled = false;
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
                    putPumpAwayBtn.Enabled = false;
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
                    putPumpAwayBtn.Enabled = false;
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
                    putPumpAwayBtn.Enabled = false;
                    string name = Enum.GetName(typeof(FuelType), (int)FuelScreen.SelectedFuelType);
                    string s = ConfigurationManager.AppSettings[name];
                    PriceUi.UnitPrice = Convert.ToDouble(s);
                    PriceUi.UpdateUnitPrice();
                    break;

                case State.TakeFuel:
                    touchScreenBtn.Enabled = false;
                    insertCardBtn.Enabled = false;
                    removeCardBtn.Enabled = false;
                    pump1Btn.Enabled = false;
                    pump2Btn.Enabled = false;
                    pump3Btn.Enabled = false;
                    pullTriggerBtn.Enabled = true;
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
                    SetTimer();
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
                    putPumpAwayBtn.Enabled = false;
                    SetTimer();
                    break;
            }
        }

        private void ResetVariable()
        {
            WorkingThread = null;
            PriceUi.ResetVariable();
            FuelScreen.ResetVariable();
        }

        private void EndProcess(object source, ElapsedEventArgs e)
        {
            FuelScreen.SelectTab((int)State.Welcome);
        }

        private void FuelControl_FormClosed(object sender, FormClosedEventArgs e)
        {
            WorkingThread?.Abort();
        }

        public void TriggerFalse()
        {
            if (releaseTriggerBtn.InvokeRequired && pullTriggerBtn.InvokeRequired && putPumpAwayBtn.InvokeRequired)
            {
                TriggerFalseCallback d = new TriggerFalseCallback(TriggerFalse);
                Invoke(d);
            }
            else
            {
                releaseTriggerBtn.Enabled = false;
                pullTriggerBtn.Enabled = false;
                putPumpAwayBtn.Enabled = true;
            }
        }

        private void SetTimer()
        {
            EndTimer = new System.Timers.Timer(2000);
            EndTimer.Elapsed += EndProcess;
            EndTimer.AutoReset = false;
            EndTimer.Enabled = true;
        }
        
        private void ManageEndPump(object sender, EventArgs e)
        {
            TriggerFalse();
            WorkingThread.Abort();
        }
        #endregion
    }
}
