using System;

namespace L6
{

    public class Player
    {
        public int score;

        public void calculatescore(bool truth)
        {
            if (truth == true)
            {
                score = score + 1;
            }
            else
            {
                score = score - 1;
            }
        }
    }
}