using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5_OOP_PartTwo
{
    class Circle : Figure
    {
        private Graphics _graphics;
        public Form1 Form1 { get; private set; }
        protected float Radius { get; private set; }

        public Circle(float radius, float x, float y, Form1 form1) : base(x, y)
        {
            Radius = radius;
            Form1 = form1;
        }

        public override void DrawBlack()
        {
            _graphics = Form1.CreateGraphics();
            _graphics.DrawEllipse(Pens.Black, X, Y, Radius, Radius);
        }

        public override void HideDrawingBackGround()
        {
            _graphics = Form1.CreateGraphics();
            _graphics.DrawEllipse(new Pen(Form1.BackColor), X, Y, Radius, Radius);
        }
    }
}
