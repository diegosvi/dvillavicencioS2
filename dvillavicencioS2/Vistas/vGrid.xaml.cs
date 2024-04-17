namespace dvillavicencioS2.Vistas;

public partial class vGrid : ContentPage
{

	string usuario1;
	string contraseña1;
	public vGrid()
	{
		InitializeComponent();
	}

	public vGrid(string usuario, string contraseña) 
	{
		InitializeComponent();
		usuario1 = usuario;
		contraseña1 = contraseña;
	}

    private void btnInicio_Clicked(object sender, EventArgs e)
    {

		if (txtUsuario.Text == usuario1 && txtContraseña.Text == contraseña1)
		{
			Navigation.PushAsync(new vInicio(usuario1));
		}
		else
		{
			DisplayAlert("Alerta", "Usuario/Contraseña incorrecto", "Cerrar");
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