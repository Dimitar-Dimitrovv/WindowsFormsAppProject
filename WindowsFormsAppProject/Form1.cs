using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace WindowsFormsAppProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Thread Th1;
        Thread Th2;
        Thread Th3;
        Thread Th4;
        Random rdm;

        //Rectangle
        private void RectangleButton_Click(object sender, EventArgs e)
        {
            Th1 = new Thread(threadA);
            Th1.Start();
        }
        public void threadA()
        {
            for (int i = 0; i < 100; i++)
            {
                this.CreateGraphics().DrawRectangle(new Pen(Brushes.Blue, 5), new Rectangle(rdm.Next(0, this.Width), rdm.Next(0, this.Height), 20, 20));
                Thread.Sleep(100);
            }
            MessageBox.Show("Rectangle Executed.");
        }

        //Triangle
        private void TriangleButton_Click(object sender, EventArgs e)
        {
            Th2 = new Thread(threadB);
            Th2.Start();
        }
        public void threadB()
        {
            for (int i = 0; i < 50; i++)
            {
                Thread.Sleep(50);
            }
            MessageBox.Show("Triangle Executed.");
        }

        //Circle
        private void CircleButton_Click(object sender, EventArgs e)
        {
            Th3 = new Thread(threadC);
            Th3.Start();
        }
        public void threadC()
        {
            for (int i = 0; i < 50; i++)
            {
                Thread.Sleep(50);
            }
            MessageBox.Show("Circle Executed.");
        }


        private void Form1_Load_1(object sender, EventArgs e)
        {
            rdm = new Random();
        }
    }
}
