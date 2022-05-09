using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainingVS
{
    internal class Write
    {

        public string[] tekst = new string[5];
        public int[] testX = new int[5];
        public int[] testY = new int[5];
        public System.Drawing.Color[] color = new System.Drawing.Color[3];
        public int[] krasa = new int[5];
        public Write()
        {
            this.color[0] = System.Drawing.Color.Black;
            this.color[1] = System.Drawing.Color.Blue;
            this.color[2] = System.Drawing.Color.Red;
        }


        public void print()
        {
            for (int i = 0; i < tekst.Length; i++)
            {
                if (krasa[i] == 0)
                {

                    Console.ForegroundColor = ConsoleColor.Red;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.White;
                }

                Console.SetCursorPosition(testX[i], testY[i]);
                Console.WriteLine(tekst[i]);
            }

        }
    }
}
