using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVM_1.Models
{
    class Apartado1Model : INotifyPropertyChanged, ICloneable
    {
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public object Clone()
        {
            return MemberwiseClone();
        }

        private string dato1;
        public string Dato1
        {
            get { return dato1; }
            set { dato1 = value; OnPropertyChanged(nameof(Dato1)); }
        }
        
        private string dato2;
        public string Dato2
        {
            get { return dato2; }
            set { dato2 = value; OnPropertyChanged(nameof(Dato2)); }
        }
        
        private string dato3;
        public string Dato3
        {
            get { return dato3; }
            set { dato3 = value; OnPropertyChanged(nameof(Dato3)); }
        }
        
        public Apartado1Model()
        {

        }
    }
}
