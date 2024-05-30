using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPaint.Business
{
    class Picture : Shape
    {
        private List<Shape> _shapes;

        public Picture()
        {
            _shapes = new List<Shape>();
        }

        public override void Draw()
        {
            foreach (var item in _shapes)
            {
                item.Draw();
            }
        }

        public override void MoveTo(Point2D newOrigin)
        {
            foreach (var shape in _shapes)
            {
                shape.MoveTo(newOrigin);
            }
        }

        public override void Resize(int scaleFactor)
        {
            foreach (var shape in _shapes)
            {
                shape.Resize(scaleFactor);
            }
        }

        public override void Add(Shape shape)
        {
            _shapes.Add(shape);
        }

        public override void Remove(Shape shape)
        {
            _shapes.Remove(shape);
        }
    }

}
