using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using NutritionWeb.BusinessLayer;
using NutritionWeb.Data;

namespace NutritionWeb.Pages.Diseases
{
    public class IndexModel : PageModel
    {
        private readonly NutritionWeb.Data.DataContext _context;

        public IndexModel(NutritionWeb.Data.DataContext context)
        {
            _context = context;
        }

        public IList<Disease> Disease { get;set; }

        public async Task OnGetAsync()
        {
            Disease = await _context.Diseases
                .Include(d => d.Vitamin).ToListAsync();
        }
    }
}
