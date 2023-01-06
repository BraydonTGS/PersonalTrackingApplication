using System;
using System.Windows.Input;

namespace PersonalTracking.WPF.Commands
{
   public class RelayCommand : ICommand
    {
        public event EventHandler? CanExecuteChanged;
        private Action _action;

        public RelayCommand(Action action)
        {
            _action = action;
        }

        // When Can Execute Returns True It Will Make our Control Enabled //
        public bool CanExecute(object? parameter)
        {
            return true;
        }

        // When User Clicks The Control the Execute Will Fire and Call the Delegate //
        // The Delegate will Store the Reference of the Method that is passed in by the User //
        public void Execute(object? parameter)
        {
            _action();
        }
    }
}
