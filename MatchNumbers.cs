using System;
using System.Collections;
namespace matchs
{
    class MatchNumber
    {
        static void Main(string[] args)
        {
            Console.WriteLine(checkOrder("123321"));
            Console.WriteLine(checkOrder("45547"));


        }
        static bool checkOrder(string source)
        {
            Stack matchStack = new Stack();
            int number = 0;
            char temp;
            while (number < source.Length)
            {
                if (matchStack.Count == 0)
                {
                    matchStack.Push(source[number]);
                    number++;
                    continue;
                }

                temp = (char)matchStack.Peek();

                if (source[number] == temp)
                {
                    matchStack.Pop();
                }
                else if (source[number] != temp)
                {
                    matchStack.Push(source[number]);
                }
                number++;
            }
            return matchStack.Count == 0;
        }

    }
}
