﻿using System;
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
    public partial class translation : Form
    {
        public translation()
        {
            InitializeComponent();
        }

        public Menu Menu
        {
            get => default;
            set
            {
            }
        }

        private void главноеМенюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            Menu from2 = new Menu();
            from2.ShowDialog();
            Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void translation_Load(object sender, EventArgs e)
        {
            ClientSize = new Size(640, 520);
            FormBorderStyle = FormBorderStyle.FixedSingle;
        }
    }
}
