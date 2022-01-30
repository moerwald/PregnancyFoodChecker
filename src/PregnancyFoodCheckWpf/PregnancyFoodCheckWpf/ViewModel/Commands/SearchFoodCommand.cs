using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PregnancyFoodCheckWpf.ViewModel.Commands
{

    public class SearchFoodCommand : BaseCommand
    {
        private readonly SearchFoodViewModel _searchFoodViewModel;

        public SearchFoodCommand(SearchFoodViewModel searchFoodViewModel) => _searchFoodViewModel = searchFoodViewModel;

        public override bool CanExecute(object? parameter) => !string.IsNullOrEmpty(_searchFoodViewModel.FoodToSearch);

        public override void Execute(object? parameter) => _searchFoodViewModel.FindNotAllowedFoodAsync();
    }
}
