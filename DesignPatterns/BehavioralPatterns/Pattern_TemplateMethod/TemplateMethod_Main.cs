using System;
using System.Collections.Generic;

namespace DesignPatterns.BehavioralPatterns.Pattern_TemplateMethod
{
    public static class TemplateMethod_Main
    {
        public static void Go()
        {
            School school = new School();
            University university = new University();         

            school.Learn();
            Console.WriteLine("----------------------");
            university.Learn();
            Console.WriteLine("----------------------");
            //-------------------------------------------
            Console.WriteLine("----------------------");
            List<Education> eds = new List<Education>();
            eds.Add(school);
            eds.Add(university);
            eds.Add(university);
            foreach (var item in eds)
            {
                item.Learn();
                Console.WriteLine("----------------------");
            }
            Console.Read();
        }
    }
}
