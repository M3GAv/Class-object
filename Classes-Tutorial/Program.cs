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
            Tutorial pTutor = new Tutorial();
            pTutor.SetTutorial(1,"First Tutorial");
            Console.WriteLine(pTutor.GetTutorialName());

            pTutor.SetTutorial("Second Tutorial");
            Console.WriteLine(pTutor.GetTutorialName());

        }
    }
}
