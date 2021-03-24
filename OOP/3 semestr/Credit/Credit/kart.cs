using System;

namespace zalik
{
    public class kart : iskus
    {
        protected int h;
        protected int w;

        public kart(string name, string nazv, int data, int h, int w) : base(name, nazv, data)
        {
            this.name = name;
            this.nazv = nazv;
            this.data = data;
            this.h = h;
            this.w = w;
        }
        public int H
        {
            get { return h; }
            set { if (h != 0) h = value; }
        }
        public int W
        {
            get { return w; }
            set { if (w != 0) w = value; }
        }
        public new void ekran()
        {
            Console.WriteLine($"Автор: {name}, Назва: {nazv}, Рiк створення:{data}, Висота: {h}, Ширина: {w}");
        }
    }
}