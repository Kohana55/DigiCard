/**
 * The "CardView" is our top level view and as such,
 * it's ViewModel "CardViewModel" will be our top level ViewModel
 * 
 * Just as our top level ViewModel creates all our ViewModels
 * Our top level View (this class) creates all our Views
 * 
 * The Views that this View will create are found in the xaml (CardView.xaml)
 * Using their x:Name property, we can use them here in our code behind
 * 
 * Not the only way of structuring this out but one of my favorites
 * */


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
        /// <summary>
        /// Assign a CardViewModel to this property and it'll set this View's DataContext
        /// And since the ViewModel for this View creates the ViewModels for all the other views,
        /// assign them here too
        /// </summary>
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

                _KataView._FizzBuzzView.ViewModel = value.kataVM.fizzBuzzVM;
            }
        }     

        /// <summary>
        /// Init View and create/assign our ViewModel
        /// </summary>
        public CardView()
        {
            InitializeComponent();
            ViewModel = new CardViewModel();
        }
    }
}
