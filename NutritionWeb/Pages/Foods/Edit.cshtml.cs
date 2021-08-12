using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using NutritionWeb.BusinessLayer;
using NutritionWeb.Data;

namespace NutritionWeb.Pages.Foods
{
    public class EditModel : PageModel
    {
        private readonly NutritionWeb.Data.DataContext _context;

        public EditModel(NutritionWeb.Data.DataContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Food Food { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Food = await _context.Foods
                .Include(f => f.Vitamin).FirstOrDefaultAsync(m => m.Id == id);

            if (Food == null)
            {
                return NotFound();
            }
           ViewData["VitaminId"] = new SelectList(_context.Vitamins, "Id", "VitaminName");
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Food).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!FoodExists(Food.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool FoodExists(int id)
        {
            return _context.Foods.Any(e => e.Id == id);
        }
    }
}
