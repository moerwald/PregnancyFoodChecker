using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PregnancyFoodCheckWpf.Model
{
    public class NotAllowedPregnanyFood 
    {

        private string _foodName;
        public string FoodName
        {
            get { return _foodName; }
            set { 
                _foodName = value;
            }
        }


        private int _preWeekStart;
        public int PregWeekStart
        {
            get { return _preWeekStart; }
            set { 
                _preWeekStart = value;
            }
        }

        private int _preWeekEnd;
        public int PregWeekEnd
        {
            get { return _preWeekEnd; }
            set { 
                _preWeekEnd = value;
            }
        }

        private string _amount;
        public string Amount
        {
            get { return _amount; }
            set { 
                _amount = value;
            }
        }

        private string _urlToFurtherInformation;
        public string UrlToFurtherInformation
        {
            get { return _urlToFurtherInformation; }
            set { 
                _urlToFurtherInformation = value;
            }
        }






    }
}
