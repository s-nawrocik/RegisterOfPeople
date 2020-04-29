using RegisterOfPeopleApp.ViewModel;
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

namespace RegisterOfPeopleApp
{
    /// <summary>
    /// Interaction logic for RegisterOfPeopleWindow.xaml
    /// </summary>
    public partial class RegisterWindow : Window
    {
        private readonly RegisterViewModel viewModel;
        public RegisterWindow()
        {
            InitializeComponent();

            viewModel = new RegisterViewModel();
            DataContext = viewModel;
        }
    }
}
