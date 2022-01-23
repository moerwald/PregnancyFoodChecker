using PregnancyFoodCheckWpf.Helper;
using PregnancyFoodCheckWpf.ViewModel.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PregnancyFoodCheckWpf.ViewModel
{
    public class AddNewNotAllowedFoodViewModel : BaseViewModel
    {
        public AddNewNotAllowedFoodViewModel()
        {
            AddNewFood = new AddNewNotAllowedFoodCommand(this);
        }

        private string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public AddNewNotAllowedFoodCommand AddNewFood { get; init; }

        public Task AddNewNotAllowedAsync() => FireStoreHelper.AddNotAllowedFoodAsync(Name);
    }
}
