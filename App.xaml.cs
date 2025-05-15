namespace moneyLaundring
{
    public partial class App : Application
    {
        public IServiceProvider Services { get; private set; } 

        public App(IServiceProvider serviceProvider) 
        {
            Services = serviceProvider; 
            InitializeComponent();
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            var page = Services.GetService<MainPage>(); 
            return new Window(page);
        }
    }
}