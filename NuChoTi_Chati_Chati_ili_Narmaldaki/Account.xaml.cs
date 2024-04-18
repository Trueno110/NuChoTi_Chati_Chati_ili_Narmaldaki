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
using System.Windows.Shapes;

namespace NuChoTi_Chati_Chati_ili_Narmaldaki
{
    /// <summary>
    /// Логика взаимодействия для Account.xaml
    /// </summary>
    public partial class Account : Window
    {
        public Account()
        {
            InitializeComponent();
        }
        private SolidColorBrush originalBackground;
        private bool isColorChanged = false;
        private void Tema_click(object sender, RoutedEventArgs e)
        {
            if (!isColorChanged)
            {

                originalBackground = (SolidColorBrush)Accounts.Background;

                SolidColorBrush newBackground = new SolidColorBrush(Colors.Black);
                Accounts.Background = newBackground;
                isColorChanged = true;
            }
            else
            {

                Accounts.Background = originalBackground;
                isColorChanged = false;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

        }
    }
}
