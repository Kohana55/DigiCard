using DigiCard.Model;
using DigiCard.UtilityObjects;
using System.Windows;

namespace DigiCard.ViewModels
{
    public class BioViewModel : BindableBase
    {
        private Biography model;

        public Visibility IsVisible
        {
            get { return isVisible; }
            set { SetProperty(ref isVisible, value); }
        }
        private Visibility isVisible = Visibility.Collapsed;

        public BioViewModel(Biography bioArg)
        {
            model = bioArg;
        }
    }
}
