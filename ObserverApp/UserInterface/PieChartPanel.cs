using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace UserInterface
{
    public class PieChartPanel : Panel
    {
        private Dictionary<string, float> _data;

        public PieChartPanel(Dictionary<string, float> data)
        {
            _data = data;
            this.Paint += new PaintEventHandler(DrawPieChart);
        }

        private void DrawPieChart(object sender, PaintEventArgs e)
        {
            float total = 0f;
            foreach (var value in _data.Values)
            {
                total += value;
            }

            float startAngle = 0f;
            foreach (var entry in _data)
            {
                float sweepAngle = (entry.Value / total) * 360;
                e.Graphics.FillPie(new SolidBrush(GetRandomColor()), new Rectangle(10, 10, this.Width - 20, this.Height - 20), startAngle, sweepAngle);
                startAngle += sweepAngle;
            }
        }

        private Color GetRandomColor()
        {
            Random rand = new Random();
            return Color.FromArgb(rand.Next(255), rand.Next(255), rand.Next(255));
        }
    }
}
