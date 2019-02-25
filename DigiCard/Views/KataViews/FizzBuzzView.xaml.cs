using DigiCard.ViewModels;
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

namespace DigiCard.Views
{
    /// <summary>
    /// Interaction logic for FizzBuzzView.xaml
    /// </summary>
    public partial class FizzBuzzView : UserControl
    {

        public FizzBuzzViewModel ViewModel
        {
            get { return DataContext as FizzBuzzViewModel; }
            set { DataContext = value; }
        }

        public FizzBuzzView()
        {
            InitializeComponent();
        }
    }
}
