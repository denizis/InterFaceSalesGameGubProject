using GameHub.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameHub.Entities
{
    public class Player:IPlayer
    {
        public int Player_Id { get; set; }
        public string Player_TcNo { get; set; }
        public string Player_Ad { get; set; }
        public string Player_Soyad { get; set; }   
        public DateTime Player_DogumYili { get; set; }

    }
}
