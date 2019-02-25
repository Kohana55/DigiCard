using DigiCard.Model;
using DigiCard.UtilityObjects;
using System.Windows;

namespace DigiCard.ViewModels
{
    public class BioViewModel : BindableBase
    {
        private BioObj model;

        public Visibility IsVisible
        {
            get { return isVisible; }
            set { SetProperty(ref isVisible, value); }
        }
        private Visibility isVisible = Visibility.Collapsed;

        public BioViewModel(BioObj bioArg)
        {
            model = bioArg;
        }
    }
}
