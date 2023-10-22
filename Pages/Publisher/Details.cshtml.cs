using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Hancu_Sebastian_Lab2.Data;
using Hancu_Sebastian_Lab2.Models;

namespace Hancu_Sebastian_Lab2.Pages.Publisher
{
    public class DetailsModel : PageModel
    {
        private readonly Hancu_Sebastian_Lab2.Data.Hancu_Sebastian_Lab2Context _context;

        public DetailsModel(Hancu_Sebastian_Lab2.Data.Hancu_Sebastian_Lab2Context context)
        {
            _context = context;
        }

      public Publisher Publisher { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Publisher == null)
            {
                return NotFound();
            }

            var publisher = await _context.Publisher.FirstOrDefaultAsync(m => m.ID == id);
            if (publisher == null)
            {
                return NotFound();
            }
            else 
            {
                Publisher = publisher;
            }
            return Page();
        }
    }
}
