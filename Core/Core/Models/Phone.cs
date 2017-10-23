using System.Collections.Generic;
using Core.Interfaces;

namespace Core.Models
{
    public class Phone : IPhoneList
    {
        public IEnumerable<string> GetPhones()
        {
            throw new System.NotImplementedException();
        }

        //Test branches
        public bool IsValidNumber(string inputNumber)
        {
            bool result = true;
            int temp;
            foreach(var item in inputNumber)
            {
                if (!int.TryParse(item.ToString(), out temp))
                {
                    result = false;
                }
            }

            return result;
        }
    }
}