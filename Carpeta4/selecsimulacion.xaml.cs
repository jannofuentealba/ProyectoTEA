namespace AppProyect.Carpeta4;

public partial class selecsimulacion : ContentPage
{
	public selecsimulacion()
	{
		InitializeComponent();
	}

    private void SSimular_Clicked(object sender, EventArgs e)
    {

        Navigation.PushAsync(new Carpeta5.supermercado());
    }
}