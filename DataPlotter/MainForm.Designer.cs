namespace DataPlotter
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.GenerateDataButton = new System.Windows.Forms.Button();
            this.ReadDataButton = new System.Windows.Forms.Button();
            this.plotView1 = new OxyPlot.WindowsForms.PlotView();
            this.SuspendLayout();
            // 
            // GenerateDataButton
            // 
            this.GenerateDataButton.Location = new System.Drawing.Point(12, 12);
            this.GenerateDataButton.Name = "GenerateDataButton";
            this.GenerateDataButton.Size = new System.Drawing.Size(170, 39);
            this.GenerateDataButton.TabIndex = 0;
            this.GenerateDataButton.Text = "Сгенерировать данные";
            this.GenerateDataButton.UseVisualStyleBackColor = true;
            this.GenerateDataButton.Click += new System.EventHandler(this.GenerateDataButton_Click);
            // 
            // ReadDataButton
            // 
            this.ReadDataButton.Location = new System.Drawing.Point(189, 13);
            this.ReadDataButton.Name = "ReadDataButton";
            this.ReadDataButton.Size = new System.Drawing.Size(193, 38);
            this.ReadDataButton.TabIndex = 1;
            this.ReadDataButton.Text = "Прочитать данные";
            this.ReadDataButton.UseVisualStyleBackColor = true;
            this.ReadDataButton.Click += new System.EventHandler(this.ReadDataButton_Click);
            // 
            // plotView1
            // 
            this.plotView1.Location = new System.Drawing.Point(12, 57);
            this.plotView1.Name = "plotView1";
            this.plotView1.PanCursor = System.Windows.Forms.Cursors.Hand;
            this.plotView1.Size = new System.Drawing.Size(599, 395);
            this.plotView1.TabIndex = 2;
            this.plotView1.Text = "plotView1";
            this.plotView1.ZoomHorizontalCursor = System.Windows.Forms.Cursors.SizeWE;
            this.plotView1.ZoomRectangleCursor = System.Windows.Forms.Cursors.SizeNWSE;
            this.plotView1.ZoomVerticalCursor = System.Windows.Forms.Cursors.SizeNS;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 482);
            this.Controls.Add(this.plotView1);
            this.Controls.Add(this.ReadDataButton);
            this.Controls.Add(this.GenerateDataButton);
            this.Name = "MainForm";
            this.Text = "Построитель графиков";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button GenerateDataButton;
        private System.Windows.Forms.Button ReadDataButton;
        private OxyPlot.WindowsForms.PlotView plotView1;
    }
}

