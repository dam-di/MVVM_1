using MVVM_1.Commands;
using MVVM_1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MVVM_1.ViewModels
{
    class HomeViewModel:ViewModelBase
    {
        private Apartado1Model apartado1Model;
        public Apartado1Model Apartado1Model
        {
            get { return apartado1Model; }
            set { apartado1Model = value;OnPropertyChanged(nameof(Apartado1Model)); }
        }
        private Apartado1Model apartado2Model;
        public Apartado1Model Apartado2Model
        {
            get { return apartado2Model;}
            set { apartado2Model = value;OnPropertyChanged(nameof (Apartado2Model)); }
        }

        private Apartado1Model apartado3Model;
        public Apartado1Model Apartado3Model
        {
            get { return apartado3Model; }
            set { apartado3Model = value; OnPropertyChanged(nameof(Apartado3Model)); }
        }


        public ICommand Apartado2Command { get; set; }
        public ICommand Apartado3Command { get; set; }

        public HomeViewModel() 
        { 
            Apartado1Model = new Apartado1Model();
            Apartado2Model = new Apartado1Model();
            Apartado2Model = new Apartado1Model();

            Apartado2Command = new Apartado2Command(this);
            Apartado3Command = new Apartado3Command(this);

        }
    }

    
}
