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
    public class DeleteModel : PageModel
    {
        private readonly NutritionWeb.Data.DataContext _context;

        public DeleteModel(NutritionWeb.Data.DataContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Disease Disease { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Disease = await _context.Diseases
                .Include(d => d.Vitamin).FirstOrDefaultAsync(m => m.Id == id);

            if (Disease == null)
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

            Disease = await _context.Diseases.FindAsync(id);

            if (Disease != null)
            {
                _context.Diseases.Remove(Disease);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
