namespace InMP2
{
    partial class Histogram
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.redPage = new System.Windows.Forms.TabPage();
            this.redPlot = new OxyPlot.WindowsForms.PlotView();
            this.greenPage = new System.Windows.Forms.TabPage();
            this.greenPlot = new OxyPlot.WindowsForms.PlotView();
            this.bluePage = new System.Windows.Forms.TabPage();
            this.bluePlot = new OxyPlot.WindowsForms.PlotView();
            this.tabControl1.SuspendLayout();
            this.redPage.SuspendLayout();
            this.greenPage.SuspendLayout();
            this.bluePage.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.redPage);
            this.tabControl1.Controls.Add(this.greenPage);
            this.tabControl1.Controls.Add(this.bluePage);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(624, 381);
            this.tabControl1.TabIndex = 0;
            // 
            // redPage
            // 
            this.redPage.Controls.Add(this.redPlot);
            this.redPage.Location = new System.Drawing.Point(4, 24);
            this.redPage.Name = "redPage";
            this.redPage.Padding = new System.Windows.Forms.Padding(3);
            this.redPage.Size = new System.Drawing.Size(616, 353);
            this.redPage.TabIndex = 0;
            this.redPage.Text = "Red";
            this.redPage.UseVisualStyleBackColor = true;
            // 
            // redPlot
            // 
            this.redPlot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.redPlot.Location = new System.Drawing.Point(3, 3);
            this.redPlot.Name = "redPlot";
            this.redPlot.PanCursor = System.Windows.Forms.Cursors.Hand;
            this.redPlot.Size = new System.Drawing.Size(610, 347);
            this.redPlot.TabIndex = 1;
            this.redPlot.Text = "plotView1";
            this.redPlot.ZoomHorizontalCursor = System.Windows.Forms.Cursors.SizeWE;
            this.redPlot.ZoomRectangleCursor = System.Windows.Forms.Cursors.SizeNWSE;
            this.redPlot.ZoomVerticalCursor = System.Windows.Forms.Cursors.SizeNS;
            // 
            // greenPage
            // 
            this.greenPage.Controls.Add(this.greenPlot);
            this.greenPage.Location = new System.Drawing.Point(4, 24);
            this.greenPage.Name = "greenPage";
            this.greenPage.Size = new System.Drawing.Size(876, 653);
            this.greenPage.TabIndex = 2;
            this.greenPage.Text = "Green";
            this.greenPage.UseVisualStyleBackColor = true;
            // 
            // greenPlot
            // 
            this.greenPlot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.greenPlot.Location = new System.Drawing.Point(0, 0);
            this.greenPlot.Name = "greenPlot";
            this.greenPlot.PanCursor = System.Windows.Forms.Cursors.Hand;
            this.greenPlot.Size = new System.Drawing.Size(876, 653);
            this.greenPlot.TabIndex = 0;
            this.greenPlot.Text = "plotView1";
            this.greenPlot.ZoomHorizontalCursor = System.Windows.Forms.Cursors.SizeWE;
            this.greenPlot.ZoomRectangleCursor = System.Windows.Forms.Cursors.SizeNWSE;
            this.greenPlot.ZoomVerticalCursor = System.Windows.Forms.Cursors.SizeNS;
            // 
            // bluePage
            // 
            this.bluePage.Controls.Add(this.bluePlot);
            this.bluePage.Location = new System.Drawing.Point(4, 24);
            this.bluePage.Name = "bluePage";
            this.bluePage.Padding = new System.Windows.Forms.Padding(3);
            this.bluePage.Size = new System.Drawing.Size(876, 653);
            this.bluePage.TabIndex = 1;
            this.bluePage.Text = "Blue";
            this.bluePage.UseVisualStyleBackColor = true;
            // 
            // bluePlot
            // 
            this.bluePlot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bluePlot.Location = new System.Drawing.Point(3, 3);
            this.bluePlot.Name = "bluePlot";
            this.bluePlot.PanCursor = System.Windows.Forms.Cursors.Hand;
            this.bluePlot.Size = new System.Drawing.Size(870, 647);
            this.bluePlot.TabIndex = 0;
            this.bluePlot.Text = "plotView1";
            this.bluePlot.ZoomHorizontalCursor = System.Windows.Forms.Cursors.SizeWE;
            this.bluePlot.ZoomRectangleCursor = System.Windows.Forms.Cursors.SizeNWSE;
            this.bluePlot.ZoomVerticalCursor = System.Windows.Forms.Cursors.SizeNS;
            // 
            // Histogram
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 381);
            this.Controls.Add(this.tabControl1);
            this.Name = "Histogram";
            this.Text = "Histogram";
            this.tabControl1.ResumeLayout(false);
            this.redPage.ResumeLayout(false);
            this.greenPage.ResumeLayout(false);
            this.bluePage.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabControl1;
        private TabPage redPage;
        private OxyPlot.WindowsForms.PlotView redPlot;
        private TabPage bluePage;
        private OxyPlot.WindowsForms.PlotView bluePlot;
        private TabPage greenPage;
        private OxyPlot.WindowsForms.PlotView greenPlot;
    }
}