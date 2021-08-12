using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NutritionWeb.BusinessLayer
{
    public class Supplement
    {
        public int Id { get; set; }

        public string SupplementName { get; set; }

        public string CompanyName { get; set; }

        public float Price { get; set; }

        public int VitaminId { get; set; }

        public Vitamin Vitamin { get; set; }
    }
}
