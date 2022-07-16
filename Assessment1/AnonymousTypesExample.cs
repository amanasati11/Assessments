using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Anonymous types
 * public read-only properties
 * nested anonymous types
*/
namespace Assessment1
{
    class AnonymousTypesExample
    {
        static void Main(string[] agrs)
        {
            var firstAnonymousType = new { firstName = "Aman", lastName = "Asati" };
            Console.WriteLine(firstAnonymousType.firstName);
            Console.WriteLine(firstAnonymousType.lastName);

        }
    }
}
