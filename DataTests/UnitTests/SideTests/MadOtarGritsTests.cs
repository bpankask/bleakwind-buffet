/*
 * Author: Zachery Brunner / Brayden Pankaskie
 * Class: MadOtarGritsTests.cs
 * Purpose: Test the MadOtarGrits.cs class in the Data library
 */
using Xunit;
using BleakwindBuffet.Data.Sides;
using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Enums;
using System.ComponentModel;

namespace BleakwindBuffet.DataTests.UnitTests.SideTests
{
    public class MadOtarGritsTests
    {
        [Fact]
        public void ChangingSizeNotifiesSizeProperty()
        {
            var mg = new MadOtarGrits();

            Assert.PropertyChanged(mg, "Size", () =>
            {
                mg.Size = Size.Large;
            });

            Assert.PropertyChanged(mg, "Size", () =>
            {
                mg.Size = Size.Medium;
            });

            Assert.PropertyChanged(mg, "Size", () =>
            {
                mg.Size = Size.Small;
            });
        }

        [Fact]
        public void ChangingSizeNotifiesPriceProperty()
        {
            var mg = new MadOtarGrits();

            Assert.PropertyChanged(mg, "Price", () =>
            {
                mg.Size = Size.Large;
            });

            Assert.PropertyChanged(mg, "Price", () =>
            {
                mg.Size = Size.Medium;
            });

            Assert.PropertyChanged(mg, "Price", () =>
            {
                mg.Size = Size.Small;
            });
        }

        [Fact]
        public void ChangingSizeNotifiesCaloriesProperty()
        {
            var mg = new MadOtarGrits();

            Assert.PropertyChanged(mg, "Calories", () =>
            {
                mg.Size = Size.Large;
            });

            Assert.PropertyChanged(mg, "Calories", () =>
            {
                mg.Size = Size.Medium;
            });

            Assert.PropertyChanged(mg, "Calories", () =>
            {
                mg.Size = Size.Small;
            });
        }

        [Fact]
        public void ShouldBeAnINotifyPropertyChanged()
        {
            MadOtarGrits mg = new MadOtarGrits();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(mg);
        }

        [Fact]
        public void ShouldBeAnIOrderItem()
        {
            MadOtarGrits mg = new MadOtarGrits();
            Assert.IsAssignableFrom<IOrderItem>(mg);
        }

        [Fact]
        public void ShouldBeASide()
        {
            MadOtarGrits mg = new MadOtarGrits();
            Assert.IsAssignableFrom<Side>(mg);
        }

        [Fact]
        public void ShouldBeSmallByDefault()
        {
            MadOtarGrits mg = new MadOtarGrits();
            Assert.Equal(Size.Small, mg.Size);
        }
                
        [Fact]
        public void ShouldBeAbleToSetSize()
        {
            MadOtarGrits mg = new MadOtarGrits();

            mg.Size = Size.Large;
            Assert.Equal(Size.Large, mg.Size);

            mg.Size = Size.Medium;
            Assert.Equal(Size.Medium, mg.Size);

            mg.Size = Size.Small;
            Assert.Equal(Size.Small, mg.Size);
        }

        [Fact]
        public void ShouldReturnCorrectStringOnSpecialInstructions()
        {
            MadOtarGrits mg = new MadOtarGrits();
            Assert.Empty(mg.SpecialInstructions);
        }

        [Theory]
        [InlineData(Size.Small, 1.22)]
        [InlineData(Size.Medium, 1.58)]
        [InlineData(Size.Large, 1.93)]
        public void ShouldReturnCorrectPriceBasedOnSize(Size size, double price)
        {
            MadOtarGrits mg = new MadOtarGrits();
            mg.Size = size;
            Assert.Equal(price, mg.Price);
        }

        [Theory]
        [InlineData(Size.Small, 105)]
        [InlineData(Size.Medium, 142)]
        [InlineData(Size.Large, 179)]
        public void ShouldReturnCorrectCaloriesBasedOnSize(Size size, uint calories)
        {
            MadOtarGrits mg = new MadOtarGrits();
            mg.Size = size;
            Assert.Equal(calories, mg.Calories);
        }

        [Theory]
        [InlineData(Size.Small, "Small Mad Otar Grits")]
        [InlineData(Size.Medium, "Medium Mad Otar Grits")]
        [InlineData(Size.Large, "Large Mad Otar Grits")]
        public void ShouldReturnCorrectToStringBasedOnSize(Size size, string name)
        {
            MadOtarGrits mg = new MadOtarGrits();
            mg.Size = size;
            Assert.Equal(name, mg.ToString());
        }
    }
}