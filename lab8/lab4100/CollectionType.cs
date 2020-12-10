using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4100
{
    class CollectionType<T> : IGeneralization<T> where T : new()
    {
        public List<T> ForWork = new List<T>();
        public int count = 0;
        
        public T CountOfList(int i)
        {
            return ForWork[i];
        }
        public void WriteToFile(string path = @"C:\file.txt")
        {
            StreamWriter writer = new StreamWriter(path);
            if (writer == null)
                throw new Exception("File does not open");

            foreach (T i in ForWork)
                writer.WriteLine(i);

            writer.Close();
        }

        public string[] ReadFromFile(string path = @"C:\file.txt")
        {
            StreamReader reader = new StreamReader(path);
            if (reader == null)
                throw new Exception("File does not open");

            List<string> line = new List<string>();

            while (!reader.EndOfStream)
            {
                line.Add(reader.ReadLine());

            }
            reader.Close();
            string[] str = new string[line.Count];
            int i = 0;
            foreach (string j in line)
            {
                str[i] = j;
                i++;
            }
            return str;
        }
        public void Add(T[] item)
        {
            foreach (T i in item)
            {
                if (!ForWork.Contains(i))
                {
                    ForWork.Add(i);
                }
            }
        }

        public void Check()
        {
            foreach (T i in this.ForWork)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }

        public void Remove(T item)
        {
            ForWork.Remove(item);
        }


    }
}
