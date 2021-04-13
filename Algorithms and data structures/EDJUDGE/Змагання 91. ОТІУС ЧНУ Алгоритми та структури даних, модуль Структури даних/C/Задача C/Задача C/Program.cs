using System;

namespace ЗадачаC
{
    class Program
    {
        static void Main(string[] args)
        {
            int p = int.Parse(Console.ReadLine());
            Student[] array = new Student[p];

            for (int i = 0; i < array.Length; i++)
            {
                string surName = Console.ReadLine();
                string firstname = Console.ReadLine();
                string numberOfclass = Console.ReadLine();

                string dateOfBirthday = Console.ReadLine();
                array[i] = new Student(surName, firstname, numberOfclass, dateOfBirthday);
            }
            Array.Sort(array);

            foreach (Student value in array)
            {

                Console.WriteLine(value);
            }

        }
    }

    struct Student : IComparable<Student>
    {
        public string surName;
        public string firstname;
        public ClassNumber numberOfclass;
        public string dateOfBirthday;

        public Student(string surName, string firstname, string numberOfclass, string dateOfBirthday)
        {
            this.surName = surName;
            this.firstname = firstname;
            this.numberOfclass = new ClassNumber(numberOfclass.Trim());
            this.dateOfBirthday = dateOfBirthday;
        }

        public int CompareTo(Student object_1)
        {
            int rez;

            rez = this.numberOfclass.CompareTo(object_1.numberOfclass);
            if (rez != 0)
                return rez;

            return this.surName.CompareTo(object_1.surName);
        }


        public override string ToString()
        {
            return numberOfclass + " " +
                 surName + " " +
                   firstname + " " +
                     dateOfBirthday;
        }
    }

    struct ClassNumber : IComparable<ClassNumber>
    {
        public int number;
        public string letter;

        public ClassNumber(string numberOfclass)
        {
            string n = "";
            string l = "";

            for (int i = 0; i < numberOfclass.Length; i++)
            {
                if (Char.IsDigit(numberOfclass[i]))
                {
                    n = n + numberOfclass[i];
                }
                else
                {
                    l = l + numberOfclass[i];
                }
            }

            this.number = int.Parse(n);
            this.letter = l;
        }

        public override string ToString()
        {
            return number + "" + letter;
        }

        public int CompareTo(ClassNumber object_1)
        {
            int r = this.number.CompareTo(object_1.number);

            if (r != 0)
            {
                return r;
            }
            r = this.letter.CompareTo(object_1.letter);
            return r;
        }
    }
}