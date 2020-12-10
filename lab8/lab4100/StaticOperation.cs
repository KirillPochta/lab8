using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace lab4100
{
    public static class StaticOperation
    {
        public static int Sum(Set set)
        {
            int sum = 0;
            for(int i=0;i<set.mnojestvo.Length;i++)
            {
                sum += set.mnojestvo.Length;
            }
            return sum;
        }
        public static int RAznost(Set set)
        {
            int max = set.mnojestvo[0];int min = set.mnojestvo[0];
            for (int i = 0; i<set.mnojestvo.Length; i++)
            {
                if (max > set.mnojestvo[i]) max = set.mnojestvo[i];
                if (min > set.mnojestvo[i]) min = set.mnojestvo[i];
                
            }
            return max - min;
        }
        public static int Length(Set set)
        {
            
            return set.mnojestvo.Length;
        }

        public static int first_number_in_string(this string str)
        {
            
            Console.WriteLine(str.Where(x => Char.IsDigit(x)).ToArray());

            return 0;
        }
        public static void Dalete_plus_number(this Set A)
        {
            int gay = 0;
            List<int> arr = new List<int>();
            for(int i=0;i<A.mnojestvo.Length;i++)
            {
                if (0 >  A.mnojestvo[i])
                {
                    
                    arr.Add(A.mnojestvo[i]);
                    gay++;
                }

            }
            for(int i= 0; i<arr.Count; i++)
                Console.WriteLine(arr[i]);
        }

    }
}
