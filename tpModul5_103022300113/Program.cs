using System;
using tpModul5_103022300113; 
namespace jurnal
{
    class Program
    {
        static void Main(string[] args) 
        {
            HaloGeneric hg = new HaloGeneric(); 
            hg.SapaUser("John");

            DataGeneric<string> data1 = new DataGeneric<string>("12345678");
            data1.PrintData();  
        }
    }
}
