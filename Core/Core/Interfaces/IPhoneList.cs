using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Interfaces
{
    interface IPhoneList
    {
        bool IsValidNumber(string inputNumber);

        IEnumerable<string> GetPhones();
    }
}
