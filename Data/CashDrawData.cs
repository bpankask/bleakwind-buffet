using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using RoundRegister;

namespace BleakwindBuffet.Data
{
    /// <summary>
    /// Class to represent currency given by user.
    /// ModelView for Model CashDrawer and View Register.
    /// </summary>
    public class CashDrawData : INotifyPropertyChanged
    {

        public event PropertyChangedEventHandler PropertyChanged;

        private Order order = null;

        private int pennies = 0;
        private int nickels = 0;
        private int dimes = 0;
        private int quarters = 0;
        private int halfDollars = 0;
        private int dollars = 0;
        private int ones = 0;
        private int twos = 0;
        private int fives = 0;
        private int tens = 0;
        private int twenties = 0;
        private int fifties = 0;
        private int hundreds = 0;

        private int penniesChange = 0;
        private int nickelsChange = 0;
        private int dimesChange = 0;
        private int quartersChange = 0;
        private int halfDollarsChange = 0;
        private int dollarsChange = 0;
        private int onesChange = 0;
        private int twosChange = 0;
        private int fivesChange = 0;
        private int tensChange = 0;
        private int twentiesChange = 0;
        private int fiftiesChange = 0;
        private int hundredsChange = 0;
        private double totalChange = 0;

        /// <summary>
        /// Constructor for CashDrawData class
        /// </summary>
        public CashDrawData(Order order)
        {
            this.order = order;
        }

        public CashDrawData()
        {
            
        }

        public int Pennies 
        { 
            get
            {
                return pennies;
            } 
            
            set
            {
                pennies = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Pennies"));
            } 
        }

        public int Nickels
        {
            get
            {
                return nickels;
            }

            set
            {
                nickels = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Nickels"));
            }
        }

        public int Dimes
        {
            get
            {
                return dimes;
            }

            set
            {
                dimes = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Dimes"));
            }
        }

        public int Quarters
        {
            get
            {
                return quarters;
            }

            set
            {
                quarters = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Quarters"));
            }
        }

        public int HalfDollars
        {
            get
            {
                return halfDollars;
            }

            set
            {
                halfDollars = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("HalfDollars"));
            }
        }

        public int Dollars
        {
            get
            {
                return dollars;
            }

            set
            {
                dollars = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Dollars"));
            }
        }

        public int Ones
        {
            get
            {
                return ones;
            }

            set
            {
                ones = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Ones"));
            }
        }

        public int Twos
        {
            get
            {
                return twos;
            }

            set
            {
                twos = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Twos"));
            }
        }

        public int Fives
        {
            get
            {
                return fives;
            }

            set
            {
                fives = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Fives"));
            }
        }

        public int Tens
        {
            get
            {
                return tens;
            }

            set
            {
                tens = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Tens"));
            }
        }

        public int Twenties
        {
            get
            {
                return twenties;
            }

            set
            {
                twenties = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Twenties"));
            }
        }

        public int Fifties
        {
            get
            {
                return fifties;
            }

            set
            {
                fifties = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Fifties"));
            }
        }

        public int Hundreds
        {
            get
            {
                return hundreds;
            }

            set
            {
                hundreds = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Hundreds"));
            }
        }

        public double GetTotalAmmountPaid()
        {
            double total = (pennies * .01) + (nickels * .05) + (dimes * .1) + (quarters * .25) + (halfDollars * .5)
                + dollars + ones + (twos * 2) + (fives * 5) + (tens * 10) + (twenties * 20) + (fifties * 50) + (hundreds * 100);

            return total;
        }

        /// <summary>
        /// Event listener which implements logic of giving correct change
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void CheckChange()
        {
            double totalPaid = GetTotalAmmountPaid();
            double remainingChange = totalPaid - order.Total;
            order.ChangeOwed = Math.Round(remainingChange,2);

            if(remainingChange >= 0)
            {
                    while(remainingChange - 100 >= 0)
                    {
                        HundredsChange++;
                        remainingChange -= 100;
                    }

                    while (remainingChange - 50 >= 0)
                    {
                        FiftiesChange++;
                        remainingChange -= 50;
                    }

                    while (remainingChange - 20 >= 0)
                    {
                        TwentiesChange++;
                        remainingChange -= 20;
                    }

                    while (remainingChange - 10 >= 0)
                    {
                        TensChange++;
                        remainingChange -= 10;
                    }

                    while (remainingChange - 5 >= 0)
                    {
                        remainingChange -= 5;
                        fivesChange++;
                    }

                    while (remainingChange - 2 >= 0)
                    {
                        TwosChange++;
                        remainingChange -= 2;
                    }

                    while (remainingChange - 1 >= 0)
                    {
                        OnesChange++;
                        remainingChange -= 1;
                    }

                    while (remainingChange - .5 >= 0)
                    {
                        HalfDollarsChange++;
                        remainingChange -= .5;
                    }

                    while (remainingChange - .25 >= 0)
                    {
                        QuartersChange++;
                        remainingChange -= .25;
                    }

                    while (remainingChange - .1 >= 0)
                    {
                        DimesChange++;
                        remainingChange -= .1;
                    }

                    while (remainingChange - .05 >= 0)
                    {
                        NickelsChange++;
                        remainingChange -= .05;
                    }

                    remainingChange = Math.Round(remainingChange, 2);

                    while (remainingChange - .01 >= 0)
                    {
                        PenniesChange++;
                        remainingChange -= .01;
                    }
            }
        }

        public int PenniesChange
        {
            get
            {
                return penniesChange;
            }

            set
            {
                penniesChange = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("PenniesChange"));
            }
        }

        public int NickelsChange
        {
            get
            {
                return nickelsChange;
            }

            set
            {
                nickelsChange = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("NickelsChange"));
            }
        }

        public int DimesChange
        {
            get
            {
                return dimesChange;
            }

            set
            {
                dimesChange = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("DimesChange"));
            }
        }

        public int QuartersChange
        {
            get
            {
                return quartersChange;
            }

            set
            {
                quartersChange = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("QuartersChange"));
            }
        }

        public int HalfDollarsChange
        {
            get
            {
                return halfDollarsChange;
            }

            set
            {
                halfDollarsChange = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("HalfDollarsChange"));
            }
        }

        public int DollarsChange
        {
            get
            {
                return dollarsChange;
            }

            set
            {
                dollarsChange = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("DollarsChange"));
            }
        }

        public int OnesChange
        {
            get
            {
                return onesChange;
            }

            set
            {
                onesChange = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("OnesChange"));
            }
        }

        public int TwosChange
        {
            get
            {
                return twosChange;
            }

            set
            {
                twosChange = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("TwosChange"));
            }
        }

        public int FivesChange
        {
            get
            {
                return fivesChange;
            }

            set
            {
                fivesChange = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("FivesChange"));
            }
        }

        public int TensChange
        {
            get
            {
                return tensChange;
            }

            set
            {
                tensChange = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("TensChange"));
            }
        }

        public int TwentiesChange
        {
            get
            {
                return twentiesChange;
            }

            set
            {
                twentiesChange = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("TwentiesChange"));
            }
        }

        public int FiftiesChange
        {
            get
            {
                return fiftiesChange;
            }

            set
            {
                fiftiesChange = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("FiftiesChange"));
            }
        }

        public int HundredsChange
        {
            get
            {
                return hundredsChange;
            }

            set
            {
                hundredsChange = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("HundredsChange"));
            }
        }

        public double TotalChange
        {
            get
            {
                return totalChange;
            }

            set
            {
                totalChange = value;
            }
        }


    }
}
