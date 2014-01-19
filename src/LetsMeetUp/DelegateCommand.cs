using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace LetsMeetUp
{
    public sealed class DelegateCommand
        : ICommand
    {
        private bool _canExecuteProperty;
        private readonly Action<object> _executeDelegate;

        public bool CanExecuteProperty { get { return _canExecuteProperty; } set { _canExecuteProperty = value; if (CanExecuteChanged != null) CanExecuteChanged(this, new EventArgs()); } }

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return CanExecuteProperty;
        }

        public void Execute(object parameter)
        {
            _executeDelegate(parameter);
        }

        public DelegateCommand(Action<object> executeDelegate, bool canExecute = true) 
        {
            _canExecuteProperty = canExecute;
            _executeDelegate = executeDelegate;
        }
    }
}
