using ExamPreparation.Entities;
using ExamPreparation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HowestHealthFood_FolensDylan.ViewModels
{
    public class MealsModel
    {
        Random rnd = new Random();
        public List<Meals> MealsList { get; set; }
        public List<Meal> Meals { get; set; }
        public int AmountOfDishes { get; set; }

        public Meal MealOfTheDay { get; set; }
        public MealsModel(List<Meals> meals)
        {
            this.MealsList = meals;
            Meals = new List<Meal>();
            foreach (Meals meal in MealsList)
            {
                Meal n = new Meal
                {
                    Id = meal.Id,
                    Title = meal.Title,
                    Img = meal.Img,
                    Cook = meal.Cook,
                    Calories = meal.Calories,
                    Price = meal.Price
                };
                if (n.Id == rnd.Next(1, MealsList.Count + 1))
                {
                    MealOfTheDay = n;
                }
                Meals.Add(n);
                AmountOfDishes += 1;
            }
        }

        public MealsModel(List<Meal> meals)
        {
            Meals = meals;
        }

    }
}