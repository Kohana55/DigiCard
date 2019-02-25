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
using DigiCard.ViewModels;

namespace DigiCard.Views
{
    /// <summary>
    /// Interaction logic for CardView.xaml
    /// </summary>
    public partial class CardView : UserControl
    {
        public CardViewModel ViewModel
        {
            get { return DataContext as CardViewModel; }
            set
            {
                DataContext = value;
                _MenuView.ViewModel = value.menuVM;
                _HomeView.ViewModel = value.homeVM;
                _BioView.ViewModel = value.bioVM;
                _SkillsView.ViewModel = value.skillsVM;
                _ProfessionalView.ViewModel = value.proVM;
                _KataView.ViewModel = value.kataVM;
                _Contact.ViewModel = value.contactVM;
            }
        }     

        public CardView()
        {
            InitializeComponent();
            ViewModel = new CardViewModel();
        }
    }
}
