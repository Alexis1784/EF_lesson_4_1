using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_lesson_4_1
{
    class Program
    {
        static void Main(string[] args)
        {
            using (PhoneContext db = new PhoneContext())
            {
                var phones = db.Phones.Where(p => p.CompanyId == 1);
                foreach (Phone ph in phones)
                {
                    Console.WriteLine("Name - {0}, Price - {1}, CompanyId - {2}", ph.Name, ph.Price, ph.CompanyId);
                }
                var phones2 = from p in db.Phones
                              where p.CompanyId == 2
                              select p;
                foreach (Phone ph in phones2)
                {
                    Console.WriteLine("Name - {0}, Price - {1}, CompanyId - {2}", ph.Name, ph.Price, ph.CompanyId);
                }
                var phones3 = db.Phones.Where(p => p.CompanyId == 1).ToList().Where(p => p.Id == 2);
                foreach (Phone ph in phones3)
                {
                    Console.WriteLine("p.Id = 2: Name - {0}, Price - {1}, CompanyId - {2}", ph.Name, ph.Price, ph.CompanyId);
                }
                Console.ReadLine();
            }
        }
    }
}
