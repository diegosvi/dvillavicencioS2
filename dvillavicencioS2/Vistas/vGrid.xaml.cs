namespace dvillavicencioS2.Vistas;

public partial class vGrid : ContentPage
{

	string usuario1;
	string contrase�a1;
	public vGrid()
	{
		InitializeComponent();
	}

	public vGrid(string usuario, string contrase�a) 
	{
		InitializeComponent();
		usuario1 = usuario;
		contrase�a1 = contrase�a;
	}

    private void btnInicio_Clicked(object sender, EventArgs e)
    {

		if (txtUsuario.Text == usuario1 && txtContrase�a.Text == contrase�a1)
		{
			Navigation.PushAsync(new vInicio(usuario1));
		}
		else
		{
			DisplayAlert("Alerta", "Usuario/Contrase�a incorrecto", "Cerrar");
		}
    }

    private void btnInicio_Clicked_1(object sender, EventArgs e)
    {

    }

    private void btnInicio_Clicked_2(object sender, EventArgs e)
    {

    }

    private void btnRegistro_Clicked(object sender, EventArgs e)
    {
		Navigation.PushAsync(new vRegistro());
    }
}