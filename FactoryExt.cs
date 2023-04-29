using PRO_HW_5.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace PRO_HW_5
{
    public static class FactoryExt
    {
        public static void ChengFactoru<T>(this T factoru) where T : IClose, IRename
        {
            factoru.ReName("test");
            factoru.Close(true);
            
        }

    }
}
