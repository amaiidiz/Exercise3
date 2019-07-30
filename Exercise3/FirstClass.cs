using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3
{
    public class FirstClass
    {

        public void CompareStrings(string string1, string string2)
        {
            int lenghtWord1 = string1.Length;
            int lenghtWord2 = string2.Length;

            if (lenghtWord1 == lenghtWord2)
                Console.WriteLine("They have same lenght");
            else
                Console.WriteLine("They do not have the same lenght");
        }

        public void CompareLists(int number1, int number2)
        {
            var list1 = new List<int>();
            var list2 = new List<int>();

            for (int i = 0; i <= number1 - 1; i++)
            {
                list1.Add(i);
            }
            Console.WriteLine("The size of the fisrt List is: " + list1.Count);

            for (int i = 0; i <= number2 - 1; i++)
            {
                list2.Add(i);
            }
            Console.WriteLine("The size of the second List is: " + list2.Count);

            if (list1.Count == list2.Count)
                Console.WriteLine("The lists have the same size");
            else
                Console.WriteLine("The lists do not have the same size");

        }

        public void CompareList2(List<string> words)
        {
            
            Console.WriteLine("-Sorting Asc-");
            words.Sort();
            foreach (string i in words)
            {
                Console.WriteLine(i);
            }

            Console.ReadLine();
            
            Console.WriteLine("-Reverse Desc-");
            words.Reverse();
            foreach (string n in words)
            {
                Console.WriteLine(n);
            }
        }

        public void FilterList(List<string> words, string filter)
        {
            var list = words.Where(e => e.ToLower().Contains(filter.ToLower()));
            Console.WriteLine("Words in the list that contains: " + filter);
            foreach ( var print in list)
            {
                Console.WriteLine(print);
            }
        }

        public void DuplicateNumbers(List<int> numbers)
        {
            Console.WriteLine("List with duplicate numbers:");
            foreach(int value in numbers)
            {
                Console.WriteLine(value);
            }

            Console.WriteLine("List without duplicate numbers");
            List<int> distinct = numbers.Distinct().ToList();
            foreach(int value in distinct)
            {
                Console.WriteLine(value);
            }
        }
    }

    public class ClassB : FirstClass, Interface1
    {
        public void CompareNewLists(List<string> lista, string word)
        {
            foreach(string i in lista)
            {
                CompareStrings(word, i);
            }
        }

        public void PrintHello()
        {
            Console.WriteLine("Hello Interface 2.0");
        }
    }

}
