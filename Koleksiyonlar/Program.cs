// See https://aka.ms/new-console-template for more information
using System.Collections.Generic;

//string[] isimler = new string[] { "Ebru", "İrem", "Semih" };
//Console.WriteLine(isimler[0]);
//Console.WriteLine(isimler[1]);
//Console.WriteLine(isimler[2]);

//isimler = new string[5];
//isimler[3] = "Nebahat";
//Console.WriteLine(isimler[3]);


List<string> isimler2 = new List<string> { "Ebru", "İrem", "Semih" };
Console.WriteLine(isimler2[0]);
Console.WriteLine(isimler2[1]);
Console.WriteLine(isimler2[2]);
isimler2.Add("Nebahat");
Console.WriteLine(isimler2[3]);
Console.WriteLine(isimler2[0]);