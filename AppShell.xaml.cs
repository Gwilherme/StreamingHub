using StreamingHub.Pages;

namespace StreamingHub
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            Routing.RegisterRoute("CriarConteudo", typeof(CriarConteudo));
            Routing.RegisterRoute("Conteudos", typeof(Conteudos));
            Routing.RegisterRoute("Estatisticas", typeof(Estatisticas));
            Routing.RegisterRoute("Configuracoes", typeof(Configuracoes));
        }
    }
}
