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
    public class IndexModel : PageModel
    {
        private readonly Hancu_Sebastian_Lab2.Data.Hancu_Sebastian_Lab2Context _context;

        public IndexModel(Hancu_Sebastian_Lab2.Data.Hancu_Sebastian_Lab2Context context)
        {
            _context = context;
        }

        public IList<Publisher> Publisher { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Publisher != null)
            {
                Publisher = await _context.Publisher.ToListAsync();
            }
        }
    }
}
