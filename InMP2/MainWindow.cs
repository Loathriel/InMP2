using InMP2.Operators;
using InMP2.Extensions;

namespace InMP2
{
    public partial class MainWindow : Form
    {
        Bitmap image, transformed;
        public MainWindow()
        {
            InitializeComponent();
            openFileDialog.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialog.InitialDirectory = Directory.GetCurrentDirectory();
        }

        private void openFileButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() != DialogResult.OK)
                return;
            if (image != null)
            {
                image.Dispose();
            }
            openFileDialog.InitialDirectory = Path.GetDirectoryName(openFileDialog.FileName);
            image = new Bitmap(openFileDialog.FileName);
            originalBox.Image = image;
        }

        private void transformButton_Click(object sender, EventArgs e)
        {
            transformed = Change();
            transformedBox.Image = transformed;
        }

        private Bitmap Change()
        {
            if (equalizeButton.Checked == true)
                return image.Equalize();
            if (RobertsButton.Checked == true)
                return image.ApplyOperator(new RobertsOperator(), grayscaleCheck.Checked);
            if (PrewittButton.Checked == true)
                return image.ApplyOperator(new PrewittOperator(), grayscaleCheck.Checked);
            if (SobelButton.Checked == true)
                return image.ApplyOperator(new SobelOperator(), grayscaleCheck.Checked);
            return image;
        }

        private void histogramOriginal_Click(object sender, EventArgs e)
        {
            if (image == null)
            {
                MessageBox.Show("Open an image file first", "Error");
                return;
            }
            new Histogram(image).Show();
        }

        private void saveFileButton_Click(object sender, EventArgs e)
        {
            if (transformed == null)
            {
                MessageBox.Show("Perform a transformation first", "Error");
                return;
            }
            if (saveFileDialog.ShowDialog() != DialogResult.OK)
                return;
            saveFileDialog.InitialDirectory = Path.GetDirectoryName(saveFileDialog.FileName);
            transformed.Save(saveFileDialog.FileName);
        }

        private void histogramTransformed_Click(object sender, EventArgs e)
        {
            if (transformed == null)
            {
                MessageBox.Show("Perform a transformation first", "Error");
                return;
            }
            new Histogram(transformed).Show();
        }
    }
}