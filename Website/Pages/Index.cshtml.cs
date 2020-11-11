using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using BleakwindBuffet.Data;

namespace Website.Pages
{
    public class IndexModel : PageModel
    {
        /// <summary>
        /// Menu items
        /// </summary>
        public IEnumerable<IOrderItem> menuItems { get; set; }

        private readonly ILogger<IndexModel> _logger;

        /// <summary>
        /// Used for displaying order catagories
        /// </summary>
        public string[] OrderCatagories
        {
            get => new string[]
            {
                "Entree",
                "Side",
                "Drink"
            };
        }

        /// <summary>
        /// Holds search terms
        /// </summary>
        public string SearchTerms { get; set; }

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        /// <summary>
        /// On get for form and start up
        /// </summary>
        /// <param name="PriceMin"></param>
        /// <param name="PriceMax"></param>
        /// <param name="CalMin"></param>
        /// <param name="CalMax"></param>
        public void OnGet(double PriceMin, double PriceMax, double CalMin, double CalMax)
        {
            menuItems = Menu.Search(Request.Query["SearchTerms"]);
            menuItems = Menu.FilterByCatagory(menuItems, Request.Query["OrderItems"]);
            menuItems = Menu.FilterByPrice(menuItems, PriceMin, PriceMax);
            menuItems = Menu.FilterByCalories(menuItems, CalMin, CalMax);
        }
    }
}
