
using MauiAppHotel.Models;

namespace MauiAppHotel
{
    public partial class App : Application
    {

        public List<Quarto> lista_quartos = new List<Quarto>
        {
            new Quarto
            {
                Descricao = "Suíte Super Luxo ",
                Valor_Diaria_Adulto = 110.0,
                Valor_Diaria_Crianca = 55.0,
            },
             new Quarto
            {
                Descricao = "Suíte Luxo ",
                Valor_Diaria_Adulto = 80.0,
                Valor_Diaria_Crianca = 40.0,
            },
              new Quarto
            {
                Descricao = "Suíte Single ",
                Valor_Diaria_Adulto = 50.0,
                Valor_Diaria_Crianca = 25.0,
            },
              new Quarto
            {
                Descricao = "Suíte Crise ",
                Valor_Diaria_Adulto = 25.0,
                Valor_Diaria_Crianca = 12.50,
             },
        };


        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new Views.ContratacaoHospedagem());
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            var window = base.CreateWindow(activationState);

            window.Width = 400;
            window.Height = 600;

            return window;
        }
    }
}
