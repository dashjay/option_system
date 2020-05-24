using System.Diagnostics;
namespace utils.debug
{
    public class debugger
    {
         public void dd(string input){
            Debug.WriteLine(input);
            return;
        }
         public void ddf(string input, params object[] args)
         {
             Debug.WriteLine(input, args);
             return;
         }
    }
}
