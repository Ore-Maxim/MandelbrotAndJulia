using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Mandelbrot : Form
    {
        bool key_zoom = false, key_julia = false;
        public double wx = 0, wy = 0; // перемещение по фракталу
        public double speed = 2f, zoom = 2f, zoomSpeed = 0.001d; // zoom - степень приближения фрактала, zoomspeed - разрешение нашего фрактала
        public int res = 1; // ускорение вычисления фрактала
        public int k = 5; // коэффициент скорости перемещения

        DrawPx draw = new DrawPx();

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Q)
            {
                res -= 1;
            }
            if (e.KeyCode == Keys.E)
            {
                res += 1;
            }

            if (e.KeyCode == Keys.Up)
            {
                wy -= speed * (5 - Math.Abs(zoom));
            }
            if (e.KeyCode == Keys.Down)
            {
                wy += speed * (5 - Math.Abs(zoom));
            }

            if (e.KeyCode == Keys.Left)
            {
                wx -= speed * (5 - Math.Abs(zoom));
            }
            if (e.KeyCode == Keys.Right)
            {
                wx += speed * (5 - Math.Abs(zoom));
            }


            if (e.KeyCode == Keys.Space)
            {
                timer1.Stop();
                Draw();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (key_zoom == true)
            {
                zoom -= (zoomSpeed / zoom) * k;
                Draw();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void главноеМенюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            Menu from2 = new Menu();
            from2.ShowDialog();
            Close();
        }

        private void сохранитьИзображениеКакToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Title = "Сохранить изображение как...";
                sfd.OverwritePrompt = true;
                sfd.CheckPathExists = true;
                sfd.Filter = "Image Files(*.BMP)|*.BMP|Image Files(*.JPG)|*.JPG|Image Files(*.GIF)|*.GIF|Image Files(*.PNG)|*.PNG|All files(*.*)|*.*";
                sfd.ShowHelp = true;

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        pictureBox1.Image.Save(sfd.FileName);
                    }
                    catch
                    {
                        MessageBox.Show("Невозможно сохранить изображение", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }
        }

        private void renderPixelToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        public Mandelbrot()
        {
            InitializeComponent();
        }

        private void renderPixelToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //Выбираем перо "myPen" черного цвета Black
            //толщиной в 1 пиксель:
            Pen myPen = new Pen(Color.Black, 1);
            //Объявляем объект "g" класса Graphics и предоставляем
            //ему возможность рисования на pictureBox1:
            Graphics g = Graphics.FromHwnd(pictureBox1.Handle);
            //вызываем функцию рисования фрактала
            DrawFractal(g, myPen);

        }

        private void renderAllImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Draw();
        }

        private void ускоритьToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            k += 1;
        }

        private void замедлитьToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (k <= 1)
            {
                k = 1;
            }
            else k -= 1;
        }

        private void включитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            key_zoom = true;
        }

        private void выключитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            key_zoom = false;
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (key_julia == true)
            {
                Hide();
                double x = ((e.X + (wx / res / zoom)) - ((Width / 2d) / res)) / (double)(Width / zoom / res / 1.777f);
                double y = ((e.Y + (wy / res / zoom)) - ((Height / res / 2d))) / (double)(Height / res / zoom);
                Julia form3 = new Julia(x, y);
                form3.ShowDialog();
            }

        }

        public void DrawFractal(Graphics g, Pen pen)
        {
            for (int x = 0; x < Width; x++)
            {
                for (int y = 0; y < Height; y++)
                {
                    int it = draw.drawFractalM(x, y, Width, Height);
                    pen.Color = Color.FromArgb(255, it % 8 * 16, it % 4 * 32, it % 2 * 64);
                    //рисуем пиксель
                    g.DrawRectangle(pen, x, y, 1, 1);

                }
            }
            key_julia = true;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            ClientSize = new Size(800, 450);
            FormBorderStyle = FormBorderStyle.FixedSingle;
        }


        public void Draw()
        {
            if (res <= 1)
            {
                res = 1;
            }
            Bitmap frame = new Bitmap(Width / res, Height / res); // создание кадра, которое будет идти в picturbox
            for (int x = 0; x < Width / res; x++) // перебираем пиксели
            {
                for (int y = 0; y < Height / res; y++)// перебираем пиксели
                {
                    int it = draw.drawM(x, y, res, Width, Height, wx, wy, zoom);
                    frame.SetPixel(x, y, Color.FromArgb(255, it % 8 * 16, it % 4 * 32, it % 2 * 64));
                }
            }
            pictureBox1.Image = frame;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            key_julia = true;
        }

        public Menu Menu
        {
            get => default;
            set
            {
            }
        }

        public DrawPx DrawPx
        {
            get => default;
            set
            {
            }
        }

        public Numbers Numbers
        {
            get => default;
            set
            {
            }
        }
    }

}
