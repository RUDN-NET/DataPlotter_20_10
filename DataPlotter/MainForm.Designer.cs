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
            this.DataPlotter = new OxyPlot.WindowsForms.PlotView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dxEdit = new System.Windows.Forms.NumericUpDown();
            this.XminEdit = new System.Windows.Forms.NumericUpDown();
            this.XmaxEdit = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.dxEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.XminEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.XmaxEdit)).BeginInit();
            this.SuspendLayout();
            // 
            // GenerateDataButton
            // 
            this.GenerateDataButton.Location = new System.Drawing.Point(12, 12);
            this.GenerateDataButton.Name = "GenerateDataButton";
            this.GenerateDataButton.Size = new System.Drawing.Size(147, 39);
            this.GenerateDataButton.TabIndex = 0;
            this.GenerateDataButton.Text = "Сгенерировать данные";
            this.GenerateDataButton.UseVisualStyleBackColor = true;
            this.GenerateDataButton.Click += new System.EventHandler(this.GenerateDataButton_Click);
            // 
            // ReadDataButton
            // 
            this.ReadDataButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ReadDataButton.Location = new System.Drawing.Point(530, 12);
            this.ReadDataButton.Name = "ReadDataButton";
            this.ReadDataButton.Size = new System.Drawing.Size(128, 38);
            this.ReadDataButton.TabIndex = 1;
            this.ReadDataButton.Text = "Прочитать данные";
            this.ReadDataButton.UseVisualStyleBackColor = true;
            this.ReadDataButton.Click += new System.EventHandler(this.ReadDataButton_Click);
            // 
            // DataPlotter
            // 
            this.DataPlotter.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataPlotter.Location = new System.Drawing.Point(12, 57);
            this.DataPlotter.Name = "DataPlotter";
            this.DataPlotter.PanCursor = System.Windows.Forms.Cursors.Hand;
            this.DataPlotter.Size = new System.Drawing.Size(646, 413);
            this.DataPlotter.TabIndex = 2;
            this.DataPlotter.Text = "plotView1";
            this.DataPlotter.ZoomHorizontalCursor = System.Windows.Forms.Cursors.SizeWE;
            this.DataPlotter.ZoomRectangleCursor = System.Windows.Forms.Cursors.SizeNWSE;
            this.DataPlotter.ZoomVerticalCursor = System.Windows.Forms.Cursors.SizeNS;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(166, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Xmin";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(236, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Xmax";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(312, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "dx";
            // 
            // dxEdit
            // 
            this.dxEdit.DecimalPlaces = 2;
            this.dxEdit.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.dxEdit.Location = new System.Drawing.Point(312, 27);
            this.dxEdit.Name = "dxEdit";
            this.dxEdit.Size = new System.Drawing.Size(68, 23);
            this.dxEdit.TabIndex = 6;
            this.dxEdit.Value = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            // 
            // XminEdit
            // 
            this.XminEdit.Location = new System.Drawing.Point(166, 27);
            this.XminEdit.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.XminEdit.Name = "XminEdit";
            this.XminEdit.Size = new System.Drawing.Size(64, 23);
            this.XminEdit.TabIndex = 7;
            this.XminEdit.Value = new decimal(new int[] {
            5,
            0,
            0,
            -2147483648});
            // 
            // XmaxEdit
            // 
            this.XmaxEdit.Location = new System.Drawing.Point(236, 27);
            this.XmaxEdit.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.XmaxEdit.Name = "XmaxEdit";
            this.XmaxEdit.Size = new System.Drawing.Size(70, 23);
            this.XmaxEdit.TabIndex = 8;
            this.XmaxEdit.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 482);
            this.Controls.Add(this.XmaxEdit);
            this.Controls.Add(this.XminEdit);
            this.Controls.Add(this.dxEdit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DataPlotter);
            this.Controls.Add(this.ReadDataButton);
            this.Controls.Add(this.GenerateDataButton);
            this.Name = "MainForm";
            this.Text = "Построитель графиков";
            ((System.ComponentModel.ISupportInitialize)(this.dxEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.XminEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.XmaxEdit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button GenerateDataButton;
        private System.Windows.Forms.Button ReadDataButton;
        private OxyPlot.WindowsForms.PlotView DataPlotter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown dxEdit;
        private System.Windows.Forms.NumericUpDown XminEdit;
        private System.Windows.Forms.NumericUpDown XmaxEdit;
    }
}

