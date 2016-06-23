using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using System.IO;
// File/Project Prolog
// Name: Matthew Vaughan
// CS 1400 Section 003
// Project: Project 11
// Date: 04/15/2016 09:15:19 pm
//
// I declare that the following code was written by me or provided 
// by the instructor for this project. I understand that copying source
// code from any other source constitutes cheating, and that I will receive
// a zero on this project if I am found in violation of this policy.
// ---------------------------------------------------------------------------
namespace Proj11
{
    class Program
    {
        static void Main(string[] args)
        {

            //Display instructions
            WriteLine("Resistor Batch Test Analysis Program");
            WriteLine("Data file must be in your documents folder");
            Write("Please enter the file name: ");

            //Declare file name and take users input to find appropriate folder
            string fileName = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal) + @"\";
            fileName += ReadLine();

            StreamReader theTextFile = new StreamReader(fileName);

            Resistance rs = new Resistance(theTextFile.ReadLine());

            while (theTextFile.EndOfStream == false)
            {
                rs.AddDate(theTextFile.ReadLine());
            }


            WriteLine("\n\n");
            WriteLine("Res#\tDissipation\tPassed");
            for (int i = 0; i < rs.GetLength(); i++)
            {
                WriteLine($"{i + 1}\t{rs.GetPowerDissipated(i):f2}\t\t{rs.GetTestPassFail(i)}");
            }
            

            ReadLine();
        }
    }
}
