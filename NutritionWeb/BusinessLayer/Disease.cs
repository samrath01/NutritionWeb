using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NutritionWeb.BusinessLayer
{
    public class Disease
    {
        public int Id { get; set; }

        public string DiseaseName { get; set; }

        public string Description { get; set; }

        public int VitaminId { get; set; }

        public Vitamin Vitamin { get; set; }
    }
}
