using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            string word1;
            string word2;
            string word3;
            var ListString = new List<string>() { "eneida", "Juan", "Diana", "Pedro", "Pablo", "Luz"};
            var StringList2 = new List<string>() { "Text", "Computer", "Automation", "Visual Studio", "Auto Parts", " " };
            var ListNumbers = new List<int>() { 1, 1, 2, 3, 4, 4, 5, 6, 7, 8, 10 };

            int list1 = 0 ;
            int list2 = 0;

            FirstClass Strings = new FirstClass();
            FirstClass Lists = new FirstClass();
            ClassB Compare = new ClassB();
            print Inter1 = new print();
            FirstClass SortList = new FirstClass();
            FirstClass FilterWords = new FirstClass();
            FirstClass Duplicate = new FirstClass();

            Console.WriteLine("*****Activity 1*****");
            Console.WriteLine("Add first word");
            word1 = Console.ReadLine();
            Console.WriteLine("Add second word");
            word2 = Console.ReadLine();
            Strings.CompareStrings(word1, word2);
            Console.ReadLine();
            Console.WriteLine("*****Activity 2*****");
            Console.WriteLine("Enter the size of the first list");
            string lenght1 = "0";
            lenght1 = Console.ReadLine();
            list1 = Convert.ToInt16(lenght1);
            Console.WriteLine("Enter the size of the second list");
            string lenght2 = "0";
            lenght2 = Console.ReadLine();
            list2 = Convert.ToInt16(lenght2);
            Lists.CompareLists(list1, list2);
            Console.ReadLine();
            Console.WriteLine("*****Activity 3*****");
            Console.WriteLine("The List have the following elements: eneida Juan, Diana, Pedro, Pablo, Luz");
            Console.WriteLine("Add the word to compare with the rest of the elements in the list");
            word2 = Console.ReadLine();
            Compare.CompareNewLists(ListString,word2);
            Console.ReadLine();
            Console.WriteLine("*****Activity 4*****");
            Inter1.PrintHello();
            Console.ReadLine();
            Console.WriteLine("*****Activity 5*****");
            Compare.PrintHello();
            Console.ReadLine();
            Console.WriteLine("*****Activity 6*****");
            SortList.CompareList2(StringList2);
            Console.ReadLine();
            Console.WriteLine("*****Activity 7*****");
            Console.WriteLine("The list have the following elements: Text, Computer, Automation, Visual Studio, Auto Parts");
            Console.WriteLine("Enter the word to filter:");
            word3 = Console.ReadLine();
            FilterWords.FilterList(StringList2, word3);
            Console.ReadLine();
            Console.WriteLine("*****Activity 8*****");
            Console.WriteLine("The list have the following elements: 1, 1, 2, 3, 4, 4, 5, 6, 7, 8, 10 ");
            Duplicate.DuplicateNumbers(ListNumbers);
            Console.ReadLine();
        }
    }
}
