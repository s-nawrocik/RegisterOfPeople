using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace RegisterOfPeopleApp.Helpers
{
    public class RelayCommand : ICommand
    {
        private readonly Predicate<object> canExecute;
        private readonly Action<object> executeWithParam;
        private readonly Action execute;

        private event EventHandler CanExecuteChangedInternal;

        public RelayCommand(Action<object> execute) : this(execute, null)
        {
            this.executeWithParam = execute;
        }
        public RelayCommand(Action execute) : this(execute, null)
        {
            this.execute = execute;
        }
        public RelayCommand(Action<object> execute, Predicate<object> canExecute)
        {
            this.executeWithParam = execute ?? throw new ArgumentNullException("Execute==Null");
            this.canExecute = canExecute;
        }
        public RelayCommand(Action execute, Predicate<object> canExecute)
        {
            this.execute = execute ?? throw new ArgumentNullException("Execute==Null");
            this.canExecute = canExecute;
        }
        public bool CanExecute(object parameter)
        {
            return canExecute == null || canExecute(parameter);
        }
        public void Execute(object parameter)
        {
            if (parameter == null)
            {
                execute();
            }
            else
            {
                executeWithParam(parameter);
            }
        }

        public event EventHandler CanExecuteChanged
        {
            add
            {
                CommandManager.RequerySuggested += value;
                CanExecuteChangedInternal += value;
            }
            remove
            {
                CommandManager.RequerySuggested -= value;
                CanExecuteChangedInternal -= value;
            }
        }
    }
}
