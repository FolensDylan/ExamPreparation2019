using System;
using System.Collections.Generic;

namespace ExamPreparation.Entities
{
    public partial class Meals
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Img { get; set; }
        public int? Book { get; set; }
        public int? Calories { get; set; }
        public int? Servings { get; set; }
        public string Type { get; set; }
        public int? Price { get; set; }
        public string Cook { get; set; }
        public int? Quantity { get; set; }
    }
}
