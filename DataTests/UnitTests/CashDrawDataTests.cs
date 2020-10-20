using BleakwindBuffet.Data;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace BleakwindBuffet.DataTests.UnitTests
{
    public class CashDrawDataTests
    {
        [Fact]
        public void ChangingPenniesAndPenniesChangeNotifiesPropertyChange()
        {
            CashDrawData cdd = new CashDrawData();

            Assert.PropertyChanged(cdd, "Pennies", () =>
            {
                cdd.Pennies = 7;
            });

            Assert.PropertyChanged(cdd, "PenniesChange", () =>
            {
                cdd.PenniesChange = 6;
            });
        }

        [Fact]
        public void ChangingNickelsAndNickelsChangeNotifiesPropertyChange()
        {
            CashDrawData cdd = new CashDrawData();

            Assert.PropertyChanged(cdd, "Nickels", () =>
            {
                cdd.Nickels = 7;
            });

            Assert.PropertyChanged(cdd, "NickelsChange", () =>
            {
                cdd.NickelsChange = 6;
            });
        }

        [Fact]
        public void ChangingDimesAndDimesChangeNotifiesPropertyChange()
        {
            CashDrawData cdd = new CashDrawData();

            Assert.PropertyChanged(cdd, "Dimes", () =>
            {
                cdd.Dimes = 7;
            });

            Assert.PropertyChanged(cdd, "DimesChange", () =>
            {
                cdd.DimesChange = 6;
            });
        }

        [Fact]
        public void ChangingQuartersAndQuartersChangeNotifiesPropertyChange()
        {
            CashDrawData cdd = new CashDrawData();

            Assert.PropertyChanged(cdd, "Quarters", () =>
            {
                cdd.Quarters = 7;
            });

            Assert.PropertyChanged(cdd, "QuartersChange", () =>
            {
                cdd.QuartersChange = 6;
            });
        }

        [Fact]
        public void ChangingHalfDollarsAndHalfDollarsChangeNotifiesPropertyChange()
        {
            CashDrawData cdd = new CashDrawData();

            Assert.PropertyChanged(cdd, "HalfDollars", () =>
            {
                cdd.HalfDollars = 7;
            });

            Assert.PropertyChanged(cdd, "HalfDollarsChange", () =>
            {
                cdd.HalfDollarsChange = 6;
            });
        }

        [Fact]
        public void ChangingDollarsAndDollarsChangeNotifiesPropertyChange()
        {
            CashDrawData cdd = new CashDrawData();

            Assert.PropertyChanged(cdd, "Dollars", () =>
            {
                cdd.Dollars = 7;
            });

            Assert.PropertyChanged(cdd, "DollarsChange", () =>
            {
                cdd.DollarsChange = 6;
            });
        }










        [Fact]
        public void ChangingOnesAndOnesChangeNotifiesPropertyChange()
        {
            CashDrawData cdd = new CashDrawData();

            Assert.PropertyChanged(cdd, "Ones", () =>
            {
                cdd.Ones = 7;
            });

            Assert.PropertyChanged(cdd, "OnesChange", () =>
            {
                cdd.OnesChange = 6;
            });
        }

        [Fact]
        public void ChangingTwosAndTwosChangeNotifiesPropertyChange()
        {
            CashDrawData cdd = new CashDrawData();

            Assert.PropertyChanged(cdd, "Twos", () =>
            {
                cdd.Twos = 7;
            });

            Assert.PropertyChanged(cdd, "TwosChange", () =>
            {
                cdd.TwosChange = 6;
            });
        }

        [Fact]
        public void ChangingFivesAndFivesChangeNotifiesPropertyChange()
        {
            CashDrawData cdd = new CashDrawData();

            Assert.PropertyChanged(cdd, "Fives", () =>
            {
                cdd.Fives = 7;
            });

            Assert.PropertyChanged(cdd, "FivesChange", () =>
            {
                cdd.FivesChange = 6;
            });
        }

        [Fact]
        public void ChangingTensAndTensChangeNotifiesPropertyChange()
        {
            CashDrawData cdd = new CashDrawData();

            Assert.PropertyChanged(cdd, "Tens", () =>
            {
                cdd.Tens = 7;
            });

            Assert.PropertyChanged(cdd, "TensChange", () =>
            {
                cdd.TensChange = 6;
            });
        }

        [Fact]
        public void ChangingTwentiesAndTwentiesChangeNotifiesPropertyChange()
        {
            CashDrawData cdd = new CashDrawData();

            Assert.PropertyChanged(cdd, "Twenties", () =>
            {
                cdd.Twenties = 7;
            });

            Assert.PropertyChanged(cdd, "TwentiesChange", () =>
            {
                cdd.TwentiesChange = 6;
            });
        }

        [Fact]
        public void ChangingFiftiesAndFiftiesChangeNotifiesPropertyChange()
        {
            CashDrawData cdd = new CashDrawData();

            Assert.PropertyChanged(cdd, "Fifties", () =>
            {
                cdd.Fifties = 7;
            });

            Assert.PropertyChanged(cdd, "FiftiesChange", () =>
            {
                cdd.FiftiesChange = 6;
            });
        }

        [Fact]
        public void ChangingHundredsAndHundredsChangeNotifiesPropertyChange()
        {
            CashDrawData cdd = new CashDrawData();

            Assert.PropertyChanged(cdd, "Hundreds", () =>
            {
                cdd.Hundreds = 7;
            });

            Assert.PropertyChanged(cdd, "HundredsChange", () =>
            {
                cdd.HundredsChange = 6;
            });
        }

        [Fact]
        public void TestIfCanSetPenniesAndPenniesChange()
        {
            CashDrawData cdd = new CashDrawData();
            cdd.Pennies = 9;
            Assert.Equal(9, cdd.Pennies);

            cdd.PenniesChange = 8;
            Assert.Equal(8, cdd.PenniesChange);

        }

        [Fact]
        public void TestIfCanSetNickelsAndNickelsChange()
        {
            CashDrawData cdd = new CashDrawData();
            cdd.Nickels = 9;
            Assert.Equal(9, cdd.Nickels);

            cdd.NickelsChange = 8;
            Assert.Equal(8, cdd.NickelsChange);

        }

        [Fact]
        public void TestIfCanSetDimesAndDimesChange()
        {
            CashDrawData cdd = new CashDrawData();
            cdd.Dimes = 9;
            Assert.Equal(9, cdd.Dimes);

            cdd.DimesChange = 8;
            Assert.Equal(8, cdd.DimesChange);

        }

        [Fact]
        public void TestIfCanSetQuartersAndQuartersChange()
        {
            CashDrawData cdd = new CashDrawData();
            cdd.Quarters = 9;
            Assert.Equal(9, cdd.Quarters);

            cdd.QuartersChange = 8;
            Assert.Equal(8, cdd.QuartersChange);

        }

        [Fact]
        public void TestIfCanSetHalfDollarsAndHalfDollarsChange()
        {
            CashDrawData cdd = new CashDrawData();
            cdd.HalfDollars = 9;
            Assert.Equal(9, cdd.HalfDollars);

            cdd.HalfDollarsChange = 8;
            Assert.Equal(8, cdd.HalfDollarsChange);

        }

        [Fact]
        public void TestIfCanSetDollarsAndDollarsChange()
        {
            CashDrawData cdd = new CashDrawData();
            cdd.Dollars = 9;
            Assert.Equal(9, cdd.Dollars);

            cdd.DollarsChange = 8;
            Assert.Equal(8, cdd.DollarsChange);

        }

        [Fact]
        public void TestIfCanSetOnesAndOnesChange()
        {
            CashDrawData cdd = new CashDrawData();
            cdd.Ones = 9;
            Assert.Equal(9, cdd.Ones);

            cdd.OnesChange = 8;
            Assert.Equal(8, cdd.OnesChange);

        }

        [Fact]
        public void TestIfCanSetTwosAndTwosChange()
        {
            CashDrawData cdd = new CashDrawData();
            cdd.Twos = 9;
            Assert.Equal(9, cdd.Twos);

            cdd.TwosChange = 8;
            Assert.Equal(8, cdd.TwosChange);

        }

        [Fact]
        public void TestIfCanSetFivesAndFivesChange()
        {
            CashDrawData cdd = new CashDrawData();
            cdd.Fives = 9;
            Assert.Equal(9, cdd.Fives);

            cdd.FivesChange = 8;
            Assert.Equal(8, cdd.FivesChange);

        }

        [Fact]
        public void TestIfCanSetTensAndTensChange()
        {
            CashDrawData cdd = new CashDrawData();
            cdd.Tens = 9;
            Assert.Equal(9, cdd.Tens);

            cdd.TensChange = 8;
            Assert.Equal(8, cdd.TensChange);

        }

        [Fact]
        public void TestIfCanSetTwentiesAndTwentiesChange()
        {
            CashDrawData cdd = new CashDrawData();
            cdd.Twenties = 9;
            Assert.Equal(9, cdd.Twenties);

            cdd.TwentiesChange = 8;
            Assert.Equal(8, cdd.TwentiesChange);

        }

        [Fact]
        public void TestIfCanSetFiftiesAndFiftiesChange()
        {
            CashDrawData cdd = new CashDrawData();
            cdd.Fifties = 9;
            Assert.Equal(9, cdd.Fifties);

            cdd.FiftiesChange = 8;
            Assert.Equal(8, cdd.FiftiesChange);

        }

        [Fact]
        public void TestIfCanSetHundredsAndHundredsChange()
        {
            CashDrawData cdd = new CashDrawData();
            cdd.Hundreds = 9;
            Assert.Equal(9, cdd.Hundreds);

            cdd.HundredsChange = 8;
            Assert.Equal(8, cdd.HundredsChange);

        }
    }
}
