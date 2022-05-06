// vairak pa 255 mb nevar apstradat jaizlabo metode FormatData() pie atzimes __1__ jo ints var glabat par 32
// bitiem, bet vajag 64 biti
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainingVS
{
    public class Sha256
    {
        PrintInfo print = new PrintInfo();
        public string path { get; set; }
        private uint[] konstant = {
            0x428a2f98, 0x71374491, 0xb5c0fbcf, 0xe9b5dba5, 0x3956c25b, 0x59f111f1, 0x923f82a4, 0xab1c5ed5,
            0xd807aa98, 0x12835b01, 0x243185be, 0x550c7dc3, 0x72be5d74, 0x80deb1fe, 0x9bdc06a7, 0xc19bf174,
            0xe49b69c1, 0xefbe4786, 0x0fc19dc6, 0x240ca1cc, 0x2de92c6f, 0x4a7484aa, 0x5cb0a9dc, 0x76f988da,
            0x983e5152, 0xa831c66d, 0xb00327c8, 0xbf597fc7, 0xc6e00bf3, 0xd5a79147, 0x06ca6351, 0x14292967,
            0x27b70a85, 0x2e1b2138, 0x4d2c6dfc, 0x53380d13, 0x650a7354, 0x766a0abb, 0x81c2c92e, 0x92722c85,
            0xa2bfe8a1, 0xa81a664b, 0xc24b8b70, 0xc76c51a3, 0xd192e819, 0xd6990624, 0xf40e3585, 0x106aa070,
            0x19a4c116, 0x1e376c08, 0x2748774c, 0x34b0bcb5, 0x391c0cb3, 0x4ed8aa4a, 0x5b9cca4f, 0x682e6ff3,
            0x748f82ee, 0x78a5636f, 0x84c87814, 0x8cc70208, 0x90befffa, 0xa4506ceb, 0xbef9a3f7, 0xc67178f2
        };
        private uint[] H =
        {
            0x6a09e667, 0xbb67ae85, 0x3c6ef372, 0xa54ff53a, 0x510e527f, 0x9b05688c, 0x1f83d9ab, 0x5be0cd19
        };
        private uint[] W = new uint[64];    // glabās vārdus ar kuriem strādās
        private byte[] data;                // glabāsies dati kurus nolasīs no faila
        private byte[] newdata;             // glabajas dati pec nolasišanas un apstrades
        private byte[] block = new byte[64];  // glabāsies bloki pa 512 bitiem
        private int hovblocknead;
        FileRead file;
        public string lastHash { get; }
        // konstruktors kas pieņem ceļu un faila nosaukumu kuram vajadzēs ireiķināt hesh summu
        public Sha256(string path)
        {
            this.path = path;
            file = new FileRead(path);
        }
        private void FormatData()
        {
            int hovNeead = data.Length * 8 + 72;
            if (hovNeead > 512)
            {
                if (hovNeead % 512 != 0)
                {
                    hovblocknead = (hovNeead / 512) + 1;
                }
                else
                {
                    hovblocknead = (hovNeead / 512);
                }
            }
            else { hovblocknead = 1; }
            newdata = new byte[hovblocknead * 64];
            for (int i = 0; i < data.Length; i++)
            {
                newdata[i] = data[i];
            }
            newdata[data.Length] = 128;    // visu datu beigas pievieno "1"; bitu uzliek HIGHT limeni
           ulong hovdataBits = Convert.ToUInt64(data.Length * 8);   //   __1__
            int shiftBits = 56;
            for(int i = newdata.Length - 8; i < newdata.Length; i++) //   __1__
            {
                ulong value = (hovdataBits >> shiftBits) & 0x00000000000000ff ;

                newdata[i] = Convert.ToByte(value);//101 208
                shiftBits -= 8;
            }
            //int newFileLenght = 
        }
        private void Get16Words(int bloks) // 
        {
            for(int i = 0; i < 16; i++)
            {
                for(int a = 0; a < 4; a++)                // 4 * 63 * 1
                {
                    W[i] = W[i] + Convert.ToUInt32(newdata[] << (a * 8));
                }
            }
        }

        public string GetHash()
        {
            data = file.Load(); // Nolasam visu failu un saglabājam masiva
            FormatData();       // Noformate datus blokos pa 512 bitiem un pieliek gala to kopejo garumu
           
            for (int s = 0; s < hovblocknead; s++) // apstradas blokus pa 512 bitiem
            {
                Get16Words(s);
            }
            print.PrintBinary_32(W);
            return lastHash;
        }
    }
}
