using System;
using System.Security.Cryptography;
using Calc;


//Demostration Of Calculator Using Every Statement In C#
class Calcl
{
    //Method to Find Greater No Between Two Numbers
   

    //Method For Calculation And Decision Making
    static void Decision(int no1, int no2)
    {
        Console.WriteLine("Enter The Symbol Of Opration:");
        string? decision = Console.ReadLine();


        switch (decision)
        {
            case "+":
                Console.WriteLine("Sum Of Numbers:{0}",Calc.Calcu.Sum(no1, no2));
                break;
            case "-":
                Console.WriteLine("Remains Are:{0}", Calc.Calcu.Sub(no1, no2));
                break;
            case "*":
                Console.WriteLine("Multiple:{0}", Calc.Calcu.Multiply(no1, no2));
                break;
            case "/":
                Console.WriteLine("Dividend:{0}", Calc.Calcu.Division(no1, no2));
                break;
            case "%":
                Console.WriteLine("Reminder Is:{0}", Calc.Calcu.Modoulus(no1, no2));
                break;
            case ">":
                Console.WriteLine("Greater Number Is:{0}.", Calc.Calcu.GreaterNumber(no1,no2));
                break;
            default:
                Console.WriteLine("Unkwon Symbol Use Only(+,-,*,%,>,/)");
                break;

        }
    }

    //Musical Chords

    static void Chords()
    {
        int[] musicChords = {    1635,3270,6541,13081,26163,52325,104650,209300,418601,
                                 1732,3465,6930,13859,27718,55437,110873,221746,443492,
                                 1835,3671,7342,14683,29366,58733,117466,234932,469863,
                                 1945,3889,7778,15556,31113,62225,124451,248902,497803,
                                 2060,4120,8241,16481,32963,65925,131851,263702,527404,
                                 2183,4365,87310,17461,34923,69846,139691,279383,558765,
                                 2312,4625,9250,18500,36999,73999,147998,295996,591991,
                                 2450,4900,9800,19600,39200,78399,156798,313596,627190,
                                 2596,5191,10383,20765,41530,83061,166122,332244,664488,
                                 2750,5500,11000,22000,44000,88000,176000,352000,704000,
                                 372931,745862,3087,6174,12347,24694,49388,98777,197553,
                                 395107,790213
                            };
    }

    //Method For Looping And Loop Selection Decision Making
    static void LoopDecision()
    {
        Loop:

        Console.WriteLine("__________________________");
        Console.WriteLine("1. For Loop.");
        Console.WriteLine("2. While Loop");
        Console.WriteLine("3. Do While Loop");
        Console.WriteLine("__________________________");
        int loop = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter The How Many Times You Want To Run Loop: ");
        int loopTime = Convert.ToInt32(Console.ReadLine());
        switch(loop)
        {
            case 1:
                Loops.ForLoop(loopTime);
                break;
            case 2:
                Loops.WhileLoop(loopTime);
                break;
            case 3:
                Loops.DoWhileLoop(loopTime);
                break;
            default:
                Console.WriteLine("Invalid Section, Do Want To Try Again!(Y/N)/(Default N)");
                string? loopAgain=Console.ReadLine();
                if(loopAgain=="Y")
                {
                    goto Loop;

                }
                else
                {
                    Console.WriteLine("Thanks For Using Looping Statement In C#");
                }
                break;
        }

    }

    //Method Still In Process
    static void Infinite()   
    {
        for(int i = 0; i < 10; i++)
        {
            int rand = 10;
            Console.WriteLine("{0}", i, " {1} ",rand);

        }
    }

    //Method To Implement Beep
    static void Beep(int freq,int druation)
    {
        
        Console.Beep(freq, druation);


    }

    //Main Method
    static void Main()
    {
    rem:


        //Method Testing Area Starts Here

        //Beep(38, 2000);

        //Method Testing Area Ends Here

       

        //Main Calculator Starts Here
       /* int no1,no2;
        Console.Write("Enter The First No: ");
        no1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter The Second No: ");
        no2 = Convert.ToInt32(Console.ReadLine());
        Decision(no1, no2);*/

       // Second.Float();
        
        //Loop Statement Decision Method Demonstration
        Console.WriteLine("Do Want To Use Loop Demonstration(Y/N): ");
        string? loop=Console.ReadLine();loop.ToUpper();

        if (loop=="Y")
        {
            Console.WriteLine(loop);
            LoopDecision();
        }
        else
        { 
            Console.WriteLine();
            //Infinite();
        }

        //Re-Running The Application
        Console.Write("Do You Want To Continue (Y/N) :");
        string? choice=Console.ReadLine();
        if (!(choice != "Y"))
        {
            Console.Clear();
            goto rem;
        }
        else
        {
            Console.Clear();
            Console.WriteLine("Thanks For Using Me!");
        }

        
    }

}

class Second
{
    //Default Date Of This running Program Is 11/12/2003

    public struct DayMonthYear
    {
        public DaysOfWeek day;
        public Months month;
        public int year;
    };

    public struct Date
    {
       
        public int day;
        public int month;
        public int year;
    };

    public enum DaysOfWeek
    {
        Monday=1,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday
    }
    
    public enum Months
    {
        January=1,
        Fabruary,
        March,
        April,
        May,
        June,
        July,
        August,
        September,
        October,
        November,
        December
    }

    public static DaysOfWeek SetDay()
    {
        Console.Write("Enter The Index Of The Day In A Week : ");
        DaysOfWeek day = (DaysOfWeek)Convert.ToInt32(Console.ReadLine());
        //Console.Write("The Today Is ",day);
        return day;
    }

    public static void SetMonth()
    {
        Console.Write("Enter The Index Of Month In An Year:");
        Months month = (Months)Convert.ToInt32(Console.ReadLine());
        DaysOfWeek today = SetDay();
        Console.WriteLine("This Is the {0} Of Month {1}", today, month);
        Console.ReadLine();
    }

    public  Date Today()
    {
        Date Datetoday;
        DayMonthYear todayDetails;

        Console.Write("What Is The Date Today:");
        Datetoday.day=Convert.ToInt32(Console.ReadLine());
        Console.Write("What Is The Month Is This:");
        Datetoday.month=Convert.ToInt32(Console.ReadLine());
        Console.Write("What Is The Year Is This:");
        Datetoday.year=Convert.ToInt32(Console.ReadLine());

        todayDetails.day = (DaysOfWeek)Datetoday.day;
        todayDetails.month = (Months)Datetoday.month;
        todayDetails.year = Datetoday.year;
        //int Year=(int)Datetoday.year;

        Console.WriteLine("Today Is {0},{1},{2}", todayDetails.day, todayDetails.month, todayDetails.year);
        Console.ReadKey();

        return Datetoday;
    }

    

}

/*class Music
{
    public struct Beep
    {
        public int[] freq;
        public int[] duration;

        public static void GetFreq(int[] frequency)
        {
            foreach (int i in frequency)
            {
                int maxFreq=20000;
                frequency[i] = RandomNumberGenerator.GetInt32(maxFreq);
                
            }

        }

        public static void GetDur(int[] Duration)
        {
            foreach (int i in Duration)
            {
                int druation = 2000;
                Duration[i] = RandomNumberGenerator.GetInt32(druation*100);
            }
        }



    };

}  */