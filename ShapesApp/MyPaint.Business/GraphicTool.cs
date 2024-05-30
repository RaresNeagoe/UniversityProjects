using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPaint.Business
{
    class GraphicTool
    {
        public List<Shape> Shapes { get; private set; }

        public GraphicTool()
        {
            Shapes = new List<Shape>();
        }

        public void Add(Shape shape)
        {
            Shapes.Add(shape);
        }

        public void Remove(Shape shape)
        {
            Shapes.Remove(shape);
        }

        public void DrawAll()
        {
            foreach (var shape in Shapes)
            {
                shape.Draw();
            }
        }
    }

}
