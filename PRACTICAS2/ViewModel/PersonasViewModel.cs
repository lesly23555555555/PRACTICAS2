using FoundationStandard.ObjectHydrator;
using PRACTICAS2.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRACTICAS2.ViewModel
{
    public class PersonasViewModel
    {
        public ObservableCollection<PersonasModel> Personas { get; set; }


        public PersonasViewModel()
        {
            Consultar();
        }

        public void Consultar()
        {
            var listado = new Hydrator<PersonasModel>().WithFirstName(n => n.Nombre);
            Personas = new ObservableCollection<PersonasModel>(listado.GetList(20));
        }
    }
}
