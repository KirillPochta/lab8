using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace lab4100
{
    public class Date
    {
        public int day;
        public int month;
        public int year;
        public Date(int day,int month,int year)
        {
            this.day = day;
            this.month = month;
            this.year = year;
        }

       
    }


    
    class Owner
    {
        public int id;
        public string name;
        public string name_or_organization;
        public Owner(int id, string name, string name_or_organization)
        {
            this.id = id;
            this.name = name;
            this.name_or_organization = name_or_organization;
        }
        public void GetInfo()
        {
            Console.WriteLine($"Имя: {name}  id: {id} имя организации {name_or_organization}");
        }
    }

    public class Set
    {
        static Owner Kirill = new Owner(7, "Кирилл", "ByTech");
        public int[] mnojestvo;
        public Set(int[] values)
        {
            mnojestvo = values;
        }
        
        public static bool operator >(Set A,int b)
        {
            int ab = 0;
            foreach(int s1 in A.mnojestvo)
            {
                if (s1 == b) ab++;
                

            }
            if (ab > 0)
                return true;
            else
                return false;
            
        }
        public static bool operator <(Set A, int b)
        {
                return false;
        }

        public static bool operator <(Set A, Set B)
        {
            int ab1 = 0;
            for(int i = 0; i < A.mnojestvo.Length; i++)
            {
                for(int j=0;j<B.mnojestvo.Length;j++)
                {
                    if (A.mnojestvo[i] == B.mnojestvo[j])
                    {
                        ab1++;
                        
                    }
                }
            }
            if (ab1 == A.mnojestvo.Length)
                return true;
                else 
                return false;         
           
        }
        public static bool operator >(Set A, Set B)
        {
            return false;
        }


        public static Set operator *(Set s1, Set s2)
        {
            int len = 0, ind = 0;
            foreach (int w1 in s1.mnojestvo)
            {
                foreach (int w2 in s2.mnojestvo)
                {
                    if (w1 == w2)
                    {
                        len++;
                    }
                }
            }
            int[] z = new int[len];
            foreach (int w1 in s1.mnojestvo)
            {
                foreach (int w2 in s2.mnojestvo)
                {
                    if (w1 == w2)
                    {
                        z[ind] = w1;
                        ind++;
                    }
                }
            }
            return new Set(z);
        }
        public  int Sum(Set set)
        {
            int sum = 0;
            for (int i = 0; i < set.mnojestvo.Length; i++)
            {
                sum += set.mnojestvo.Length;
            }
            return sum;
        }
        public  int RAznost(Set A)
        {
            int max = A.mnojestvo[0]; int min = A.mnojestvo[0];
            for (int i = 0; i < A.mnojestvo.Length; i++)
            {
                if (max > A.mnojestvo[i]) max = A.mnojestvo[i];
                if (min > A.mnojestvo[i]) min = A.mnojestvo[i];

            }
            return max - min;
        }

    }
}
