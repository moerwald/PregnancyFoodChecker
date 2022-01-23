using Firebase.Auth;
using Google.Cloud.Firestore;
using Google.Cloud.Firestore.V1;
using Grpc.Core;
using PregnancyFoodCheckWpf.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PregnancyFoodCheckWpf.Helper
{
    internal static class FireStoreHelper
    {
        private const string FireStoreName = "eighth-feat-339019";
        private const string PregnancyFoodCollection = "pregnancyFood";

        public static void Init()
        {
            var pathToCreds = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"eighth-feat-339019-firebase.json");
            Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS", pathToCreds);
        }

        public static async Task AddNotAllowedFoodAsync(string foodName)
        {
            var db = FirestoreDb.Create(FireStoreName);
            var collection = db.Collection(PregnancyFoodCollection);
            await collection.Document(foodName).SetAsync(new Dictionary<string, object>
            {
                { nameof(NotAllowedPregnanyFood.FoodName), foodName }
            });
        }

        public static async Task AddNotAllowedFoodAsync(NotAllowedPregnanyFood food)
        {
            var db = FirestoreDb.Create(FireStoreName);
            var collection = db.Collection(PregnancyFoodCollection);
            await collection.Document(food.FoodName).SetAsync(food.ToDictionary());
        }

        public static async Task<IEnumerable<NotAllowedPregnanyFood>> FindFoodAsync(string foodName)
        {
            var resultList = new List<NotAllowedPregnanyFood>();
            var db = FirestoreDb.Create(FireStoreName);
            var collection = db.Collection(PregnancyFoodCollection);
            var query = collection.WhereEqualTo(nameof(NotAllowedPregnanyFood.FoodName), foodName);
            var snapshot = await query.GetSnapshotAsync();
            foreach (var doc in snapshot.Documents)
            {
                var notAllowedFood = new NotAllowedPregnanyFood();
                var docDictionary = doc.ToDictionary();

                notAllowedFood.FoodName = docDictionary[nameof(NotAllowedPregnanyFood.FoodName)] as string;
                resultList.Add(notAllowedFood);
            }

            return resultList;
        }
    }
}
