namespace AppProyect.carpeta2;

public partial class registrar : ContentPage
{
	public registrar()
	{
		InitializeComponent();
	}

    private void Siguiente3_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new carpeta3.bienvenida());
    }
}