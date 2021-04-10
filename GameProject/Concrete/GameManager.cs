using GameProject.Abstract;
using GameProject.Entites;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concrete
{
    class GameManager : IGameService
    {
        public void Add(Game game)
        {
            Console.WriteLine(game.GameName+" Adlı oyun sisteme ekledi");
        }

        public void Delete(Game game)
        {
            Console.WriteLine(game.GameName + " Adlı oyun sistemeden silindi");
        }

        public void Update(Game game)
        {
            Console.WriteLine(game.GameName + " Adlı oyun bilgileri güncellendi");
        }
    }
}
