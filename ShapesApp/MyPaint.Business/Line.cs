using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace MyPaint.Business
{
     public class Line : Shape
    {
        public Point2D Start { get; set; }
        public Point2D End { get; set; }

        public Line(Point2D start, Point2D end)
        {
            Start = start;
            End = end;
        }

        public override void Draw()
        {
            using (Graphics g = Graphics.FromImage(canvas))
            {
                g.DrawLine(Pens.Black, new Point(Start.X, Start.Y), new Point(End.X, End.Y));
            }
        }

        public override void MoveTo(Point2D newStart)
        {
            End = new Point2D { X = End.X + (newStart.X - Origin.X), Y = End.Y + (newStart.Y - Origin.Y) };
            Origin = newStart;
        }

        public override void Resize(int scaleFactor)
        {
            End = new Point2D { X = (int)(Origin.X + (End.X - Origin.X) * scaleFactor), Y = (int)(Origin.Y + (End.Y - Origin.Y) * scaleFactor) };
        }

        
    }

}
