namespace AppProyect
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("MjQ5NDc1NkAzMjMyMmUzMDJlMzBTRHNBeXhld1VjSlY4SUg1K094UGlSTVRZNWhrSDBXTUxuTTY5WmJxbEIwPQ==");
            MainPage = new AppShell();
        }
    }
}