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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Deneme1
{
    /// <summary>
    /// Interaction logic for SporOutdoorKategoriler.xaml
    /// </summary>
    public partial class SporOutdoorKategoriler : Page
    {
        public SporOutdoorKategoriler()
        {
            InitializeComponent();
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {

            Sepet s = new Sepet();
            this.NavigationService.Navigate(s);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            DR d = new DR();
            this.NavigationService.Navigate(d);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Barkod b = new Barkod();
            this.NavigationService.Navigate(b);
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Arama a = new Arama();
            this.NavigationService.Navigate(a);
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            SporOutdoor so = new SporOutdoor();
            this.NavigationService.Navigate(so);
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            SporOutdoor so = new SporOutdoor();
            this.NavigationService.Navigate(so);
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            SporOutdoor so = new SporOutdoor();
            this.NavigationService.Navigate(so);
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            SporOutdoor so = new SporOutdoor();
            this.NavigationService.Navigate(so);
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            SporOutdoor so = new SporOutdoor();
            this.NavigationService.Navigate(so);
        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {

        }

        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
