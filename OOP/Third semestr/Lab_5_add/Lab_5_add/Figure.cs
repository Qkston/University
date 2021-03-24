using System.Drawing;

namespace Lab_5_add
{
    abstract class Figure
    {
        public Color colour
        {
            get;
            set;
        }
        private double X_;
        private double Y_;
        public double x
        {
            get
            {
                return X_;
            }
            set
            {
                X_ = x;
            }
        }
        public double y
        {
            get
            {
                return Y_;
            }
            set
            {
                Y_ = y;
            }
        }
        public abstract void DrawBlack();
        public abstract void HideDrawingBackGround();
        public void MoveRight()
        {
            for (int i = 0; i < 250; i++)
            {
                DrawBlack();
                System.Threading.Thread.Sleep(15);
                HideDrawingBackGround();
                X_++;
            }
        }
    }
}