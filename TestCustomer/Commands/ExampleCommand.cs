using System;
using System.Collections.Generic;
using System.Windows.Input;
using TestCustomer.ViewModels;

namespace TestCustomer.Commands
{
    public class ChangeNameToCharlieCommand : ICommand
    {
        private CustomerViewModel _viewModel;

        #region constructor
        public ChangeNameToCharlieCommand(CustomerViewModel viewModel)
        {
            this._viewModel = viewModel;
        }
        #endregion

        public bool CanExecute(object parameter)
        {
            return _viewModel.CanExecuteCustomerCommand;
        }

        public event EventHandler CanExecuteChanged;

        public void Execute(object parameter)
        {
            _viewModel.ChangeNameToCharlie();
        }
    }
}
