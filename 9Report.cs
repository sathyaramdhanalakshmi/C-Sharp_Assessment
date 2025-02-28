using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConcepts
{
    public interface IPrintable
    {
        void Print();
    }

    public interface ISerializable
    {
        void SaveToFile(string filename);
    }

    public class Report : IPrintable, ISerializable
    {
        private string content;

        public Report(string content)
        {
            this.content = content;
        }

        public void Print()
        {
            Console.WriteLine("Printing Report: " + content);
        }

        public void SaveToFile(string filename)
        {
            File.WriteAllText(filename, content);
            Console.WriteLine("Report saved to file: " + filename);
        }
    }
}
