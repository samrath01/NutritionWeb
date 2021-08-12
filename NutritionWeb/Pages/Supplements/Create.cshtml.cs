using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using NutritionWeb.BusinessLayer;
using NutritionWeb.Data;

namespace NutritionWeb.Pages.Supplements
{
    public class CreateModel : PageModel
    {
        private readonly NutritionWeb.Data.DataContext _context;

        public CreateModel(NutritionWeb.Data.DataContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["VitaminId"] = new SelectList(_context.Vitamins, "Id", "VitaminName");
            return Page();
        }

        [BindProperty]
        public Supplement Supplement { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Supplements.Add(Supplement);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
