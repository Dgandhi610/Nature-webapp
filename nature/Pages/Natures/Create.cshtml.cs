using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using nature;

namespace nature.Pages_Natures
{
    public class CreateModel : PageModel
    {
        private readonly natureContext _context;

        public CreateModel(natureContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public natureProgramme natureProgramme { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.natureProgramme.Add(natureProgramme);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
