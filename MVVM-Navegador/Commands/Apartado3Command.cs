using MVVM_1.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MVVM_1.Commands
{
    class Apartado3Command: ICommand
    {
        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            HomeViewModel.Apartado3Model = (Models.Apartado1Model)HomeViewModel.Apartado1Model.Clone();
        }

        public HomeViewModel HomeViewModel { get; set; }
        public Apartado3Command(HomeViewModel HomeViewModel)
        {
            this.HomeViewModel = HomeViewModel;
        }
    }
}
