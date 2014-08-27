using System;
using System.Collections.Generic;
using System.Windows.Input;
using TestCustomer.Commands;
using TestCustomer.Models;

namespace TestCustomer.ViewModels
{
    public class CustomerViewModel
    {
        /// <summary>
        /// This is the Customer variable that represents the model. It is accessed 
        /// by the XAML view when using this view model as a datacontext. 
        /// This exposes the model properties.
        /// </summary>
        public Customer CustomerModel { get; set; } // Make sure you include accessors get; set; or this won't be exposed.

        /// <summary>
        /// This ensures that the command can only be executed when we have instantiated Customer
        /// </summary>
        public bool CanExecuteCustomerCommand
        {
            get
            {
                if (CustomerModel == null)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
        }

        /// <summary>
        /// This command will be accessible in the XAML
        /// via {Binding ChangeNameToCharlieCommand}
        /// </summary>
        public ICommand ChangeNameToCharlieCommand { get; private set; }


        /// <summary>
        /// This is the constructor which is called when a new version
        /// of the ViewModel is created. This will run when DataContext
        /// is initially bound to this ViewModel in the XAML
        /// </summary>
        public CustomerViewModel()
        {
            ChangeNameToCharlieCommand = new ChangeNameToCharlieCommand(this);

            //Mock Data
            CustomerModel = new Customer();
            CustomerModel.Id = 1;
            CustomerModel.Name = "David";
        }

        #region methods
        /// <summary>
        /// This is called from the ExampleCommand.Execute(...) function
        /// </summary>
        public void ChangeNameToCharlie()
        {
            // Changing the name here will change the name on the form
            CustomerModel.Name = "Charlie";
        }
        #endregion
    }
}
