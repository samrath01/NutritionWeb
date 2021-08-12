using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using NutritionWeb.BusinessLayer;
using NutritionWeb.Data;

namespace NutritionWeb.Pages.Supplements
{
    public class DeleteModel : PageModel
    {
        private readonly NutritionWeb.Data.DataContext _context;

        public DeleteModel(NutritionWeb.Data.DataContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Supplement Supplement { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Supplement = await _context.Supplements
                .Include(s => s.Vitamin).FirstOrDefaultAsync(m => m.Id == id);

            if (Supplement == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Supplement = await _context.Supplements.FindAsync(id);

            if (Supplement != null)
            {
                _context.Supplements.Remove(Supplement);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
