using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Entrees;
using NuGet.Frameworks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xunit;

namespace BleakwindBuffet.DataTests.UnitTests
{
    public class MenuTests
    {

        [Theory]
        [InlineData(100, 900)]
        [InlineData(0, 500)]
        [InlineData(500, 800)]
        public void FilterByCaloriesShouldReturnCorrectList(double min, double max)
        {
            List<IOrderItem> items = (List<IOrderItem>)Menu.FullMenu;
            List<IOrderItem> itemsAfter = (List<IOrderItem>)Menu.FilterByCalories(items, min, max);

            foreach (IOrderItem menuItem in Menu.FullMenu)
            {
                if (menuItem.Calories >= min && menuItem.Calories <= max)
                {
                    Assert.Contains(itemsAfter, item => item.ToString() == menuItem.ToString());
                }
            }
        }

        [Theory]
        [InlineData(8.0, 10)]
        [InlineData(0, 5)]
        [InlineData(5, 10)]
        public void FilterByPriceShouldReturnCorrectList(double min, double max)
        {
            List<IOrderItem> items = (List<IOrderItem>)Menu.FullMenu;
            List<IOrderItem> itemsAfter = (List<IOrderItem>)Menu.FilterByPrice(items, min, max );

            foreach(IOrderItem menuItem in Menu.FullMenu)
            {
                if(menuItem.Price >= min && menuItem.Price <= max)
                {
                    Assert.Contains(itemsAfter, item => item.ToString() == menuItem.ToString());
                }
            }
        }

        [Theory]
        [InlineData("Entree")]
        [InlineData("Drink")]
        [InlineData("Side")]
        public void FilterByCatagoryShouldReturnCorrectList(string cat)
        {
            List<string> list = new List<string>();
            list.Add(cat);

            List<IOrderItem> items = (List<IOrderItem>)Menu.FullMenu;
            List<IOrderItem> itemsAfter = (List<IOrderItem>)Menu.FilterByCatagory(items, list);
            

            switch (cat)
            {
                case "Entree":
                    List<IOrderItem> entrees = (List<IOrderItem>)Menu.Entrees;
                    if (Menu.Entrees.Count() != itemsAfter.Count()) Assert.Equal("false", "true");
                    for(int i=0; i<entrees.Count(); i++)
                    {
                        if (entrees[i].ToString() == itemsAfter[i].ToString())
                            Assert.Equal("true", "true");
                    }
                    break;
                case "Side":
                    List<IOrderItem> sides = (List<IOrderItem>)Menu.Sides;
                    if (Menu.Sides.Count() != itemsAfter.Count()) Assert.Equal("false", "true");
                    for (int i = 0; i < sides.Count(); i++)
                    {
                        if (sides[i].ToString() == itemsAfter[i].ToString())
                            Assert.Equal("true", "true");
                    }
                    break;
                case "Drink":
                    List<IOrderItem> drinks = (List<IOrderItem>)Menu.Drinks;
                    if (Menu.Drinks.Count() != itemsAfter.Count()) Assert.Equal("false", "true");
                    for (int i = 0; i < drinks.Count(); i++)
                    {
                        if (drinks[i].ToString() == itemsAfter[i].ToString())
                            Assert.Equal("true", "true");
                    }
                    break;
            }
        }

        [Fact]
        public void SearchShouldReturnCorrectEntree()
        {
            Assert.Collection(Menu.Search("garden Orc Omelette"),
                item => Assert.Equal("Garden Orc Omelette", item.ToString())
                );

            Assert.Collection(Menu.Search("Thalmor triple"),
                item => Assert.Equal("Thalmor Triple", item.ToString())
                );

            Assert.Empty(Menu.Search("ThamorT iple"));
        }

        [Fact]
        public void SearchShouldReturnCorrectSide()
        {
            Assert.Collection(Menu.Search("candlehearth coffee"),
                item => Assert.Equal("Small Candlehearth Coffee", item.ToString()),
                item => Assert.Equal("Medium Candlehearth Coffee", item.ToString()),
                item => Assert.Equal("Large Candlehearth Coffee", item.ToString())
                );

            Assert.Collection(Menu.Search("wArrior WateR"),
                item => Assert.Equal("Small Warrior Water", item.ToString()),
                item => Assert.Equal("Medium Warrior Water", item.ToString()),
                item => Assert.Equal("Large Warrior Water", item.ToString())
                );

            Assert.Empty(Menu.Search("s[ogason"));
        }

