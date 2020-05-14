using System;

namespace TruthTable
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercise One");
            Console.WriteLine("(( one OR two ) AND three )");
            Console.WriteLine("");

            Console.WriteLine(new LogicGateOne(true, true, true).PrintOut());
            Console.WriteLine(new LogicGateOne(false, true, true).PrintOut());
            Console.WriteLine(new LogicGateOne(true, false, true).PrintOut());
            Console.WriteLine(new LogicGateOne(true, true, false).PrintOut());
            Console.WriteLine(new LogicGateOne(false, false, true).PrintOut());
            Console.WriteLine(new LogicGateOne(false, true, false).PrintOut());
            Console.WriteLine(new LogicGateOne(true, false, false).PrintOut());
            Console.WriteLine(new LogicGateOne(false, false, false).PrintOut());

            Console.WriteLine("");
            Console.WriteLine("Exercise Two");
            Console.WriteLine("(( one OR two ) OR  ( three AND four ))");
            Console.WriteLine("");

            Console.WriteLine(new LogicGateTwo(true, true, true, true).PrintOut());
            Console.WriteLine(new LogicGateTwo(false, true, true, true).PrintOut());
            Console.WriteLine(new LogicGateTwo(true, false, true, true).PrintOut());
            Console.WriteLine(new LogicGateTwo(true, true, false, true).PrintOut());
            Console.WriteLine(new LogicGateTwo(true, true, true, false).PrintOut());
            Console.WriteLine(new LogicGateTwo(false, false, true, true).PrintOut());
            Console.WriteLine(new LogicGateTwo(false, true, false, true).PrintOut());
            Console.WriteLine(new LogicGateTwo(false, true, true, false).PrintOut());
            Console.WriteLine(new LogicGateTwo(false, false, false, true).PrintOut());
            Console.WriteLine(new LogicGateTwo(false, false, true, false).PrintOut());
            Console.WriteLine(new LogicGateTwo(false, true, false, false).PrintOut());
            Console.WriteLine(new LogicGateTwo(true, false, false, false).PrintOut());
            Console.WriteLine(new LogicGateTwo(true, false, true, false).PrintOut());
            Console.WriteLine(new LogicGateTwo(true, false, false, true).PrintOut());
            Console.WriteLine(new LogicGateTwo(false, false, false, false).PrintOut());
        }
    }
}
