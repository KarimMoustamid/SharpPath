// See https://aka.ms/new-console-template for more information
// using Animals;

// UnitConverter feetToInchesConverter = new UnitConverter(12);
// Console.WriteLine(feetToInchesConverter.Convert(30));
//
// public class UnitConverter
// {
//     private int ratio;
//
//     public UnitConverter(int unitRatio)
//     {
//         ratio = unitRatio;
//     }
//
//     public int Convert(int unit)
//     {
//         return ratio * unit;
//     }
// }

//
// Panda p1 = new Panda("Pan da");
// Panda p2 = new Panda("Pan di");
// Panda p3 = new Panda("Pan de");
//
//
// Console.WriteLine(p1.Name);
// Console.WriteLine(p2.Name);
//
// Console.WriteLine(Panda.Population);
//
// namespace Animals
// {
//     public class Panda
//     {
//         public string Name;
//         public static int Population;
//
//         public Panda(string name)
//         {
//             Name = name;
//             Population = Population + 1;
//         }
//     }
// }

// int x = 1234;
// long y = x;
// short z = (short)x;


// using System.Drawing;
//
// int millon = 1_000_000;
// // Point p1 = null;
// Point p1 =  new Point();
//
// p1.x = 1;
// Point p2 = p1;
// p1.x = 2;
//
// Console.WriteLine(p1.x);
// Console.WriteLine(p2.x);
//
// // public struct Point
// public class Point
// {
//     public int x, y;
// }

// Console.WriteLine (        1.0.GetType());  // Double  (double)
// Console.WriteLine (       1E06.GetType());  // Double  (double)
// Console.WriteLine (          1.GetType());  // Int32   (int)
// Console.WriteLine ( 0xF0000000.GetType());  // UInt32  (uint)
// Console.WriteLine (0x100000000.GetType());  // Int64   (long)
//

// int a = 2 / 3;      // 0
// float a = 2f / 3f;      // 0.6666667
// Console.WriteLine(a);
//
// int b = 0;
// int c = 5 / b;      // throws DivideByZeroException


// int i = int.MinValue;
// i--;
//
// Console.WriteLine(i == int.MaxValue);

// decimal d = 0.1m;
// Console.WriteLine(d + d + d + d + d + d + d + d + d + d );
//
// float f = 0.1f;
// Console.WriteLine(f + f + f + f + f + f + f + f + f + f);
// double dd = 0.1d;
// Console.WriteLine(dd +dd +dd +dd +dd +dd +dd +dd +dd + dd );
//
//
// decimal m = 1M / 6M;               // 0.1666666666666666666666666667M
// double  d = 1.0 / 6.0;             // 0.16666666666666666 This leads to accumulated rounding errors: decimal notQuiteWholeM = m+m+m+m+m+m;  // 1.0000000000000000000000000002M
// double  notQuiteWholeD = d+d+d+d+d+d;  // 0.99999999999999989
//
//
// bitArray[] a = new bitArray[];

char c = 'A';
int num = c; // Implicit conversion from char to int
Console.WriteLine(num);