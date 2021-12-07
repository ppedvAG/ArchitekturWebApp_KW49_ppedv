using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorPageMovieSample.Data;
using RazorPageMovieSample.Models;

namespace RazorPageMovieSample.Pages.MyMovie
{
    public class IndexModel : PageModel
    {
        private readonly RazorPageMovieSample.Data.RazorPageMovieSampleContext _context;

        public IndexModel(RazorPageMovieSample.Data.RazorPageMovieSampleContext context)
        {
            _context = context;
        }

        //RazorPages verwenden ViewModels
        public IList<Movie> Movie { get;set; }

        //....Ist Erweiterbar

        public async Task OnGetAsync()
        {
            Movie = await _context.Movie.ToListAsync();
        }
    }
}
