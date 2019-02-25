using DigiCard.Model;
using DigiCard.UtilityObjects;
using System.Windows;

namespace DigiCard.ViewModels
{
    public class ContactViewModel : BindableBase
    {
        private ContactInfo model;

        public string Header
        {
            get { return header; }
            set { SetProperty(ref header, value); }
        }
        private string header;

        public string Body
        {
            get { return body; }
            set { SetProperty(ref body, value); }
        }
        private string body;

        public Visibility IsVisible
        {
            get { return isVisible; }
            set { SetProperty(ref isVisible, value); }
        }
        private Visibility isVisible = Visibility.Collapsed;

        public ContactViewModel(ContactInfo contactInfoArg)
        {
            model = contactInfoArg;
            Header = model.header;
            Body = model.body;
        }
    }
}