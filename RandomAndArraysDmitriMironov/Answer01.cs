//Coded By Dmitry Mironov QA 1021 course  2/4/2021
//Answer 02
//------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomAndArraysDmitriMironov
{

    class Answer01
    {

        static List<int> SortedArr = new List<int>();
        static Dictionary<int, int> PairsCollection = new Dictionary<int, int>();

        static void Main(string[] args)
        {
            int[] myArray = new int[100];


            //print the array to user
            PrintRandomNumbers(myArray);

            //Sort the array before continue.
            SortedArr = SortMyArray(myArray);

            //Search for repeated items
            //using Dictionary Generics object
            PairsCollection = SearchRepeatedValue(SortedArr);

            //Print the repeated values
            PrintRepeatedValues(PairsCollection);

            //Print Max
            PrintMax(PairsCollection);

            //Print Min
            PrintMin(PairsCollection);

            //Print Average
            double Average = CalculateAverage(PairsCollection);
            PrintAverage(Average);

        }


        //Custom methods............................................
        static double CalculateAverage(Dictionary<int, int> _dictionary)
        {
            double SumOfDictionary = 0;
            int NumberOfItemsInDictionary = _dictionary.Count;

            foreach (var item in _dictionary)
            {
                SumOfDictionary += item.Key;                   //Key is Number
            }                                                  //Value is number's appearances in total
                                                               //Calculate average
                                                               //Don't forget to cast to double!!!!
            double sum = SumOfDictionary / (double)NumberOfItemsInDictionary;
            return sum;
        } //done

        static void PrintRepeatedValues(Dictionary<int, int> _dictionary)
        {
            foreach (var Pair in _dictionary)
            {
                //Key= Number
                //Value= Number of appearances of this number
                Console.WriteLine("Value {0} occurred {1} times.", Pair.Key, Pair.Value);
            }
        } //done

        static Dictionary<int, int> SearchRepeatedValue(List<int> _listArr)
        {
            Dictionary<int, int> MyDictionary = new Dictionary<int, int>();
            foreach (var item in _listArr)
            {
                if (MyDictionary.ContainsKey(item)) //if my dictionary's (KEY/Value) =>Value's-value  contains a similar number, just increase the counter.
                {
                    MyDictionary[item]++;
                }
                else
                {
                    MyDictionary[item] = 1; //No, my dictionary doesn't contain this value add it to the Pair Key
                }

                //Doing this we end up with a fully completed Key-Value pairs Dictionary Object
                //Containing numbers'-amount, and their repetition's amount :-)
            }
            //return  MyDictionary Object
            return MyDictionary;
        } //done

        static void PrintMax(Dictionary<int, int> _pairsCollection)
        {

            int MaximumAppearences = 0;  //get the key based on the MaximumAppearences number
            int OfThisNumer = 0;

            //First get maximum appearances amount
            foreach (var item in _pairsCollection.Values)
            {
                if (item > MaximumAppearences)
                {
                    MaximumAppearences = item;
                }
            }
            //get the MaximumAppearance value by finding it within _pairsCollection Dictionary
            foreach (var item in _pairsCollection)
            {
                if (item.Value == MaximumAppearences)
                {
                    //get its key
                    //I Found it, lets add it to OfThisNumer variable
                    OfThisNumer = item.Key;
                }
            }

            //Find the greates number of all
            int greatestNumber = 0;
            foreach (var item in _pairsCollection.Keys)
            {
                if (item > greatestNumber)
                {
                    greatestNumber = item;
                }
            }
            Console.WriteLine("\nThe Number {0} is appeared {1} times\n" +
                "So the number with maximum appearances is: {2}", OfThisNumer, MaximumAppearences, OfThisNumer);
            Console.WriteLine("\nthe Max num is {0}", greatestNumber);
            //Console.Read();

        }  //done

        static void PrintMin(Dictionary<int, int> _pairsCollection)
        {
            //Don't forget to import use System.Linq to make OrderBy extension method to work :-)
            //Finding the very first Item within Dictionary Object.
            var SmallestKeyValuePair = _pairsCollection.OrderBy(kvp => kvp.Key).First();
            int smallestNumber = SmallestKeyValuePair.Key;

            foreach (var item in _pairsCollection.Keys)
            {
                if (item < smallestNumber)
                {
                    smallestNumber = item;
                }
            }
            Console.WriteLine("\nThe smallest number is {0}\n", smallestNumber);
            //Console.Read();

        }  //done!

        static void PrintAverage(double _param)
        {
            //Format decimal to represent only 3 digits after point
            Console.WriteLine("\nThe Average is: {0,2:#.000}", _param);
            Console.WriteLine("\npress any key to exit...");
            Console.Read();
        } //done

        static List<int> SortMyArray(int[] _arr)
        {
            List<int> SortedList = new List<int>();

            for (int i = 0; i < _arr.Length; i++)
            {
                //Fill the SortedArrList
                SortedList.Add(_arr[i]);
            }
            //Now simply Sort the List
            SortedList.Sort(); //will sort in Ascending

            return SortedList;
        } //done

        static void PrintRandomNumbers(int[] _aray)
        {
            Random rnd = new Random();

            for (int i = 0; i < _aray.Length; i++)
            {
                _aray[i] = rnd.Next(1, 50); //You can change the values between 0,50 it also works!!! I wanted to omit the zeros on the print
            }

            //print the 100 numbers to screen.
            Console.WriteLine("Hello User!\nYour array contains the following 100 Random numbers. Each fom 0 to 50:\n");
            for (int i = 0; i < _aray.Length; i++)
            {
                Console.Write("{0}\t ", _aray[i]); //print each item
            }
            Console.WriteLine("\n\nPress any key to continue...");
            Console.ReadLine();


        } //done


    }
}
