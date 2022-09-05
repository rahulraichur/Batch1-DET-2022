//using System;
//using System.Collections.Generic;
//using System.ComponentModel.DataAnnotations;
//using System.Diagnostics;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Batch1_DET_2022
//{
//    internal class LearnLINQ
//    {
//        public static void Main()
//        {


//            //List<int> num = new List<int>();
//            //num.Add(100);
//            //num.Add(103);
//            //num.Add(105);
//            //num.Add(102);

//            //var numQuery= num.Where(x => x%2==0);

//            //num.Add(205);
//            //num.Add(301);
//            //num.Add(400);
//            //foreach (int number in numQuery)
//            //{
//            //    Console.WriteLine("{0}", num);

//            //}
//            //Console.ReadLine();



//            //int[] nums = { 109, 22, 108 };

//            //var result = nums.OrderBy(n => n);

//            //Console.WriteLine("Ordered list of numbers:");
//            //foreach (int num in result)
//            //   Console.WriteLine(num);


//            //char[] characters = { 'R', 'A', 'H', 'U', 'L', 'R' };

//            //var result = characters.Reverse();

//            //Console.WriteLine("Characters in reverse order:");
//            //foreach (char character in result)
//            // Console.WriteLine(character);

//            //string[] city = { "Gandhinagar", "Hyderabad", "Surat", "Belgaum", "Bangalore",
//            //            "Hubli", "Kolkata", "Bhubaneshwar" };

//            ////var result = city.OrderBy(c => c.Length).ThenBy(c => c);
//            //var result = city.OrderBy(c => c.Length).ThenByDescending(c => c);

//            //Console.WriteLine("Ordered list of cities");
//            //foreach (string cities in result)
//            //   Console.WriteLine(cities);



//            //string[] words = { "Rahul", "Shishir", "Rohan", "Dhanush", "Rutuja", "Suruchi" };

//            //var result = words.Skip(1);

//            //Console.WriteLine("After skipping the word list is :");
//            //foreach (string word in result)
//            //    Console.WriteLine(word);



//            //Intersect
//            //int[] numbers1 = { 9, 8, 7 };
//            //int[] numbers2 = { 7, 8, 4 };

//            //var result = numbers1.Intersect(numbers2);

//            //Console.WriteLine("Duplicates in the list are :");
//            //foreach (int number in result)
//            //    Console.WriteLine(number);


//            //int[] numbers1 = { 1, 2, 3 };
//            //int[] numbers2 = { 3, 4, 5 };

//            //var result = numbers1.Union(numbers2);

//            //Console.WriteLine("After Duplicates are removed :");
//            //foreach (int number in result)
//            //    Console.WriteLine(number);

//            //var numbers = new int[] { 9, 3, 4, 2, 7 };

//            //   var result = numbers.Aggregate((a, b) => a * b);

//            //   Console.WriteLine("Aggregated numbers by multiplication:");
//            //   Console.WriteLine(result);

//            //int[] numbers = { 1,102,13,19,11,32,78 };

//            //var result = numbers.Average();

//            //Console.WriteLine("Average is:");
//            //Console.WriteLine(result);


//            //string[] names = { "Rahul", "Dhanush", "Rohan", "Shishir", "Abhilash","MSD","virat"};

//            //var result = names.Count();

//            //Console.WriteLine("Number of names :");
//            //Console.WriteLine(result);


//            //ASSIGNMENT 1
//            //string[] names = { "Shishir", "Dhanush", "Rohan" };


//            //var result = names.Where(names => names.Contains("o"));

//            //Console.WriteLine("name which contain o :");
//            //foreach (string name in result)
//            //    Console.WriteLine(name);


//            ////ASSIGNMENT 2 
//            //{
//            //    string[] capitals = { "John", "Peter", "Jacob", "Harry", "Jackson" };

//            //    var res = capitals.OrderBy(c => c.Length);
//            //    var result = capitals.Skip(4);

//            //    Console.WriteLine("Name which has max no of character length:");
//            //    foreach (string capital in result)
//            //        Console.WriteLine(capital);
//            //}




//            //Assignment 4

//            //string[] words = { "blueberry", "blackberry", "abacus" };
//            //foreach (string item in words)
//            //    Console.WriteLine(item.Reverse().ToArray());


//            ////Assignment 5

//            //string[] subjects = {"C#", "SQL", "LINQ", "Java"};

//            //var subs=

//            //select subjects[1];

//            //Console.WriteLine("subject is :");
//            //foreach (var num in Nums)
//            //{
//            //    Console.WriteLine(subjects);
//            //}


//            //Assignment 3

//            string[] words = { "believe", "relief", "reciept", "field" };
//            foreach (string m in words)
//                Console.WriteLine($"{m} -- {m.Length}");



//            //Example

//            //{
//            //    List<string> words = new List<string> { "Rahul", "Rohan", "Rutuja", "Dhanush", "Dharmendra", "shishir", "suruchi" };

//            //    var WordGroups = words.GroupBy(x => x[0]).Select(y => new { FirstLetter = y.Key, Words = y });

//            //    foreach(var item in WordGroups)
//            //    {
//            //        Console.WriteLine("words that start with" + "letter '{0}':", item.FirstLetter);

//            //        foreach (var w in item.Words)
//            //        {
//            //            Console.WriteLine(w);
//            //        }
//            //    }
//            //}


//            //Example 2

//           // List<string> words = new List<string> { "Rahul", "Rohan", "Rutuja", "Dhanush", "Dharmendra", "shishir", "suruchi" };
            
//           // foreach (string m in words)
//           // {
//           //     Console.WriteLine($"{m} -- {m.Length}");
//           // }
//           // var WordGroups = words.GroupBy(x => x.Length).Select(y => new { FirstLetter = y.Key, Words = y });
//           // foreach (var item in WordGroups)
//           //{
//           //       Console.WriteLine("words that start with" + "letter '{0}':", item.FirstLetter);

//           //            foreach (var w in item.Words)
//           //            {
//           //                Console.WriteLine(w);
//           //            }
                

//           // }


















//        }

//    }
//}
