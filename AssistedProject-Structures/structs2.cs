using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssistedProject_Structures
{
    internal class structs2
    {
        static void Main(string[] args)
        {
            doApp();
        }

        public static void doApp()
        {

            Students[] students = new Students[3];
            for (int i = 0; i < students.Length; i++)
            {
                students[i].names = "Name " + i.ToString();
                students[i].addresss = "Address of student ";
                students[i].rollNumbers = i;
                students[i].classNames = " VA";
                students[i].dateOfBirths = Convert.ToDateTime("1992-09-10 00:00:00");
            }

            for (int i = 0; i < students.Length; i++)
            {
                Console.Write(students[i].names + ",");
                Console.Write(students[i].addresss + ",");
                Console.Write(students[i].rollNumbers + ",");
                Console.Write(students[i].classNames + ",");
                Console.Write(students[i].dateOfBirths);
                Console.WriteLine("------------------------");
            }
            Console.Read();
        }
    }

    struct Students
    {
        public string names;
        public string addresss;
        public int rollNumbers;
        public string classNames;
        public DateTime dateOfBirths;
    }
}
