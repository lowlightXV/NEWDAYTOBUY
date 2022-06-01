using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace saveMoneyToBuy1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }


        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            double income1 = Convert.ToDouble(income.Text);
            double expenses1 = Convert.ToDouble(expenses.Text);
            double priceItem1 = Convert.ToDouble(priceItem.Text);
            
            income1 = priceItem1 / (income1 - expenses1) ;
            int priceTotal = (int)Math.Ceiling(income1);
            collectMoney.Text = Convert.ToString(priceTotal);

        }
    }
}
