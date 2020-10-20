using System;
using System.Drawing;
using System.IO;
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

            
            var data = Data.CreateData(x => Data.Sinc(2 * Math.PI * x), -5, 5, 0.1);

            Data.WriteDataToFile(data, selected_file);
        }

        
    }
}
