using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical_1
{
    internal class Program
    {
        class Student
        {
            public int AdmissionNumber;
            public string Name;
            public string Course;
            public int Semester;

            //Private Data Members
            private double Fees;
            private bool IsScholershipEligible;


            //constant


            private const double ScholershipRate = 0.10;

            //Default Constracture

            public Student()
            {
                Console.WriteLine("____________________");
                Console.WriteLine(" STUDENT ADMISSION SYSTEM");
                Console.WriteLine("_____________________");

                //Default  Values
                Course = "CSE";
                Semester = 5;
                Console.WriteLine("Subject Oriented Created Succesfully");
                Console.WriteLine();

            }
            //Method To Accept Student Details
            public void AcceptDetails()
            {
                Console.WriteLine("Enter Admission Number:");
                AdmissionNumber = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter Student Name:");
                Name = Console.ReadLine();

                Console.WriteLine("Enter Course:");
                Course = Console.ReadLine();

                Console.WriteLine("Enter Semester:");
                Semester = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter Admission Fees:");
                Fees = Convert.ToDouble(Console.ReadLine());

            }
            //Method To Check Scholership Eligiblity

            public void CheckScholarShipEligiblity()
            {

                if (Fees <= 50000)
                {
                    IsScholershipEligible = true;
                }
                else
                {
                    IsScholershipEligible = false;
                }
            }

            //Method To Display Student Details

            public void DisplayDetails()
            {
                double FinalFees = Fees;

                if (IsScholershipEligible)
                {
                    FinalFees = Fees - (Fees * ScholershipRate);
                }

                Console.WriteLine();
                Console.WriteLine("--------------------------");
                Console.WriteLine(" STUDENT ADMISSION DETAILS : ");
                Console.WriteLine("----------------------------");
                Console.WriteLine("Admission Number : " + AdmissionNumber);
                Console.WriteLine("Student Name: " + Name);
                Console.WriteLine("Coures: " + Course);
                Console.WriteLine("Semester :" + Semester);
                Console.WriteLine("Admission Fees: " + Fees);
                Console.WriteLine("SchoolerShip :" +
                    (IsScholershipEligible ? "Eligible" : "Not Eligible")
                    );
                Console.WriteLine("Final fees: " + FinalFees);
                Console.WriteLine("------------");
            }

            static void Main(string[] args)
            {
                Student sc = new Student();
                sc.AcceptDetails();
                sc.CheckScholarShipEligiblity();
                sc.DisplayDetails();
            }
        }
    }
}
