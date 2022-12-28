using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Julia : Form
    {
        bool key_zoom = false;
        public double wx = 0, wy = 0; // перемещение по фракталу
        public double speed = 2f, zoom = 2f, zoomSpeed = 0.001d; // speed - скорость перемещения, zoom - степень приближения фрактала, zoomspeed - разрешение нашего фрактала
        public int res = 10; // ускорение вычисления фрактала
        public int k = 5;

        public double pointX = 0.28 , pointY= 0.0113;
        DrawPx draw = new DrawPx();

        private void Form3_Load(object sender, EventArgs e)
        {
            Draw(pointX, pointY);
            ClientSize = new Size(800, 450);
            FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void Form3_KeyDown(object sender, KeyEventArgs e)
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
                Draw(pointX, pointY);
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (key_zoom == true)
            {
                zoom -= (zoomSpeed / zoom) * k;
                Draw(pointX, pointY);
            }
            
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

        private void включитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            key_zoom = true;
        }

        private void выключитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            key_zoom = false;
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

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        public Julia(double pointX, double pointY)
        {
            InitializeComponent();
            this.pointX = pointX;
            this.pointY = pointY;
        }

        private void zoomToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        public void Draw(double pointX, double pointY)
        {
            if (res <= 0)
            {
                res = 1;
            }

            Bitmap frame = new Bitmap(Width / res, Height / res); // создание кадра, которое будет идти в picturbox
            for (int x = 0; x < Width / res; x++) 
            {
                for (int y = 0; y < Height / res; y++)
                {
                    int it = draw.drawJ(x, y, res, Width, Height, wx, wy, zoom, pointX, pointY);
                    frame.SetPixel(x, y, Color.FromArgb(255, it % 8 * 16, it % 4 * 32, it % 2 * 64));
                }
            }

            pictureBox1.Image = frame;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

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
