using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using MainingVS;

namespace Benchmark
{
    [MemoryDiagnoser]
    [RankColumn]
    public class Mybanchmark
    {
        private const string path0 = "file0.txt";
        private const string path1 = "File1.txt";
        private const string path2 = "File2.txt";
        private const string path3 = "file1.txt";
       private const string path4 = "file4.jpeg";
        private byte[] data = File.ReadAllBytes(path4);

       // private readonly FileRead file = new FileRead(path4);
      private readonly  Maining maining = new Maining();
        //data = File.ReadAllBytes(path4);

        [Benchmark]
        public void test1()
        {
              byte[] data = File.ReadAllBytes(path4);
        string answer = maining.GetSha256(data);
            Console.WriteLine(answer);
        }
        



    }
}
