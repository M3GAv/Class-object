using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Classes_Tutorial
{
    public class Tutorial
    {
        protected int TutorialID;    // <- defining the fields of the class
        protected string TutorialName; // <-    -||-
        public Tutorial()
        {
            TutorialID = 0;
            TutorialName = "Default";
        }


        public void SetTutorial(int pID, string pName) // <- defining the set tutorial method
        {
            TutorialID = pID; // <- setting the fields values
            TutorialName = pName; // <-     -||-
        }

        public void SetTutorial(String pName)
        {
            TutorialName = pName; // <- setting the fields values
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

    public class MyTutorial : Tutorial
    {
        public void RenameTutorial(String pNewName)
        {
            TutorialName = pNewName;
        }
    }

}
