namespace FuelStation
{
    public class ErrorManager
    {
        FuelControl Control { get; set; }
        public ErrorManager(FuelControl control)
        {
            this.Control = control;
        }

        public void ShowPumpError()
        {
            Control.FuelScreen.ShowErrorPumpTab();
        }
    }
}