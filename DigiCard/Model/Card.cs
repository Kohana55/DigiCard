using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigiCard.Model
{
    class Card
    {

        public HomeObj home;
        public BioObj bio;

        public Card()
        {
            home = new HomeObj();
            bio = new BioObj();
        }
    }
}
