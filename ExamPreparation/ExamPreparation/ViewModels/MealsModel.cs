using ExamPreparation.Entities;
using ExamPreparation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExamPreparation.ViewModels
{
    public class MealsModel
    {
        private static int i = 0;
        public List<Meal> MealsList { get; set; }

        public Meal MealOfTheDay { get; set; }
        public MealsModel(List<Meals> meals)
        {
            MealsList = new List<Meal>();
            foreach (Meals meal in meals)
            {
                Meal n = new Meal()
                {
                    Id = meal.Id,
                    Title = meal.Title,
                    Img = meal.Img,
                    Cook = meal.Cook,
                    Calories = meal.Calories,
                    Price = meal.Price
                };
                MealsList.Add(n);
            }
            if (i >= meals.Count)
            {
                i = 0;
            }
            MealOfTheDay = MealsList.ElementAt(i);
            i += 1; 
        }

    }
}