using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Availity_Parentheses
{
    class Program
    {
        static void Main(string[] args)
        {
            string txt1 = "This is a test ((1235) 4567) (23) (67), this is another test ( 45667 ) ";
            string txt2 = "This is a test (((1235) 4567) (23) (67), this is another test ( 45667 ) ";
            string txt3 = "This is a test ((1235) 4567) (23) (67), this is another test ( 45667 )) test ";

            bool isClosed1 = IsParenthesisClosed(txt1);
            bool isClosed2 = IsParenthesisClosed(txt2);
            bool isClosed3 = IsParenthesisClosed(txt3);

            Console.ReadLine();
        }

        public static bool IsParenthesisClosed(string inputString)
        {
            bool IsClosed = false;
            bool overFlow = false;
            Stack<char> parStk = new Stack<char>();
            foreach (char item in inputString)
            {
                if (item.ToString() == "(")
                {
                    parStk.Push(item);
                }
                else if (item.ToString() == ")")
                {
                    try
                    {
                        parStk.Pop();

                    }
                    catch (Exception ex)
                    {
                        string strExc = ex.ToString();
                        overFlow = true;
                    }
                }

            }

            if (parStk.Count == 0)
                if (overFlow == false)
                    IsClosed = true;


            return IsClosed;
        }
    }
}
