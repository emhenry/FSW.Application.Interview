using System;
using System.Windows.Input;

namespace FSW.Application.Interview.ViewModel
{
    public class Updater : ICommand
    {
        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            
        }
    }
}
