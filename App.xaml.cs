namespace Order
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new AppShell();
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            var window = base.CreateWindow(activationState);

#if WINDOWS
    if (DeviceInfo.Idiom == DeviceIdiom.Desktop)
    {
      window.Width = 480;
      window.Height = 720;
    }
    var displayInfo = DeviceDisplay.Current.MainDisplayInfo;

// Center the window
window.X = (displayInfo.Width / displayInfo.Density - window.Width) / 2;
window.Y = (displayInfo.Height / displayInfo.Density - window.Height) / 2;
#endif

            return window;
        }
    }
}
