using HW_If_Switch_Array_List_Dict;
using System;
using System.Collections.Generic;

namespace Homework4
{
    class Program
    {
        static void Main(string[] args)
        {
            /*var drivingLicence = new DrivingLicence("Ukraine", "Olena", 4352, 1234, "25-09-2033");

            bool isRaining = true;
            bool isCloudy = false;
            bool isSunny = true;

            if (isRaining == true && isCloudy == true)
            {
                Console.WriteLine("Take an umbrella");
            }
            else if (isSunny == true)
            {
                Console.WriteLine("Take sunglasses");
            }
            else if (isRaining == true && isSunny == true)
            {
                Console.WriteLine("Take both an umbrella and sunglasses");
            }
            else
            {
                Console.WriteLine("Take nothing.");
            }



            int[] wholeNumbersArray = new int[] { 23, 56, 83, 10, 95 };

            List<int> oddNumbersList = new List<int>();
            List<int> evenNumbersList = new List<int>();

            foreach (int number in wholeNumbersArray)
            {
                if (number % 2 == 0)
                {
                    evenNumbersList.Add(number);

                }
                else
                {
                    oddNumbersList.Add(number);
                }

            }

            int[] wholeNumbersArray2 = new int[] { 78, 23, 81, 16, 90 };

            List<int> oddNumbersList2 = new List<int>();
            List<int> evenNumbersList2 = new List<int>();

            for (int i = 0; i < wholeNumbersArray2.Length; i++)
            {
                if (wholeNumbersArray2[i] % 2 == 0)
                {
                    //розібратись чому так, а не evenNumbersList2.Add(i);
                    evenNumbersList2.Add(wholeNumbersArray2[i]);
                }
                else
                {
                    oddNumbersList2.Add(wholeNumbersArray2[i]);
                }
            }


            var Capitals = new Dictionary<string, string>();

            Capitals.Add("Ukraine", "Kyiv");
            Capitals.Add("Czech Republi", "Prague");
            Capitals.Add("USA", "Washington");
            Capitals.Add("Canada", "Ottawa");
            Capitals.Add("Italy", "Rome");

            var capital1 = Capitals["Ukraine"];
            var capital2 = Capitals["Czech Republi"];
            var capital3 = Capitals["USA"];
            var capital4 = Capitals["Canada"];
            var capital5 = Capitals["Italy"];

            Console.WriteLine(capital1, capital2, capital3, capital4, capital5);

        }
        static void CelebrateHolidays(Holidays holidays)
        {
            switch (holidays)
            {
                case Holidays.Christmas:
                    Console.WriteLine("Cook 12 dishes!");
                    break;
                case Holidays.Easter:
                    Console.WriteLine("Paint eggs and bake Easter Bread");
                    break;
                case Holidays.NewYearsDay:
                    Console.WriteLine("Decorate a Christmas tree!");
                    break;


            }*/


            //HOMEWORK.December 29

            //Task 1
            int anyNumber = 0;

            while (anyNumber < 10) 
            { 
                anyNumber++;
                Console.WriteLine($"While value: {anyNumber}");
            }
            
            //Task 2
            int anyNumber2 = 10;

            while (anyNumber2 < 10)
            {
                anyNumber2++;
                Console.WriteLine($"Value of the 2d while cycle: {anyNumber2}");
            }

            //Task 3
            int anyNumber3 = 0;

            do
            {
                Console.WriteLine($"DoWhile value: {anyNumber3}");
                anyNumber3++;
            }
            while (anyNumber3 < 10);

            //Task 4
            int anyNumber4 = 10;
            do
            {
                Console.WriteLine($"Value of the 2d DoWhile cycle: {anyNumber4}");
                anyNumber4++;
            }
            while (anyNumber4 < 10);

            //Task 5
            var human = new Human();
            human.GetHumanName(null);


        }
    }
}