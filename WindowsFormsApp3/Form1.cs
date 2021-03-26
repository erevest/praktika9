using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
  public partial class Form1 : Form
  {
    Point[] points = new Point[50];
    Pen pen = new Pen(Color.Black, 2);
    int i;
    public Form1()
    {
      InitializeComponent();
    }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
      Graphics g = e.Graphics;

      

      

      SolidBrush brush1 = new SolidBrush(Color.LightBlue);
      Rectangle[] rects1 = { new Rectangle(0, 0, 1000, 1000) };
      e.Graphics.FillRectangles(brush1, rects1);

      //синие квадраты

      SolidBrush blueBrush = new SolidBrush(Color.Gray);
      Rectangle[] rects = { new Rectangle(25, 125, 500, 500), new Rectangle(475, 450, 50, 100) };
      // Fill rectangles to screen.
      e.Graphics.FillRectangles(blueBrush, rects);

    

      g.DrawLine(new Pen(Brushes.Black, 2), 10, 4* i +20, 500, 4*i+20);
      
      g.DrawRectangle(new Pen(Brushes.Blue, 2), 475, 450, 50, 100);
      g.DrawEllipse(new Pen(Brushes.Black, 4), 200, 200, 60, 60);
      
      //пунктирная линия
      float[] dashValues = { 5, 2, 15, 4 };
      Pen blackPen = new Pen(Color.Black, 5);
      blackPen.DashPattern = dashValues;
      e.Graphics.DrawLine(blackPen, new Point(5, 5), new Point(405, 5));
      //ещё одна линия
      
    }

    private void Form1_Load(object sender, EventArgs e)
    {
    }

    private void Button3_Click(object sender, EventArgs e)
    {
      
    }
  }
}
