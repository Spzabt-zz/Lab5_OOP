using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5_OOP_PartTwo
{
    class Rhomb : Figure
    {
        public Form1 Form1 { get; private set; }
        protected float HorDiagLen { get; private set; }
        protected float VertDiagLen { get; private set; }

        public Rhomb(float horDiagLen, float vertDiagLen, float x, float y, Form1 form1)
            : base(x, y)
        {
            HorDiagLen = horDiagLen;
            VertDiagLen = vertDiagLen;
            Form1 = form1;
        }

        public override void DrawBlack()
        {
            Graphics graphics = Form1.CreateGraphics();

            graphics.DrawPolygon(Pens.Black, new PointF[] { new PointF(X, HorDiagLen / Y), new PointF((VertDiagLen / Y) + X, 0f), 
                new PointF(VertDiagLen + X, HorDiagLen / Y), new PointF(VertDiagLen / Y + X, HorDiagLen) });

        }

        public override void HideDrawingBackGround()
        {
            Graphics graphics = Form1.CreateGraphics();

            graphics.DrawPolygon(new Pen(Form1.BackColor), new PointF[] { new PointF(X, HorDiagLen / Y), new PointF((VertDiagLen / Y) + X, 0f),
                new PointF(VertDiagLen + X, HorDiagLen / Y), new PointF(VertDiagLen / Y + X, HorDiagLen) });
        }
    }
}
