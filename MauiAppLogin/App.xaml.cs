namespace MauiAppLogin
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            var window = new Window(new Login());

            window.Width = 400;
            window.Height = 600;

            _ = VerificarUsuarioLogadoAsync(window);

            return window;
        }

        private async Task VerificarUsuarioLogadoAsync(Window window)
        {
            try
            {
                string? usuario_logado = await SecureStorage.Default.GetAsync("usuario_logado");

                if (!string.IsNullOrEmpty(usuario_logado))
                {
                    window.Page = new Protecao();
                }
            }
            catch (Exception)
            {
                // Se não conseguir ler o SecureStorage, continua no Login
            }
        }
    }
}