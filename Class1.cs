using System;

namespace Test1
{
    public static class Oprators
    {
        public static void Increment(float No)
        {
            Console.WriteLine("No Before Increment:{0}", No);
            No++;
            Console.WriteLine("No After Increment:{0}", No);
            Console.ReadLine();
        }

        public static void Decrement(float no)
        {
            Console.WriteLine("No Before Decrement:{0}",no);
            no--;
            Console.WriteLine("No After Decrement:{0}", no);
            Console.ReadLine();
        }

        public static void Plus(float no1,float no2)
        {
            Console.WriteLine("Numbers Before Merging Them:{0},{1}",no1,no2);
            Console.WriteLine("Numbers After Merging Them Together:{0}",no1 + no2);
            Console.ReadLine();

        }
        public static void Minus(float no1,float no2)
        {
            Console.WriteLine("Numbers Before Subtracting:{0},{1}", no1, no2);
            Console.WriteLine("Numbers After Subtracting Them Together:{0}",no1- no2);
            Console.ReadLine();

        }

        public static void Divide(float no1,float no2)
        {
            Console.WriteLine("Numbers Before Dividing Them Together:{0},{1}", no1, no2);
            Console.WriteLine("Numbers After Dividing Them Together:{0}", no1 / no2);
            Console.ReadLine();

        }

        public static void Multipication(float no1,float no2)
        {
            Console.WriteLine("Numbers Before Multipling Them Together:{0},{1}", no1, no2);
            Console.WriteLine("Numbers After multipling Them Together:{0}", no1 * no2);
            Console.ReadLine();

        }

        public static void Mudolus(float no1,float no2)
        {
            Console.WriteLine("Numbers Before Using The Modulus Divison:{0},{1}",no1,no2);
            Console.WriteLine("Numbers After Using Mudoulus Oprator:{0}", no1 % no2);
            Console.ReadLine();
        }
    }

    public class Loops
    {
        //Mehod For ForLoop
        public static void ForLoop(int LoopTime)
        {
            for (int i = 0; i < LoopTime; i++)
            {
                Console.WriteLine("This Is The Running Of For Loop.");
                Console.WriteLine("Loop Is Runing For {0}, Times.", i);
                Console.WriteLine("Press Enter To Continue.....");
                Console.ReadLine();
            }

        }

        //Method For DoWhile Loop
        public static void DoWhileLoop(int LoopTime)
        {
            int i = 0;
            do
            {
                Console.WriteLine("This Is The Running Of Do-While Loop.");
                Console.WriteLine("Loop Is Runing For {0}, Times.", i);
                Console.WriteLine("Press Enter To Continue.....");
                Console.ReadLine();
                i++;

            } while (i < LoopTime);
        }

        //Method For While Loop
        public static void WhileLoop(int LoopTime)
        {
            int i = 0;
            while (i < LoopTime)
            {
                Console.WriteLine("This The Running Of While Loop.");
                Console.WriteLine("Loop IS Running  For {0}, Times.", i);
                Console.WriteLine("Press Enter To Continue.....");
                Console.ReadLine();
                
                i++;

            }
        }


    }

  public static class Calcu
    {
         public static float GreaterNumber(float no1, float no2)
        {
            if (no1 > no2)
            {
                return no1;
            }
            else
            {
                return no2;
            }

        }

        //Method For Subtraction
        public static float Sub(int no, int no2)
        {
            return no2 - no;
        }

        //Method for modulous
        public static float Modoulus(float no, float no2)
        {
            return no % no2;
        }

        //Method For Sum Of Two Numbers
        public static float Sum(int no, int no2)
        {
            return no + no2;
        }

        //M<ethod For Division Of Two Numbers
        public static float Division(int no, int div)
        {
            return no / div;
        }

        //Method for Multipication Of Two Numbers
        public static float Multiply(int no, int no2)
        {
            return no2 * no;
        }
    }

    
}