using System;

namespace zalik
{
    public class iskus
    {
        protected string name;
        protected string nazv;
        protected int data;

        public iskus(string name, string nazv, int data)
        {
            this.name = name;
            this.nazv = nazv;
            this.data = data;
        }
        public string Name
        {
            get { return name; }
            set { if (name != null) name = value; }
        }

        public string Nazv
        {
            get { return nazv; }
            set { if (nazv != null) nazv = value; }
        }

        public int Date
        {
            get { return data; }
            set { if (data != 0) data = value; }
        }

        public void ekran()
        {
            Console.WriteLine($"Автор: {name}, Назва: {nazv}, Дата створення: {data}");
        }
    }
}