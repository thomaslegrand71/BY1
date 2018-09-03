using System;

namespace BY1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your name");
            var name = Console.ReadLine();
            //Console.WriteLine(name);

            Console.WriteLine("Please reserve a table 1-9");

            saisie:;

            var number = int.Parse(Console.ReadLine());

            if (number >= 1 && number <=9 )
            { Console.WriteLine("saisie valide"); }
            else { Console.WriteLine("Please enter a number between 1 and 9");
                goto saisie;
            }

            saisie2:;
            Console.WriteLine("Please enter a date dd/mm/yyyy");
            string date = Console.ReadLine();

            DateTime dDate;

            if(DateTime.TryParse(date, out dDate))
            { string.Format("{0:d/MM/yyyy}", dDate); Console.WriteLine("saisie valide"); }
            else { Console.WriteLine("invalid"); goto saisie2; }

            Console.WriteLine($"Table {number} is succesfully booked for {name}");

            Console.WriteLine("\nPlease enter another name for a new booking");
            var name2 = Console.ReadLine();

            Console.WriteLine("\nPlease enter another date for a new booking");
            var date2 = Console.ReadLine();
            DateTime dDate2;
            DateTime.TryParse(date2, out dDate2);

            Console.WriteLine("\nPlease choose a table for a new booking");
            var number2 = int.Parse(Console.ReadLine());

            int compare = DateTime.Compare(dDate, dDate2);

            if (number2!=number || compare!=0)
            { Console.WriteLine("thank you for your booking"); }
            else
            { Console.WriteLine($"table {number} is already booked by {name}");
                Console.WriteLine("\nDo you want to override ? Y/N");

                var yn = Console.ReadLine();

                if(yn=="Y")
                { Console.WriteLine($"Table number{number2} is successfully booked for {date2} for {name2}" ); }
                else
                { Console.WriteLine($"Table number{number2} is still booked for {date2} for {name}"); }
            }
        }
    }
}
