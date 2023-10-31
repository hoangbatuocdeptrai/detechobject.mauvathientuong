using Emgu.CV;
using Emgu.CV.Structure;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Emgu.CV.CvEnum;
using Emgu.CV.UI;
using Emgu.CV.Util;
//using Emgu.CV.Videoio;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Image<Bgr, byte> ImgInput { get; set; }
        public Form1()
        {
            InitializeComponent();
            
        }

        private void openimg_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Images (*.jpg;*.png;*.bmp)|*.jpg;*.png;*.bmp;";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                ImgInput = new Image<Bgr, byte>(dialog.FileName);
                picbox.Image = ImgInput.AsBitmap();
            }
        }

        private void greenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (picbox.Image == null) return;

                var img = new Bitmap(picbox.Image).ToImage<Bgr, byte>();
                img._SmoothGaussian(5);

                //màu xanh (green)
                //Bgr lower = new Bgr(0, 36, 0);
                //Bgr higher = new Bgr(183, 255, 175);

                //màu đỏ(red)
                //Bgr lower = new Bgr(0, 0, 82);
                //Bgr higher = new Bgr(180, 182, 255);

                //màu tím (purple)
                //Bgr lower = new Bgr(43, 0, 36);
                //Bgr higher = new Bgr(222, 156, 178);

                //màu xanh duong (Blue)
                //Bgr lower = new Bgr(36, 0, 0);
                //Bgr higher = new Bgr(255, 203, 184);

                //màu đen (black)
                //Bgr lower = new Bgr(0, 0, 0);
                //Bgr higher = new Bgr(38, 39, 41);

                //màu xám (gray) khó chưa làm xong
                //Bgr lower = new Bgr(56, 56, 56);
                //Bgr higher = new Bgr(235, 234, 233);

                //màu trắng (white)khó chưa làm xong
                Bgr lower = new Bgr(227, 225, 224);
                Bgr higher = new Bgr(255, 255, 255);

                var mask = img.InRange(lower, higher).Not();
                //img.SetValue(new Bgr(0, 0, 0), mask);
                img.SetValue(new Bgr(0, 219, 187), mask);
                picbox.Image = img.AsBitmap();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            Bitmap pixelData = (Bitmap)picbox.Image;
            Color clr = pixelData.GetPixel(e.X, e.Y);
            IblSmallScreen.BackColor = clr;

            IblRGBValues.Text = "R: " + clr.R.ToString() + "G: " + clr.G.ToString() + "B: " + clr.B.ToString();

        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void IblSmallScreen_Click(object sender, EventArgs e)
        {
        }

        private void IblRGBValues_Click(object sender, EventArgs e)
        {
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
        }
        private VideoCapture capture;
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            capture = new VideoCapture(0); // Sử dụng camera mặc định (0) hoặc thay đổi thành số khác nếu bạn có nhiều camera

            if (capture.IsOpened)
            {
                capture.ImageGrabbed += Capture_ImageGrabbed;
                capture.Start();

                
            }
            else
            {
                MessageBox.Show("Không thể mở camera.");
            }
        }
        private void Capture_ImageGrabbed(object sender, EventArgs e)
        {
            Mat frame = new Mat();
            capture.Retrieve(frame);
            picbox.Image = frame.ToBitmap();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (capture != null && capture.IsOpened)
            {
                capture.Stop();
                capture.Dispose();
            }
        }

        private void chụpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (capture != null && capture.IsOpened)
            {
                Mat frame = new Mat();
                capture.Read(frame);

                if (!frame.IsEmpty)
                {
                    // Lưu hình ảnh xuống đĩa, bạn có thể thay đổi đường dẫn và tên tệp theo nhu cầu
                    string filePath = "C:\\Users\\ASUS-VivoBook\\source\\repos\\WinFormsApp1\\WinFormsApp1\\Image\\captured_image.jpg";
                    frame.Save(filePath);
                    MessageBox.Show("Hình ảnh đã được chụp và lưu tại: " + filePath);
                    capture.Stop();
                    try
                    {
                        if (picbox.Image == null) return;

                        var img = new Bitmap(picbox.Image).ToImage<Bgr, byte>();
                        img._SmoothGaussian(5);

                        //màu xanh (green)
                        //Bgr lower = new Bgr(0, 36, 0);
                        //Bgr higher = new Bgr(183, 255, 175);

                        //màu đỏ(red)
                        //Bgr lower = new Bgr(0, 0, 82);
                        //Bgr higher = new Bgr(152, 147, 255);

                        //màu tím (purple)
                        //Bgr lower = new Bgr(43, 0, 36);
                        //Bgr higher = new Bgr(222, 156, 178);

                        //màu tím (Blue)
                        //Bgr lower = new Bgr(114, 0, 0); 
                        //Bgr higher = new Bgr(255, 203, 184);

                        //màu đen (black)
                        //Bgr lower = new Bgr(0, 0, 0);
                        //Bgr higher = new Bgr(71, 71, 62);

                        //màu xám (gray) khó chưa làm xong
                        //Bgr lower = new Bgr(102, 102, 102);
                        //Bgr higher = new Bgr(139, 142, 136);

                        //màu trắng (white)khó chưa làm xong
                        Bgr lower = new Bgr(129, 127, 130);
                        Bgr higher = new Bgr(255, 255, 255);

                        var mask = img.InRange(lower, higher).Not();
                        //img.SetValue(new Bgr(0, 0, 0), mask);
                        img.SetValue(new Bgr(0, 219, 187), mask);
                        picbox.Image = img.AsBitmap();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("Không thể chụp hình ảnh.");
                }
            }
        }
    }
}