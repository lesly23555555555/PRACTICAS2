using PRACTICAS2.Model;

namespace PRACTICAS2
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
            Ejecutar();
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            count++;

            if (count == 1)
                CounterBtn.Text = $"Clicked {count} time";
            else
                CounterBtn.Text = $"Clicked {count} times";

            SemanticScreenReader.Announce(CounterBtn.Text);
        }

        public void Ejecutar()
        {
            //Binding en el backed
            //PersonaModel personaModel = new PersonaModel();
            //personaModel.Nombre = "Holaa";
            //txtNombre.Text = personaModel.Nombre;


            PersonaModel personaModel = new PersonaModel()
            {
                Nombre = "LESLY GOMEZ",
            };

            //Esto es lo de la practica_05 (BindingContext)
            BindingContext = personaModel.Nombre;

            txtNombre.Text = personaModel.Nombre;
            Binding personaBinding = new Binding();

            personaBinding.Source = personaModel; //Origen
            personaBinding.Path = "Nombre"; //Ruta
            txtNombre.SetBinding(Entry.TextProperty, personaBinding); //Destino

        }


        private void Aceptar_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Asistente del sistema", "Se ha guardado el registro en la bd", "Aceptar");

        }
    }

}
