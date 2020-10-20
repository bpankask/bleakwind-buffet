using BleakwindBuffet.Data;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for CashRegister.xaml
    /// </summary>
    public partial class CashRegister : UserControl
    {
        private CashDrawData cdd = null;

        public CashRegister(Order order)
        {
            InitializeComponent();
            cdd = new CashDrawData(order);
            this.DataContext = cdd;
        }

        void OnCheckChangeClick(object sender, RoutedEventArgs e)
        {
            cdd.CheckChange();
        }
    }
}
