using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace MainingVS
{
    public class Maining
    {
        
        SHA256 sha256 = new SHA256CryptoServiceProvider();
        private byte[] result;
        public string answer { get;}
        public string GetSha256(byte[] data)
        {
            result = sha256.ComputeHash(data);
            string answer = "";
            for (int i = 0; i < result.Length; i++)
            {

                
                answer = answer + Convert.ToString(result[i], toBase: 16);
            }


            return answer;
        }

    }
}
