namespace AppProyect.carpeta;

public partial class registro : ContentPage
{
	public registro()
	{
		InitializeComponent();
	}

    private void Siguiente2_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new carpeta2.registrar());
    }
}