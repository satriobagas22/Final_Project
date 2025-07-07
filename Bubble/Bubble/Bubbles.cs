using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bubble
{
    internal class Bubbles
    {
        public int height;
        public int width;
        public int PosX;
        public int PosY;
        public int[] sizes = { 10, 20, 30, 40, 50, 60};
        public int speedX = 1;
        public int speedY;
        public int topLimit;
        public int moveLimit;

        public Image bubble;
        Random random = new Random();

        public Bubbles()
        {
            moveLimit = random.Next(50, 200);
            int i = random.Next(0, sizes.Length);
            bubble = Image.FromFile("images/bubble.png");

            height = sizes[i];
            width = sizes[i];

            topLimit = random.Next(10, 100);
            PosX = random.Next(-10, 800);
            PosY = random.Next(600, 1200);

            speedY = random.Next(1, 5);

        }

        public void MoveBubble()
        {
            moveLimit -= 1;
            if (moveLimit < 1) 
            {
                speedX = -speedX;
                moveLimit = random.Next(50, 200);
            }
        }
    }
}
