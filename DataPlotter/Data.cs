﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace DataPlotter
{
    internal static class Data
    {
        public static DataPoint[] ReadDataFromFile(string FileName)
        {
            var points = GetPoints(FileName).ToArray();
            return points;
        }

        private static IEnumerable<DataPoint> GetPoints(string FileName, int HeaderLinesCount = 1)
        {
            using (var file = File.OpenText(FileName))
            {
                for (var i = 0; i < HeaderLinesCount && !file.EndOfStream; i++)
                    file.ReadLine();

                while (!file.EndOfStream)
                {
                    var line = file.ReadLine();

                    //if(line.Length == 0) continue;
                    //if(line == null || line.Length == 0) continue;
                    if(string.IsNullOrEmpty(line)) continue;

                    var xy_str = line.Split(';');

                    if(xy_str.Length < 2) continue;

                    var x = double.Parse(xy_str[0]);
                    var y = double.Parse(xy_str[1]);

                    var point = new DataPoint(x, y);

                    yield return point;
                }
            }
        }

        public static void WriteDataToFile(DataPoint[] Points, string FileName)
        {
            using (var file = File.CreateText(FileName))
            {
                file.WriteLine("x;f(x)");

                for (var i = 0; i < Points.Length; i++)
                {
                    file.WriteLine("{0};{1}", Points[i].X, Points[i].Y);
                }
            }
        }

        public static double Sinc(double x)
        {
            if (x == 0) return 1;
            return Math.Sin(x) / x;
        }

        public static DataPoint[] CreateData(
            Func<double, double> f,
            double Xmin, double Xmax,
            double dx
        )
        {
            var points_count = (int)((Xmax - Xmin) / dx) + 1;

            var points = new DataPoint[points_count];

            for (var i = 0; i < points_count; i++)
            {
                var x = i * dx + Xmin;
                var y = f(x);

                points[i] = new DataPoint(x, y);
            }

            return points;
        }
    }
}
