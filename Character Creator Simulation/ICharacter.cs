using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Character_Creator_Simulation
{
    public interface ICharacter
    {
        void Act();
        void Speak();
        void PrintDetails();

    }
}
