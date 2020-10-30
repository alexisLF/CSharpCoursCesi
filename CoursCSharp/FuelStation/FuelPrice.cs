using System;
using System.Configuration;
using System.Threading;
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
        public EventHandler MaxPrice;
        public FuelPrice()
        {
            InitializeComponent();
            FuelLiterBox.Text = FuelLitre.ToString();
            PriceBox.Text = Price.ToString();
            UnitPriceBox.Text = UnitPrice.ToString();
        }

        public void UpdateFuelLitre()
        {
            if (!FuelLiterBox.InvokeRequired)
            {
                FuelLiterBox.Text = string.Format("{0:0.00}", FuelLitre);
            }
            else
            {
                UpdateFuelLitreCallback d = new UpdateFuelLitreCallback(UpdateFuelLitre);
                Invoke(d);
            }
        }

        public void UpdatePrice()
        {
            if (FuelLiterBox.InvokeRequired)
            {
                UpdatePriceCallback d = new UpdatePriceCallback(UpdatePrice);
                Invoke(d);
            }
            else
            {
                PriceBox.Text = string.Format("{0:0.00}", Price);
            }
        }

        public void UpdateUnitPrice()
        {
            UnitPriceBox.Text = string.Format("{0:0.00}", UnitPrice);
        }

        public void IncrementFuel()
        {
            while (Price < double.Parse(ConfigurationManager.AppSettings["MaxSpent"]))
            {
                waitThread.WaitOne();
                FuelLitre += 0.01;
                Price = FuelLitre * UnitPrice;
                UpdateFuelLitre();
                UpdatePrice();
            }
            StopPump();
        }

        private void StopPump()
        {
            MaxPrice(this, EventArgs.Empty);
        }

        internal void ResetVariable()
        {
            UnitPrice = 0;
            Price = 0;
            FuelLitre = 0;
            UpdatePrice();
            UpdateUnitPrice();
            UpdateFuelLitre();
        }
    }
}
