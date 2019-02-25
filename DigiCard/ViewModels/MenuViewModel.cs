using DigiCard.UtilityObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace DigiCard.ViewModels
{
    public class MenuViewModel : BindableBase
    {

        public Enums.Views CurrentPage { get; set; }

        public ICommand HomeSelect
        {
            get { return homeSelect ?? (homeSelect = new DelegateCommand(HomeSelected)); }
        }
        private ICommand homeSelect;

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

        public MenuViewModel() { }

        public void HomeSelected()
        {
            CurrentPage = Enums.Views.Home;
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

        public delegate void OnMenuClickEventHandler(object sender, Enums.Views e);
        public event OnMenuClickEventHandler OnMenuClick;
    }
}
