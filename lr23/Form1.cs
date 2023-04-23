using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lr23
{
    public partial class Form1 : Form
    {
        private const int Width = 800;
        private const int Height = 600;
        private const int Margin = 50;
        private const float Step = 0.1f;

        private readonly Pen _pen = new Pen(Color.Blue, 2f);
        private float _a;
        private float _t;

        public Form1()
        {
            InitializeComponent();
            SetClientSizeCore(Width, Height);
            DoubleBuffered = true;
        }

        private void ButtonDrawOnClick_Click(object sender, EventArgs e)
        {
            if (float.TryParse(textBoxA.Text, out var a) && float.TryParse(textBoxT.Text, out var t))
            {
                _a = a;
                _t = t;
                labelError.Visible = false;
                Invalidate();
            }
            else
            {
                labelError.Visible = true;
                labelError.Text = "Невірне значення";
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            var g = e.Graphics;

            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            g.Clear(BackColor);

            // Зображення осей x та y
            var pen = new Pen(Color.Black, 2f);
            g.DrawLine(pen, Margin, Height - Margin, Width - Margin, Height - Margin); // Вісь x
            g.DrawLine(pen, Margin, Height - Margin, Margin, Margin); // Вісь y

            // Зображення міток x та y
            var font = new Font("Arial", 12);
            var brush = Brushes.Black;

            for (int i = Margin + 100; i < Width - Margin; i += 100)
            {
                g.DrawString((i - Width / 2).ToString(), font, brush, i, Height - Margin + 5);
                g.DrawLine(pen, i, Height - Margin - 5, i, Height - Margin + 5);
            }

            for (int i = Margin + 100; i < Height - Margin; i += 100)
            {
                g.DrawString((Height - i - Margin).ToString(), font, brush, Margin - 20, i);
                g.DrawLine(pen, Margin - 5, i, Margin + 5, i);
            }

            // Зображення графіка
            var points = new PointF[Width];
            for (var i = 0; i < Width; i++)
            {
                var currentT = i * Step + _t;
                var x = _a * (currentT - (float)Math.Pow(Math.Sin(currentT), 2));
                var y = _a * (currentT - (float)Math.Pow(Math.Cos(currentT), 2));
                points[i] = new PointF(x + Width / 2, Height - y - Margin);
            }
            g.DrawLines(_pen, points);
        }
    }
}