using System.Collections.ObjectModel;
using StreamingHub.Model;

namespace StreamingHub.Pages;

public partial class CriarConteudo : ContentPage
{
    public ObservableCollection<PlayList> PlayLists { get; set; }

    public CriarConteudo()
    {
        InitializeComponent();

        PlayLists = new ObservableCollection<PlayList>
        {
            new PlayList { Name = "Sem PlayList" },
            new PlayList { Name = "Videos" },
            new PlayList { Name = "Podcasts" },
            new PlayList { Name = "Lives" }
        };

        BindingContext = this;
    }

    private async void OnItemSelected(object sender, SelectedItemChangedEventArgs e)
    {
        if (e.SelectedItem is Item selectedItem)
        {
            await DisplayAlert("Item Selecionado", $"Você escolheu: {selectedItem.Name}", "OK");
            ((ListView)sender).SelectedItem = null;
        }
    }

    public class PlayList
    {
        public string Name { get; set; }
    }
}