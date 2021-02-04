using System;
using System.Collections.Generic;
//Coded By Dmitry Mironov QA 1021 course  2/4/2021
//Answer 02
//------------------------------------------------
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Answer02
{
    class Answer02
    {
        static List<string[]> MyList = new List<string[]>();
        static List<string> MySortedList = new List<string>();
        static bool toSorAscending;

        static void Main(string[] args)
        {
            MyList = CreateThreeArrays();         //create 3 arrays and "put" them into a List
            SimplePrint(MyList);                  //Print 3 Unconcatinated  arrays on the screen.
            toSorAscending = AskUserHowToSort();  //Ask how to sort

            //Passing 3 arrays to a method + toSorAscending bool........ AS REQUESTED!
            MySortedList = Sort(toSorAscending, MyList);
            PrintMySortedList(MySortedList, toSorAscending); //Print based on selection
        }

        //Custom methods...........................................
        private static void PrintMySortedList(List<string> _List, bool _isSroted)
        {
            if (_isSroted)
            {
                //print sorted
                Console.WriteLine("\n\nHere is: Sorted And CONCATENATED ARRAY:\n");
                foreach (var item in _List)
                {
                    Console.Write("\t" + item);
                }
                Console.WriteLine("\n\nPress any key to exit..");
                Console.ReadLine();
            }
            else
            {
                //print sorted
                Console.WriteLine("\n\nHere is: UNSORTED CONCATENATED ARRAY:\n");
                foreach (var item in _List)
                {
                    Console.Write("\t" + item);
                }
                Console.WriteLine("\n\nPress any key to exit..");
                Console.ReadLine();
            }
        } //done

        private static List<string> Sort(bool toSorAscending, List<string[]> _myList)
        {
            List<string> concList = new List<string>();

            //Concatinating the strings into one single List
            foreach (var MyCollection in _myList)
            {
                foreach (var item in MyCollection)
                {
                    concList.Add(item);
                }
            }
            if (toSorAscending)
            {
                //do the sort
                concList.Sort();
            }

            return concList;
        } //done

        private static bool AskUserHowToSort()
        {
            bool IsAscending;
            Console.WriteLine("\n\nPress [y] button to Sort, or press any other key to proceed without sorting");
            string input = Console.ReadLine();
            if (input == "y")
            {
                IsAscending = true;
            }
            else
            {
                IsAscending = false;
            }
            return IsAscending;
        } //done

        private static List<string[]> CreateThreeArrays()
        {
            List<string[]> MyArrayList = new List<string[]>();
            string[] arr1 = new string[] { "F", "H", "E", "G", "D", "J", "C", "I", "B", "A", "dog" };
            string[] arr2 = new string[] { "N", "M", "K", "", "L", "lazy", "the", "O", "X", "P", "quick" };
            string[] arr3 = new string[] { "Y", "Q,", "over", "Z", "", "The", "fox", "", "jumps", "brown" };
            MyArrayList.Add(arr1);
            MyArrayList.Add(arr2);
            MyArrayList.Add(arr3);
            //The quick brown fox jumps over the lazy dog
            return MyArrayList;
        } //done

        private static void SimplePrint(List<string[]> _arrayList)
        {
            Console.WriteLine("\n Here are 3  UNCONCATENATE ARRAYS:");
            int ctr = 1;                                             
            foreach (var ListOfArrays in _arrayList)
            {
                Console.Write("\n\nArray: {0}\n", ctr);
                foreach (var item in ListOfArrays)
                {
                    Console.Write("\t" +"["+ item +"]");
                }
                ctr++;
            }
        } //done
    }

}
