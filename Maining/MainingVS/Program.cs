using MainingVS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

using System.Diagnostics;
using System.Threading;



//Console.ForegroundColor = ConsoleColor.Red;   // Sarkani uzraksti
//Console.BackgroundColor = ConsoleColor.Red;     // zem burtuem
//Console.SetWindowSize(100, 50);
//Console.SetCursorPosition(100, 10);
//Console.Write("Janis");
//Console.BackgroundColor = ConsoleColor.Red;
//Console.SetCursorPosition(100, 5);
//Console.Write("Dimpens");
//Console.ReadLine();


Write write = new Write();
write.tekst[0] = "Janis";
write.krasa[0] = 1;
write.testX[0] = 20;
write.testY[0] = 10;

write.tekst[1] = "Dimpens";
write.testX[1] = 18;
write.krasa[1] = 0;
write.testY[1] = 5;

write.tekst[2] = "Kata";
write.krasa[2] = 1;
write.testX[2] = 5;
write.testY[2] = 7;

write.print();

Console.ReadLine();

//Console.BufferWidth = 100;

/*
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
*/






//Console.WriteLine(answer);



//Console.WriteLine(sha256.ComputeHash(data));
//var sha256 = SHA256.Create();

//Sha256 sha256 = new Sha256(path2);
//sha256.GetHash();
