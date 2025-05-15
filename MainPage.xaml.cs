
namespace moneyLaundring
{
    public partial class MainPage : ContentPage
    {
        private readonly HttpClientFile _httpClientFile;

        public MainPage(HttpClientFile httpClientFile)
        {
            InitializeComponent();
            _httpClientFile = httpClientFile;
        }

        private async void OnConvertClicked(object sender, EventArgs e)
        {
            if (decimal.TryParse(AmountEntry.Text, out decimal amount))
            {
                var euroRate = await _httpClientFile.GetEuroRateAsync();
                if (euroRate.HasValue)
                {
                    var convertedAmount = amount * euroRate.Value;
                    ResultLabel.Text = $"Converted Amount: {convertedAmount:F2} HUF";
                }
                else
                {
                    ResultLabel.Text = "Error fetching exchange rate.";
                }
            }
            else
            {
                ResultLabel.Text = "Invalid amount.";
            }
        }
    }

}
