using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace utils.debug
{
    public class debugger
    {
         public void dd(string input){
            System.Diagnostics.Debug.WriteLine(input);
            return;
        }
         public void ddf(string input, params object[] args)
         {
             System.Diagnostics.Debug.WriteLine(input, args);
             return;
         }
    }
}
