using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Invoker
{
    public class Imported
    {
        [DllImport("NativeDll.dll", EntryPoint = "SetToOne", CallingConvention = CallingConvention.StdCall)]
        internal static extern void SetToOne(double d);
    }
}
