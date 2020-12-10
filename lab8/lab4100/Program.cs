using System;
using System.Collections.Generic;

using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4100
{
    class film
    {
        public string name;
        public string YearOfRelease;

        public film()
        {

        }
        public film(string name,string YearOfRelease)
        {
            this.name = name;
            this.YearOfRelease = YearOfRelease;
        }
    }
    class news
    {
        public string name_of_programm;
        #region lb7
        public string nameOfReader;
        public int broadCastTime;

        
        #endregion
        public news()
        {
        }

        public news(string name_of_programm, int broadCastTime, string nameOfReader)
        {
            this.name_of_programm = name_of_programm;
            this.broadCastTime = broadCastTime;
            this.nameOfReader = nameOfReader;

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string str = "при5ет";

            try
            {

                CollectionType<int> set1 = new CollectionType<int>();
                CollectionType<news> set2 = new CollectionType<news>();
                CollectionType<film> set3 = new CollectionType<film>();

                int[] abc = new int[] { 1 };
                int[] absc = new int[] { 1,2 };
                set1.Add(abc);
                set1.Add(absc);
                set1.Remove(2);
                set1.Check();
                set1.WriteToFile();
                set1.ReadFromFile();
            }
            catch { Console.WriteLine("Exception ready!"); }
            finally { Console.WriteLine("Finally"); }
        }
    }

    

}
