﻿using System;

namespace NestedIf
{
    class Program
    {
        static void Main(string[] args)
        {

            //Nested if statement is an if statement within another if statement 
            
            int a = 100;//local variable 
            int b = 200;

            /* check the boolean condition */
            if (a == 100)
            {

                /* if condition is true then check the following */
                if (b == 200)
                {
                    /* if condition is true then print the following */
                    Console.WriteLine("Value of a is 100 and b is 200");
                }
            }
            Console.WriteLine("Exact value of a is : {0}", a);
            Console.WriteLine("Exact value of b is : {0}", b);
            Console.ReadLine();
        }
    }
}
        
    

