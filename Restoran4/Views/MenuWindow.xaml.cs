using Restoran4.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace Restoran4.Views
{
    /// <summary>
    /// Interaction logic for MenuWindow.xaml
    /// </summary>
    public partial class MenuWindow : Window
    {
        public ObservableCollection<Food> _foodItems;

        public MenuWindow()
        {
            InitializeComponent();
            this.DataContext = this;
            _foodItems = new ObservableCollection<Food>
            {
                new Food { Name = "Ayran", Price = 11.2,Count = 0 },
                new Food { Name = "Pive", Price = 12,Count = 0 },
                new Food { Name = "Kofe", Price = 15,Count = 0 },
                new Food { Name = "Dolma", Price = 8,Count = 0 },
                new Food { Name = "Merci", Price = 5,Count = 0 },
                new Food { Name = "Dovga", Price = 5,Count = 0 }
            };
            leftListView.Items.Add(_foodItems);
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var button = (Button)sender;
            var foodName = button.Content.ToString();

            // Remove the clicked button from the left ListView.
            leftListView.Items.Remove(button);

            // Add the food name to the right ListView.
            rightListView.Items.Add(foodName);
        }

        private void Btn1(object sender, RoutedEventArgs e)
        {


        }

    }
}
