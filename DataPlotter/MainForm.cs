﻿using System;
using System.IO;
using System.Windows.Forms;
using OxyPlot;
using OxyPlot.Axes;
using OxyPlot.Series;

namespace DataPlotter
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void GenerateDataButton_Click(object sender, EventArgs e)
        {
            var save_file_dialog = new SaveFileDialog
            {
                Title = "Файл исходных данных",
                Filter = "Файлы данных (*.csv)|*.csv|Все файлы (*.*)|*.*",
                FileName = "data.csv"
            };

            if (save_file_dialog.ShowDialog() != DialogResult.OK) return;

            var selected_file = save_file_dialog.FileName;

            
            var data = Data.CreateData(x => Data.Sinc(2 * Math.PI * x), -5, 5, 0.01);

            Data.WriteDataToFile(data, selected_file);
        }

        private void ReadDataButton_Click(object sender, EventArgs e)
        {
            var open_file_dialog = new OpenFileDialog
            {
                Title = "Выбор файла данных для построения графиков",
                Filter = "Файлы данных (*.csv)|*.csv|Все файлы (*.*)|*.*",
                FileName = "data.csv"
            };

            if (open_file_dialog.ShowDialog() != DialogResult.OK) return;

            var selected_file = open_file_dialog.FileName;

            var values = Data.ReadDataFromFile(selected_file);

            PlotData(values, Path.GetFileName(selected_file));
        }

        private void PlotData(Value[] Values, string Title)
        {
            var plot_model = new PlotModel { Title = $"Данные {Title}" };

            plot_model.Axes.Add(new LinearAxis
            {
                Title = "x",
                Position = AxisPosition.Bottom,
                MajorGridlineThickness = 2,
                AxislineThickness = 2,
                MajorGridlineStyle = LineStyle.Solid,
                MinorGridlineStyle = LineStyle.Dot,
                MajorGridlineColor = OxyColors.DarkGray,
                MinorGridlineColor = OxyColors.Gray,
            });
            plot_model.Axes.Add(new LinearAxis
            {
                Title = "y",
                Position = AxisPosition.Left,
                MajorGridlineThickness = 2,
                AxislineThickness = 2,
                MajorGridlineStyle = LineStyle.Solid,
                MinorGridlineStyle = LineStyle.Dot,
                MajorGridlineColor = OxyColors.DarkGray,
                MinorGridlineColor = OxyColors.Gray,
            });

            var line = new LineSeries();
            plot_model.Series.Add(line);

            line.Color = OxyColors.Red;
            line.StrokeThickness = 2;

            for (var i = 0; i < Values.Length; i++)
                line.Points.Add(new DataPoint(Values[i].X, Values[i].Y));

            DataPlotter.Model = plot_model;
        }
    }
}
