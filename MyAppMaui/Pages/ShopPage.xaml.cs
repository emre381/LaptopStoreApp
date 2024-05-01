
namespace MyAppMaui.Pages
{
    public partial class ShopPage : ContentPage
    {
       

        public ShopPage()
        {
            InitializeComponent();

        }


        private void UpdateTotalPrice()
        {
            int totalPrice = CalculateCPU() + CalculateStorage() + CalculateMonitor() ;
            Total2.Text = "Total: " + totalPrice.ToString();
        }

        private void cpubutt1_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            UpdateTotalPrice();
        }

        private void cpubutt2_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            UpdateTotalPrice();
        }

        private void cpubutt3_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            UpdateTotalPrice();
        }

        private void cpubutt4_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            UpdateTotalPrice();
        }

        private void stbutt1_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            UpdateTotalPrice();
        }

        private void stbutt2_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            UpdateTotalPrice();
        }

        private void mnbutt1_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            UpdateTotalPrice();
        }

        private void mnbutt2_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            UpdateTotalPrice();
        }

        private void mnbutt3_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            UpdateTotalPrice();
        }

       

        private int CalculateCPU()
        {
            if (cpubutt1.IsChecked)
                return 200;
            else if (cpubutt2.IsChecked)
                return 300;
            else if (cpubutt3.IsChecked)
                return 400;
            else if (cpubutt4.IsChecked)
                return 500;
            else
                return 0;
        }

        private int CalculateStorage()
        {
            if (stbutt1.IsChecked)
                return 300;
            else if (stbutt2.IsChecked)
                return 150;
            else
                return 0;
        }

        private int CalculateMonitor()
        {
            if (mnbutt1.IsChecked)
                return 250;
            else if (mnbutt2.IsChecked)
                return 350;
            else if (mnbutt3.IsChecked)
                return 450;
            else
                return 0;
        }
    }
}
