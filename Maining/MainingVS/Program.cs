using MainingVS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

using System.Diagnostics;
using System.Threading;



string path0 = "file0.txt";
  string path1 = "File1.txt";
  string path2 = "File2.txt";
string path3 = "file1.txt";
string path4 = "file4.jpeg";
FileRead file = new FileRead(path4);
byte[] data = file.Load();
string answer = "";

Maining maining = new Maining();

Stopwatch stopWatch = new Stopwatch();
stopWatch.Start();

for (int i = 0; i < 100; i++)
{
   // Thread.Sleep(10000);
    answer = maining.GetSha256(data);
}

stopWatch.Stop();

TimeSpan ts = stopWatch.Elapsed;
string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
            ts.Hours, ts.Minutes, ts.Seconds,
            ts.Milliseconds / 10);
Console.WriteLine("RunTime " + elapsedTime);
Console.WriteLine(answer);
//Console.WriteLine(answer);



//Console.WriteLine(sha256.ComputeHash(data));
//var sha256 = SHA256.Create();

//Sha256 sha256 = new Sha256(path2);
//sha256.GetHash();
