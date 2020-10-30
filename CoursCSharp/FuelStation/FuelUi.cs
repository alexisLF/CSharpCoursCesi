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
    public partial class FuelUi : Form
    {
        private string CodeCB = "";
        public State State { get; set; }
        public EventHandler<State> ChangeTab;
        public State LastStateBeforeError;
        public FuelType SelectedFuelType;
        public int WrongCodeNumber { get; set; }
        private delegate void SelectedTabCallback(int index);

        public FuelUi()
        {
            InitializeComponent();
            numPad1.PressedValue += InsertCardCode;
            State = State.Welcome;
        }

        public void SelectTab(int index)
        {
            if (tabControl1.InvokeRequired)
            {
                SelectedTabCallback d = new SelectedTabCallback(SelectTab);
                Invoke(d, new object[] { index });
            }
            else
            {
                tabControl1.SelectedIndex = index;
                if (State != State.ErrorCode && State != State.ErrorPump)
                    LastStateBeforeError = State;
                //Change State
                State = (State)index;
                //manage tab
                ChangeTab(this, State);
            }
        }

        public void InsertCardCode(object sender, string value)
        {
            switch (value)
            {
                case "X":
                    CodeCB = "";
                    break;

                case "O":
                    wrongCodeErrorLabel.Visible = false;
                    wrongFormatCodeErrorLabel.Visible = false;
                    ValidateCode();
                    break;

                default:
                    if(CodeCB.Length < 4)
                        CodeCB += value;
                    break;
            }
            textBox1.Text = "";
            for (int i = 0; i < CodeCB.Length; ++i)
            {
                textBox1.Text += "*";
            }
        }

        private void ValidateCode()
        {
            if(CodeCB.Length == 4)
            {
                if (CodeCB.Equals(ConfigurationManager.AppSettings["PinCode"]))
                    SelectTab((int)State.PullCard);
                else
                    ShowWrongCodeError();
            }
            else
            {
                ShowWrongFormatCode();
            }
        }

        private void ShowWrongCodeError()
        {
            CodeCB = "";
            ++WrongCodeNumber;
            if (WrongCodeNumber < 3)
                wrongCodeErrorLabel.Visible = true;
            else
                SelectTab((int)State.ErrorCode);
        }

        private void ShowWrongFormatCode()
        {
            wrongFormatCodeErrorLabel.Visible = true;
        }

        public void ShowErrorPumpTab()
        {
            if(State != State.ErrorPump && State != State.ErrorCode)
            {
                LastStateBeforeError = State;
                SelectTab((int)State.ErrorPump);
            }
        }

        private void FuelTypeBtn_Click(object sender, EventArgs e)
        {
            switch (((Button)sender).Text)
            {
                case "Gasole":
                    SelectedFuelType = FuelType.Gasole;
                    break;

                case "SP95":
                    SelectedFuelType = FuelType.SP95;
                    break;

                case "SP98":
                    SelectedFuelType = FuelType.SP98;
                    break;
            }
            SelectTab((int)State.PullPump);
        }

        internal void ResetVariable()
        {
            CodeCB = "";
            State = State.Welcome;
            LastStateBeforeError = State.Welcome;
            WrongCodeNumber = 0;
            textBox1.Text = "";
        }
    }
}
