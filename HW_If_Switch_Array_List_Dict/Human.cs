using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;


namespace HW_If_Switch_Array_List_Dict
{
    //HOMEWORK.December 29. Task 5
    class Human
    {
        public string Name { get; set; }

        public void GetHumanName(Human human) 
        {

            try
            {
                var name = human.Name;
                Console.WriteLine(name);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"You tried to pass null as a parameter. Exception: {ex}");
            }
        }
    }
}
