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

namespace WpfApp4
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            list1.ItemsSource = Food.arrayFood;
        }

        private void FoodNew(object sender, RoutedEventArgs e)
        {
            new Food("Новое блюдо", 1, 1);
        }

        private void FoodEdit(object sender, RoutedEventArgs e)
        {
            Food edit = (Food)list1.SelectedItem;
            if (edit != null)
                new WinFoodEdit(edit).Show();
        }

        private void FoodDel(object sender, RoutedEventArgs e)
        {
            Food delete = (Food)list1.SelectedItem;
            if (delete != null)
                Food.arrayFood.Remove(delete);
        }
    }
}
