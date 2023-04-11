using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BowlingGame
{
    public class BowlingGame : IBowlingGame
    {
        private int[] _rolls = new int[21];
        private int[] _frames = new int[10];
        int _currentRoll = 0;
        int _score = 0;
        private bool isStrike(int frameIndex)
        {
            return _rolls[frameIndex] == 10;
        }
        private bool isSpare(int frameIndex)
        {
            return _rolls[frameIndex] + _rolls[frameIndex + 1] == 10;
        }

   
        public void Roll(int noOfPins)
        {
            _rolls[_currentRoll++] = noOfPins;
        }

        public int Score()
        {
           
            int frameIndex = 0;
            for (int frame = 0; frame < 10; frame++)
            {
                if (isSpare(frameIndex))
                {
                    _score += 10 + _rolls[frameIndex + 2];
                    frameIndex += 2;
                }
                else if (isStrike(frameIndex))
                {
                    _score += 10 + _rolls[frameIndex + 1] + _rolls[frameIndex + 2];
                    frameIndex++;
                }
                else
                {
                    _score += _rolls[frameIndex] + _rolls[frameIndex + 1];
                    frameIndex += 2;
                }

            }

            return _score;
        }
    }
}
