using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Interfaces
{
    interface IPerson
    {
        string Name { get; set; }
        string LastName { get; set; }

        IPhoneList Phones { get; set; }
    }
}
