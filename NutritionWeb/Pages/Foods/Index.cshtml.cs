using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using NutritionWeb.BusinessLayer;
using NutritionWeb.Data;

namespace NutritionWeb.Pages.Foods
{
    public class IndexModel : PageModel
    {
        private readonly NutritionWeb.Data.DataContext _context;

        public IndexModel(NutritionWeb.Data.DataContext context)
        {
            _context = context;
        }

        public IList<Food> Food { get;set; }

        public async Task OnGetAsync()
        {
            Food = await _context.Foods
                .Include(f => f.Vitamin).ToListAsync();
        }
    }
}
