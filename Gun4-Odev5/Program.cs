using System;

namespace Gun4_Odev5
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string, string> myDictionary = new MyDictionary<string, string>();

            myDictionary.Add("1", "Engin");
            myDictionary.Add("2", "Furkan");

            Console.WriteLine(myDictionary.Length);
            
            myDictionary.Add("3", "Derin");

            Console.WriteLine(myDictionary.Length);

            myDictionary.Items();

        }
    }
}
