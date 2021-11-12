using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp4.Abstractions;

namespace WindowsFormsApp4.Entities
{
    class CarFactory : Interface1
    {
        public Toy CreateNew()
        {
            return new Car();
        }
    }
}
