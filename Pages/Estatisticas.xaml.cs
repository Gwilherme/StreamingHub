using StreamingHub.Model;
using System.Collections.ObjectModel;

namespace StreamingHub.Pages;

public partial class Estatisticas : ContentPage
{
    public ObservableCollection<Estatistica> EstatisticasList { get; set; }

    public Estatisticas()
	{
		InitializeComponent();

        EstatisticasList = new ObservableCollection<Estatistica>
        {
            new Estatistica { Descricao = "Vizualizações" },
            new Estatistica { Descricao = "Likes" },
            new Estatistica { Descricao = "Dislikes" }
        };

        BindingContext = this;
    }

    public class Estatistica
    {
        public string Descricao { get; set; }
    }
}