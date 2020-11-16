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
        public string[] SearchTerms { get; set; }

        /// <summary>
        /// Used for displaying order catagories
        /// </summary>
        public string[] OrderCat { get; set; }

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
            menuItems = Menu.FullMenu;
            string strToSplit = Request.Query["SearchTerms"];

            //search menu for items matching search
            if (strToSplit != null)
            {
                SearchTerms = strToSplit.Split(' ');

                IEnumerable<IOrderItem> mI1 = menuItems;
                IEnumerable<IOrderItem> mI2 = Enumerable.Empty<IOrderItem>();

                foreach (string searchTerm in SearchTerms)
                {
                    mI1 = menuItems.Where(item => item.ToString() != null && item.ToString().Contains(searchTerm, 
                        StringComparison.InvariantCultureIgnoreCase) || item.Description.Contains(searchTerm, 
                        StringComparison.InvariantCultureIgnoreCase));

                    mI2 = mI2.Concat(mI1);
                }

                menuItems = mI2;

            }

            menuItems = Menu.FilterByCatagory(menuItems, OrderCat);

            //filters by price
            if (PriceMin >= 0 && PriceMax > 0)
            {
                menuItems = menuItems.Where(item => item.Price >= PriceMin && item.Price <= PriceMax);
            }

            //filters by calories
            if(CalMin >= 0 && CalMax > 0)
            {
                menuItems = menuItems.Where(item => item.Calories >= PriceMin && item.Calories <= CalMax);
            }


        }
    }
}
