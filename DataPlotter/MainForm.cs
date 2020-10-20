using System;
using System.Drawing;
using System.Windows.Forms;

namespace DataPlotter
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void GenerateDataButton_Click(object sender, System.EventArgs e)
        {
            var save_file_dialog = new SaveFileDialog
            {
                Title = "Файл исходных данных",
                Filter = "Файлы данных (*.csv)|*.csv|Все файлы (*.*)|*.*",
                FileName = "data.csv"
            };

            if (save_file_dialog.ShowDialog() != DialogResult.OK) return;

            var selected_file = save_file_dialog.FileName;

        }

        private static DataPoint[] CreateData(
            Func<double, double> f,
            double Xmin, double Xmax,
            double dx
            )
        {
            var points_count = (int)((Xmax - Xmin) / dx) + 1;

            var points = new DataPoint[points_count];

            for(var i = 0; i < points_count; i++)
            {
                var x = i * dx + Xmin;
                var y = f(x);

                points[i] = new DataPoint(x, y);
            }

            return points;
        }
    }
}
