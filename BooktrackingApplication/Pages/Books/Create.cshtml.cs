using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using BooktrackingApplication.Data;
using booktrackingapp.Models;

namespace BooktrackingApplication.Pages.Books
{
    public class CreateModel : PageModel
    {
        private readonly BooktrackingApplication.Data.BooktrackingApplicationContext _context;

        public CreateModel(BooktrackingApplication.Data.BooktrackingApplicationContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            ViewData["CategoryId"] = new SelectList(_context.Category, "CategoryId", "CategoryId");
            
            return Page();
        }

        [BindProperty]
        public Book Book { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Book.Add(Book);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
