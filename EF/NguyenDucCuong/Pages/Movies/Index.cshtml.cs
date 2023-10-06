using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Cuong110.Data;
using Cuong110.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Cuong110.Pages.Movies
{
    public class IndexModel : PageModel
    {
        private readonly Cuong110.Data.Cuong110Context _context;

        public IndexModel(Cuong110.Data.Cuong110Context context)
        {
            _context = context;
        }

        public IList<Movie> Movie { get;set; } = default!;


        [BindProperty(SupportsGet = true)]
        public string? SearchString { get; set; }

        public SelectList? Genres { get; set; }

        [BindProperty(SupportsGet = true)]
        public string? MovieGenre { get; set; }

        public async Task OnGetAsync()
        {
            //if (_context.Movie != null)
            //{
            //    Movie = await _context.Movie.ToListAsync();
            //}

            //var movies = from m in _context.Movie
            //             select m;
            //if (!string.IsNullOrEmpty(SearchString))
            //{
            //    movies = movies.Where(s => s.Title.Contains(SearchString));
            //}

            //Movie = await movies.ToListAsync();

            // Use LINQ to get list of genres.
            IQueryable<string> genreQuery = from m in _context.Movie
                                            orderby m.Genre
                                            select m.Genre;

            var movies = from m in _context.Movie
                         select m;

            if (!string.IsNullOrEmpty(SearchString))
            {
                movies = movies.Where(s => s.Title.Contains(SearchString));
            }

            if (!string.IsNullOrEmpty(MovieGenre))
            {
                movies = movies.Where(x => x.Genre == MovieGenre);
            }
            Genres = new SelectList(await genreQuery.Distinct().ToListAsync());
            Movie = await movies.ToListAsync();
        }
    }
}
