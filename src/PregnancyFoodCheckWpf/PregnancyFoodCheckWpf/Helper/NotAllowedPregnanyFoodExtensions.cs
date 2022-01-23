using PregnancyFoodCheckWpf.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PregnancyFoodCheckWpf.Helper
{
    internal static class NotAllowedPregnanyFoodExtensions
    {
        public static Dictionary<string, object> ToDictionary(this NotAllowedPregnanyFood food) => new Dictionary<string, object>
            {
                { nameof(NotAllowedPregnanyFood.Amount), food.Amount },
                { nameof(NotAllowedPregnanyFood.FoodName), food.FoodName },
                { nameof(NotAllowedPregnanyFood.PregWeekStart), food.PregWeekStart },
                { nameof(NotAllowedPregnanyFood.PregWeekEnd), food.PregWeekEnd},
                { nameof(NotAllowedPregnanyFood.UrlToFurtherInformation), food.UrlToFurtherInformation }
            };
    }
}
