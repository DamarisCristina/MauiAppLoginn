namespace MauiAppLogin;

public partial class Login : ContentPage
{
	public Login()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
		try
		{
			List<DadosUsuarios> lista_usuarios

        }
		catch (Exception ex)
		{
			DisplayAlert("Opss", ex.Message, "Fechar");
        }
    }
}