using MVVM_1.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MVVM_1.Commands
{
    class Apartado2Command : ICommand
    {
        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            HomeViewModel.Apartado2Model = HomeViewModel.Apartado1Model;
        }

        public HomeViewModel HomeViewModel { get; set; }
        public Apartado2Command(HomeViewModel HomeViewModel)
        {
            this.HomeViewModel = HomeViewModel;
        }
    }
}
