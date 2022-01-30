using PregnancyFoodCheckWpf.Helper;
using PregnancyFoodCheckWpf.Model;
using PregnancyFoodCheckWpf.ViewModel.Commands;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace PregnancyFoodCheckWpf.ViewModel
{
    public class SearchFoodViewModel : BaseViewModel
    {
        public ObservableCollection<NotAllowedPregnanyFood> NotAllowedPregnancyFood { get; set; }

        private string _foodToSearch;

        public string FoodToSearch
        {
            get { return _foodToSearch; }
            set { _foodToSearch = value; }
        }

        private Visibility _progressBarVisible = Visibility.Collapsed;

        public Visibility ProgressBarVisible
        {
            get => _progressBarVisible;
            set
            {
                _progressBarVisible = value;
                OnPropertyChagend();
            }
        }

        public SearchFoodViewModel()
        {
            NotAllowedPregnancyFood = new ObservableCollection<NotAllowedPregnanyFood>();
            SearchFoodCommand = new SearchFoodCommand(this);
        }

        public SearchFoodCommand SearchFoodCommand { get; init; }

        internal async Task FindNotAllowedFoodAsync()
        {
            try
            {
                ProgressBarVisible = Visibility.Visible;
                NotAllowedPregnancyFood.Clear();
                var foundFoods = await FireStoreHelper.FindFoodAsync(FoodToSearch);
                foreach (var food in foundFoods)
                {
                    NotAllowedPregnancyFood.Add(food);
                }

            }
            finally
            {
                ProgressBarVisible = Visibility.Collapsed;
            }
        }
    }
}
