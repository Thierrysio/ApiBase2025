using ApiBase2025.Vues;

namespace ApiBase2025
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new VueListeProduits();
        }
    }
}
