using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Memory_Game.Forms;
using System.Threading.Tasks;

namespace Memory_Game.Processes
{
    public class RandomGenerator
    {
        public int RandomNumber(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max);

        }
     
    }

    public class LongRandomGenerator
    {
        public int RandomNumber(int min, int max)
        {
            Random random = new Random(Guid.NewGuid().GetHashCode());
            return random.Next(min, max);
        }

        public Int64 LongRandomNumber()
        {
            Int64 longRandom = 0;

            for (int i = 0; i < 10; i++)
            {
                longRandom += RandomNumber(1, 9) * Convert.ToInt64(Math.Pow(10, i));
            }

            return longRandom;
        }
    }
}
