using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOD5_1302220143
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            HaloGeneric.SapaUser("Jeremy Mathew Fabian Sitepu");
            DataGeneric<String> NIM = new DataGeneric<String>("1302220143");
            NIM.PrintData();
        }
    }

    public class DataGeneric<T>
    {
        T data;
        public DataGeneric(T data)
        {
            this.data = data;
        }

        public void PrintData()
        {
            Console.WriteLine("Data yang tersimpan adalah: " + data);
        }
    }

    public class HaloGeneric
    {
        public static void SapaUser(String X)
        {
            Console.WriteLine("Halo user " + X);
        }
    }
}
