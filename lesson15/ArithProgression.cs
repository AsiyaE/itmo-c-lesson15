using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson15
{
    class ArithProgression : ISeries
    {
        int startPosition;
        int step;
        int curPosition;
        
        public ArithProgression(int startPosition, int step){
            this.startPosition = startPosition;
            this.step = step;
        }
        public int GetNext()
        {
            curPosition += step;
            return curPosition;
        }

        public void Reset()
        {
            curPosition = startPosition;
        }

        public void SetStart(int x)
        {
            startPosition = x;
            curPosition = startPosition;
        }

        public void SetStep(int s)
        {
            step = s;
        }
    }
}
