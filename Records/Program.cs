using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace Records
{
    internal class Program <T>
    {
        public T Max<T>(T a, T b, T c) where T : IComparable
        {
            if (a.CompareTo(b) > 0 && a.CompareTo(c) > 0)
            {
                return a;
            }
            else if (b.CompareTo(a) > 0 && b.CompareTo(c) > 0)
            {
                return b;
            }
            else
            {
                return c;
            }
        }
        static void Main(string[] args)
        {
            //Console.WriteLine(3.IsntEqual());

            //Console.WriteLine(4.IsEqual());

            //Console.WriteLine("hello".HowMuchVowels());

            //Console.WriteLine(4.IsSimple());

            //Console.WriteLine("hello".HowMuchNotVowels());

            //Console.WriteLine("hello".Reverse());

            Program<int> program = new Program<int>();
            Console.WriteLine(program.Max(1, 2, 3));
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
    public class Stek<T>
    {
        public T[] arr = new T[10];
        public int count = 0;
        public void Push(T a)
        {
            arr[count] = a;
            count++;
        }
        public void Pop()
        {
            count--;
            T[] temp = new T[count];
            for (int i = 0; i < count; i++)
            {
                temp[i] = arr[i];
            }
            arr = temp;
        }
        public T Peek()
        {
            return arr[count]; 
        }
        public int Count()
        {
            return count;
        }
    }

}
