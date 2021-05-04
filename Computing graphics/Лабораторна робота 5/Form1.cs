using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsGraphics5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Stopwatch stopwatch = new Stopwatch();

            Brush brush = Brushes.Blue;
            Pen pen = Pens.Black;

            PointF[] point3D = new PointF[6];

            int xCoordinate = Convert.ToInt32(textBox4.Text); int yCoordinate = Convert.ToInt32(textBox5.Text);

            int cameraDist = Convert.ToInt32(textBox6.Text);
            int size = Convert.ToInt32(textBox7.Text);

            int xRotate = Convert.ToInt32(trackBar1.Value); int yRotate = Convert.ToInt32(trackBar2.Value); int zRotate = Convert.ToInt32(trackBar3.Value);

            stopwatch.Start();

            pictureBox1.Image = new Bitmap(pictureBox1.Width, pictureBox1.Height);

            using (var graphics = Graphics.FromImage(pictureBox1.Image))
            {
                View3D.Point3D startPoint = new View3D.Point3D(0, 0, 0);
                View3D.Point3D[] pyramidPoints = Points(size, size, size);
                View3D.Point3D pyramidOrigin = new View3D.Point3D((int)(size / 2), (int)(size / 2), (int)(size / 2));

                pyramidPoints = View3D.MovePoints(pyramidPoints, pyramidOrigin, startPoint);

                pyramidPoints = View3D.RotateX(pyramidPoints, xRotate); pyramidPoints = View3D.RotateY(pyramidPoints, yRotate); pyramidPoints = View3D.RotateZ(pyramidPoints, zRotate);

                pyramidPoints = View3D.MovePoints(pyramidPoints, startPoint, pyramidOrigin);

                for (int i = 0; i < point3D.Length; i++)
                {
                    point3D[i].X = ((xCoordinate / 2) + (((float)pyramidPoints[i].X * cameraDist) / ((float)pyramidPoints[i].Z + cameraDist)));
                    point3D[i].Y = (yCoordinate / 2) - (((float)pyramidPoints[i].Y * cameraDist) / ((float)pyramidPoints[i].Z + cameraDist));
                }

                //Перевірка на замальованість

                if (!checkBox1.Checked) //Якщо НЕ замальований
                {
                    View3D.Point3D n = View3D.CalcNormal(pyramidPoints[3], pyramidPoints[0], pyramidPoints[1]);
                    if (n.Z * cameraDist + n.X * pyramidPoints[3].X + n.Y * pyramidPoints[3].Y + n.Z * pyramidPoints[3].Z > 0)
                    {
                        //Перша сторона
                        graphics.DrawLine(pen, point3D[1].X, point3D[1].Y, point3D[0].X, point3D[0].Y); 
                        graphics.DrawLine(pen, point3D[3].X, point3D[3].Y, point3D[0].X, point3D[0].Y); 
                        graphics.DrawLine(pen, point3D[3].X, point3D[3].Y, point3D[1].X, point3D[1].Y);
                    }
                    n = View3D.CalcNormal(pyramidPoints[5], pyramidPoints[0], pyramidPoints[3]);
                    if (n.Z * cameraDist + n.X * pyramidPoints[5].X + n.Y * pyramidPoints[5].Y + n.Z * pyramidPoints[5].Z > 0)
                    {
                        //Друга сторона
                        graphics.DrawLine(pen, point3D[3].X, point3D[3].Y, point3D[0].X, point3D[0].Y); 
                        graphics.DrawLine(pen, point3D[5].X, point3D[5].Y, point3D[0].X, point3D[0].Y); 
                        graphics.DrawLine(pen, point3D[3].X, point3D[3].Y, point3D[5].X, point3D[5].Y);
                    }

                    n = View3D.CalcNormal(pyramidPoints[5], pyramidPoints[3], pyramidPoints[1]);
                    if (n.Z * cameraDist + n.X * pyramidPoints[5].X + n.Y * pyramidPoints[5].Y + n.Z * pyramidPoints[5].Z > 0)
                    {
                        //Третя сторона
                        graphics.DrawLine(pen, point3D[3].X, point3D[3].Y, point3D[5].X, point3D[5].Y); 
                        graphics.DrawLine(pen, point3D[5].X, point3D[5].Y, point3D[1].X, point3D[1].Y); 
                        graphics.DrawLine(pen, point3D[3].X, point3D[3].Y, point3D[1].X, point3D[1].Y);
                    }

                    n = View3D.CalcNormal(pyramidPoints[5], pyramidPoints[1], pyramidPoints[0]);
                    if (n.Z * cameraDist + n.X * pyramidPoints[5].X + n.Y * pyramidPoints[5].Y + n.Z * pyramidPoints[5].Z > 0)
                    {
                        //Четверта сторона
                        graphics.DrawLine(pen, point3D[5].X, point3D[5].Y, point3D[0].X, point3D[0].Y); 
                        graphics.DrawLine(pen, point3D[5].X, point3D[5].Y, point3D[1].X, point3D[1].Y); 
                        graphics.DrawLine(pen, point3D[1].X, point3D[1].Y, point3D[0].X, point3D[0].Y);
                    }
                }

                else //Якщо замальований
                {
                    View3D.Point3D n = View3D.CalcNormal(pyramidPoints[3], pyramidPoints[0], pyramidPoints[1]);

                    if (n.Z * cameraDist + n.X * pyramidPoints[3].X + n.Y * pyramidPoints[3].Y + n.Z * pyramidPoints[3].Z > 0)
                    {
                        var s = Math.Abs(n.X * button2.Location.X + n.Y * button2.Location.Y + n.X * pyramidPoints[3].X + n.Y * pyramidPoints[3].Y + n.Z * pyramidPoints[3].Z);
                        Color color = new Color();

                        s = (s - 0) / (25500 - 0); //Нормалізуємо значення

                        if (s < 255) { color = Color.FromArgb(0, 0, (int)s); }
                        else { color = Color.FromArgb(0, 0, 255); }

                        brush = new SolidBrush(color);

                        //Перша сторона
                        graphics.FillPolygon(brush, new PointF[3] { new PointF(point3D[1].X, point3D[1].Y), new PointF(point3D[0].X, point3D[0].Y), new PointF(point3D[3].X, point3D[3].Y) });
                        graphics.DrawLine(pen, point3D[1].X, point3D[1].Y, point3D[0].X, point3D[0].Y); 
                        graphics.DrawLine(pen, point3D[3].X, point3D[3].Y, point3D[0].X, point3D[0].Y); 
                        graphics.DrawLine(pen, point3D[3].X, point3D[3].Y, point3D[1].X, point3D[1].Y);
                    }

                    n = View3D.CalcNormal(pyramidPoints[5], pyramidPoints[0], pyramidPoints[3]);

                    if (n.Z * cameraDist + n.X * pyramidPoints[5].X + n.Y * pyramidPoints[5].Y + n.Z * pyramidPoints[5].Z > 0)
                    {
                        var s = Math.Abs(n.X * button2.Location.X + n.Y * button2.Location.Y + n.X * pyramidPoints[3].X + n.Y * pyramidPoints[3].Y + n.Z * pyramidPoints[3].Z);
                        Color color = new Color();

                        s = (s - 0) / (25500 - 0); //Нормалізуємо значення

                        if (s < 255) { color = Color.FromArgb(0, 0, (int)s); }
                        else { color = Color.FromArgb(0, 0, 255); }

                        brush = new SolidBrush(color);

                        //Друга сторона
                        graphics.FillPolygon(brush, new PointF[3] { new PointF(point3D[3].X, point3D[3].Y), new PointF(point3D[0].X, point3D[0].Y), new PointF(point3D[5].X, point3D[5].Y) });
                        graphics.DrawLine(pen, point3D[3].X, point3D[3].Y, point3D[0].X, point3D[0].Y); 
                        graphics.DrawLine(pen, point3D[5].X, point3D[5].Y, point3D[0].X, point3D[0].Y); 
                        graphics.DrawLine(pen, point3D[3].X, point3D[3].Y, point3D[5].X, point3D[5].Y);
                    }

                    n = View3D.CalcNormal(pyramidPoints[5], pyramidPoints[3], pyramidPoints[1]);

                    if (n.Z * cameraDist + n.X * pyramidPoints[5].X + n.Y * pyramidPoints[5].Y + n.Z * pyramidPoints[5].Z > 0)
                    {
                        var s = Math.Abs(n.X * button2.Location.X + n.Y * button2.Location.Y + n.X * pyramidPoints[3].X + n.Y * pyramidPoints[3].Y + n.Z * pyramidPoints[3].Z);
                        Color color = new Color();

                        s = (s - 0) / (25500 - 0); //Нормалізуємо значення

                        if (s < 255) { color = Color.FromArgb(0, 0, (int)s); }
                        else { color = Color.FromArgb(0, 0, 255); }

                        brush = new SolidBrush(color);

                        //Третя сторона
                        graphics.FillPolygon(brush, new PointF[3] { new PointF(point3D[3].X, point3D[3].Y), new PointF(point3D[5].X, point3D[5].Y), new PointF(point3D[1].X, point3D[1].Y) });
                        graphics.DrawLine(pen, point3D[3].X, point3D[3].Y, point3D[5].X, point3D[5].Y); 
                        graphics.DrawLine(pen, point3D[5].X, point3D[5].Y, point3D[1].X, point3D[1].Y); 
                        graphics.DrawLine(pen, point3D[3].X, point3D[3].Y, point3D[1].X, point3D[1].Y);
                    }

                    n = View3D.CalcNormal(pyramidPoints[5], pyramidPoints[1], pyramidPoints[0]);

                    if (n.Z * cameraDist + n.X * pyramidPoints[5].X + n.Y * pyramidPoints[5].Y + n.Z * pyramidPoints[5].Z > 0)
                    {
                        var s = Math.Abs(n.X * button2.Location.X + n.Y * button2.Location.Y + n.X * pyramidPoints[3].X + n.Y * pyramidPoints[3].Y + n.Z * pyramidPoints[3].Z);
                        Color color = new Color();

                        s = (s - 0) / (25500 - 0); //Нормалізуємо значення

                        if (s < 255) { color = Color.FromArgb(0, 0, (int)s); }
                        else { color = Color.FromArgb(0, 0, 255); }

                        brush = new SolidBrush(color);

                        //Четверта сторона
                        graphics.FillPolygon(brush, new PointF[3] { new PointF(point3D[5].X, point3D[5].Y), new PointF(point3D[0].X, point3D[0].Y), new PointF(point3D[1].X, point3D[1].Y) });
                        graphics.DrawLine(pen, point3D[5].X, point3D[5].Y, point3D[0].X, point3D[0].Y); 
                        graphics.DrawLine(pen, point3D[5].X, point3D[5].Y, point3D[1].X, point3D[1].Y); 
                        graphics.DrawLine(pen, point3D[1].X, point3D[1].Y, point3D[0].X, point3D[0].Y);
                    }
                }
                pictureBox1.Refresh();
            }

            stopwatch.Stop();
            label12.Text = $"Час виконання: {stopwatch.Elapsed.Milliseconds.ToString()} мс";
            GC.Collect();
        }
        public class View3D
        {
            public class Point3D
            {
                public double X, Y, Z;

                public Point3D(int x, int y, int z) { X = x; Y = y; Z = z; }

                public Point3D(float x, float y, float z) { X = (double)x; Y = (double)y; Z = (double)z; }

                public Point3D(double x, double y, double z) { X = x; Y = y; Z = z; }

                public override string ToString() { return "(" + X.ToString() + ", " + Y.ToString() + ", " + Z.ToString() + ")"; }
            }

            //Матриця повороту по осі Х

            public static Point3D RotateX(Point3D point3D, double degrees)
            {
                double rad = (Math.PI * degrees) / 180.0f;
                double x = (point3D.X * Math.Cos(rad)) + (point3D.Z * Math.Sin(rad)); double z = (point3D.X * -Math.Sin(rad)) + (point3D.Z * Math.Cos(rad));

                return new Point3D(x, point3D.Y, z);
            }

            //Матриця повороту по осі Y

            public static Point3D RotateY(Point3D point3D, double degrees)
            {
                double rad = (Math.PI * degrees) / 180.0;
                double y = (point3D.Y * Math.Cos(rad)) + (point3D.Z * Math.Sin(rad)); double z = (point3D.Y * -Math.Sin(rad)) + (point3D.Z * Math.Cos(rad));

                return new Point3D(point3D.X, y, z);
            }

            //Матриця повороту по осі Z

            public static Point3D RotateZ(Point3D point3D, double degrees)
            {
                double rad = (Math.PI * degrees) / 180.0;
                double x = (point3D.X * Math.Cos(rad)) + (point3D.Y * Math.Sin(rad)); double y = (point3D.X * -Math.Sin(rad)) + (point3D.Y * Math.Cos(rad));

                return new Point3D(x, y, point3D.Z);
            }

            //Знаходимо різницю нової точки зі старою, а потім додаємо різницю

            public static Point3D DifferencePoints(Point3D point3D, Point3D oldOrigin, Point3D newOrigin)
            {
                Point3D difference = new Point3D(newOrigin.X - oldOrigin.X, newOrigin.Y - oldOrigin.Y, newOrigin.Z - oldOrigin.Z);
                point3D.X += difference.X; point3D.Y += difference.Y; point3D.Z += difference.Z;

                return point3D;
            }

            //Знаходимо нормаль для знаходження невидимих ліній

            public static Point3D CalcNormal(Point3D points3D1, Point3D points3D2, Point3D points3D3)
            {
                View3D.Point3D n = new View3D.Point3D(points3D1.Y * points3D3.Z - points3D2.Y * points3D3.Z - points3D1.Y * points3D2.Z - points3D1.Z * points3D3.Y + points3D2.Z * points3D3.Y + points3D1.Z * points3D2.Y, points3D1.Z * points3D3.X - points3D2.Z * points3D3.X - points3D1.Z * points3D2.X - points3D1.X * points3D3.Z + points3D2.X * points3D3.Z + points3D1.X * points3D2.Z, points3D1.X * points3D3.Y - points3D2.X * points3D3.Y - points3D1.X * points3D2.Y - points3D1.Y * points3D3.X + points3D2.Y * points3D3.X + points3D1.Y * points3D2.X);

                return n;
            }

            //Метод для повертання матриці по осі Х

            public static Point3D[] RotateX(Point3D[] points3D, double degrees)
            {
                for (int i = 0; i < points3D.Length; i++)
                {
                    points3D[i] = RotateX(points3D[i], degrees);
                }

                return points3D;
            }

            //Метод для повертання матриці по осі Y

            public static Point3D[] RotateY(Point3D[] points3D, double degrees)
            {
                for (int i = 0; i < points3D.Length; i++)
                {
                    points3D[i] = RotateY(points3D[i], degrees);
                }

                return points3D;
            }

            //Метод для повертання матриці по осі Z

            public static Point3D[] RotateZ(Point3D[] points3D, double degrees)
            {
                for (int i = 0; i < points3D.Length; i++)
                {
                    points3D[i] = RotateZ(points3D[i], degrees);
                }

                return points3D;
            }

            //Метод переміщення точок з доданою різницею

            public static Point3D[] MovePoints(Point3D[] points3D, Point3D oldOrigin, Point3D newOrigin)
            {
                for (int i = 0; i < points3D.Length; i++)
                {
                    points3D[i] = DifferencePoints(points3D[i], oldOrigin, newOrigin);
                }

                return points3D;
            }

        }

        //Задаємо точки піраміди

        public static View3D.Point3D[] Points(int width, int height, int depth)
        {
            View3D.Point3D[] verts = new View3D.Point3D[6];

            verts[0] = new View3D.Point3D(0, 0, 0);
            verts[1] = new View3D.Point3D(width, 0, 0);
            verts[2] = new View3D.Point3D(0, height, 0);
            verts[3] = new View3D.Point3D(0, 0, depth);
            verts[4] = new View3D.Point3D(width, 0, 0);
            verts[5] = new View3D.Point3D((int)(width/4), height,(int)(depth/4));

            return verts;
        }

        private void trackBar1_Scroll(object sender, EventArgs e) { button1_Click(sender, e); }
        private void trackBar2_Scroll(object sender, EventArgs e) { button1_Click(sender, e); }
        private void trackBar3_Scroll(object sender, EventArgs e) { button1_Click(sender, e); }

        //Переміщення світла
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MouseEventArgs me = (MouseEventArgs)e;
            button2.Location = me.Location;
        }
    }
}