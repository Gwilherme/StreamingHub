using System.Collections.ObjectModel;
using static StreamingHub.Pages.Conteudos;

namespace StreamingHub
{
    public partial class MainPage : ContentPage
    {
        public ObservableCollection<Item> Items { get; set; }
        
        public MainPage()
        {
            InitializeComponent();

            Items = new ObservableCollection<Item>
            {
                new Item { Name = "Ver Conteúdos", Tag = "Conteudo" },
                new Item { Name = "Ver Estatísticas", Tag = "Estatistica" },
                new Item { Name = "Configurações", Tag = "Configuracao" }
            };

            BindingContext = this;
        }

        private async void OnNavigateButtonClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("CriarConteudo");
        }

        private async void OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem is Item selectedItem)
            {
                if (selectedItem.Tag.Equals("Conteudo"))
                {
                    await Shell.Current.GoToAsync("Conteudos");
                }
                if (selectedItem.Tag.Equals("Estatistica"))
                {
                    await Shell.Current.GoToAsync("Estatisticas");
                }
                if (selectedItem.Tag.Equals("Configuracao"))
                {
                    await Shell.Current.GoToAsync("Configuracoes");
                }
                
            }
        }
    }

    // colocar em uma classe separada
    public class Item
    {
        public string Name { get; set; }
        public string Tag { get; set; }
    }
}
