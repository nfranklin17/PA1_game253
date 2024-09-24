/*
_________________________________________
DO NOT TOUCH THIS FILE. 
ANY MODIFICATION TO THIS FILE WILL RESULT IN AN IMMEDIATE FAILURE

THIS PROGRAM RUNS YOUR OTHER PROGRAMS
ALL WORK SHOULD BE COMPLETED IN OTHER FILES
//_________________________________________
*/

using System;

namespace PA1
{
    class Runner
    {
        static void Main( )
        {
            Console.WriteLine("PA1");

            Console.WriteLine("---------PA1 Part 1 ----------");
            PA1_1.Problem test1 = new PA1_1.Problem();
            test1.doStuff(); 
            Console.WriteLine("---------PA1 Part 2 ----------");
            PA1_2.Problem test2 = new PA1_2.Problem();
            test2.doStuff();
            Console.WriteLine("---------PA1 Part 3 ----------");
            PA1_3.Problem test3 = new PA1_3.Problem();
            test3.doStuff();
            Console.WriteLine("---------PA1 Part 4 ----------");
            PA1_4.Problem test4 = new PA1_4.Problem();
            test4.doStuff();
            Console.WriteLine("---------PA1 Part 5 ----------");
            PA1_5.Problem test5 = new PA1_5.Problem();
            test5.doStuff();
        }
    }
}
