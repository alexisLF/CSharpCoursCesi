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
    public partial class FuelUi : Form
    {
        private string CodeCB = "";
        public State State { get; set; }
        public EventHandler<State> ChangeTab;
        public State LastStateBeforeError;
        public FuelType SelectedFuelType;

        public FuelUi()
        {
            InitializeComponent();
            numPad1.PressedValue += insertCardCode;
            State = State.Welcome;
        }

        public void SelectTab(int index)
        {
            this.tabControl1.SelectedIndex = index;
            this.LastStateBeforeError = this.State;
            //Change State
            this.State = (State)index;
            //manage tab
            ChangeTab(this, State);
        }

        public void insertCardCode(object sender, string value)
        {
            //string value = numPad1.Value;
            
            switch (value)
            {
                case "X":
                    CodeCB = "";
                    break;

                case "O":
                    ValidateCode();
                    break;

                default:
                    if(CodeCB.Length < 4)
                        CodeCB += value;
                    break;
            }
            textBox1.Text = CodeCB;
        }

        private void ValidateCode()
        {
            if(CodeCB.Length == 4)
            {
                SelectTab(3);
            }
        }

        public void ShowErrorPumpTab()
        {
            LastStateBeforeError = State;
            SelectTab((int)State.ErrorPump);
        }

        public void ReturnToNormalState()
        {
            SelectTab((int)LastStateBeforeError);
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
            SelectTab((int)State.TakeFuel);
        }
    }
}
