using System;
using System.Collections.Generic;
using System.Text;
using GameProject.Abstract;
using GameProject.Entities;

namespace GameProject.Concrete
{
   public class GameManager:IGameService
    {
        public void Add(Game game)
        {
            Console.WriteLine(game.GameName + "Added." + '\n');
        }

        public void Delete(Game game)
        {
            Console.WriteLine(game.GameName + "Deleted." + '\n');
        }

        public void UpDate(Game game)
        {
            Console.WriteLine(game.GameName + "Updated." + '\n');
        }

        public void Update(Game game)
        {
            throw new NotImplementedException();
        }
    }
}