        [Fact]
        public void SearchShouldReturnCorrectDrink()
        {
            Assert.Collection(Menu.Search("Dragonborn waffle fries"),
                item => Assert.Equal("Small Dragonborn Waffle Fries", item.ToString()),
                item => Assert.Equal("Medium Dragonborn Waffle Fries", item.ToString()),
                item => Assert.Equal("Large Dragonborn Waffle Fries", item.ToString())
                );

            Assert.Collection(Menu.Search("vokun Salad"),
                item => Assert.Equal("Small Vokun Salad", item.ToString()),
                item => Assert.Equal("Medium Vokun Salad", item.ToString()),
                item => Assert.Equal("Large Vokun Salad", item.ToString())
                );

            Assert.Empty(Menu.Search("Vokan Sallad"));
        }

        [Fact]
        public void EntreesShouldHaveAllItems()
        {
            IEnumerable<IOrderItem> list = Menu.Entrees;
            Assert.Collection(list, 
                item => Assert.Equal("Briarheart Burger", item.ToString()),
                item => Assert.Equal("Double Draugr", item.ToString()),
                item => Assert.Equal("Garden Orc Omelette", item.ToString()),
                item => Assert.Equal("Philly Poacher", item.ToString()),
                item => Assert.Equal("Smokehouse Skeleton", item.ToString()),
                item => Assert.Equal("Thalmor Triple", item.ToString()),
                item => Assert.Equal("Thugs T-Bone", item.ToString())
                );       
        }

        [Fact]
        public void DrinksShouldHaveAllItems()
        {
            IEnumerable<IOrderItem> list = Menu.Drinks;
            Assert.Collection(list,
                item => Assert.Equal("Small Aretino Apple Juice", item.ToString()),
                item => Assert.Equal("Medium Aretino Apple Juice", item.ToString()),
                item => Assert.Equal("Large Aretino Apple Juice", item.ToString()),
                item => Assert.Equal("Small Candlehearth Coffee", item.ToString()),
                item => Assert.Equal("Medium Candlehearth Coffee", item.ToString()),
                item => Assert.Equal("Large Candlehearth Coffee", item.ToString()),
                item => Assert.Equal("Small Markarth Milk", item.ToString()),
                item => Assert.Equal("Medium Markarth Milk", item.ToString()),
                item => Assert.Equal("Large Markarth Milk", item.ToString()),
                item => Assert.Equal("Small Blackberry Sailor Soda", item.ToString()),
                item => Assert.Equal("Medium Blackberry Sailor Soda", item.ToString()),
                item => Assert.Equal("Large Blackberry Sailor Soda", item.ToString()),
                item => Assert.Equal("Small Cherry Sailor Soda", item.ToString()),
                item => Assert.Equal("Medium Cherry Sailor Soda", item.ToString()),
                item => Assert.Equal("Large Cherry Sailor Soda", item.ToString()),
                item => Assert.Equal("Small Grapefruit Sailor Soda", item.ToString()),
                item => Assert.Equal("Medium Grapefruit Sailor Soda", item.ToString()),
                item => Assert.Equal("Large Grapefruit Sailor Soda", item.ToString()),
                item => Assert.Equal("Small Lemon Sailor Soda", item.ToString()),
                item => Assert.Equal("Medium Lemon Sailor Soda", item.ToString()),
                item => Assert.Equal("Large Lemon Sailor Soda", item.ToString()),
                item => Assert.Equal("Small Peach Sailor Soda", item.ToString()),
                item => Assert.Equal("Medium Peach Sailor Soda", item.ToString()),
                item => Assert.Equal("Large Peach Sailor Soda", item.ToString()),
                item => Assert.Equal("Small Watermelon Sailor Soda", item.ToString()),
                item => Assert.Equal("Medium Watermelon Sailor Soda", item.ToString()),
                item => Assert.Equal("Large Watermelon Sailor Soda", item.ToString()),
                item => Assert.Equal("Small Warrior Water", item.ToString()),
                item => Assert.Equal("Medium Warrior Water", item.ToString()),
                item => Assert.Equal("Large Warrior Water", item.ToString())
                );
        }

        [Fact]
        public void SidesShouldHaveAllItems()
        {
            IEnumerable<IOrderItem> list = Menu.Sides;
            Assert.Collection(list,
                item => Assert.Equal("Small Dragonborn Waffle Fries", item.ToString()),
                item => Assert.Equal("Medium Dragonborn Waffle Fries", item.ToString()),
                item => Assert.Equal("Large Dragonborn Waffle Fries", item.ToString()),
                item => Assert.Equal("Small Fried Miraak", item.ToString()),
                item => Assert.Equal("Medium Fried Miraak", item.ToString()),
                item => Assert.Equal("Large Fried Miraak", item.ToString()),
                item => Assert.Equal("Small Mad Otar Grits", item.ToString()),
                item => Assert.Equal("Medium Mad Otar Grits", item.ToString()),
                item => Assert.Equal("Large Mad Otar Grits", item.ToString()),
                item => Assert.Equal("Small Vokun Salad", item.ToString()),
                item => Assert.Equal("Medium Vokun Salad", item.ToString()),
                item => Assert.Equal("Large Vokun Salad", item.ToString())
                );
        }

