using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace MyPaint.Business
{
    public abstract class Shape
    {
        public Point2D Origin { get; set; }
        public string NameKey { get; set; }

        public static Bitmap canvas = new Bitmap(800, 600);
        public abstract void Draw();
        public abstract void Resize(/*scale factor*/int scaleFactor);
        public abstract void MoveTo(/*new point2D*/Point2D newOrigin);
        public virtual void Add(Shape shape) { }
        public virtual void Remove(Shape shape) { }
    }
}
