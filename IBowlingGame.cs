using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BowlingGame
{
   public interface IBowlingGame
    {
        void Roll(int noOfPins);
        int Score();
    }
}
