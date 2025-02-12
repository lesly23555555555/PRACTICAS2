using PRACTICAS2.view;

namespace PRACTICAS2
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //MainPage = new AppShell();

            MainPage = new PersonasView();
        }
        }
    }