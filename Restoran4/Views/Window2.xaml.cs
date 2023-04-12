using Restoran4.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
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
    /// Interaction logic for Window2.xaml
    /// </summary>
    public partial class Window2 : Window, INotifyPropertyChanged
    {
        public List<Garson> garsons;
        public string _name;
        private string _surname;
        private string _password;
        public Window2()
        {
            InitializeComponent();
            this.DataContext = this;
            garsons = new List<Garson>
            {
                new Garson{Name = "1",Surname = "1",Password="1"},
                new Garson{Name = "Ramiz",Surname = "Eliyev",Password="Rt5n_7bv"},
                new Garson{Name = "Vaqif",Surname = "Babayev",Password="mnY2_Tp3"},
                new Garson{Name = "Saddam",Surname = "Huseyn",Password="Wl.c4Kjh"}
            };
        }
        public string _Name
        {
            get { return _name; }
            set
            {
                if (_name != value)
                {
                    _name = value;
                    OnPropertyChanged();
                }
            }
        }
        public string Surname
        {
            get { return _surname; }
            set
            {
                if (_surname != value)
                {
                    _surname = value;
                    OnPropertyChanged();
                }
            }
        }

        public string Password
        {
            get { return _password; }
            set
            {
                if (_password != value)
                {
                    _password = value;
                    OnPropertyChanged();
                }
            }
        }

        private void PasswordBox_PasswordChanged(object sender, RoutedEventArgs e)
        {
            PasswordBox passwordBox = sender as PasswordBox;
            if (passwordBox != null)
            {
                Window2 viewModel = DataContext as Window2;
                if (viewModel != null)
                {
                    viewModel.Password = passwordBox.Password;
                }
            }
        }

        private ICommand _loginCommand;
        public ICommand LoginCommand
        {
            get
            {
                return _loginCommand = new PasswordCommand(param => this.Login(param), param => this.CanLogin());
            }
        }

        private bool CanLogin()
        {
            return !string.IsNullOrEmpty(_Name) && !string.IsNullOrEmpty(Surname) && !string.IsNullOrEmpty(Password);
        }

        private void Login(object parameter)
        {
            //var passwordBox = parameter as System.Windows.Controls.PasswordBox;
            //var password = passwordBox.Password;
            for (int i = 0; i < garsons.Count; i++)
            {
                if (_Name == garsons[i].Name && Surname== garsons[i].Surname && Password == garsons[i].Password)
                {
                    MessageBox.Show("Welcome To Menu!");
                    Close();
                    MenuWindow Window = new MenuWindow();
                    Window.Show();
                    return;
                } 


                
            }
            MessageBox.Show("Name or Surname or Password  not ready!");
            

        }



        public event PropertyChangedEventHandler? PropertyChanged;
        private void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }

    public class PasswordCommand : ICommand
    {
        private readonly Action<object> _execute;
        private readonly Predicate<object> _canExecute;

        public PasswordCommand(Action<object> execute, Predicate<object> canExecute)
        {
            _execute = execute;
            _canExecute = canExecute;
        }

        public bool CanExecute(object parameter)
        {
            return _canExecute == null ? true : _canExecute(parameter);
        }

        public void Execute(object parameter)
        {
            _execute(parameter);
        }

        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }
    }

}
