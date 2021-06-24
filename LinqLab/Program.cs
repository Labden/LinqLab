using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqLab
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[] { 10, 2230, 112233, 10, 949, 3764, 2942 };

            List<Students> students = new List<Students>();
            students.Add(new Students("Jimmy", 13));
            students.Add(new Students("Hannah Banana", 21));
            students.Add(new Students("Justin", 30));
            students.Add(new Students("Sarah", 53));
            students.Add(new Students("Hannibal", 15));
            students.Add(new Students("Philip", 16));
            students.Add(new Students("Maria", 63));
            students.Add(new Students("Abe", 33));
            students.Add(new Students("Curtis", 10));
            Console.WriteLine("Our array of numbers:");
            PrintNums(nums);
            Console.WriteLine();
            Console.WriteLine();
            //Nums
            //Find Min Value
            //Find Max Value less than 10000
            //Find all values between 10 and 100
            //Find all the values between 100000 and 999999 inclusive
            //Count all the even numbers
            int minValue = nums.Min();
            Console.WriteLine("Min value: " + minValue);

            int maxValue = nums.Max();
            Console.WriteLine("Max value: " + maxValue);

            List<int> under10k = nums.Where(x => nums.Max() < 10000).ToList();
            Console.WriteLine("Max value under 10k: " + under10k);
            foreach (int num in under10k)
            {
                Console.WriteLine(num);
            }

            List<int> between10and100 = nums.Where(x => x < 100).ToList();
            Console.WriteLine("All values between 100,000 and 999,999: " + between10and100);
            foreach (int num in between10and100)
            {
                Console.WriteLine(num);
            }

            List<int> evenNums = nums.Where(x => x % 2 == 0).ToList();
            Console.WriteLine("All even numbers: " + evenNums);
            foreach (int num in evenNums)
            {
                Console.WriteLine(num);
            }




            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            //For Students
            //Find all students age of 21 and over
            //Find the oldest student
            //Find the youngest student
            //Find the oldest student under the age of 25
            //Find all students over 21 and with even ages
            //Find all teenage students (13 to 19 inclusive)
            //Find all students whose name starts with a vowel

            PrintStudents(students);

            List <Students> drinkingAge = students.Where(s => s.Age >= 21).ToList();
            foreach (Students s in drinkingAge)
            {
                Console.WriteLine(s.Age);
            }

            int oldest = students.Max(x => x.Age);
            Console.WriteLine("The oldest student is: " + oldest);

            int youngest = students.Min(x => x.Age);
            Console.WriteLine("The youngest student is: " + youngest);

            List<Students> studentsUnder25 = students.Where(x => x.Age < 25).ToList();
            string oldestunder25 = studentsUnder25.Max(x => x.Name);
            Console.WriteLine("The oldest student under 25 is: " + oldestunder25);

            List<Students> over21AndEven = students.Where(x => x.Age > 21 && x.Age % 2 == 0).ToList();
            string over21AndEvenStudents = over21AndEven.Max(x => x.Name);
            Console.WriteLine("The students that are over 21 and have even ages are: " + over21AndEvenStudents);

            //List<Students> vowelStudents = students.Contains();

            double averageAge = students.Average(x => x.Age);
            Console.WriteLine("Average Age: " + averageAge);


        }

        public static void PrintStudents(List<Students> students)
        {
            foreach (Students s in students)
            {
                Console.WriteLine();
                Console.WriteLine("Name: " + s.Name);
                Console.WriteLine("Age: " + s.Age);
            }
        }
        public static void PrintNums(int[] nums)
        {
            foreach (int num in nums)
            {
                Console.WriteLine(num);
            }
        }

        public static bool HasVowel(char c)
        {
            char[] vowels = { 'a', 'e', 'i', 'o', 'u' };

            return vowels.Contains(c);
            //return c.ToString() == vowels.ToString();
        }
    }
}
