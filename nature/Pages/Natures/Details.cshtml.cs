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
    public class DetailsModel : PageModel
    {
        private readonly natureContext _context;

        public DetailsModel(natureContext context)
        {
            _context = context;
        }

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
    }
}
