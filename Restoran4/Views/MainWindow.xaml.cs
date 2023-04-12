using Restoran4.Models;
using Restoran4.ViewModels;
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

namespace Restoran4.Views
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>  
    public partial class MainWindow : Window
    {


        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = this;
        }


        public void Click(object sender, RoutedEventArgs e)
        {
            var button = (Button)sender;
            if (button.Background == Brushes.Green)
            {
                Window2 Window = new Window2();
                Window.Show();
            }
        }
    }

    public class MenuCommand : ICommand
    {
        public event EventHandler? CanExecuteChanged;




        public MenuCommand()
        {

        }

        public bool CanExecute(object? parameter) => true;

        public void Execute(object? parameter)
        {
            
        }
    }
}
