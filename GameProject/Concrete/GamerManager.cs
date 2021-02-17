using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concrete
{
    public class GamerManager : IGamerService
    {
        IGamerCheckService _gamerCheckService;
        public GamerManager(IGamerCheckService gamerCheckService)
        {
            _gamerCheckService = gamerCheckService;
        }

        public void Add(Gamer gamer)
        {
            if (_gamerCheckService.CheckIfRealPerson (gamer) == true)
            {
                Console.WriteLine(gamer.FirstName + " Registered :)" + '\n');
            }
            else
            {
                Console.WriteLine("Verification Failed! , Registration Failed!");
            }
        }

        public void Delete(Gamer gamer)
        {
            if (_gamerCheckService.CheckIfRealPerson(gamer) == true)
            {
                Console.WriteLine(gamer.FirstName + "Deleted" + '\n');
            }
            else
            {
                Console.WriteLine("Verification Failed! , Registration Failed!");
            }
        }

        public void Update(Gamer gamer)
        {
            if (_gamerCheckService.CheckIfRealPerson(gamer) == true)
            {
                Console.WriteLine(gamer.FirstName + "Updated" + '\n');
            }
            else
            {
                Console.WriteLine("Verification Failed! , Registration Failed!");
            }
        }
    }
}
