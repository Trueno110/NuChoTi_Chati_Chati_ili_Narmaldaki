﻿using System;
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
    /// Логика взаимодействия для Enterence.xaml
    /// </summary>
    public partial class Enterence : Window
    {
        public Enterence()
        {
            InitializeComponent();
        }

        private void BXOD_Click(object sender, RoutedEventArgs e)
        {
            UserSet userSet = new UserSet();
            userSet.Show();
            this.Close();
        }

        private void Zaregaca_Click(object sender, RoutedEventArgs e)
        {
            Registration registration = new Registration();
            registration.ShowDialog();
           
        }
    }
}
