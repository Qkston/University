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
            if (enumType is null || !enumType.IsEnum)
            {
                throw new Exception("EnumType must not be null and of type Enum");
            }

            EnumType = enumType;
        }
        public override object ProvideValue(IServiceProvider serviceProvider)
        {
            return Enum.GetValues(EnumType);
        }
    }
}