        [Fact]
        public void FullMenuShouldHaveAllItems()
        {
            IEnumerable<IOrderItem> list = Menu.FullMenu;
            Assert.Collection(list,
                item => Assert.Equal("Briarheart Burger", item.ToString()),
                item => Assert.Equal("Double Draugr", item.ToString()),
                item => Assert.Equal("Garden Orc Omelette", item.ToString()),
                item => Assert.Equal("Philly Poacher", item.ToString()),
                item => Assert.Equal("Smokehouse Skeleton", item.ToString()),
                item => Assert.Equal("Thalmor Triple", item.ToString()),
                item => Assert.Equal("Thugs T-Bone", item.ToString()),
                item => Assert.Equal("Small Dragonborn Waffle Fries", item.ToString()),
                item => Assert.Equal("Medium Dragonborn Waffle Fries", item.ToString()),
                item => Assert.Equal("Large Dragonborn Waffle Fries", item.ToString()),
                item => Assert.Equal("Small Fried Miraak", item.ToString()),
                item => Assert.Equal("Medium Fried Miraak", item.ToString()),
                item => Assert.Equal("Large Fried Miraak", item.ToString()),
                item => Assert.Equal("Small Mad Otar Grits", item.ToString()),
                item => Assert.Equal("Medium Mad Otar Grits", item.ToString()),
                item => Assert.Equal("Large Mad Otar Grits", item.ToString()),
                item => Assert.Equal("Small Vokun Salad", item.ToString()),
                item => Assert.Equal("Medium Vokun Salad", item.ToString()),
                item => Assert.Equal("Large Vokun Salad", item.ToString()),
                item => Assert.Equal("Small Aretino Apple Juice", item.ToString()),
                item => Assert.Equal("Medium Aretino Apple Juice", item.ToString()),
                item => Assert.Equal("Large Aretino Apple Juice", item.ToString()),
                item => Assert.Equal("Small Candlehearth Coffee", item.ToString()),
                item => Assert.Equal("Medium Candlehearth Coffee", item.ToString()),
                item => Assert.Equal("Large Candlehearth Coffee", item.ToString()),
                item => Assert.Equal("Small Markarth Milk", item.ToString()),
                item => Assert.Equal("Medium Markarth Milk", item.ToString()),
                item => Assert.Equal("Large Markarth Milk", item.ToString()),
                item => Assert.Equal("Small Blackberry Sailor Soda", item.ToString()),
                item => Assert.Equal("Medium Blackberry Sailor Soda", item.ToString()),
                item => Assert.Equal("Large Blackberry Sailor Soda", item.ToString()),
                item => Assert.Equal("Small Cherry Sailor Soda", item.ToString()),
                item => Assert.Equal("Medium Cherry Sailor Soda", item.ToString()),
                item => Assert.Equal("Large Cherry Sailor Soda", item.ToString()),
                item => Assert.Equal("Small Grapefruit Sailor Soda", item.ToString()),
                item => Assert.Equal("Medium Grapefruit Sailor Soda", item.ToString()),
                item => Assert.Equal("Large Grapefruit Sailor Soda", item.ToString()),
                item => Assert.Equal("Small Lemon Sailor Soda", item.ToString()),
                item => Assert.Equal("Medium Lemon Sailor Soda", item.ToString()),
                item => Assert.Equal("Large Lemon Sailor Soda", item.ToString()),
                item => Assert.Equal("Small Peach Sailor Soda", item.ToString()),
                item => Assert.Equal("Medium Peach Sailor Soda", item.ToString()),
                item => Assert.Equal("Large Peach Sailor Soda", item.ToString()),
                item => Assert.Equal("Small Watermelon Sailor Soda", item.ToString()),
                item => Assert.Equal("Medium Watermelon Sailor Soda", item.ToString()),
                item => Assert.Equal("Large Watermelon Sailor Soda", item.ToString()),
                item => Assert.Equal("Small Warrior Water", item.ToString()),
                item => Assert.Equal("Medium Warrior Water", item.ToString()),
                item => Assert.Equal("Large Warrior Water", item.ToString())
                );
        }
    }
}
