/**
 * The "CardView" is the top level view and as such,
 * it's ViewModel (this class) is the top level ViewModel
 * 
 * Just as the top level View creates all our Views
 * Our top level ViewModel can create all our ViewModels
 * 
 * The advantage here is that our model is created at the same time our 
 * ViewModels are, allowing us to easily assign to them from our model
 * 
 * Not the only way of structuring this out but one of my favorites
 * */


using DigiCard.Model;
using DigiCard.UtilityObjects;
using System.Windows;

namespace DigiCard.ViewModels
{
    /// <summary>
    /// Card ViewModel
    /// </summary>
    public class CardViewModel : BindableBase
    {
        #region Fields
        /// <summary>
        /// Create the Model (our programme)
        /// </summary>
        private CardModel model;


        /// <summary>
        /// Create viewmodels
        /// </summary>
        public MenuViewModel menuVM;
        public HomeViewModel homeVM;
        public BioViewModel bioVM;
        public SkillsViewModel skillsVM;
        public ProViewModel proVM;
        public KataViewModel kataVM;
        public ContactViewModel contactVM;
        #endregion Fields

        #region Properties
        /// <summary>
        /// Set to change the current page
        /// </summary>
        public Enums.Views CurrentPage
        {
            get { return currentPage; }
            set
            {
                currentPage = value;
                UpdateView();
            }
        }
        private Enums.Views currentPage;
        #endregion

        #region Constructor
        /// <summary>
        /// The Constructor creates our model
        /// Creates our ViewModels
        /// Sets our current page and subscribes to our Menu's event
        /// </summary>
        public CardViewModel()
        {
            model = new CardModel();

            menuVM = new MenuViewModel();
            homeVM = new HomeViewModel(model.home);
            bioVM = new BioViewModel(model.bio);
            skillsVM = new SkillsViewModel();
            proVM = new ProViewModel();
            kataVM = new KataViewModel();
            contactVM = new ContactViewModel();
            
            CurrentPage = Enums.Views.Home;

            menuVM.OnMenuClick += MenuVM_OnMenuClick;
        }
        #endregion Constructor

        #region Methods
        private void MenuVM_OnMenuClick(object sender, Enums.Views e)
        {
            CurrentPage = e;
        }

        /// <summary>
        /// 
        /// </summary>
        private void UpdateView()
        {
            homeVM.IsVisible = CurrentPage == Enums.Views.Home ? Visibility.Visible : Visibility.Hidden;
            bioVM.IsVisible = CurrentPage == Enums.Views.Bio ? Visibility.Visible : Visibility.Hidden;
            skillsVM.IsVisible = CurrentPage == Enums.Views.Skills ? Visibility.Visible : Visibility.Hidden;
            proVM.IsVisible = CurrentPage == Enums.Views.Professional ? Visibility.Visible : Visibility.Hidden;
            kataVM.IsVisible = CurrentPage == Enums.Views.Kata ? Visibility.Visible : Visibility.Hidden;
            contactVM.IsVisible = CurrentPage == Enums.Views.Contact ? Visibility.Visible : Visibility.Hidden;
        }
        #endregion Methods
    }
}
