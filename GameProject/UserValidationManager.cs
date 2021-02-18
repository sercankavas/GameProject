using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class UserValidationManager : IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {
            if (gamer.FirstName == "Sercan"&&gamer.LastName == "Kavas"&&gamer.BirthYear == 1986&&gamer.IdentityNo == 3636363)
            {
                return true;
            }
            else 
            {
                return false;
            }
        }
    }
}
