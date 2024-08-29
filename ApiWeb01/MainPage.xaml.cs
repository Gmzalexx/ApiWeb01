using ApiWeb01.Servicios;
namespace ApiWeb01
{
    public partial class MainPage : ContentPage
    {
        

        private readonly IRickAndMortyServices _rickAndMortyServices;
        public MainPage(IRickAndMortyServices services)
        {
            InitializeComponent();
            _rickAndMortyServices = services;
        }

        private async void OnCounterClicked(object sender, EventArgs e)
        {
            loading.IsVisible = true;

            var data = await _rickAndMortyServices.Obtener();
            listViewPersonajes.ItemsSource = data;

            loading.IsVisible = false;
        }
    }

}
