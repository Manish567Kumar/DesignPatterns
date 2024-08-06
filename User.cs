using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Designpatters
{
    public class User
    {
        public string name;
        public void sayHello()
        {
           // this.name = "Manish";
            Console.Write(this.name);
            Console.ReadKey();
        }
        public User(string name, int age) {
            this.name = name;
            
        }
    }

    
}
