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
            
            int jumpCapacity = 10;
            int slippingCount = 1;
            int wallsCount = 1;
            int[] heightsOfWalls = new int[] { 10 };

            int jumpCount = 0;

            
            jumpCount = GetJumpCount(jumpCapacity, slippingCount, wallsCount, heightsOfWalls);

            if(jumpCount == 0)
            {
                Console.WriteLine("Some Error. 2 of possible reasons could be to use values outside of  below range, as below:" +
                    "1<=Jump Capacity<10^9 \n" +
                    "1<=Slipping Value<10^5 \n" +
                    "");
            }
            else
            {
                Console.WriteLine("Total Jumps required to break out of Bhopal Jail is" + jumpCount);
            }

            Console.ReadKey();

        }

        public static int GetJumpCount(int jumpCapacity, int slippingCount, int wallsCount, int[] heightsOfWalls)
        {
            bool jumpCapacityError=false;
            bool slippingCountError=false;

            if (jumpCapacity < 1 || jumpCapacity > Convert.ToInt32(Math.Pow(10, 9)))
            {
                jumpCapacityError = true;
                return 0;
            }

            if (slippingCount < 1 || slippingCount > Convert.ToInt32(Math.Pow(10, 5)))
            {
                slippingCountError = true;
                return 0;
            }

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
