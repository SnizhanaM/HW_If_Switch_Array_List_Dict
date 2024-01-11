using HW_If_Switch_Array_List_Dict;
using System;
using System.Collections.Generic;
using System.Linq;

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
            /*int anyNumber = 0;

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
            human.GetHumanName(null);*/

            //HOMEWORK. January 5. Task 1.

            var program = new Program();
            List<string> clothesTypes = new List<string> {"shirt", "t-shirt", "trousers", "coat", "jeans", "dress"};
            program.GetClothes(clothesTypes);
            List<string> nullIssue = new List<string> { null };
            program.GetClothes(nullIssue);


            //HOMEWORK. January 5. Task 2.

            var honda = new Car();
            honda.MakeOfCar = "accord";
            honda.YearOfManufacture = 2012;

            var volsvolkswagen = new Car();
            volsvolkswagen.MakeOfCar = "Golf";
            volsvolkswagen.YearOfManufacture = 2004;

            var toyota = new Car();
            toyota.MakeOfCar = "Camry";
            toyota.YearOfManufacture = 1983;

            var audi = new Car();
            audi.MakeOfCar = "A8";
            audi.YearOfManufacture = 1994;

            var mercedes = new Car();
            mercedes.MakeOfCar = "Mercedes-Benz GLE";
            mercedes.YearOfManufacture = 2023;

            var hyundai = new Car();
            hyundai.MakeOfCar = "Cortina";
            hyundai.YearOfManufacture = 1968;

            List<Car> allCars = new List<Car>();
            allCars.Add(honda);
            allCars.Add(volsvolkswagen);
            allCars.Add(audi);
            allCars.Add(hyundai);
            allCars.Add(mercedes);
            allCars.Add(toyota);

            List<Car> oldCars = new List<Car>();
            List<Car> newCars = new List<Car>();
            List<string> namesOfOldCars = new List<string>();

            var oldCarsSelection = oldCars.Where(oldCar => oldCar.YearOfManufacture <= 2000);
            var newCarsSelection = newCars.Where(newCar => newCar.YearOfManufacture > 2000);
            var oldCarNames = allCars.Select(nameOfOldCar => nameOfOldCar.YearOfManufacture <= 2000);

            Console.WriteLine(allCars);
            Console.WriteLine(oldCarsSelection);
            Console.WriteLine(newCarsSelection);
            Console.WriteLine(oldCarNames);
            

        }
        
        //HOMEWORK. January 5. Task 1.
        public void GetClothes<T>(List<T> clothesTypes)
        {
            try
            {
                Console.WriteLine(clothesTypes[5]);
            } 
            catch (NullReferenceException ex) 
            {
                Console.WriteLine(ex);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine(ex);
            }
           
        }

        

    }
}