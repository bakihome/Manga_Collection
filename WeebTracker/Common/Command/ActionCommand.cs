using System.Windows.Input;

namespace Common.Command
{
    /// <summary>
    /// simple ICommand implement
    /// </summary>
    public class ActionCommand : ICommand
    {
        /// <summary>
        /// The method called when Execute() is invoked.
        /// </summary>
        private readonly Action<object> _handlerExecute;
        /// <summary>
        /// The method called when CanExecute() is invoked.
        /// </summary>
        private readonly Func<object, bool> _handlerCanExecute;

        /// <summary>
        /// Initializes a new instance of the <see cref="ActionCommand" /> class.
        /// </summary>
        /// <param name="execute">The method called when Execute() is invoked.</param>
        /// <param name="canExecute">The method called when CanExecute() is invoked.</param>
        public ActionCommand(Action<object> execute, Func<object, bool> canExecute)
        {
            this._handlerExecute = execute ?? throw new ArgumentNullException(nameof(execute));
            this._handlerCanExecute = canExecute;
        }

        #region -------------------------------------- ICommand implementation ------------------------------------------------
        /// <summary>
        /// Occurs when changes occur that affect whether or not the command should execute.
        /// </summary>
        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        /// <summary>
        /// Defines the method to be called when the command is invoked.
        /// </summary>
        /// <param name="parameter">Data used by the command. If the command does not require data to be passed,
        /// this object can be set to null.</param>
        public void Execute(object parameter)
        {
            this._handlerExecute(parameter);
        }

        /// <summary>
        /// Defines the method that determines whether the command can execute in its current state.
        /// </summary>
        /// <param name="parameter">Data used by the command. If the command does not require data to be passed,
        /// this object can be set to null.</param>
        /// <returns>
        /// <c>true</c> if this command can be executed; otherwise <c>false</c>.
        /// </returns>
        public bool CanExecute(object parameter)
        {
            if (this._handlerCanExecute == null)
            {
                return true;
            }

            return this._handlerCanExecute(parameter);
        }        
        #endregion






        //public void RaiseCanExecuteChanged()
        //    => CanExecuteChanged?.Invoke(this, EventArgs.Empty);
    }
}
