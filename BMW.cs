using PRO_HW_5.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRO_HW_5
{
    public class BMW : IRename, IClose
    {
        public string Name { get; set; }
        public bool Closee { get; set; }

        public BMW() { }

        public void ReName(string name)
        {
            this.Name=name;
        }

        public void Close (bool close)
        {
            Closee = close; 
        }
    }
}
