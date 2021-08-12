using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using NutritionWeb.BusinessLayer;
using NutritionWeb.Data;

namespace NutritionWeb.Pages.Vitamins
{
    public class DeleteModel : PageModel
    {
        private readonly NutritionWeb.Data.DataContext _context;

        public DeleteModel(NutritionWeb.Data.DataContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Vitamin Vitamin { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Vitamin = await _context.Vitamins.FirstOrDefaultAsync(m => m.Id == id);

            if (Vitamin == null)
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

            Vitamin = await _context.Vitamins.FindAsync(id);

            if (Vitamin != null)
            {
                _context.Vitamins.Remove(Vitamin);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
