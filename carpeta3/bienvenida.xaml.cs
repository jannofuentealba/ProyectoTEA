namespace AppProyect.carpeta3;

public partial class bienvenida : ContentPage
{
	public bienvenida()
	{
		InitializeComponent();
	}

    private void Continua_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Carpeta4.selecsimulacion());
    }
}