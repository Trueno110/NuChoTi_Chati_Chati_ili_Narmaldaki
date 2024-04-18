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
    /// Логика взаимодействия для UserSet.xaml
    /// </summary>
    public partial class UserSet : Window
    {
        public UserSet()
        {
            InitializeComponent();

        }

        private void users_Click(object sender, RoutedEventArgs e)
        {

        }
        
        
        private SolidColorBrush originalBackground; 
        private bool isColorChanged = false; 
        
        private void Tema_click(object sender, RoutedEventArgs e)
        {

            if (!isColorChanged)
            {
               
                originalBackground = (SolidColorBrush)Perepiska.Background; 
                                                                                 
                SolidColorBrush newBackground = new SolidColorBrush(Colors.Black); 
                Perepiska.Background = newBackground; 
                isColorChanged = true; 
            }
            else
            {
              
                Perepiska.Background = originalBackground; 
                isColorChanged = false; 
            }
        }

        private void Nastroyki_Click(object sender, RoutedEventArgs e)
        {
            Account account = new Account();
            account.Show();
            this.Close();
        }

        private void Obnovit_Click(object sender, RoutedEventArgs e)
        {

        }

        private void SendMessage_Click(object sender, RoutedEventArgs e)
        {
            string message = messageTextBox.Text;
            if (!string.IsNullOrEmpty(message))
            {
                messageListBox.Items.Add(message);
                messageTextBox.Text = string.Empty;
            }
        }

       
    }
}
