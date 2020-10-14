using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Entrees;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace BleakwindBuffet.DataTests.UnitTests
{
    public class OrderTests
    {
        [Fact]
        public void AddingItemShouldTriggerPricePropertyChange()
        {
            Order order = new Order();
            PhillyPoacher pp = new PhillyPoacher();

            Assert.PropertyChanged(order, "Price", () =>
            {
                order.Add(pp);
            });

        }
    }
}
