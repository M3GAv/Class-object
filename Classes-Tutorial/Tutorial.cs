using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Classes_Tutorial
{
    class Tutorial
    {
        int TutorialID;    // <- defining the fields of the class
        string TutorialName; // <-    -||-

        public void SetTutorial(int pID, string pName) // <- defining the set tutorial method
        {
            TutorialID = pID; // <- setting the fields values
            TutorialName = pName; // <-     -||-
        }

        public String GetTutorialName() // defining the get tutorial name method
        {
            return TutorialName; // <- returning the TutorialName
        }

        public Int32 GetTutorialID() // <- defining the get tutorial id method
        {
            return TutorialID; // returning the TutorialID
        }
    }
}
