using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace MVVMDemo.Helpers
{
    class RelayCommand : ICommand
    {
        public RelayCommand(Action execute, Func<bool> canExecute = null)
        {
            this.execute = execute ?? throw new ArgumentNullException(nameof(execute));
            this.canExecute = canExecute ?? new Func<bool>(() => true);
        }

        private Action execute;
        private Func<bool> canExecute;
        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return canExecute();
        }

        public void Execute(object parameter)
        {
            execute?.Invoke();
        }
    }
}
