using PregnancyFoodCheckWpf.Store;
using PregnancyFoodCheckWpf.ViewModel.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace PregnancyFoodCheckWpf.ViewModel
{
    public class CurrentViewModel : BaseViewModel
    {
        private readonly NavigationStore _navigationStore;

        public BaseViewModel CurrentVM  => _navigationStore.CurrentVM; 

        public ICommand ShowSearchViewCommand { get; init; }
        public ICommand ShowAddFoodViewCommand { get; init; }

        public CurrentViewModel()
        {
            _navigationStore = new NavigationStore(() => OnPropertyChagend(nameof(CurrentVM)));

            ShowSearchViewCommand = new ChangeViewCommand<SearchFoodViewModel>(_navigationStore,() => new SearchFoodViewModel());
            ShowAddFoodViewCommand = new ChangeViewCommand<AddNewNotAllowedFoodViewModel>(_navigationStore, () => new AddNewNotAllowedFoodViewModel());
        }
    }

}
