using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace GetARoom.Test.Output
{
    class Program
    {
        static void Main(string[] args)
        {
            TestMethods tm = new TestMethods();

            //tm.Delete(tm.GetById(1));     // werkt beide
            // Console.WriteLine(tm.GetById(-5));
            //tm.AddTest(); // Werkt
            //tm.GetAll();// Werkt
            // tm.TestAssembly();// Werkt
            //tm.WrongEntityType();
            //tm.SeedRoles();
            // tm.FindRole();
            // tm.CheckRolesAreEqual();
            //tm.AddEntities();
            // tm.testAdd();
            //tm.TestAsset();
            //  tm.testBookingRepo();
            //tm.CheckIfBetweenDates();
            tm.testRating(1);
            Console.Read();
        }
    }
}
