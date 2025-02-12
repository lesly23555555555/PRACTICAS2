using PRACTICAS2.ViewModel;
namespace PRACTICAS2.view;

public partial class PersonaView : ContentPage
{
	public PersonaView()
	{
		InitializeComponent();

		BindingContext = new PersonasViewModel();
    }
}