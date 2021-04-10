using System;
using System.Collections.Generic;
using System.Text;
using GameProject.Entites;

namespace GameProject.Abstract
{
    abstract class BaseGamerManager : IGamerService
    {
        public virtual void Add(Gamer gamer)
        {
            Console.WriteLine(gamer.FirstName + " " + gamer.LastName + " İsimli kullanıcı eklendi");
        }

        public virtual void Delete(Gamer gamer)
        {
            Console.WriteLine(gamer.FirstName + " " + gamer.LastName + " İsimli kullanıcı kayıtları silindi");
        }

        public virtual void Update(Gamer gamer)
        {
            Console.WriteLine(gamer.FirstName + " " + gamer.LastName + " İsimli kullanıcı bilgileri güncellendi");
        }
    }
}
