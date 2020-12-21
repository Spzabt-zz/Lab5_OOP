using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5_OOP_PartTwo
{
    class Square : Figure
    {
        public Form1 Form1 { get; private set; }
        protected float SideLength { get; private set; }

        public Square(float sideLength, float x, float y, Form1 form1) : base(x, y)
        {
            SideLength = sideLength;
            Form1 = form1;
        }

        public override void DrawBlack()
        {
            Graphics graphics = Form1.CreateGraphics();
            graphics.DrawRectangle(Pens.Black, X, Y, SideLength, SideLength);
        }

        public override void HideDrawingBackGround()
        {
            Graphics graphics = Form1.CreateGraphics();
            graphics.DrawRectangle(new Pen(Form1.BackColor), X, Y, SideLength, SideLength);
        }
    }
}
