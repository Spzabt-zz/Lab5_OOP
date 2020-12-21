using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab5_OOP_PartTwo
{
    public partial class Form1 : Form
    {
        private Circle _circle;
        private Square _square;
        private Rhomb _rhomb;

        private int _iter;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;

            _circle = new Circle(100.0f, 100.0f, 100.0f, this);
            if (!int.TryParse(textBox1.Text, out _iter))
                MessageBox.Show("Введіть число!");
            else
                _circle.MoveRight(_iter, this);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;

            _square = new Square(100.0f, 100.0f, 100.0f, this);
            if (!int.TryParse(textBox1.Text, out _iter))
                MessageBox.Show("Введіть число!");
            else
                _square.MoveRight(_iter, this);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;

            _rhomb = new Rhomb(120.0f, 100.0f, 0f, 2.0f, this);

            if (!int.TryParse(textBox1.Text, out _iter))
                MessageBox.Show("Введіть число!");
            else
                _rhomb.MoveRight(_iter, this);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
        }
    }
}
