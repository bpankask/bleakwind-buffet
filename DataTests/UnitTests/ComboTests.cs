using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Sides;
using Newtonsoft.Json.Bson;
using Xunit;

namespace BleakwindBuffet.DataTests.UnitTests
{
    public class ComboTests
    {
        [Fact]
        public void AddingEntreeShouldChangePrice()
        {

        }

        [Fact]
        public void ShouldBeAnINotifyPropertyChanged()
        {
            Combo c = new Combo();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(c);
        }

        [Fact]
        public void ShouldBeAnIOrderItem()
        {
            Combo c = new Combo();
            Assert.IsAssignableFrom<IOrderItem>(c);
        }

        [Fact]
        public void CheckIfAddsEntree()
        {
            Combo c = new Combo();
            
            BriarheartBurger bb = new BriarheartBurger();

            c.Entree = bb;

            Assert.Equal(bb, c.Entree);
        }

        [Fact]
        public void CheckIfAddsSide()
        {
            Combo c = new Combo();

            DragonbornWaffleFries dw = new DragonbornWaffleFries();

            c.Side = dw;

            Assert.Equal(dw, c.Side);
        }

        [Fact]
        public void CheckIfAddsDrink()
        {
            Combo c = new Combo();

            AretinoAppleJuice aj = new AretinoAppleJuice();

            c.Drink = aj;

            Assert.Equal(aj, c.Drink);
        }

       
    }
}
