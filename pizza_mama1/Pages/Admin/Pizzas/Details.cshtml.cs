using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using pizza_mama1.Data;
using pizza_mama1.Models;

namespace pizza_mama1.Pages.Admin.Pizzas
{
    public class DetailsModel : PageModel
    {
        private readonly pizza_mama1.Data.DataContext _context;

        public DetailsModel(pizza_mama1.Data.DataContext context)
        {
            _context = context;
        }

        public Pizza Pizza { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Pizza = await _context.Pizzas.FirstOrDefaultAsync(m => m.PizzaID == id);

            if (Pizza == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
