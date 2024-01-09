namespace dAstudilloExamen
{
    public partial class MainPage : ContentPage
    {
        int count = 0;
       String[] usuarios= { "david","gerald","israel" };
        String[] contrasenia = { "david", "gerald", "israel" };
       
        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            String usuario =usu.Text;

            if (usuarios.Contains(usu.Text))
                if (contrasenia.Contains(con.Text))
                {
                    DisplayAlert("Incio de sesion", "Bienvenido", "OK");
                    Navigation.PushAsync(new Registro(usuario));
                }
                else
                {
                    DisplayAlert("Error", "Usuario o Contraseña Incorrecta", "OK");
                }

            SemanticScreenReader.Announce(CounterBtn.Text);
        }

        private void Acerca_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Acerca de la App", "Aplicacion creada por David Astudillo 8vo A", "OK");
        }
    }
}