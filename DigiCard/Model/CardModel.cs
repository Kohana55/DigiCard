using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigiCard.Model
{
    /// <summary>
    /// The "Model"
    /// </summary>
    class CardModel
    {
        /// <summary>
        /// Setting the 'header' and 'body' fields  
        /// will cause them to display on the front end
        /// </summary>
        public ID home = new ID();
        public Biography bio = new Biography();
        public Skills skills = new Skills();
        public Professional pro = new Professional();
        public CodingKatas kata = new CodingKatas();
        public ContactInfo contact = new ContactInfo();

        /// <summary>
        /// Entry point for programme (business logic)
        /// From here feel free to spiral out and write as much logic as you like. 
        /// </summary>
        public CardModel()
        {

        }
    }
}
