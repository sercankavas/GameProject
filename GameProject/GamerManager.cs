using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class GamerManager : IGamerService
    {

        IUserValidationService _userValidationService;

        public GamerManager(IUserValidationService userValidationService)
        {
            _userValidationService = userValidationService;
        }

        public void Add(Gamer gamer)
        {
            if (_userValidationService.Validate(gamer))
            {
                Console.WriteLine("Gamer is added");
            }
            else
            {
                Console.WriteLine("Gamer is not added");
            }
            
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("Gamer is deleted");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("Gamer is updated");
        }
    }
}
