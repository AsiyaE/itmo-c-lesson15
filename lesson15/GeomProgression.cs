using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson15
{
    class GeomProgression : ISeries
    {
        int startPosition;
        int k;
        int curPosition;

        public GeomProgression(int startPosition, int k)
        {
            this.startPosition = startPosition;
            this.k = k;
        }
        public int GetNext()
        {
            curPosition *= k;
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

        public void SetK(int k)
        {
            this.k = k;
        }
    }
}
