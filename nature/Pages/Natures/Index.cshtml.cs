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
    public class IndexModel : PageModel
    {
        private readonly natureContext _context;

        public IndexModel(natureContext context)
        {
            _context = context;
        }

        public IList<natureProgramme> natureProgramme { get;set; }

        public async Task OnGetAsync()
        {
            natureProgramme = await _context.natureProgramme.ToListAsync();
        }
    }
}
