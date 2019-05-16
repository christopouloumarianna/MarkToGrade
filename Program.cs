using System;

namespace Mark2Grade
{
    class Program
    {
        static void Main(string[] args)
        {
            bool doContinue;
            do
            {
                DoWork();
                Console.WriteLine("Do you want to continue? (y/n)");
                char response = char.Parse(Console.ReadLine());
                if (response == 'y')
                {
                    doContinue = true;
                }
                else
                {
                    doContinue = false;
                }


            }
            while (doContinue);
            Console.ReadLine();
        }
        static void DoWork()
        {
            //INPUT
            Console.WriteLine("Enter the mark :");
            int mark = int.Parse(Console.ReadLine());
            //PROCESSING
            string grade = GradeCalculation(mark);
            //OUTPUT
            Console.WriteLine("The grade is {0}", grade);

        }
        static string GradeCalculation(int mark)

        {
            string grade;
            if (mark <= 100 && mark >= 80)
            {
                grade = "A";
            }
            else if (mark <= 79 && mark >= 70)
            {
                grade = "B";

            }
            else if (mark <= 69 && mark >= 60)
            {
                grade = "C";
            }
            else if (mark <= 59 && mark >= 50)
            {
                grade = "D";
            }
            else if (mark <= 49 && mark >= 0)
            {
                grade = "F";
            }
            else
            {
                grade = "wrong mark";
            }

            return grade;

        }
        static string GradeCalculationSwitch(int i)
        {
            string grade;
            switch (i)
            {
                case int n when (n > 100):
                    grade = "wrong grade";
                    break;

                case int n when (n <= 100 && n >= 80):
                    grade = "A";

                    break;

                case int n when (n <= 79 && n >= 70):
                    grade = "B";
                    break;
                case int n when (n <= 69 && n >= 60):
                    grade = "C";
                    break;
                case int n when (n <= 59 && n >= 50):
                    grade = "D";
                    break;
                case int n when (n <= 49 && n >= 0):
                    grade = "F";
                    break;

                default:
                    grade = "wrong grade";
                    break;
            }
            return grade;
        }
    }
}
