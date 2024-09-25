using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryCatchAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ask the user for their age.
            Console.Write("Please enter your age; ");
            int userAge = Convert.ToInt32(Console.ReadLine());

            try
            {                
                if (userAge > 0 && userAge < 100)
                {
                    // use the age variable
                    Console.WriteLine("You are {0} years old!", userAge);

                    //Obtaining the current system date and then year.
                    int currentYear = DateTime.Now.Year;
                    Console.WriteLine(currentYear);

                    //Calculating the year the user was born.
                    int yearOfBirth = currentYear - userAge;

                    //Display the year the user was born.
                    Console.WriteLine("You were born in the year {0}", yearOfBirth);
                    Console.ReadLine();
                }
                if (userAge <= 0 || userAge > 100)
                {
                    throw new ArgumentOutOfRangeException();
                }

            }                     
            catch (Exception)
            {
                Console.WriteLine("Something went wrong!");
                Console.ReadLine();
                return;
            }            
            Console.ReadLine();
        }
    }
}

