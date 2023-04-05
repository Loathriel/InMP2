using InMP2.Operators;

namespace InMP2.Extensions
{
    public static class BitmapExtensions
    {
        public static Bitmap ApplyOperator(this Bitmap bitmap, Operator @operator, bool grayscale = true)
        {
            int[,] xFilterMatrix = @operator.GetHorizontalMatrix();
            int[,] yFilterMatrix = @operator.GetVerticalMatrix();

            var result = new Bitmap(bitmap.Width, bitmap.Height);
            var rStorage = new double[bitmap.Width, bitmap.Height];
            var gStorage = new double[bitmap.Width, bitmap.Height];
            var bStorage = new double[bitmap.Width, bitmap.Height];
            double rmin, gmin, bmin;
            double rmax, gmax, bmax;
            rmin = gmin = bmin = double.MaxValue;
            rmax = gmax = bmax = double.MinValue;
            for (var x = 1; x < bitmap.Width - 1; ++x)
            {
                for (var y = 1; y < bitmap.Height - 1; ++y)
                {
                    var pixelMatrix = bitmap.GetPixelMatrix(x, y, xFilterMatrix.GetLength(0));
                    (rStorage[x, y - 1], gStorage[x, y - 1], bStorage[x, y - 1]) = 
                        Transformations.ScalarDistance(pixelMatrix, xFilterMatrix, yFilterMatrix, grayscale);

                    if (rStorage[x, y - 1] < rmin) rmin = rStorage[x, y - 1];
                    if (rStorage[x, y - 1] > rmax) rmax = rStorage[x, y - 1];
                    if (gStorage[x, y - 1] < gmin) gmin = gStorage[x, y - 1];
                    if (gStorage[x, y - 1] > gmax) gmax = gStorage[x, y - 1];
                    if (bStorage[x, y - 1] < bmin) bmin = bStorage[x, y - 1];
                    if (bStorage[x, y - 1] > bmax) bmax = bStorage[x, y - 1];
                }
            }

            for (var x = 1; x < bitmap.Width - 1; ++x)
            {
                for (var y = 1; y < bitmap.Height - 2; ++y)
                {
                    var normilizedR = rStorage[x, y].Normalize(rmin, rmax, 255);
                    var normilizedG = gStorage[x, y].Normalize(gmin, gmax, 255);
                    var normilizedB = bStorage[x, y].Normalize(bmin, bmax, 255);
                    result.SetPixel(x, y, Color.FromArgb(normilizedR, normilizedG, normilizedB));
                }
            }

            return result;
        }
        public static Bitmap Equalize(this Bitmap bitmap)
        {
            var (redPixelsCount, greenPixelsCount, bluePixelsCount) = bitmap.CountChanels();
            var result = new Bitmap(bitmap.Width, bitmap.Height);

            for (var i = 0; i < result.Width; ++i)
            {
                for (var j = 0; j < result.Height; ++j)
                {
                    var currentPixel = bitmap.GetPixel(i, j);
                    result.SetPixel(i, j,
                        Color.FromArgb((int)(redPixelsCount[currentPixel.R] * 255),
                                       (int)(greenPixelsCount[currentPixel.G] * 255),
                                       (int)(bluePixelsCount[currentPixel.B] * 255)));
                }
            }

            return result;
        }

        public static (double[] r, double[] g, double[] b) CountChanels(this Bitmap image)
        {
            var (r, g, b) = (new double[256], new double[256], new double[256]);
            var totalPixelsAmount = image.Width * image.Height;

            for (var i = 0; i < image.Width; ++i)
            {
                for (var j = 0; j < image.Height; ++j)
                {
                    var currentPixel = image.GetPixel(i, j);
                    r[currentPixel.R] += 1d / totalPixelsAmount;
                    g[currentPixel.G] += 1d / totalPixelsAmount;
                    b[currentPixel.B] += 1d / totalPixelsAmount;
                }
            }

            for (var i = 1; i < 256; ++i)
            {
                r[i] = r[i - 1] + r[i];
                g[i] = g[i - 1] + g[i];
                b[i] = b[i - 1] + b[i];
            }
            return (r, g, b);
        }
        public static Color[,] GetPixelMatrix(this Bitmap image, int x, int y, int size)
        {
            return size switch
            {
                2 => GetTwoMatrix(image, x, y),
                3 => GetThreeMatrix(image, x, y),
                _ => GetEmptyMatrix(),
            };
        }

        private static Color[,] GetEmptyMatrix()
            => new Color[,] { };

        private static Color[,] GetTwoMatrix(Bitmap image, int x, int y)
            => new Color[,]
            {
                { image.GetPixel(x-1, y-1), image.GetPixel(x, y-1)},
                { image.GetPixel(x-1, y), image.GetPixel(x, y) }
            };

        private static Color[,] GetThreeMatrix(Bitmap image, int x, int y)
            => new Color[,]
            {
                { image.GetPixel(x-1, y-1), image.GetPixel(x, y-1), image.GetPixel(x+1, y-1)},
                { image.GetPixel(x-1, y), image.GetPixel(x, y), image.GetPixel(x+1, y) },
                { image.GetPixel(x-1, y+1), image.GetPixel(x, y+1), image.GetPixel(x+1, y+1) }
            };
        private static Color[,] GetFiveMatrix(Bitmap image, int x, int y)
            => new Color[,]
            {
                { image.GetPixel(x-2,y-2), image.GetPixel(x-1,y-2), image.GetPixel(x, y-2), image.GetPixel(x+1,y-2), image.GetPixel(x+2,y-2) },
                { image.GetPixel(x-2, y-1), image.GetPixel(x-1, y-1), image.GetPixel(x, y-1), image.GetPixel(x+1, y-1), image.GetPixel(x+2, y-1) },
                { image.GetPixel(x-2,y),image.GetPixel(x-1, y), image.GetPixel(x, y), image.GetPixel(x+1, y), image.GetPixel(x+2,y) },
                { image.GetPixel(x-2,y+1),image.GetPixel(x-1, y+1), image.GetPixel(x, y+1), image.GetPixel(x+1, y+1),image.GetPixel(x+2,y+1) },
                { image.GetPixel(x-2,y+2),image.GetPixel(x-1, y+2), image.GetPixel(x, y+2), image.GetPixel(x+1, y+2),image.GetPixel(x+2,y+2) }
            };
    }
}
