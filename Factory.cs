using PRO_HW_5.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRO_HW_5
{
    public class Factory<T> where T : class, new ()
    {
        public T Create() 
        { 
            return new T();
        }

    }
}
