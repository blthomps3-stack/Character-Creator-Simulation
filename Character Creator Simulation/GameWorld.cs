using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Character_Creator_Simulation
{
    public class GameWorld
    {
        private static GameWorld _instance;
        private static readonly object _lock = new object();
        private GameWorld() { }
        public string Difficulty { get; set; } = "normal";
        public int Days { get; set; } = 1;
        public ICharacter Character { get; set; }
        public static GameWorld GetInstance()
        {
            if(_instance == null)
            {
                lock (_lock)
                {
                    if(_instance == null)
                    {
                        _instance = new GameWorld();
                    }
                }
            }
            return _instance;
        }

        public void PassDay()
        {
            Days++;
        }
    }
}
