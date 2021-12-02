using System;
using System.Linq;
using Data;

namespace ReflectionExample
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // User modelin property isimleri reflection ile yazdırıldı.

            User user = new User();
            user.GetType().GetProperties().ToList().ForEach(x =>
            {
                Console.WriteLine(x.Name);
            });

            Console.Read();

        }
    }
}
