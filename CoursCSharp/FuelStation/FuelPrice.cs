using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FuelStation
{
    public partial class FuelPrice : Form
    {
        public double Price { get; set; }
        public double UnitPrice { get; set; }
        public double FuelLitre { get; set; }
        public EventWaitHandle waitThread = new EventWaitHandle(false, EventResetMode.ManualReset);
        private delegate void UpdateFuelLitreCallback();
        private delegate void UpdatePriceCallback();
        public FuelPrice()
        {
            InitializeComponent();
            UnitPrice = 1.42;
            FuelLiterBox.Text = FuelLitre.ToString();
            PriceBox.Text = Price.ToString();
            UnitPriceBox.Text = UnitPrice.ToString();
        }

        public void UpdateFuelLitre()
        {
            if (FuelLiterBox.InvokeRequired)
            {
                UpdateFuelLitreCallback d = new UpdateFuelLitreCallback(UpdateFuelLitre);
                this.Invoke(d);
            }
            else
            {
                Price = FuelLitre * UnitPrice;
                FuelLiterBox.Text = FuelLitre.ToString();
                PriceBox.Text = Price.ToString();
            }
        }

        public void UpdatePrice()
        {
            if (FuelLiterBox.InvokeRequired)
            {
                UpdatePriceCallback d = new UpdatePriceCallback(UpdatePrice);
                this.Invoke(d);
            }
            else
            {
                PriceBox.Text = Price.ToString();
            }
        }

        public void IncrementFuel()
        {
            while (true)
            {
                waitThread.WaitOne();

                FuelLitre += 0.01;
                Price = FuelLitre * UnitPrice;
                UpdateFuelLitre();
                UpdatePrice();
            }
        }
    }
}
