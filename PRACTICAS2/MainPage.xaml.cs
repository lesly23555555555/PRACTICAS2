using PRACTICAS2.Model;

namespace PRACTICAS2
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        private PersonaModel personaModel { get; set; }

        public MainPage()
        {
            InitializeComponent();
            Ejecutar();
        }

        public void Ejecutar()
        {
            //PersonaModel personaModel = new PersonaModel();
            //personaModel.Nombre = "Holaa";
            //txtNombre.Text = personaModel.Nombre;


            personaModel = new PersonaModel()
            {
                Nombre = "LESLY GOMEZ",
            };

            BindingContext = personaModel;

            //txtNombre.Text = personaModel.Nombre;
            //Binding personaBinding = new Binding();

            //personaBinding.Source = personaModel; //Origen
            //personaBinding.Path = "Nombre"; //Ruta
            //txtNombre.SetBinding(Entry.TextProperty, personaBinding); //Destino

        }
        //EVENTO GUARDAR 
        private void Aceptar_Clicked(object sender, EventArgs e)
        {
            personaModel.Nombre = "Lesly";
            personaModel.Apellido = "Gomez";
            personaModel.Edad = "21";
        }

    }
}


