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

namespace KeyboardSupportSample
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
        private void SamplePage1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.Key==Key.Enter || e.Key == Key.Space)
            {
                titleLabel.Content = "Sample Page 1";
                mainLabel.Content = "Sample Page 1 Content";
            }
        }

        private void SamplePage2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter || e.Key == Key.Space)
            {
                titleLabel.Content = "Sample Page 2";
                mainLabel.Content = "Sample Page 2 Content";
            }
        }

        private void SamplePage3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter || e.Key == Key.Space)
            {
                titleLabel.Content = "Sample Page 3";
                mainLabel.Content = "Sample Page 3 Content";
            }
        }

        private void SamplePage4_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter || e.Key == Key.Space)
            {
                titleLabel.Content = "Sample Page 4";
                mainLabel.Content = "Sample Page 4 Content";
            }
        }

        private void Clicked_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter || e.Key == Key.Space)
            {
                titleLabel.Content = "Clicked Page";
                mainLabel.Content = "Clicked Page Content";
            }
        }

        private void Settings_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter || e.Key == Key.Space)
            {
                titleLabel.Content = "Settings Page";
                mainLabel.Content = "Settings Page Content";
            }
        }
    }
}
