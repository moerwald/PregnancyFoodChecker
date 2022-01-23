using PregnancyFoodCheckWpf.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PregnancyFoodCheckWpf.Store
{
    internal class NavigationStore
    {
        private readonly Action _viewModelChanged;
        private BaseViewModel _currentVM = new SearchFoodViewModel();

        public NavigationStore(Action viewModelChanged) => _viewModelChanged = viewModelChanged;

        public BaseViewModel CurrentVM
        {
            get => _currentVM; set
            {
                _currentVM = value;
                _viewModelChanged?.Invoke();
            }
        }
    }
}
