using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using RazorPageMovieSample.Data;
using RazorPageMovieSample.Models;

namespace RazorPageMovieSample.Pages.MyMovie
{
    public class CreateModel : PageModel
    {
        private readonly RazorPageMovieSample.Data.RazorPageMovieSampleContext _context;

        public CreateModel(RazorPageMovieSample.Data.RazorPageMovieSampleContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page(); //Leeres Formular
        }

        [BindProperty]
        public Movie Movie { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Movie.Add(Movie);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
