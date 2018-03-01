using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.Models
{
    public class PersonModel
    {
        /// <summary>
        /// Represten the players first name.
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Represents the players last name.
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// Represents the email adress of the player.
        /// </summary>
        public string EmailAddress { get; set; }

        /// <summary>
        /// Represents the players cellphone number.
        /// </summary>
        public string CellphoneNumber { get; set; }

    }
}

