// See https://aka.ms/new-console-template for more information
using SolidSampel;

Console.WriteLine("Hello, World!\n Here is our program to converet the number");
NumberConverter converter = new NumberConverter(new Logger(),new Reader());
converter.Convert();
