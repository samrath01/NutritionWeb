using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NutritionWeb.BusinessLayer
{
    public class Food
    {
        public int Id { get; set; }

        public string FoodName { get; set; }

        public string Details { get; set; }

        public int VitaminId { get; set; }

        public Vitamin Vitamin { get; set; }
    }
}
