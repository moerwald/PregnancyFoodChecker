using PregnancyFoodCheckWpf.Helper;
using PregnancyFoodCheckWpf.Model;
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
        public AddNewNotAllowedFoodViewModel() => AddNewFood = new AddNewNotAllowedFoodCommand(this);

        private string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        private string _url;

        public string UrlToFurtherInformation
        {
            get { return _url; }
            set { _url = value; }
        }

        private string _amount;

        public string Amount
        {
            get { return _amount; }
            set { _amount = value; }
        }

        private int _pregWeekStart;

        public int PregWeekStart
        {
            get { return _pregWeekStart; }
            set { _pregWeekStart = value; }
        }

        private int _pregWeekEnd;

        public int PregWeekEnd
        {
            get { return _pregWeekEnd; }
            set { _pregWeekEnd = value; }
        }

        public AddNewNotAllowedFoodCommand AddNewFood { get; init; }

        public Task AddNewNotAllowedAsync() => FireStoreHelper.AddNotAllowedFoodAsync(new NotAllowedPregnanyFood()
        {
            FoodName = Name,
            Amount = Amount,
            PregWeekStart = PregWeekStart,
            PregWeekEnd = PregWeekEnd,
            UrlToFurtherInformation = UrlToFurtherInformation
        });
    }
}
