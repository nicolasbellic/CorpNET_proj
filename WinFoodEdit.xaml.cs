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
using System.Windows.Shapes;

namespace WpfApp4
{
    /// <summary>
    /// Логика взаимодействия для WinFoodEdit.xaml
    /// </summary>
    public partial class WinFoodEdit : Window
    {
        public WinFoodEdit(Food food)
        {
            InitializeComponent();
            DataContext = food;
        }

        private void SaveClose(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
