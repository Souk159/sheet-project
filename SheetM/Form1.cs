using Emgu.CV.Structure;
using Emgu.CV;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Emgu.CV.Util;

namespace SheetM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnProcessImage_Click(object sender, EventArgs e)
        {
            //Image<Bgr, byte> correctAnswersImage = new Image<Bgr, byte>(@"../../ims/correct_answers20.png");
            //Image<Bgr, byte> toCompareImage = new Image<Bgr, byte>(@"../../ims/to_compare20.png");

            var correctAnswersImage = new Image<Bgr, byte>(@"../../ims/C1T.png");
            var toCompareImage = new Image<Bgr, byte>(@"../../ims/toC2.png");

            // Display images
            pictureBoxCorrectAnswers.Image = correctAnswersImage.ToBitmap();
            pictureBoxAnswersToCompare.Image = toCompareImage.ToBitmap();

            // Process and compare images
            int correctAnswersCount;
            var resultImage = CompareAnswers(correctAnswersImage, toCompareImage, out correctAnswersCount);

            // Calculate the score
            int maxQuestions = 10; // Assuming there are 10 questions
            int score = (correctAnswersCount * 100) / maxQuestions;

            // Display result
            pictureBoxResult.Image = resultImage.ToBitmap();
            labelCorrectAnswers.Text = $"Correct Answers: {correctAnswersCount}";
            labelScore.Text = $"Score: {score}/100";
        }
        private Image<Bgr, byte> CompareAnswers(Image<Bgr, byte> correctAnswersImage, Image<Bgr, byte> toCompareImage, out int correctAnswersCount)
        {
            correctAnswersCount = 0;

            // Convert images to grayscale
            var correctGray = correctAnswersImage.Convert<Gray, byte>();
            var toCompareGray = toCompareImage.Convert<Gray, byte>();

            // Apply Gaussian blur to reduce noise
            var correctBlurred = correctGray.SmoothGaussian(5);
            var toCompareBlurred = toCompareGray.SmoothGaussian(5);

            // Apply adaptive thresholding to detect black circles
            var correctThresh = correctBlurred.InRange(new Gray(0), new Gray(50)); // Adjust range as necessary
            var toCompareThresh = toCompareBlurred.InRange(new Gray(0), new Gray(50)); // Adjust range as necessary

            // Find contours
            var correctContours = new VectorOfVectorOfPoint();
            var toCompareContours = new VectorOfVectorOfPoint();
            CvInvoke.FindContours(correctThresh, correctContours, null, Emgu.CV.CvEnum.RetrType.External, Emgu.CV.CvEnum.ChainApproxMethod.ChainApproxSimple);
            CvInvoke.FindContours(toCompareThresh, toCompareContours, null, Emgu.CV.CvEnum.RetrType.External, Emgu.CV.CvEnum.ChainApproxMethod.ChainApproxSimple);

            // Create result image
            var resultImage = toCompareImage.Copy();

            // Approximate contours to find circles and compare
            foreach (var correctContour in correctContours.ToArrayOfArray())
            {
                var correctCircle = ApproximateCircle(new VectorOfPoint(correctContour));

                if (correctCircle.Radius > 0) // Check if the circle is valid
                {
                    bool matchFound = false;

                    foreach (var toCompareContour in toCompareContours.ToArrayOfArray())
                    {
                        var toCompareCircle = ApproximateCircle(new VectorOfPoint(toCompareContour));

                        if (toCompareCircle.Radius > 0 && IsCircleMatch(correctCircle, toCompareCircle))
                        {
                            // If circles match, draw a green circle
                            CvInvoke.Circle(resultImage, Point.Round(toCompareCircle.Center), (int)toCompareCircle.Radius, new MCvScalar(0, 255, 0), 2);
                            matchFound = true;
                            correctAnswersCount++;
                            break;
                        }
                    }

                    if (!matchFound)
                    {
                        // If no match found, draw a red circle
                        CvInvoke.Circle(resultImage, Point.Round(correctCircle.Center), (int)correctCircle.Radius, new MCvScalar(0, 0, 255), 2);
                    }
                }
            }

            // Draw all contours detected in the toCompare image
            foreach (var toCompareContour in toCompareContours.ToArrayOfArray())
            {
                var toCompareCircle = ApproximateCircle(new VectorOfPoint(toCompareContour));

                if (toCompareCircle.Radius > 0)
                {
                    //CvInvoke.Circle(resultImage, Point.Round(toCompareCircle.Center), (int)toCompareCircle.Radius, new MCvScalar(255, 0, 0), 1);
                }
            }

            return resultImage;
        }

        private bool IsCircleMatch(CircleF circle1, CircleF circle2)
        {
            const float tolerance = 10; // Adjust tolerance as needed
            return Math.Abs(circle1.Center.X - circle2.Center.X) < tolerance &&
                   Math.Abs(circle1.Center.Y - circle2.Center.Y) < tolerance &&
                   Math.Abs(circle1.Radius - circle2.Radius) < tolerance;
        }


        private CircleF ApproximateCircle(VectorOfPoint contour)
        {
            if (contour.Size == 0)
                return new CircleF(PointF.Empty, 0);

            // Get the minimum enclosing circle
            var minEnclosingCircle = CvInvoke.MinEnclosingCircle(contour);
            return minEnclosingCircle;
        }









    }
}
