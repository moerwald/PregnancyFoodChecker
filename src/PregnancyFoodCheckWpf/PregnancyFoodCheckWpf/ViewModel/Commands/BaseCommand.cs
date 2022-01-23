using PregnancyFoodCheckWpf.Store;
using System;
using System.Windows.Input;

namespace PregnancyFoodCheckWpf.ViewModel.Commands
{
    public class BaseCommand : ICommand
    {
        public event EventHandler? CanExecuteChanged
        {
            add => CommandManager.RequerySuggested += value; 
            remove => CommandManager.RequerySuggested -= value; 
        }

        public virtual bool CanExecute(object? parameter) => true;

        public virtual void Execute(object? parameter)
        { }
    }

    internal class ChangeViewCommand<TViewModel> : BaseCommand
        where TViewModel : BaseViewModel
    {
        private readonly NavigationStore _navigationStore;
        private readonly Func<TViewModel> _getViewModel;

        public ChangeViewCommand(NavigationStore navigationStore, Func<TViewModel> getViewModel)
        {
            _navigationStore = navigationStore;
            _getViewModel = getViewModel;
        }

        public override void Execute(object? parameter) => _navigationStore.CurrentVM = _getViewModel();
    }

}
