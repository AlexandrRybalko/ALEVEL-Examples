﻿using System;

namespace Example2
{
    class Program
    {
        static void Main(string[] args)
        {

           // int i;
           // i = "Hello"; // error CS0029: Cannot implicitly convert type 'string' to 'int'


            double x = 1234999995555555555555555555555555555555555555555555555555555555.7;
            int a;

            // Cast double to int.
            a = (int)x;

            Console.WriteLine(a);


            string strInt = "24532";
            string strNull = null;
            string strWrongFrmt = "5.87";
            string strAboveRange = "98765432123456";
            int res;
            try
            {
                // int.Parse() - TEST
                res = int.Parse(strInt); // res = 24532
                res = int.Parse(strNull); // System.ArgumentNullException
                res = int.Parse(strWrongFrmt); // System.FormatException
                res = int.Parse(strAboveRange); // System.OverflowException

                // Convert.ToInt32(string s) - TEST
                res = Convert.ToInt32(strInt); // res = 24532
                res = Convert.ToInt32(strNull); // res = 0
                res = Convert.ToInt32(strWrongFrmt); // System.FormatException
                res = Convert.ToInt32(strAboveRange); //System.OverflowException

                // int.TryParse(string s, out res) - Test
                bool isParsed;
                isParsed = int.TryParse(strInt, out res); // isParsed = true, res = 24532
                isParsed = int.TryParse(strNull, out res); // isParsed = false, res = 0
                isParsed = int.TryParse(strWrongFrmt, out res); // isParsed = false, res = 0
                isParsed = int.TryParse(strAboveRange, out res); // isParsed = false, res = 0 
            }
            catch (Exception e)
            {
                Console.WriteLine("Check this.\n" + e.Message);
            }

            Console.ReadLine();

        }
    }
}
