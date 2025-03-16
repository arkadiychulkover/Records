using System.Runtime.CompilerServices;

namespace Records
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(3.IsntEqual());

            Console.WriteLine(4.IsEqual());

            Console.WriteLine("hello".HowMuchVowels());

            Console.WriteLine(4.IsSimple());

            Console.WriteLine("hello".HowMuchNotVowels());

            Console.WriteLine("hello".Reverse());
        }
    }

    public static class test
    {
        public static bool IsntEqual(this int a)
        {
            return a % 2 != 0;
        }
        public static bool IsEqual(this int a)
        {
            return a % 2 == 0;
        }
        public static int HowMuchVowels(this string a)
        {
            int count = 0;
            foreach (char item in a)
            {
                if (item == 'a' || item == 'e' || item == 'i' || item == 'o' || item == 'u')
                {
                    count++;
                }
            }
            return count;
        }
        public static bool IsSimple(this int a)
        {
            for (int i = 2; i < a; i++)
            {
                if (a % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
        public static int HowMuchNotVowels(this string a)
        {
            int count = 0;
            foreach (char item in a)
            {
                if (item != 'a' && item != 'e' && item != 'i' && item != 'o' && item != 'u')
                {
                    count++;
                }
            }
            return count;
        }
        public static int HowMuchSentenses(this string a)
        {
            int count = 0;
            foreach (char item in a)
            {
                if (item == '.' || item == '?' || item == '!')
                {
                    count++;
                }
            }
            return count;
        }
        public static string Reverse(this string a)
        {
            string temp = "";
            for (int i = a.Length - 1; i >= 0; i--)
            {
                temp += a[i];
            }
            return temp;
        }
        public static Person MinAge(this Person[] arr) 
        {
            Person temp = arr[0];
            foreach (Person item in arr)
            {
                if (temp.Age > item.Age)
                {
                    temp = item;
                }
            }
            return temp;
        }
        public static Person MaxAge(this Person[] arr)
        {
            Person temp = arr[0];
            foreach (Person item in arr)
            {
                if (temp.Age < item.Age)
                {
                    temp = item;
                }
            }
            return temp;
        }
    }
    public record Person(string Name, int Age, string SecondName);
    
}
