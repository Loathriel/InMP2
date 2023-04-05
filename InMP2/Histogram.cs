using OxyPlot;
using OxyPlot.Series;

namespace InMP2
{
    public partial class Histogram : Form
    {
        public Histogram(Bitmap bitmap)
        {
            InitializeComponent();

            const double minus = -0.5, plus = 0.5, width = plus - minus;

            PlotModel redModel = new PlotModel(),
                greenModel = new PlotModel(),
                blueModel = new PlotModel();

            HistogramSeries red = new HistogramSeries { FillColor = OxyColor.FromRgb(255, 0, 0) },
                green = new HistogramSeries { FillColor = OxyColor.FromRgb(0, 255, 0) },
                blue = new HistogramSeries { FillColor = OxyColor.FromRgb(0, 0, 255) };

            redModel.Series.Add(red);
            greenModel.Series.Add(green);
            blueModel.Series.Add(blue);

            redPlot.Model = redModel;
            greenPlot.Model = greenModel;
            bluePlot.Model = blueModel;

            double[] r, g, b;
            (r, g, b) = RGBCount(bitmap);

            for (int i = 0; i < 256; ++i)
            {
                double start = i + minus, end = i + plus;
                red.Items.Add(new HistogramItem(start, end, r[i] * width, 1));
                green.Items.Add(new HistogramItem(start, end, g[i] * width, 1));
                blue.Items.Add(new HistogramItem(start, end, b[i] * width, 1));
            }
        }

        public (double[], double[], double[]) RGBCount(Bitmap bitmap)
        {
            double[] red = new double[256],
                green = new double[256],
                blue = new double[256];

            for (int x = 0; x < bitmap.Width; ++x)
            {
                for (int y = 0; y < bitmap.Height; ++y)
                {
                    var pixel = bitmap.GetPixel(x, y);
                    red[pixel.R] += 1;
                    green[pixel.G] += 1;
                    blue[pixel.B] += 1;
                }
            }
            return (red, green, blue);
        }
    }
}
