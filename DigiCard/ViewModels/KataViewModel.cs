using DigiCard.UtilityObjects;
using System.Windows;

namespace DigiCard.ViewModels
{
    public class KataViewModel : BindableBase
    {
        public Visibility IsVisible
        {
            get { return isVisible; }
            set { SetProperty(ref isVisible, value); }
        }
        private Visibility isVisible = Visibility.Collapsed;

    }
}