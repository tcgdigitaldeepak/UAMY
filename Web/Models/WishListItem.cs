using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Models
{
    [Table("Wishlist")]
    public class WishlistItem
    {
        public string id { get; set; }
        public string country { get; set; }
        public string name { get; set; }
        public string type { get; set; }
        // public string type => typeof(WishlistItem).Name;
    }
}
