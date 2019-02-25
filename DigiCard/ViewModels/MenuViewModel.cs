using DigiCard.UtilityObjects;
using System.Windows.Input;

namespace DigiCard.ViewModels
{
    /// <summary>
    /// Menu View Model
    /// </summary>
    public class MenuViewModel : BindableBase
    {

        /// <summary>
        /// Current page to display
        /// </summary>
        public Enums.Views CurrentPage;

        /// <summary>
        /// COMMANDS
        /// Each command is bound to its button in the MenuView.xaml
        /// This binding is possible because we have assigned the MenuView's Datacontex to this ViewModel
        /// Each command calls a method in this class
        /// </summary>
        #region Commands
        public ICommand IdSelect
        {
            get { return idSelect ?? (idSelect = new DelegateCommand(IdSelected)); }
        }
        private ICommand idSelect;

        public ICommand BioSelect
        {
            get { return bioSelect ?? (bioSelect = new DelegateCommand(BioSelected)); }
        }
        private ICommand bioSelect;

        public ICommand SkillsSelect
        {
            get { return skillSelect ?? (skillSelect = new DelegateCommand(SkillsSelected)); }
        }
        private ICommand skillSelect;

        public ICommand ProSelect
        {
            get { return proSelect ?? (proSelect = new DelegateCommand(ProSelected)); }
        }
        private ICommand proSelect;

        public ICommand KataSelect
        {
            get { return kataSelect ?? (kataSelect = new DelegateCommand(KataSelected)); }
        }
        private ICommand kataSelect;

        public ICommand ContactSelect
        {
            get { return contactSelect ?? (contactSelect = new DelegateCommand(ContactSelected)); }
        }
        private ICommand contactSelect;
        #endregion Commands

        #region Constructor
        public MenuViewModel() { }
        #endregion Constructor

        #region Methods
        public void IdSelected()
        {
            CurrentPage = Enums.Views.ID;
            OnMenuClick?.Invoke(this, CurrentPage);
        }

        public void BioSelected()
        {
            CurrentPage = Enums.Views.Bio;
            OnMenuClick?.Invoke(this, CurrentPage);
        }

        public void SkillsSelected()
        {
            CurrentPage = Enums.Views.Skills;
            OnMenuClick?.Invoke(this, CurrentPage);
        }

        public void ProSelected()
        {
            CurrentPage = Enums.Views.Professional;
            OnMenuClick?.Invoke(this, CurrentPage);
        }

        public void KataSelected()
        {
            CurrentPage = Enums.Views.Kata;
            OnMenuClick?.Invoke(this, CurrentPage);
        }

        public void ContactSelected()
        {
            CurrentPage = Enums.Views.Contact;
            OnMenuClick?.Invoke(this, CurrentPage);
        }
        #endregion Methods

        #region EventandDelegate
        public delegate void OnMenuClickEventHandler(object sender, Enums.Views e);
        public event OnMenuClickEventHandler OnMenuClick;
        #endregion EventandDelegate
    }
}
