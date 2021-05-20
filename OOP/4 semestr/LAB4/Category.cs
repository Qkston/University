using System;
using System.ComponentModel;
using System.Windows.Markup;

namespace LAB4
{
    public enum TypeValue
    {
        Passenger, Sport, Cabriolet, Jeep
    }
    public class Category : MarkupExtension
    {
        public Type EnumType { get; private set; }

        public Category(Type enumType)
        {
            EnumType = enumType;
        }
        public override object ProvideValue(IServiceProvider serviceProvider)
        {
            return Enum.GetValues(EnumType);
        }
    }
}
