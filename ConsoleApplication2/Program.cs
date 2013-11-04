using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
          // First customer
          var person1 = new Person();
          person1.firstName = "Vik";
          person1.lastName = "Ewoods";
          person1.passportPrefix = new char[2];
          person1.passportPrefix[0] = 'A';
          person1.passportPrefix[1] = 'D';
          person1.passportSerial = 209901;
          person1.customerBalance = 1789.98F;

          // Second customer
          var person2 = new Person();
          person2.firstName = "Di";
          person2.lastName = "Dila";
          person2.passportPrefix = new char[2];
          person2.passportPrefix[0] = 'D';
          person2.passportPrefix[1] = 'C';
          person2.passportSerial = 345887;
          person2.customerBalance = 13099.65F;

          // Third customer
          var person3 = new Person();
          person3.firstName = "Alisa";
          person3.lastName = "Ewoods";
          person3.passportPrefix = new char[2];
          person3.passportPrefix[0] = 'K';
          person3.passportPrefix[1] = 'A';
          person3.passportSerial = 920012;
          person3.customerBalance = 16901.05F;

          // Creating person array - list
          var personArray = new Person[3];
          personArray[0] = person1;
          personArray[1] = person2;
          personArray[2] = person3;

          // Stating count total customers balance
          float totalUsersBalance = 0.00F;
          int x;
          for (x = 0; x <= 2; x++)
          {
            if (personArray[x] == null)
            {
              break;
            }
            totalUsersBalance += personArray[x].customerBalance;
          }
          Console.WriteLine("Total customer balance: " + totalUsersBalance);
          // Hold app
          Console.ReadLine();
        }
    }
}
