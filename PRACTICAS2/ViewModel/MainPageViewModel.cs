using PRACTICAS2.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace PRACTICAS2.ViewModel
{
   public  class MainPageViewModel
    {
        public PersonasModel personasModel { get; set; }
        public MainPageViewModel()
        {
            Consultar();
        }

        public void Consultar()
        {
            personasModel = new PersonasModel()
            {
                Nombre = "LESLY GOMEZ",
                Apellido = "GOMEZ",
                Edad = "21",
            };

        }

        }
    }
