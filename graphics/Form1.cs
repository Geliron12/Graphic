using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace graphics
{
    public partial class Form1 : Form
    {
        public class point : IComparable<point>
        {
            public double x, y;
            public int CompareTo(point example)
            {
                return this.x.CompareTo(example.x);
            }
            public point(double x, double y)
            {
                this.x = x;
                this.y = y;
            }
        }
            public int acc = 1000;
        public double w0,w1,xmin, xmax, A;
        Pen black = new Pen(Color.Black);
        Pen blue = new Pen(Color.Blue);
        Pen gray = new Pen(Color.Gray);
        Font drawFont = new Font("Arial", 10);
        SolidBrush drawBrush = new SolidBrush(Color.Black);
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Построить_Click(object sender, EventArgs e)
        {
                Bitmap bitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
                Graphics graphic = Graphics.FromImage(bitmap);
                pictureBox1.Image = bitmap;
            try { 
                w0 = Convert.ToDouble(textBoxw0.Text);
                w1 = Convert.ToDouble(textBoxw1.Text);
                xmin = Convert.ToDouble(textBox_xmin.Text);
                xmax = Convert.ToDouble(textBox_xmax.Text);
                A = Convert.ToDouble(textBoxA.Text);

                double xmaxr = Math.Max(Math.Abs(xmin), Math.Abs(xmax));              
                var answer = new point(0, 0);
                answer = DrawGrid(xmaxr, Math.Abs(A), graphic);
                double xpointmax, ypointmax;
                xpointmax = answer.x;
                if (xmax <=xmin)
                {
                    xpointmax = 0;
                }
                ypointmax = answer.y;
                double kx = pictureBox1.Width / (xpointmax*2);
                double ky = pictureBox1.Height / (ypointmax*2);

                double[] arrx = new double[acc];
                arrx[0] = xmin;
                double newdelta = (xmax - xmin) / acc;
                for (int i = 1; i < acc; i++) {
                    arrx[i] = arrx[i - 1] + newdelta;
                }
                for (int i = 0; i < acc - 1; i++) {
                    graphic.DrawLine(blue, pictureBox1.Width / 2 + (float)(arrx[i] * kx),
                        pictureBox1.Height / 2 - (float)(fun(arrx[i], A, w0, w1) * ky),
                        pictureBox1.Width / 2 + (float)(arrx[i + 1] * kx),
                        pictureBox1.Height / 2 - (float)(fun(arrx[i + 1], A, w0, w1) * ky));
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Неверно введены данные!", "Ошибка!",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private double fun(double x, double A, double w0, double w1) {
            return A * Math.Sin(w0 * x) * Math.Sin(w1 * x);
        }
        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {

                Bitmap bitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
                Graphics graphic = Graphics.FromImage(bitmap);
                pictureBox1.Image = bitmap;
            try { 
                string path = textBox1.Text;
                int n;
                double tempx, tempy;
                var points = new List<point>();
                using (StreamReader str = new StreamReader(path))
                {
                    n = Convert.ToInt32(str.ReadLine());
                    for (int i = 0; i < n; i++)
                    {
                        tempx = Convert.ToDouble(str.ReadLine());
                        tempy = Convert.ToDouble(str.ReadLine());
                        points.Add(new point(tempx, tempy));
                    }
                }
                var another = points.OrderBy(s => s);
                var supportive = another.Select(s => Math.Abs(s.y));
                double xpointmax, ypointmax, kx, ky, xmaxr, ymaxr;
                xmaxr = Math.Max(Math.Abs(another.Last().x), Math.Abs(another.First().x));
                ymaxr = supportive.Max();
                var answer = new point(0, 0);
                answer = DrawGrid(xmaxr, ymaxr, graphic);
                xpointmax = answer.x;
                if (xmaxr == 0)
                {
                    xpointmax = 0;
                }
                ypointmax = answer.y;
                kx = pictureBox1.Width / (xpointmax - (-1) * xpointmax);
                ky = pictureBox1.Height / (ypointmax - (-1) * ypointmax);
                point temp1 = new point(0, 0);
                point temp2 = new point(0, 0);

                for (int i = 0; i < n - 1; i++)
                {
                    temp1 = another.Skip(i).First();
                    temp2 = another.Skip(i + 1).First();

                    graphic.DrawLine(blue, pictureBox1.Width / 2 + (float)(temp1.x * kx),
                           pictureBox1.Height / 2 - (float)(temp1.y * ky),
                           pictureBox1.Width / 2 + (float)(temp2.x * kx),
                           pictureBox1.Height / 2 - (float)(temp2.y * ky));
                    temp1 = another.Skip(i).First();
                    temp2 = another.Skip(i + 1).First();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Неверно введены данные!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
        public point DrawGrid(double xmaxr, double ymaxr,Graphics graphic) {
            double xpointmax = 0.01;
            double ypointmax = 0.01;
            double deltax = 0.002;
            double deltay = 0.002;
            int koef = 5;
            while (xpointmax < xmaxr)
            {
                if (xpointmax > 1 && koef == 5)
                {
                    koef = 2;
                }
                xpointmax *= koef;
                deltax *= koef;
            }
            koef = 5;
            while (ypointmax < Math.Abs(ymaxr))
            {
                if (ypointmax > 1&&koef ==5)
                {
                    koef = 2;
                }
                ypointmax *= koef;
                deltay *= koef;

            }
            double kx = pictureBox1.Width / (xpointmax * 2);
            double ky = pictureBox1.Height / (ypointmax * 2);
            double fx = -1 * xpointmax;
            double fy = -1 * ypointmax;

            while (fx < xpointmax)
            {
                graphic.DrawString(Convert.ToString(Math.Round(fx, 4)), drawFont, drawBrush, (float)(pictureBox1.Width / 2 +
                    fx * kx), pictureBox1.Height / 2 + 5);
                fx += deltax;
            }
            while (fy < ypointmax)
            {
                if (Math.Round(fy, 4) != 0)
                {
                    graphic.DrawString(Convert.ToString((-1)*Math.Round(fy, 4)), drawFont, drawBrush, pictureBox1.Width / 2 + 5,
                        (float)(pictureBox1.Height / 2 + fy * ky));
                }
                fy += deltay;
            }
            for (int i = 0; i < pictureBox1.Width; i += 40)
            {
                graphic.DrawLine(gray, i, 0, i, pictureBox1.Height);
                graphic.DrawLine(black, i, pictureBox1.Height / 2 - 5, i, pictureBox1.Height / 2 + 5);
                graphic.DrawLine(gray, 0, i, pictureBox1.Width, i);
                graphic.DrawLine(black, pictureBox1.Width / 2 - 5, i, pictureBox1.Width / 2 + 5, i);
            }
            graphic.DrawLine(black, 0, pictureBox1.Height / 2, pictureBox1.Width, pictureBox1.Height / 2);
            graphic.DrawLine(black, pictureBox1.Width - 10, pictureBox1.Height / 2 - 10, pictureBox1.Width, pictureBox1.Height / 2);
            graphic.DrawLine(black, pictureBox1.Width - 10, pictureBox1.Height / 2 + 10, pictureBox1.Width, pictureBox1.Height / 2);
            graphic.DrawLine(black, pictureBox1.Width / 2, 0, pictureBox1.Width / 2, pictureBox1.Height);
            graphic.DrawLine(black, pictureBox1.Width / 2 - 10, 10, pictureBox1.Width / 2, 0);
            graphic.DrawLine(black, pictureBox1.Width / 2 + 10, 10, pictureBox1.Width / 2, 0);
            return ( new point(xpointmax, ypointmax));
        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
           
        }

        private void Label6_Click(object sender, EventArgs e)
        {

        }
    }

}
