using System;

namespace zalik
{
    public class music : iskus
    {
        protected string key;
        public music(string name, string nazv, int data, string key) : base(name, nazv, data)
        {
            this.name = name;
            this.nazv = nazv;
            this.data = data;
            this.key = key;
        }
        public string Key
        {
            get { return key; }
            set { if (key != null) key = value; }
        }
        public new void ekran()
        {
            Console.WriteLine($"Автор: {name}, Назва: {nazv}, Дата створення: {data}, Тональнiсть: {key}");
        }
    }
}