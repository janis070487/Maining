using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainingVS
{
    public class PrintInfo
    {
       public void PrintBinary_32(byte[] data) // pienem byte masivu
        {
            int counter = 0;
            for (int i = 0; i < data.Length; i++)
            {
               
                string value = "";
               // for (int a = 0;  a < 4; a++)
               // {
                    Console.Write(Convert.ToString(data[i], toBase: 2));
                Console.Write("\t");
                counter++;
                if(counter == 4) { Console.WriteLine(); counter = 0; }
                    // value = value + Convert.ToString(data[i], toBase: 2) + "\t";
               // }
               // string result = Convert.ToString(value, toBase: 2) + "\t";
                //Console.WriteLine();
               // result = "";
                ///value = "";
            }
        }
        ///// pieņem uint masivu
        public void PrintBinary_32(UInt32[] data)
        {
            //int counter = 0;
            for (int i = 0; i < data.Length; i++)
            {

                string value = "";
                // for (int a = 0;  a < 4; a++)
                // {
                Console.WriteLine(Convert.ToString(data[i], toBase: 2));
               // Console.Write("\t");
               // counter++;
               // if (counter == 4) { Console.WriteLine(); counter = 0; }
                // value = value + Convert.ToString(data[i], toBase: 2) + "\t";
                // }
                // string result = Convert.ToString(value, toBase: 2) + "\t";
                //Console.WriteLine();
                // result = "";
                ///value = "";
            }
        }
    }
}
