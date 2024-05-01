using System;
namespace MyAppMaui.Pages;



public partial class StorePage : ContentPage
{
  
    Dictionary<int, int> memoryPrices = new Dictionary<int, int>()
    {
        {0, 0},
        {4, 50},
        {6, 60},
        {8, 70},
        {16, 90},
        {32, 120}
    };

    // Storage Size GB için fiyatlandırma planı
    Dictionary<int, int> storagePrices = new Dictionary<int, int>()
    {
        {0, 0},
        {100, 100},
        {200, 150},
        {300, 200},
        {400, 250},
        {500, 300},
        {600, 350},
        {700, 400},
        {800, 450},
        {900, 500},
        {1000, 550},
        {1100, 600},
        {1200, 650},
        {1300, 700},
        {1400, 750},
        {1500, 800}
    };

    // Monitor Size inch için fiyatlandırma planı
    Dictionary<int, int> monitorPrices = new Dictionary<int, int>()
    {
        {0, 0},
        {17, 450},
        {18, 500},
        {19, 550},
        {20, 600},
        {21, 650},
        {22, 700},
        {23, 750}
    };
    
    public StorePage()
	{
		InitializeComponent();
	}





    private void Button_Clicked(object sender, EventArgs e)
    {
        int number = Convert.ToInt32(numberLabel.Text);
        int[] validValues = { 4, 6, 8, 16, 32 };
        int currentIndex = Array.IndexOf(validValues, number);
        if (currentIndex > 0) // Eğer geçerli değer varsa
        {
            number = validValues[currentIndex - 1];
            numberLabel.Text = number.ToString();
            UpdatePrice();
        }
    }

    private void Button_Clicked_1(object sender, EventArgs e)
    {
        int number = Convert.ToInt32(numberLabel.Text);
        int[] validValues = { 4, 6, 8, 16, 32 };
        int currentIndex = Array.IndexOf(validValues, number);
        if (currentIndex < validValues.Length - 1) // Eğer geçerli değer varsa
        {
            number = validValues[currentIndex + 1];
            numberLabel.Text = number.ToString();
            UpdatePrice();
        }
    }

    private void Button_Clicked_2(object sender, EventArgs e)
    {
        int number = Convert.ToInt32(numberLabel2.Text);
        int[] validValues = { 100, 200, 300, 400, 500, 600, 700, 800, 900, 1000, 1100, 1200, 1300, 1400, 1500 };
        int currentIndex = Array.IndexOf(validValues, number);
        if (currentIndex > 0) // Eğer geçerli değer varsa
        {
            number = validValues[currentIndex - 1];
            numberLabel2.Text = number.ToString();
            UpdatePrice();
        }
    }

    private void Button_Clicked_3(object sender, EventArgs e)
    {
        int number = Convert.ToInt32(numberLabel2.Text);
        int[] validValues = { 100, 200, 300, 400, 500, 600, 700, 800, 900, 1000, 1100, 1200, 1300, 1400, 1500 };
        int currentIndex = Array.IndexOf(validValues, number);
        if (currentIndex < validValues.Length - 1) // Eğer geçerli değer varsa
        {
            number = validValues[currentIndex + 1];
            numberLabel2.Text = number.ToString();
            UpdatePrice();
        }
    }

    private void Button_Clicked_4(object sender, EventArgs e)
    {
        int number = Convert.ToInt32(numberLabel3.Text);
        int[] validValues = { 17, 18, 19, 20, 21, 22, 23 };
        int currentIndex = Array.IndexOf(validValues, number);
        if (currentIndex > 0) // Eğer geçerli değer varsa
        {
            number = validValues[currentIndex - 1];
            numberLabel3.Text = number.ToString();
            UpdatePrice();
        }
        else if (number == 17) // Eğer mevcut değer 17 ise, değeri 23'e ayarla
        {
            number = 23;
            numberLabel3.Text = number.ToString();
            UpdatePrice();
        }
    }

    private void Button_Clicked_5(object sender, EventArgs e)
    {
        int number = Convert.ToInt32(numberLabel3.Text);
        int[] validValues = { 17, 18, 19, 20, 21, 22, 23 };
        int currentIndex = Array.IndexOf(validValues, number);
        if (currentIndex < validValues.Length - 1) // Eğer geçerli değer varsa
        {
            number = validValues[currentIndex + 1];
            numberLabel3.Text = number.ToString();
            UpdatePrice();
        }
        else if (number == 23) // Eğer mevcut değer 23 ise, değeri 17'ye ayarla
        {
            number = 17;
            numberLabel3.Text = number.ToString();
            UpdatePrice();
        }
    }

  



    // Her bir değeri değiştirdikten sonra fiyatı güncelle
    private void UpdatePrice()
    {
        int memorySize = Convert.ToInt32(numberLabel.Text);
        int storageSize = Convert.ToInt32(numberLabel2.Text);
        int monitorSize = Convert.ToInt32(numberLabel3.Text);

        int memoryPrice = memoryPrices[memorySize];
        int storagePrice = storagePrices[storageSize];
        int monitorPrice = monitorPrices[monitorSize];

        // Toplam fiyatı hesapla ve ekrana yazdır
        int totalPrice = memoryPrice + storagePrice + monitorPrice;
        Total.Text = "Total: " + totalPrice.ToString();
    }
}