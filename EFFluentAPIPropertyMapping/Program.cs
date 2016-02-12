using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFFluentAPIPropertyMapping
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                using (var ctx = new EFContext())
                {
                    ctx.Employees.Select(e => e.EmployeeID == 0);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine("Press any key to close");
            Console.ReadKey();
        }
    }
}
