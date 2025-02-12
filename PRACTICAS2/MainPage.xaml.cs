using PRACTICAS2.Model;
using PRACTICAS2.ViewModel;

namespace PRACTICAS2
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        MainPageViewModel mainPageViewModel = new MainPageViewModel();

        public MainPage()
        {
            InitializeComponent();
            BindingContext = mainPageViewModel;
        }
        //EVENTO GUARDAR 
        private void Aceptar_Clicked(object sender, EventArgs e)
        {
           // personasModel.Nombre = "Lesly";
           // personasModel.Apellido = "Gomez";
            //personasModel.Edad = "21";
        }

    }
}


