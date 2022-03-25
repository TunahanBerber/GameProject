using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameProject.Abstract;

namespace GameProject.Entities
{
    public class Game:IEntity
    {
        public int Id { get; set; }
        public string GameName { get; set; }
        public double Price { get; set; }
        public int Stock { get; set; }
    }
}
