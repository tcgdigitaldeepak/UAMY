using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Web.Models;
using Microsoft.EntityFrameworkCore;

namespace Web.Pages.Synk
{
    public class IndexModel : PageModel
    {
        private readonly Web.Models.Context _context;

        public IndexModel(Web.Models.Context context)
        {
            _context = context;
        }

        public IList<WishlistItem> Movie { get; set; }
        


        //public async Task OnGetAsync()
        //{
        //    Movie = await _context.Movie.ToListAsync();
        //}

        public async Task OnGetAsync()
        {
            // Use LINQ to get list of genres.
            
            var movies = from m in _context.WishlistItem
                         select m;

            Movie = await movies.ToListAsync();
        }
    }
}