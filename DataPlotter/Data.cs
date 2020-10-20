using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Diagnostics;

namespace DataPlotter
{
    internal static class Data
    {
        /// <summary>Читает файл данных и возвращает массив точек, содержащийся в нём</summary>
        /// <param name="FileName">Имя файла для чтения</param>
        /// <returns>Массив прочитанных точек</returns>
        /// <exception cref="FileNotFoundException">если файл не найден</exception>
        public static Value[] ReadDataFromFile(string FileName)
        {
            if (!File.Exists(FileName))
                throw new FileNotFoundException("Файл данных не найден", FileName);

            var points = GetPoints(FileName).ToArray();
            return points;
        }

        private static IEnumerable<Value> GetPoints(string FileName, int HeaderLinesCount = 1)
        {
            if (HeaderLinesCount < 0)
                throw new ArgumentOutOfRangeException(
                    "HeaderLinesCount",
                    "Число строк заголовка должно быть больше, либо равно 0");

            if (!File.Exists(FileName))
                throw new FileNotFoundException("Файл данных не найден", FileName);

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

                    var point = new Value(x, y);

                    yield return point;
                }
            }
        }

        public static void WriteDataToFile(Value[] Points, string FileName)
        {
            if (Points == null)
                throw new ArgumentNullException(nameof(Points));
            if (FileName is null)
                throw new ArgumentNullException(nameof(FileName));

            if (!File.Exists(FileName))
                throw new FileNotFoundException("Файл данных не найден", FileName);

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

        /// <summary>Функция создаёт массив данных для указанной функции</summary>
        /// <param name="f">Исследуемая функция</param>
        /// <param name="Xmin">Минимум области определения</param>
        /// <param name="Xmax">Максимум области определения</param>
        /// <param name="dx">Шаг расчёта значений функции</param>
        /// <returns>Массив вычисленных значений в точках</returns>
        /// <exception cref="InvalidOperationException">В случае если Xmin больше, либо равно Xmax</exception>
        /// <exception cref="ArgumentOutOfRangeException">если dx меньше, либо равен 0</exception>
        public static Value[] CreateData(
            Func<double, double> f,
            double Xmin, double Xmax,
            double dx
        )
        {
            //if (Xmin >= Xmax)
            //    throw new Exception("Ошибка области определения функции");

            if (Xmin >= Xmax)
                throw new InvalidOperationException("Перепутаны значения интервала области определения функции");

            if (dx <= 0)
                throw new ArgumentOutOfRangeException(nameof(dx), dx, "Значение шага dx должно быть больше 0");

            var points_count = (int)((Xmax - Xmin) / dx) + 1;

            var points = new Value[points_count];

            for (var i = 0; i < points_count; i++)
            {
                var x = i * dx + Xmin;
                var y = f(x);

                points[i] = new Value(x, y);
            }

            return points;
        }

        private static double[] GetFileStrings(string FileName)
        {
            if (string.IsNullOrWhiteSpace(FileName))
                throw new ArgumentException("Не указано имя файла");
            if (!File.Exists(FileName))
                throw new FileNotFoundException("Не найден указанный файл данных", FileName);

            var values = new List<double>();

            var reader = new StreamReader(FileName);

            try
            {
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var value = double.Parse(line);
                    values.Add(value);
                }
            }
            catch (FormatException error)
            {
                //Debug.WriteLine(error);   // Вывод информации в окно отладки Студии
                //Console.WriteLine(error);
                Trace.WriteLine(error);     // Вывод данных в систему трассировки событий приложения

                //throw; // Перезапуск исключения после внесения информации о нём в журнал

                // Создаём "обёртку" - исключение, в которое добавляем всю нужную нам информацию
                // и перехваченное иселючение, как причину нового генерируемого исключения
                throw new InvalidOperationException($"Ошибка формата файла данных {FileName}", error);
            }
            finally
            {
                //reader.Close();
                reader.Dispose();
            }

            //// Конструкция using
            //using (var file = File.OpenText(FileName))
            //{
            //    while(!file.EndOfStream)
            //        Console.WriteLine(file.ReadLine());
            //}

            //// Преобразуется компилятором в следующий код:
            //StreamReader file = null;
            //try
            //{
            //    file = File.OpenText(FileName);
            //    while (!file.EndOfStream)
            //        Console.WriteLine(file.ReadLine());
            //}
            //finally
            //{
            //    if(file != null)
            //        file.Dispose();
            //}

            return values.ToArray();
        }
    }
}
