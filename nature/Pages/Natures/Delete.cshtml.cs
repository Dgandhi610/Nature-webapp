using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using nature;

namespace nature.Pages_Natures
{
    public class DeleteModel : PageModel
    {
        private readonly natureContext _context;

        public DeleteModel(natureContext context)
        {
            _context = context;
        }

        [BindProperty]
        public natureProgramme natureProgramme { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            natureProgramme = await _context.natureProgramme.FirstOrDefaultAsync(m => m.ID == id);

            if (natureProgramme == null)
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

            natureProgramme = await _context.natureProgramme.FindAsync(id);

            if (natureProgramme != null)
            {
                _context.natureProgramme.Remove(natureProgramme);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
