/*
 Developer : D.L Ntuli
 Date      : 05 August 2022
 Tittle    : Console Program for learners Grade Calculation
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp1
{
    internal class GradeCalculator {

        // Initialieze variables
        private static decimal total = 0;
        private static decimal counter = 0;
        private static String yesOrNo, TITLE, anotherGrade;

        static void Main() {
            Initialize();
        }

        /* This method will initialize the Program
         * The Program determines students grade by measuring their marks against the avagemark of the whole class
        */
        private static void Initialize()
        {
            yesOrNo = "y";
            anotherGrade = "y";
            TITLE = "\n################################ MARKS CAPTURING ###############################";
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.Write(TITLE);


            while (yesOrNo == "y")
            {
                Console.Write("\nEnter Student Marks : ");
                total += System.Convert.ToDecimal(Console.ReadLine());

                Console.Write("\n \nDo you wish to capture another mark? \nEnter \"y\" if you do OR \"n\" to move to grade calculation :");
                yesOrNo = Console.ReadLine();

                counter += 1;
            }

            if (yesOrNo != "y")
            {
                TITLE = "\n ******************************* STUDENT GRADE CALCULATION ********************************** ";
                Console.Clear();
                Console.Write(TITLE);
                getStudentGrade();
            }

            Console.ReadKey();

        }

        /*this method will be ran for grade calculation.
         *will keep on calulating the grade solong as the user is not satisfied.
         */
        private static void getStudentGrade()
        {
            while (anotherGrade == "y")
            {
                Console.Write("\n\nEnter student Marks : ");
                Console.WriteLine("The student Grade is : " + studentGrade(System.Convert.ToDecimal(Console.ReadLine())));
                Console.ForegroundColor = ConsoleColor.White;

                Console.Write("\nDo you wish to calculate another student grade? , \nPress \"y\" if you do OR \"n\" to terminate the program : ");
                anotherGrade = Console.ReadLine();

            }

        }

        /*Method for calculating student grade base on the class mark average.
         *Will input Double(student mark).
         *will return String(student grade).
         *the output will either be Satisfactory, Unsatisfactory or Outstanding.
         */
        private static String studentGrade(decimal studentMarks)
        {

            if ((studentMarks - total / counter) >= -2 && (studentMarks - total / counter) <= 10)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                return "Satisfactory " ;
            }

            if ((studentMarks - total / counter) > 10)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                return "Outstanding  ";
            }
            Console.ForegroundColor = ConsoleColor.Red;
            return "Unsatisfactory  ";
        }
    }
}
