using DigiCard.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DigiCard.UtilityObjects;
using System.Windows;
using System.Windows.Input;
using System.Timers;

namespace DigiCard.ViewModels
{
    public class CardViewModel : BindableBase
    {
        #region Fields
        /// <summary>
        /// Create the main Model
        /// </summary>
        private Card model;


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
        /// 
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
        /// 
        /// </summary>
        public CardViewModel()
        {
            model = new Card();
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
