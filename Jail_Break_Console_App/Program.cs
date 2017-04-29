using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jail_Break_Console_App
{
    public class Program
    {
        static void Main(string[] args)
        {
            
        }

        public static int GetJumpCount(int jumpCapacity, int slippingCount, int wallsCount, int[] heightsOfWalls)
        {
            int jumpCount = 0;
            ////////////////
            foreach (var heightOfWall in heightsOfWalls)
            {
                int localJumpCount = GetWallJumpCount(jumpCapacity, slippingCount, heightOfWall);

                jumpCount += localJumpCount;
            }
            ///////////////
            return jumpCount;
        }

        private static int GetWallJumpCount(int jumpCapacity, int slippingCount, int heightOfWall)
        {
            int reachedHeight = 0;
            int jumpedCount = 0;
            do
            {
                if (reachedHeight != 0) {
                    reachedHeight -= slippingCount;
                }
                reachedHeight += jumpCapacity;
                jumpedCount += 1;

            } while (reachedHeight < heightOfWall);

            return jumpedCount;
        }
    }
}
