using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using BooktrackingApplication.Data;
using booktrackingapp.Models;

namespace BooktrackingApplication.Pages.Books
{
    public class DetailsModel : PageModel
    {
        private readonly BooktrackingApplication.Data.BooktrackingApplicationContext _context;

        public DetailsModel(BooktrackingApplication.Data.BooktrackingApplicationContext context)
        {
            _context = context;
        }

        public Book Book { get; set; }

        public async Task<IActionResult> OnGetAsync(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Book = await _context.Book.FirstOrDefaultAsync(m => m.ISBN == id);

            if (Book == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
