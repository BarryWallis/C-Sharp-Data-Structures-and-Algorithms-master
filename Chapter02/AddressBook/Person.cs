using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    public record Person(string Name, int Age, Country Country)
    {
    }
}
