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

namespace NutritionWeb.Pages.Vitamins
{
    public class EditModel : PageModel
    {
        private readonly NutritionWeb.Data.DataContext _context;

        public EditModel(NutritionWeb.Data.DataContext context)
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

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Vitamin).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!VitaminExists(Vitamin.Id))
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

        private bool VitaminExists(int id)
        {
            return _context.Vitamins.Any(e => e.Id == id);
        }
    }
}
