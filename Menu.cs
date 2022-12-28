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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        public translation translation
        {
            get => default;
            set
            {
            }
        }

        public оПрограмме оПрограмме
        {
            get => default;
            set
            {
            }
        }

        public Julia Julia
        {
            get => default;
            set
            {
            }
        }

        public Mandelbrot Mandelbrot
        {
            get => default;
            set
            {
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            Mandelbrot from1 = new Mandelbrot();
            from1.ShowDialog();
            Close();
        }

        private void файлToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
            Julia form3 = new Julia(0.28, 0.0113);
            form3.ShowDialog();
            Close();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            ClientSize = new Size(280, 260);
            FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void справкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            оПрограмме программа = new оПрограмме();
            программа.ShowDialog();
            Close();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void управлениеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            translation form4 = new translation();
            form4.ShowDialog();
            Close();
        }
    }
}
