using System;
using System.Collections.Generic;
using System.Linq;
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
using Multipli_Views.ViewModels;

namespace Multipli_Views
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void RedView_Click(object sender, RoutedEventArgs e)
        {
            DataContext = new RedViewModel();
        }

        private void BlueView_Click(object sender, RoutedEventArgs e)
        {
            DataContext = new BlueViewModel();
        }
    }
}
