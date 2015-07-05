using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

public class SortAlphabetLength : IComparer
{
    public int Compare(Object x, Object y)
    {
        if (x.ToString().Length == y.ToString().Length)
            return string.Compare(x.ToString(), y.ToString());
        else if (x.ToString().Length > y.ToString().Length)
            return -1;
        else
            return 1;
    }
}

class Program 
{
    static void Main(string[] args)
    {

       
        StreamReader reader = File.OpenText(args[0]);
        string first = reader.ReadLine();
        int num = Convert.ToInt32(first);
        ArrayList strings = new ArrayList();
        while (!reader.EndOfStream)
        {
            strings.Add(reader.ReadLine());
          
        }

        SortAlphabetLength alphaLen = new SortAlphabetLength();
        strings.Sort(alphaLen);

        for (int i = 0; i < num; i++)
        {
            Console.WriteLine(strings[i]);
        }
        //Console.ReadLine();
    }
}