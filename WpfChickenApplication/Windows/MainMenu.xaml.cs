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

namespace WpfChickenApplication.Windows
{
    public partial class MainMenu : Window
    {
        Account CurrentAcc;
        string[] images = new string[] { "pack://application:,,,/Resources/Menu/обучалка.png", "pack://application:,,,/Resources/Menu/уровень1.png", "pack://application:,,,/Resources/Menu/уровень2.png", "pack://application:,,,/Resources/Menu/уровень3.png" };
        public MainMenu(Account acc)
        {
            InitializeComponent();
            ColorScheme.GetColorScheme(this);
            CurrentAcc = acc;
            accButton.Content = acc.Name;
        }
        private void levelButton_MouseEnter(object sender, MouseEventArgs e)
        {
            chickenImage.Source = new BitmapImage(new Uri(images[Convert.ToInt16(((Button)sender).Name[5])-48]));
        }
        private void accButton_Click(object sender, RoutedEventArgs e)
        {
            MyAccount my = new MyAccount(CurrentAcc);
            my.Show();
        }
    }
}
