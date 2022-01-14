using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler.SharedCode
{
    public static class InputHelper
    {
        public static String[] ReadCSVInput(string path)
        {
            StreamReader reader = File.OpenText(path: path);
            String str = reader.ReadLine();
            string[] pieces = str.Split(',');
            return pieces;
        }

        public static String[] ReadCSVInputNoQuotes(string path)
        {
            StreamReader reader = File.OpenText(path: path);
            String str = reader.ReadLine();
            str = str.Replace("\"", String.Empty);
            string[] pieces = str.Split(',');
            return pieces;
        }

        public static List<string> ReadInput(string path)
        {
            StreamReader reader = File.OpenText(path: path);
            List<string> lines = new List<string>();
            while (!reader.EndOfStream)
            {
                string line = reader.ReadLine();
                lines.Add(item: line);
            }

            return lines;
        }
    }
}
