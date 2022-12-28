namespace WindowsFormsApp2
{
    partial class Mandelbrot
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mandelbrot));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.главноеМенюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zoomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.включитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выключитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ускоритьToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.замедлитьToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.renderPixelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.renderPixelToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.renderAllImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьИзображениеКакToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.главноеМенюToolStripMenuItem,
            this.zoomToolStripMenuItem,
            this.renderPixelToolStripMenuItem,
            this.сохранитьИзображениеКакToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // главноеМенюToolStripMenuItem
            // 
            this.главноеМенюToolStripMenuItem.Name = "главноеМенюToolStripMenuItem";
            this.главноеМенюToolStripMenuItem.Size = new System.Drawing.Size(99, 20);
            this.главноеМенюToolStripMenuItem.Text = "Главное меню";
            this.главноеМенюToolStripMenuItem.Click += new System.EventHandler(this.главноеМенюToolStripMenuItem_Click);
            // 
            // zoomToolStripMenuItem
            // 
            this.zoomToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.включитьToolStripMenuItem,
            this.выключитьToolStripMenuItem,
            this.ускоритьToolStripMenuItem1,
            this.замедлитьToolStripMenuItem1});
            this.zoomToolStripMenuItem.Name = "zoomToolStripMenuItem";
            this.zoomToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.zoomToolStripMenuItem.Text = "zoom";
            // 
            // включитьToolStripMenuItem
            // 
            this.включитьToolStripMenuItem.Name = "включитьToolStripMenuItem";
            this.включитьToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.включитьToolStripMenuItem.Text = "Включить";
            this.включитьToolStripMenuItem.Click += new System.EventHandler(this.включитьToolStripMenuItem_Click);
            // 
            // выключитьToolStripMenuItem
            // 
            this.выключитьToolStripMenuItem.Name = "выключитьToolStripMenuItem";
            this.выключитьToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.выключитьToolStripMenuItem.Text = "Выключить";
            this.выключитьToolStripMenuItem.Click += new System.EventHandler(this.выключитьToolStripMenuItem_Click);
            // 
            // ускоритьToolStripMenuItem1
            // 
            this.ускоритьToolStripMenuItem1.Name = "ускоритьToolStripMenuItem1";
            this.ускоритьToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.ускоритьToolStripMenuItem1.Text = "Ускорить";
            this.ускоритьToolStripMenuItem1.Click += new System.EventHandler(this.ускоритьToolStripMenuItem1_Click);
            // 
            // замедлитьToolStripMenuItem1
            // 
            this.замедлитьToolStripMenuItem1.Name = "замедлитьToolStripMenuItem1";
            this.замедлитьToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.замедлитьToolStripMenuItem1.Text = "Замедлить";
            this.замедлитьToolStripMenuItem1.Click += new System.EventHandler(this.замедлитьToolStripMenuItem1_Click);
            // 
            // renderPixelToolStripMenuItem
            // 
            this.renderPixelToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.renderPixelToolStripMenuItem1,
            this.renderAllImageToolStripMenuItem});
            this.renderPixelToolStripMenuItem.Name = "renderPixelToolStripMenuItem";
            this.renderPixelToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.renderPixelToolStripMenuItem.Text = "Render";
            this.renderPixelToolStripMenuItem.Click += new System.EventHandler(this.renderPixelToolStripMenuItem_Click);
            // 
            // renderPixelToolStripMenuItem1
            // 
            this.renderPixelToolStripMenuItem1.Name = "renderPixelToolStripMenuItem1";
            this.renderPixelToolStripMenuItem1.Size = new System.Drawing.Size(162, 22);
            this.renderPixelToolStripMenuItem1.Text = "Render Pixel";
            this.renderPixelToolStripMenuItem1.Click += new System.EventHandler(this.renderPixelToolStripMenuItem1_Click);
            // 
            // renderAllImageToolStripMenuItem
            // 
            this.renderAllImageToolStripMenuItem.Name = "renderAllImageToolStripMenuItem";
            this.renderAllImageToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.renderAllImageToolStripMenuItem.Text = "Render all image";
            this.renderAllImageToolStripMenuItem.Click += new System.EventHandler(this.renderAllImageToolStripMenuItem_Click);
            // 
            // сохранитьИзображениеКакToolStripMenuItem
            // 
            this.сохранитьИзображениеКакToolStripMenuItem.Name = "сохранитьИзображениеКакToolStripMenuItem";
            this.сохранитьИзображениеКакToolStripMenuItem.Size = new System.Drawing.Size(176, 20);
            this.сохранитьИзображениеКакToolStripMenuItem.Text = "Сохранить изображение как";
            this.сохранитьИзображениеКакToolStripMenuItem.Click += new System.EventHandler(this.сохранитьИзображениеКакToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 24);
            this.pictureBox1.MaximumSize = new System.Drawing.Size(800, 426);
            this.pictureBox1.MinimumSize = new System.Drawing.Size(800, 426);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(800, 426);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            // 
            // Mandelbrot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Mandelbrot";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Множество Мандельброта";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem главноеМенюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьИзображениеКакToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem renderPixelToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem renderPixelToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem renderAllImageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zoomToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem включитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выключитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ускоритьToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem замедлитьToolStripMenuItem1;
    }
}

