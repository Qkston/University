using System;

namespace LAB4
{
    public enum TypeValue
    {
        Passenger, Sport, Cabriolet, Jeep
    }
    public class Category
    {
        public Type EnumType { get; private set; }

        public Category(Type enumType) { EnumType = enumType; }

        public static implicit operator Category(Vehicle v)
        {
            throw new NotImplementedException();
        }
    }
}
