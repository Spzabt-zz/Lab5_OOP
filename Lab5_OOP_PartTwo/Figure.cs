using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Lab5_OOP_PartTwo
{
    abstract class Figure
    {
        protected float X { get; private set; }
        protected float Y { get; private set; }

        public Figure(float x, float y)
        {
            X = x;
            Y = y;
        }

        public abstract void DrawBlack();
        public abstract void HideDrawingBackGround();

        async public void MoveRight(int iter,  Form1 form1)
        {
            for (int i = 0; i <= iter; i++)
            {
                DrawBlack();
                await Task.Delay(50);
                HideDrawingBackGround();
                form1.Text = i.ToString();
                X++;
            }
        }
    }
}
