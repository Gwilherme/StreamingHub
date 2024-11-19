using System.Collections.ObjectModel;
using StreamingHub.Model;

namespace StreamingHub.Pages;

public partial class Conteudos : ContentPage
{
    public ObservableCollection<Conteudo> ConteudosList { get; set; }

    public Conteudos()
	{
		InitializeComponent();

        ConteudosList = new ObservableCollection<Conteudo>
        {
            new Conteudo { Name = "Video engraçado" },
            new Conteudo { Name = "Video explicativo" },
            new Conteudo { Name = "Video educacional" }
        };

        BindingContext = this;
    }

    public class Conteudo
    {
        public string Name { get; set; }
    }

}