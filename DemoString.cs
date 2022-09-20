using System;

namespace DemoString
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = "Puja";
            var lastName = "Pramudya";

            var fullName = firstName + " " + lastName;

            var fullName2 = string.Format("{0} {1}", firstName, lastName);

            //Console.WriteLine(fullName);
            //Console.WriteLine(fullName2);

            var names = new string[3] { "Radya", "Labs", "Teknologi" };
            var namesCombination = string.Join("-", names);

            //Console.WriteLine(namesCombination);

            var text = "Hi Puja \nYuk pergi ke Jakarta \nUntuk bertemu dengan orang";
            Console.WriteLine(text);

            var text2 = @"Hi Puja
Yuk pergi ke Jakarta
Untuk bertemu dengan orang";
            Console.WriteLine(text2);

        }
    }
}
