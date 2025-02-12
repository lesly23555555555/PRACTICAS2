using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace PRACTICAS2.Model
{
    class PersonaModel : INotifyPropertyChanged
    {
        private string? nombre;
        private string? apellido;
        private string? edad;

        //Propiedades
        public string? Nombre
        {
            get => nombre;
            set
            {
                if (nombre != value)
                {
                    nombre = value;
                    OnPropertyChanged();
                }
            }
        }
        public string? Apellido
        {
            get => apellido;
            set
            {
                if (apellido != value)
                {
                    apellido = value;
                    OnPropertyChanged();
                }
            }
        }

        public string? Edad
        {
            get => edad;
            set
            {
                if (edad != value)
                {
                    edad = value;
                    OnPropertyChanged();
                }
            }
        }
        public event PropertyChangedEventHandler? PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName=null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }   

    }
}
