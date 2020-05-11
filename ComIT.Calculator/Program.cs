using System;
using System.Globalization;

namespace ComIT.Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo culture = CultureInfo.CreateSpecificCulture("en-US");
            NumberStyles style = NumberStyles.AllowDecimalPoint | NumberStyles.AllowLeadingSign | NumberStyles.AllowThousands;
            //
            try
            {
                Console.WriteLine("This is a sample calculator for ComIT course");
                Console.WriteLine("Basic operation are as follow: +,-,* and /");
                Console.WriteLine("It works with Integers and doubles and with negative numbers");
                Console.WriteLine("type inline basic operation like: 1+10 or 3.25 - 0.23");

                String _rl = Console.ReadLine();
                while (CheckESC(_rl))
                {
                    if (IsArythmeticFunction(_rl))
                    { 
                        String _mathFunc = DetermineMathFunc(_rl);
                        if (!string.IsNullOrEmpty(_mathFunc))
                        {
                            if (!_mathFunc.Equals("-"))
                            {
                                string[] _values = _rl.Split(_mathFunc);
                                if (_values.Length == 2)
                                {
                                    double NumberOne; //test
                                    double NumberTwo; //test

                                    if (Double.TryParse(_values[0], style, culture, out NumberOne) &&
                                        Double.TryParse(_values[1], style, culture, out NumberTwo))
                                    {
                                        //Console.WriteLine("Converted '{0}' to {1}.", _values[0], NumberOne);
                                        //Console.WriteLine("Converted '{0}' to {1}.", _values[1], NumberTwo);

                                        if (_mathFunc.Equals("+"))
                                        {
                                            Console.WriteLine("Resault: " + (double)(NumberOne + NumberTwo));
                                        }
                                        else if(_mathFunc.Equals("*"))
                                        {
                                            Console.WriteLine("Resault: " + (double)(NumberOne * NumberTwo));
                                        }
                                        else if (_mathFunc.Equals("/"))
                                        {
                                            if(NumberTwo != (double)0)
                                                Console.WriteLine("Resault: " + (double)(NumberOne / NumberTwo));
                                            else
                                                Console.WriteLine("-- Don't divide by 0 --");
                                        }
                                    }
                                    else
                                        Console.WriteLine("-- Please specify correct number format --");
                                }
                                else
                                {
                                    Console.WriteLine("-- This simple Calculator only works with two vaules --");
                                }
                            }
                            else
                            {
                                string[] _values = _rl.Split(_mathFunc);
                                double NumberOne;
                                double NumberTwo;
                                if (_values.Length > 2) //Negative number(s)
                                {
                                    int indexOfMathMinus = -1;
                                    if (_rl.StartsWith('-'))
                                        indexOfMathMinus = _rl.Substring(1).IndexOf('-') + 1;
                                    else
                                        indexOfMathMinus = _rl.IndexOf('-');
                                    _values = new string[]
                                    {
                                        _rl.Substring(0,indexOfMathMinus),
                                        _rl.Substring(indexOfMathMinus+1)
                                    };
                                }

                                if (Double.TryParse(_values[0], style, culture, out NumberOne) &&
                                        Double.TryParse(_values[1], style, culture, out NumberTwo))
                                {
                                    //Console.WriteLine("Converted '{0}' to {1}.", _values[0], NumberOne);
                                    //Console.WriteLine("Converted '{0}' to {1}.", _values[1], NumberTwo);

                                    Console.WriteLine("Resault: " + (double)(NumberOne - NumberTwo));
                                }
                                else
                                    Console.WriteLine("-- Please specify correct number format --");
                            }
                        }
                        else
                        {
                            Console.WriteLine("-- Couldn't determine arythmetical function --");
                        }
                    }
                    else
                    {
                        Console.WriteLine("-- No arythmetical function found --");
                    }
                    Console.WriteLine("");
                    _rl = Console.ReadLine();
                }
            }catch(Exception e)
            {
                Console.WriteLine("-- Something went wrong with the app --");
            }

        }

        private static bool CheckESC(string rl)
        {
            return true;
        }

        private static string DetermineMathFunc(string rl)
        {
            if (rl.Contains("+"))
            {
                return "+";

            }else if (rl.Contains("*"))
            {
                return "*";
            }
            else if(rl.Contains("/"))
            {
                return "/";
            }
            else if(rl.Contains("-"))
            {
                if (!rl.StartsWith("-"))
                {
                    return "-";
                }
                else
                {
                    if (rl.Substring(1).Contains("-"))
                    {
                        return "-";
                    }
                }
            }
            return "";
        }

        private static bool IsArythmeticFunction(string rl)
        {
            if ((rl.Contains("+") ||
                rl.Contains("-") ||
                rl.Contains("/") ||
                rl.Contains("*"))
                &&
                (!rl.StartsWith("*") ||
                !rl.StartsWith("/") ||
                !rl.StartsWith("+"))
                &&
                (!rl.EndsWith("*") ||
                !rl.EndsWith("/") ||
                !rl.EndsWith("-") ||
                !rl.EndsWith("+")))
            {
                return true;
            }
            else
                return false;
        }
    }
}
