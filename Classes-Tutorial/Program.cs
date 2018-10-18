using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Classes_Tutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Tutorial pTutor = new Tutorial(); // <- creating a new tutorial object
            pTutor.SetTutorial(1, ".Net"); // <- calling the set tutorial method

            Console.Write(pTutor.GetTutorialID()); // <- calling the get tutorial id method
            Console.WriteLine(pTutor.GetTutorialName()); // <- calling the get tutorial name method

            Tutorial test = new Tutorial(); // <- creating a new tutorial object
            test.SetTutorial(6, "Testing"); // <- calling the set tutorial method
            Console.WriteLine("{0} {1}",test.GetTutorialID(),test.GetTutorialName()); // <- calling tutorial id method and tutorail name method
        }
    }
}
