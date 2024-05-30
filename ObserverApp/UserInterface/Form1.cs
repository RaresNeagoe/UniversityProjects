using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserInterface
{
    public partial class Form1 : Form
    {

        private Dictionary<string, long> fileSizes = new Dictionary<string, long>
        {
            { ".txt", 3000 },
            { ".jpg", 2000 },
            { ".docx", 1500 },
            { ".png", 1200 },
            { ".xml", 1800 },

        };
        public Form1()
        {
            InitializeComponent();

        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            DrawPieChart(e.Graphics);
        }
        private void DrawPieChart(Graphics graphics)
        {
            var totalSize = fileSizes.Values.Sum();
            var startAngle = 0f;

            foreach (var kvp in fileSizes)
            {
                var percentage = (float)kvp.Value / totalSize;
                var sweepAngle = percentage * 360;

                using (var brush = new SolidBrush(GetRandomColor()))
                {
                    graphics.FillPie(brush, 100, 100, 200, 200, startAngle, sweepAngle);
                }

                startAngle += sweepAngle;
            }
        }

        private Color GetRandomColor()
        {
            var random = new Random();
            return Color.FromArgb(random.Next(256), random.Next(256), random.Next(256));
        }
    }
}
