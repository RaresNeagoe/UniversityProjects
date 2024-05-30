using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace MyPaint.Business
{

    public class Circle : Shape
    {
        public Point2D Center { get; set; }
        public int Radius { get; set; }

        public Circle(Point2D center, int radius)
        {
            Center = center;
            Radius = radius;
        }

        public override void Draw()
        {
            /*if (canvas == null)
            {
                canvas = new Bitmap(800, 600);
            }*/

            using (Graphics g = Graphics.FromImage(canvas))
            {
                g.DrawEllipse(Pens.Red, Center.X - Radius, Center.Y - Radius, 2 * Radius, 2 * Radius);
            }
        }

        public override void MoveTo(Point2D newCenter)
        {
            Center = newCenter;
        }

        public override void Resize(int scaleFactor)
        {
            Radius *= scaleFactor;
        }

    }
}

