using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using System.Drawing.Drawing2D;

namespace Курсова
{
    public partial class Form1 : Form
    {
        public int Y_axis;
        public int X_axis;

        public double hz;

        public double first_num;
        public double second_num;

        public int num_c;
        public int num_s;

        double x0, x1, x2, x3;
        double fx0, fx1, fx2, fx3;

        Graphics g;

        public double[,] array = new double[4, 25];
        public double[,] func;

        public Form1()
        {
            InitializeComponent();
        }
        private void Construction_graph_Click(object sender, EventArgs e)
        {
            Draw_G();
        }
        public void Draw_G() //Відмальовка графіка та будування функції і точок на ньому
        {
            g = graph.CreateGraphics();

            string num = promX.Text;
            string[] str = num.Split(' ');

            first_num = double.Parse(str[0]) - 1; //Перше число проміжку (початок)
            second_num = double.Parse(str[1]) + 1; //Друге число проміжку (кінець)
            
            Y_axis = 1;

            if (first_num >= 0 && second_num > 0)
            {
                num_c = Convert.ToInt32(second_num) - Convert.ToInt32(first_num);
                num_s = graph.Height / num_c;
            }
            else if (first_num < 0 && second_num < 0)   
            {
                num_c = Math.Abs(Convert.ToInt32(first_num) - Convert.ToInt32(second_num));
                num_s = graph.Height / num_c;
                Y_axis = num_s * num_c; //Задаємо значення осі Y
            }
            else
            {
                num_c = Convert.ToInt32(second_num) + Math.Abs(Convert.ToInt32(first_num));
                num_s = graph.Height / num_c;
                Y_axis = num_s * Convert.ToInt32(Math.Abs(first_num)); //Задаємо значення осі Y
            }

            X_axis = num_s * (num_c / 2); //Задаємо значення осі X

            hz = graph.Height / num_c;

            func = GetAllPoints();
            BuildFunc();
            MinValue_Func(first_num + 1, second_num - 1);
        }
        public void BuildFunc() //Відмальовка функції
        {
            Pen for_func = new Pen(Brushes.Blue, 2);

            Axis();

            for (int i = 0; i < graph.Width - 1; i++)
            {
                g.SmoothingMode = SmoothingMode.AntiAlias; //Задаємо якість відмальовки функції

                Point num1 = new Point(i, Convert.ToInt32((graph.Height / num_c) * (num_c / 2) - ((graph.Height / num_c) * func[1, i]))); //Перша частина графіку
                
                Point num2 = new Point(i + 1, Convert.ToInt32((graph.Height / num_c) * (num_c / 2) - (graph.Height / num_c * func[1, i + 1]))); //Друга частина графіку

                g.DrawLine(for_func, num1, num2);
            }
        }
        public void Axis()
        {
            Pen for_axis = new Pen(Brushes.Black, 2); //для осей

            g.DrawLine(for_axis, new Point(num_s * Convert.ToInt32(Math.Abs(first_num)), 0), new Point(num_s * Convert.ToInt32(Math.Abs(first_num)), graph.Height)); //Малюємо вісь Y

            g.DrawLine(for_axis, new Point(0, num_s * (num_c / 2)), new Point(graph.Width, num_s * (num_c / 2))); //Малюємо вісь Х
        }
        public double[,] GetAllPoints() //Знаходження точок для функції
        {
            double[,] array = new double[2, graph.Width];

            double output;

            double x = first_num;

            for (int i = 0; i < graph.Width; i++)
            {
                string ins = equation.Text.Replace("x", x.ToString("F", CultureInfo.CreateSpecificCulture("en-US"))); //Перетворюємо значення функції на CultureInfo, що представляє конкретну культуру, пов'язану із вказаною назвою
                output = Convert.ToDouble(new DataTable().Compute(ins, "")); //Використаємо метод DataTable().Compute для виконання операцій над даними

                array[0, i] = x;
                array[1, i] = output;
                x = x + 1 / Convert.ToDouble(num_s);

            }

            return array;
        }
        public void MinValue_Func(double first_num, double second_num)
        {
            x0 = first_num;
            x1 = (first_num + second_num) / 2;
            x2 = second_num;
            x3 = 0;
            
            fx0 = C_Func(x0);
            fx1 = C_Func(x1);
            fx2 = C_Func(x2);
            fx3 = 0;

            double min = Convert.ToDouble(minimum.Text);

            double xx = (x0 + x1) / 2 - (fx1 - fx0) * (x2 - x0) * (x2 - x1) / (2 * ((fx1 - fx0) * (x2 - x0) - (fx2 - fx0) * (x1 - x0)));
            double fxx = C_Func(xx - 1);

            array[0, 0] = x0;
            array[1, 0] = x1;
            array[2, 0] = x2;
            array[3, 0] = xx;
            
            while (x1 - xx >= min && x2 - xx >= min)
            {
                if (xx < x1)
                {
                    x3 = x2; fx3 = fx2; x2 = x1; fx2 = fx1; x1 = xx; fx1 = fxx;
                }
                else if(xx > x1)
                {
                    x3 = x2; fx3 = fx2; fx2 = xx; fx2 = fxx;
                }
                if (fx1 > fx2)
                {
                    x0 = x1; fx0 = fx1; x1 = x2; fx1 = fx2; x2 = x3; fx2 = fx3;
                }
            }

            PrintAllSteps();
            Draw_P();
        }
        public double C_Func(double x) //Обчислення точок
        {
            string str = equation.Text.Replace("x", x.ToString("F", CultureInfo.CreateSpecificCulture("en-US"))); //Перетворюємо значення функції на CultureInfo, що представляє конкретну культуру, пов'язану із вказаною назвою
            double fx = Convert.ToDouble(new DataTable().Compute(str, "")); //Використаємо метод DataTable().Compute для виконання операцій над даними
            return fx;
        }
        public void PrintAllSteps() //Друкування точок які були знайдені методом парабол
        {
            label5.Text = "x0 = " + Math.Round(array[0, 0], 4) + "\nx1 = " + Math.Round(array[1, 0], 4) + "\nx2 = " + Math.Round(array[2, 0], 4) + "\nx* = " + Math.Round(array[3, 0], 4); //Виписуємо значення точок
        }
        public void Draw_P() //Відмальовка точок які були знайдені методом парабол
        {
            SolidBrush color = new SolidBrush(Color.Black); //Для точок

            string[] text = new string[4] { "x0", "x1", "x2", "x*" }; //Задаємо букви для графіка

            for (int i = 0; i < array.GetLength(0); i++) //Малюємо точки та букви на графіку
            {
                RectangleF Drawpoint = new RectangleF(Convert.ToInt32(Y_axis + array[i, 0] * hz), Convert.ToInt32(X_axis - C_Func(array[i, 0]) * hz) - 5, 8, 8); //Задаємо координати точок для функції
                g.FillEllipse(color, Drawpoint); //Малюємо точки для функції

                RectangleF x_axis = new RectangleF(Convert.ToInt32(Y_axis + array[i, 0] * hz) - 3, X_axis - 5, 8, 8); //Задаємо координати для точок для осі Х
                RectangleF x_axis2 = new RectangleF(Convert.ToInt32(Y_axis + array[i, 0] * hz) - 3, X_axis + 4, 20, 15); //Задаємо координати для букв на осі Х
                g.FillEllipse(color, x_axis); //Малюємо точки на осі X
                g.DrawString(text[i], label1.Font, color, x_axis2); //Малюємо букви на осі Х

                RectangleF y_axis = new RectangleF(Y_axis - 5, Convert.ToInt32(X_axis - C_Func(array[i, 0]) * hz) - 5, 8, 8); //Задаємо координати для точок для осі Y
                RectangleF y_axis2 = new RectangleF(Y_axis + 5, Convert.ToInt32(X_axis - C_Func(array[i, 0]) * hz) + 3, 30, 15); //Задаємо координати для букв на осі Y
                g.FillEllipse(color, y_axis); //Малюємо точки на осі Y
                string str = "f(" + text[i] + ")";
                g.DrawString(str, label1.Font, color, y_axis2); //Малюємо букви на осі Y
            }
        }
        public void Deleted_Click(object sender, EventArgs e)
        {
            graph.Series[0].Points.Clear(); //Очищюємо графік
            equation.Text = ""; //Очищюємо поле для вводу функції
            promX.Text = ""; //Очищюємо поле для вводу проміжку
            minimum.Text = ""; //Очищаємо мінімальне значення
            label5.Text = ""; //Очищаємо значення
        }
        public void Example1_Click(object sender, EventArgs e)
        {
            equation.Text = "x*x-5";
            promX.Text = "-2 5";
            minimum.Text = "0,01";
        }
        public void Example2_Click(object sender, EventArgs e)
        {
            equation.Text = "x*x*x*x-2*x*x+3*x+1";
            promX.Text = "-2 3";
            minimum.Text = "0,5";
        }
    }
}