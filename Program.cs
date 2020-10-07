using System;

namespace JustInTest
{
    class Program
    {
        static void Main()
        {
            //int sumNumber=0;
            //int countNumber=0;
            //var nub = Convert.ToInt32(Console.ReadLine());
            //int[] array = new int[nub];
            //for (int i = 0; i < array.Length; i++)
            //{
            //    if (i >= 5)
            //        array[i] = i;
            //    else
            //        array[i] = i-10;
            //    Console.Write(array[i] + " ");
            //}
            //foreach (int i in array)
            //{
            //    if (i>0)
            //    {
            //        sumNumber += i;
            //        countNumber++;
            //    }
            //}
            //sumNumber = sumNumber / countNumber;
            //Console.WriteLine("\n"+sumNumber);
            //for (int i = 0; i < array.Length; i++)
            //{
            //    if (array[i] < 0)
            //        array[i] -= sumNumber;
            //    Console.Write(array[i] + " ");
            //}

            string s = "Hello Wermelion world, iws not werrid Wn won it me";
            string s1 = null;
            var count = 0;
            string[] words = s.Split(new char[] { ' ' });
            foreach (var ar in words)
            {
                if((ar.IndexOf('w') == 0)|| (ar.IndexOf('W') == 0))
                {
                    count++;
                    s1 += ar+" ";
                }

            }

            Console.WriteLine(s);
            Console.WriteLine(s1);
            Console.WriteLine(count);
            
            






        }
    }
}
