using CoinInterchanger.Views;
using CoinInterchanger.Views.Windows;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace CoinInterchanger
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
			//double a1 = 0, a2 = 0, a3 = 0, a4 = 0;
			//for (int j = 0; j < 60; j++)
			//{
			//    int seed = 1234567890, sum = int.MinValue;
			//    long t1, t2, t3, t4;
			//    Stopwatch sw = Stopwatch.StartNew();
			//    for (int i = 0; i < 100000000; i++)
			//    {
			//        var (a, b, c) = GetTuple(seed);
			//        sum += a + b + c;
			//    }
			//    t1 = sw.ElapsedMilliseconds;
			//    sw.Restart();
			//    for (int i = 0; i < 100000000; i++)
			//    {
			//        var point = GetPoint(seed);
			//        sum += point.X + point.Y + point.Z;
			//    }
			//    t2 = sw.ElapsedMilliseconds;
			//    sw.Restart();
			//    for (int i = 0; i < 100000000; i++)
			//    {
			//        int a, b, c;
			//        GetOut(seed, out a, out b, out c);
			//        sum += a + b + c;
			//    }
			//    t3 = sw.ElapsedMilliseconds;
			//    sw.Restart();
			//    for (int i = 0; i < 100000000; i++)
			//    {
			//        int a = 0, b = 0, c = 0;
			//        GetRef(seed, ref a, ref b, ref c);
			//        sum += a + b + c;
			//    }
			//    t4 = sw.ElapsedMilliseconds;
			//    Console.WriteLine(sum);
			//    Console.WriteLine($"Test {j}: {t1} {t2} {t3} {t4}------------------------------------------");
			//    a1 += t1;
			//    a2 += t2;
			//    a3 += t3;
			//    a4 += t4;
			//}
			//a1 /= 60;
			//a2 /= 60;
			//a3 /= 60;
			//a4 /= 60;
			//Console.WriteLine($"{a1} {a2} {a3} {a4}");


			Current.MainWindow = new BaseWindow();
			//Current.MainWindow = new TestWindow();
			Current.MainWindow.Show();
        }

        private (int, int, int) GetTuple(int seed)
        {
            return (0, 1, 2);
        }

        private Point GetPoint(int seed)
        {
            return new Point(0, 1, 2);
        }

        private void GetOut(int seed, out int x, out int y, out int z)
        {
            x = 0;
            y = 1;
            z = 2;
        }

        private void GetRef(int seed, ref int x, ref int y, ref int z)
        {
            x = 0;
            y = 1;
            z = 2;
        }

        private struct Point
        {
            public Point(int x, int y, int z)
            {
                X = x;
                Y = y;
                Z = z;
            }

            public int X { get; set; }
            public int Y { get; set; }
            public int Z { get; set; }
        }
    }

}
