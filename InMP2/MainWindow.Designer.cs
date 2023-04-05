namespace InMP2
{
    partial class MainWindow
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
            this.originalBox = new System.Windows.Forms.PictureBox();
            this.openFileButton = new System.Windows.Forms.Button();
            this.transformedBox = new System.Windows.Forms.PictureBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.applyTransformButton = new System.Windows.Forms.Button();
            this.equalizeButton = new System.Windows.Forms.RadioButton();
            this.RobertsButton = new System.Windows.Forms.RadioButton();
            this.PrewittButton = new System.Windows.Forms.RadioButton();
            this.SobelButton = new System.Windows.Forms.RadioButton();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.histogramOrigButton = new System.Windows.Forms.Button();
            this.histogramCopyButton = new System.Windows.Forms.Button();
            this.saveFileButton = new System.Windows.Forms.Button();
            this.grayscaleCheck = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.originalBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transformedBox)).BeginInit();
            this.SuspendLayout();
            // 
            // originalBox
            // 
            this.originalBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.originalBox.Location = new System.Drawing.Point(12, 12);
            this.originalBox.Name = "originalBox";
            this.originalBox.Size = new System.Drawing.Size(500, 500);
            this.originalBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.originalBox.TabIndex = 0;
            this.originalBox.TabStop = false;
            // 
            // openFileButton
            // 
            this.openFileButton.Location = new System.Drawing.Point(141, 518);
            this.openFileButton.Name = "openFileButton";
            this.openFileButton.Size = new System.Drawing.Size(75, 38);
            this.openFileButton.TabIndex = 1;
            this.openFileButton.Text = "Open file";
            this.openFileButton.UseVisualStyleBackColor = true;
            this.openFileButton.Click += new System.EventHandler(this.openFileButton_Click);
            // 
            // transformedBox
            // 
            this.transformedBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.transformedBox.Location = new System.Drawing.Point(660, 12);
            this.transformedBox.Name = "transformedBox";
            this.transformedBox.Size = new System.Drawing.Size(500, 500);
            this.transformedBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.transformedBox.TabIndex = 2;
            this.transformedBox.TabStop = false;
            // 
            // applyTransformButton
            // 
            this.applyTransformButton.Location = new System.Drawing.Point(544, 350);
            this.applyTransformButton.Name = "applyTransformButton";
            this.applyTransformButton.Size = new System.Drawing.Size(75, 23);
            this.applyTransformButton.TabIndex = 3;
            this.applyTransformButton.Text = "Transform";
            this.applyTransformButton.UseVisualStyleBackColor = true;
            this.applyTransformButton.Click += new System.EventHandler(this.transformButton_Click);
            // 
            // equalizeButton
            // 
            this.equalizeButton.AutoSize = true;
            this.equalizeButton.Checked = true;
            this.equalizeButton.Location = new System.Drawing.Point(530, 250);
            this.equalizeButton.Name = "equalizeButton";
            this.equalizeButton.Size = new System.Drawing.Size(100, 19);
            this.equalizeButton.TabIndex = 4;
            this.equalizeButton.TabStop = true;
            this.equalizeButton.Text = "Equalize Color";
            this.equalizeButton.UseVisualStyleBackColor = true;
            // 
            // RobertsButton
            // 
            this.RobertsButton.AutoSize = true;
            this.RobertsButton.Location = new System.Drawing.Point(530, 275);
            this.RobertsButton.Name = "RobertsButton";
            this.RobertsButton.Size = new System.Drawing.Size(115, 19);
            this.RobertsButton.TabIndex = 5;
            this.RobertsButton.Text = "Roberts Operator";
            this.RobertsButton.UseVisualStyleBackColor = true;
            // 
            // PrewittButton
            // 
            this.PrewittButton.AutoSize = true;
            this.PrewittButton.Location = new System.Drawing.Point(530, 300);
            this.PrewittButton.Name = "PrewittButton";
            this.PrewittButton.Size = new System.Drawing.Size(112, 19);
            this.PrewittButton.TabIndex = 6;
            this.PrewittButton.Text = "Prewitt Operator";
            this.PrewittButton.UseVisualStyleBackColor = true;
            // 
            // SobelButton
            // 
            this.SobelButton.AutoSize = true;
            this.SobelButton.Location = new System.Drawing.Point(530, 325);
            this.SobelButton.Name = "SobelButton";
            this.SobelButton.Size = new System.Drawing.Size(104, 19);
            this.SobelButton.TabIndex = 7;
            this.SobelButton.Text = "Sobel Operator";
            this.SobelButton.UseVisualStyleBackColor = true;
            // 
            // histogramOrigButton
            // 
            this.histogramOrigButton.Location = new System.Drawing.Point(307, 518);
            this.histogramOrigButton.Name = "histogramOrigButton";
            this.histogramOrigButton.Size = new System.Drawing.Size(75, 38);
            this.histogramOrigButton.TabIndex = 8;
            this.histogramOrigButton.Text = "Build Histogram";
            this.histogramOrigButton.UseVisualStyleBackColor = true;
            this.histogramOrigButton.Click += new System.EventHandler(this.histogramOriginal_Click);
            // 
            // histogramCopyButton
            // 
            this.histogramCopyButton.Location = new System.Drawing.Point(789, 518);
            this.histogramCopyButton.Name = "histogramCopyButton";
            this.histogramCopyButton.Size = new System.Drawing.Size(75, 38);
            this.histogramCopyButton.TabIndex = 9;
            this.histogramCopyButton.Text = "Build Histogram";
            this.histogramCopyButton.UseVisualStyleBackColor = true;
            this.histogramCopyButton.Click += new System.EventHandler(this.histogramTransformed_Click);
            // 
            // saveFileButton
            // 
            this.saveFileButton.Location = new System.Drawing.Point(955, 518);
            this.saveFileButton.Name = "saveFileButton";
            this.saveFileButton.Size = new System.Drawing.Size(75, 38);
            this.saveFileButton.TabIndex = 10;
            this.saveFileButton.Text = "Save file";
            this.saveFileButton.UseVisualStyleBackColor = true;
            this.saveFileButton.Click += new System.EventHandler(this.saveFileButton_Click);
            // 
            // grayscaleCheck
            // 
            this.grayscaleCheck.AutoSize = true;
            this.grayscaleCheck.Checked = true;
            this.grayscaleCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.grayscaleCheck.Location = new System.Drawing.Point(527, 388);
            this.grayscaleCheck.Name = "grayscaleCheck";
            this.grayscaleCheck.Size = new System.Drawing.Size(115, 34);
            this.grayscaleCheck.TabIndex = 11;
            this.grayscaleCheck.Text = "Operators make \npicture grayscale";
            this.grayscaleCheck.UseVisualStyleBackColor = true;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1172, 587);
            this.Controls.Add(this.grayscaleCheck);
            this.Controls.Add(this.saveFileButton);
            this.Controls.Add(this.histogramCopyButton);
            this.Controls.Add(this.histogramOrigButton);
            this.Controls.Add(this.SobelButton);
            this.Controls.Add(this.PrewittButton);
            this.Controls.Add(this.RobertsButton);
            this.Controls.Add(this.equalizeButton);
            this.Controls.Add(this.applyTransformButton);
            this.Controls.Add(this.transformedBox);
            this.Controls.Add(this.openFileButton);
            this.Controls.Add(this.originalBox);
            this.Name = "MainWindow";
            this.Text = "Main Window";
            ((System.ComponentModel.ISupportInitialize)(this.originalBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transformedBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox originalBox;
        private Button openFileButton;
        private PictureBox transformedBox;
        private OpenFileDialog openFileDialog;
        private Button applyTransformButton;
        private RadioButton equalizeButton;
        private RadioButton RobertsButton;
        private RadioButton PrewittButton;
        private RadioButton SobelButton;
        private SaveFileDialog saveFileDialog;
        private Button histogramOrigButton;
        private Button histogramCopyButton;
        private Button saveFileButton;
        private CheckBox grayscaleCheck;
    }
}