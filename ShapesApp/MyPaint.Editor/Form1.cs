using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using System.Windows.Shapes;
using MyPaint.Business;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MyPaint.Editor
{
    public partial class Form1 : Form
    {
        private Shape shape;
        public Form1()
        {
            InitializeComponent();
            this.Resize += new EventHandler(MainForm_Resize);
            ButtonDraw.Click += ButtonDraw_Click;
            this.pictureBoxCanvas.Paint += pictureBoxCanvas_Paint;
            comboBoxShapes.Items.AddRange(new string[] { "Line", "Circle" });
            comboBoxShapes.SelectedIndex = 0;

        }

        private void ButtonDraw_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBoxX.Text, out int x) && int.TryParse(textBoxY.Text, out int y))
            {
                switch (comboBoxShapes.SelectedItem.ToString())
                {
                    case "Line":
                        shape = new Line(new Point2D(0, 0), new Point2D(x, y));
                        break;
                    case "Circle":
                        shape = new Circle(new Point2D(x, y), 20);
                        break;
                }

                if (shape != null)
                {
                    //shape.Draw(); 
                    //pictureBoxCanvas.Image = Shape.canvas; 
                    pictureBoxCanvas.Invalidate();
                }
            }
            else
            {
                MessageBox.Show("Please enter valid integer values for coordinates.");
            }
        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
            pictureBoxCanvas.Invalidate();
        }

        private void pictureBoxCanvas_Paint(object sender, PaintEventArgs e)
        {
            if (shape != null)
            {
                shape.Draw();
                e.Graphics.DrawImage(Shape.canvas, new Point(0, 0));
                /*Graphics g = e.Graphics;

                g.DrawLine(new Pen(Color.Red, 2), new Point(0, 0), new Point(pictureBoxCanvas.Width, pictureBoxCanvas.Height));

                g.DrawEllipse(new Pen(Color.Red, 2), 0, 0, pictureBoxCanvas.Width, pictureBoxCanvas.Height);
                */
            }

        }
    }
}
