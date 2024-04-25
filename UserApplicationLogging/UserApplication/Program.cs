using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using UserModel;
using AppLogging;

namespace UserApplication
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var u = new User()
            {
                Username = "Cocolino",
                Password = "parola123",
                Email = "coco@upit.ro",
            };

            var u1 = new User()
            {
                Username = "Cocolinor",
                Password = "parola20001",
                Email = "colina@upit.ro",
            };

            CollectionUser cu = new CollectionUser();

            cu.Add(u);
            cu.Add(u1); 
            cu.SaveOnDisk();




            Console.ReadKey();
        }
    }
}
